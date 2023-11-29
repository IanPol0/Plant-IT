using System;
using System.IO;
using System.IO.Ports;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;

namespace COPIA
{
    public partial class RecibirDatos : Form
    {
        private bool IsClosed = false;
        private string datos = "";
        private static bool Wifi = false;
        private bool wifiAbierto;
        private SerialPort Port = new SerialPort();
       
        public RecibirDatos()
        {
            InitializeComponent();
        }

        private void recibirDatos()
        {
            while (!IsClosed)
            {
                try
                {
                    
                    datos = wifiAbierto ? Get("http://192.168.204.231/ ") : Port.ReadLine();
                    if (datos.Length > 5) 
                        datos = datos.Remove(5, datos.Length - 5);
               
                    if (datos.Length == 5)
                    {
                        txtSerial.Invoke(new MethodInvoker(
                        delegate
                        {
                            try
                            {
                                txtSerial.Text = $"N° de maceta: {datos[0]}\r\nValor de humedad: {datos.Substring(3, 2)}%\r\nValor de luz: {datos.Substring(1, 2)}%";
                            }
                            catch (IndexOutOfRangeException) { }
                        }
                        ));
                    }
                }
                catch (InvalidOperationException) { }
                catch (IOException) { }
                catch (InvalidAsynchronousStateException) { }
                catch (Win32Exception) { }
            }
        }

        #region BOTONES
        private void btnSelect_Click(object sender, EventArgs e)
        {
            Wifi = comboBox_Select.Text != "Serial Port";
            ActualizarObjetos(Wifi);
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            switch (Wifi)
            {
                case true:
                    wifiAbierto = true;
                    break;
                case false:
                    if (!Port.IsOpen)
                    {
                        if (comboBox_Port.Text != "")
                        {
                            Port.BaudRate = 9600;
                            Port.PortName = comboBox_Port.Text;
                            try
                            {
                                Port.Open();
                            }
                            catch { }
                            MessageBox.Show("Puerto abierto correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("No se ha seleccionado ningun puerto serial", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        private void BTN_Stop_Click(object sender, EventArgs e)
        {
            switch (Wifi)
            {
                case true:
                    wifiAbierto = false;
                    break;
                case false:
                    if (Port.IsOpen)
                    {
                        Port.Close();
                        MessageBox.Show("Puerto cerrado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
            }
        }
        #endregion

        #region FORM LOAD & CLOSED
        private void ConectarSerialPort_Load(object sender, EventArgs e)
        {
            comboBox_Select.SelectedIndex = Wifi ? 0 : 1;
            ActualizarObjetos(Wifi);

            Thread Hilo = new Thread(recibirDatos);
            Hilo.Start();
        }

        private void ConectarSerialPort_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsClosed = true;
            Port.Close();
            ListaPlantas.ActualizarObjetos();
        }
        #endregion

        #region TEXT CHANGED EVENTS
        private void txtSerial_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSerial.Text.Length == 57)
                {
                    int num = 1;
                    int index = num - 1;
                    int humedad = Convert.ToInt32(txtSerial.Text.Substring(35, 2));
                    int luz = Convert.ToInt32(txtSerial.Text.Substring(54, 2));
                    string estadoHumedad = SetEstadoMaceta(Planta.rango_HumedadRecomendada[index, 0], Planta.rango_HumedadRecomendada[index, 1], humedad);
                    string estadoLuz = SetEstadoMaceta(Planta.rango_LuzRecomendada[index, 0], Planta.rango_LuzRecomendada[index, 1], luz);

                    Maceta.InsertarRegistro(humedad, luz, estadoHumedad, estadoLuz, num);
                    Maceta.UpdateUltimoRegistro(humedad, luz, estadoHumedad, estadoLuz, num);
                    Maceta.ActualizarVariables();
                    EnviarNotificaciones(index);
                }
            }
            catch(FormatException a) { MessageBox.Show(a.Message); }
        }
        #endregion

        #region FUNCIONES
        private void ActualizarObjetos(bool Wifi)
        {
            datos = "";
            txtSerial.Text = "";
            comboBox_Port.Items.Clear();
            comboBox_Port.Text = "";
            comboBox_Port.Visible = !Wifi;
            switch (Wifi)
            {
                case false:
                    wifiAbierto = false;
                    String[] strPortName = SerialPort.GetPortNames();
                    foreach (string n in strPortName)
                    {
                        comboBox_Port.Items.Add(n);
                    }
                    if (comboBox_Port.Items.Count > 0)
                    {
                        comboBox_Port.SelectedIndex = 0;
                    }
                    break;
                case true:
                    Port.Close();
                    break;
            }
        }

        public string Get(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using Stream stream = response.GetResponseStream();
            using StreamReader reader = new(stream);
            return reader.ReadToEnd();
        }

        private string SetEstadoMaceta(int parametroMinimo, int parametroMaximo, int valor)
        {
            if (parametroMaximo != 0 && valor != 0)
            {
                if (valor < parametroMinimo || valor > parametroMaximo)
                {
                    if (valor < parametroMinimo)
                    {
                        return "(Bajo)";
                    }
                    else if (valor > parametroMaximo)
                    {
                        return "(Alto)";
                    }
                }
                return "(Normal)";
            }
            return "";
        }

        private void EnviarNotificaciones(int index)
        {
            _ = Notificaciones.SendSMS(index, Notificaciones.SetMensaje("Humedad", Maceta.estadoHumedad[index]));
            _ = Notificaciones.SendSMS(index, Notificaciones.SetMensaje("Luz", Maceta.estadoLuz[index]));
        }
        #endregion
    }
}
