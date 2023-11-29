using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COPIA
{
    public partial class Notificaciones : Form
    {
        private List<Label> listaLabels;
        public Notificaciones()
        {
            InitializeComponent();
            toggleButton.Checked = Usuario.Notificaciones;
            txtTelefono.Texts = Usuario.Telefono;
            listaLabels = new List<Label>() { lblNotificaciones, lblTelefono, lblOff, lblOn };
            Fuente.CambiarFuente(listaLabels);
        }

        #region BTN CONFIRMAR
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string telefono = txtTelefono.Texts;
            bool result = float.TryParse(telefono, out _);
            if (result)
            {
                if (telefono.Substring(0, 2) != "54" && telefono.Length == 10)
                    telefono = telefono.Insert(0, "54");
                Usuario.UpdateUsuario(telefono, toggleButton.Checked);
                Usuario.ActualizarVariables();
                this.Close();
                return;
            }

            MessageBox.Show("El numero de telefono no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtTelefono.Texts = Usuario.Telefono;
        }
        #endregion

        #region FUNCIONES NOTIFICACION
        public static async Task SendSMS(int index, string mensaje)
        {
            if (mensaje != "" && Usuario.Notificaciones)
            {
                string hora = Maceta.hora[index] == "0" ? "" : $"({Maceta.hora[index]})";
                
                string mensajeNotificacion = $"Hola, su planta '{Planta.nombre[index]}' {mensaje} {hora}";

                await client.GetStringAsync($"https://platform.clickatell.com/messages/http/send?apiKey=VAL3Ufa_S6mpiQDuDSE7AA==&to={Usuario.Telefono}&content={mensajeNotificacion}");
                //await client.GetStringAsync($"https://platform.clickatell.com/messages/http/send?apiKey=Cia4vWC5TgSwdrQ6v8CH0Q==&to={Usuario.Telefono}&content={mensajeNotificacion}");


            }
        }

        public static string SetMensaje(string medicion, string estado)
        {
            string mensaje = "";
            switch (estado)
            {
                case "(Bajo)":
                    mensaje = medicion == "Humedad" ? "esta recibiendo poca agua" : "esta recibiendo poca luz";
                    break;
                case "(Alto)":
                    mensaje = medicion == "Humedad" ? "esta recibiendo demasiada agua" : "esta recibiendo demasiada luz";
                    break;
            }
            return mensaje;
        }
        #endregion

        #region MOUSE DOWN & LEAVE
        private void btnConfirmar_MouseDown(object sender, MouseEventArgs e)
        {
            AnimacionBotones.Btn_MouseDown(btnConfirmar);
        }

        private void btnConfirmar_MouseLeave(object sender, EventArgs e)
        {
            AnimacionBotones.Btn_MouseLeave(btnConfirmar);
        }
        #endregion

        #region KEY PRESS
        private void toggleButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnConfirmar_Click(this, e);
            }
        }
        #endregion

    }
}
