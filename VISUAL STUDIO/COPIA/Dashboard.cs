using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace COPIA
{
    public partial class Dashboard : Form
    {
        private OleDbConnection conexion = new OleDbConnection(Database.connectionString);
        private OleDbCommand comando = new OleDbCommand();

        #region VARIABLES
        private List<int> humedadLineChart = new List<int>();
        private List<int> luzLineChart = new List<int>();
        private List<string> fechaLineChart = new List<string>();
        private List<string> horaLineChart = new List<string>();
        private double[] humedadColumnChart = new double[6];
        private double[] luzColumnChart = new double[6];
        private Button btnActivoLineChart;
        private Button previoBtnActivoLineChart;
        private bool formLoad;
        private List<Label> listaLabels;
        private List<Button> listaBotones;
        #endregion

        public Dashboard()
        {
            InitializeComponent();
        }

        #region METODOS COLUMN CHART
        private void VariablesColumnChart(int IDPlanta)
        {
            string mesComienzo = DateTime.Now.ToShortDateString();
            string[] result = Convert.ToDateTime(mesComienzo).AddMonths(-5).ToString().Split('/');
            int mes = Convert.ToInt32(result[1]);

            int diaFinal = 0;

            Database.OpenConnection(conexion, comando);

            for (int i = 0; i < 6; i++)
            {
                switch (mes)
                {
                    case 1:
                        diaFinal = 31;
                        break;
                    case 2:
                        diaFinal = 28;
                        break;
                    case 3:
                        diaFinal = 31;
                        break;
                    case 4:
                        diaFinal = 30;
                        break;
                    case 5:
                        diaFinal = 31;
                        break;
                    case 6:
                        diaFinal = 30;
                        break;
                    case 7:
                        diaFinal = 31;
                        break;
                    case 8:
                        diaFinal = 31;
                        break;
                    case 9:
                        diaFinal = 30;
                        break;
                    case 10:
                        diaFinal = 31;
                        break;
                    case 11:
                        diaFinal = 30;
                        break;
                    case 12:
                        diaFinal = 31;
                        break;

                }
            
                string fechaComienzo = $"1/{mes}/2022";
                string fechaFinal = $"{diaFinal}/{mes}/2022";

                comando.CommandText = $"select Humedad, Luz from Maceta where IDPlanta={IDPlanta} and Id>3 and Fecha between #{fechaComienzo:dd/MM/yyyy}# and #{fechaFinal:dd/MM/yyyy}#";
                OleDbDataReader reader = comando.ExecuteReader();

                List<double> humedadMensual = new();
                List<double> luzMensual = new();

                while (reader.Read())
                {
                    humedadMensual.Add(Convert.ToDouble(reader["Humedad"]));
                    luzMensual.Add(Convert.ToDouble(reader["Luz"]));
                }
                reader.Close();

                double promedioHumedad = 0;
                double promedioLuz = 0;

                
                for (int a = 0; a < humedadMensual.Count; a++)
                {
                    promedioHumedad += humedadMensual[a];
                    promedioLuz += luzMensual[a];
                }

                promedioHumedad /= humedadMensual.Count;
                promedioLuz /= luzMensual.Count;

                humedadColumnChart[i] = promedioHumedad;
                luzColumnChart[i] = promedioLuz;

                if (mes == 12)
                    mes = 1;
                else
                    mes++;
            }
            conexion.Close();
        }

        private void GenerarColumnChart()
        {
            foreach (var serie in columnChart.Series)
            {
                serie.Points.Clear();   
            }

            string mesComienzo = DateTime.Now.ToShortDateString();
            string[] result = Convert.ToDateTime(mesComienzo).AddMonths(-5).ToString().Split('/');
            int numeroMes = Convert.ToInt32(result[1]) - 1;

            string[] meses = { "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic" };

            for (int i = 0; i < 6; i++)
            {
                columnChart.Series[0].Points.AddXY(meses[numeroMes], humedadColumnChart[i]);
                columnChart.Series[1].Points.AddXY(meses[numeroMes], luzColumnChart[i]);
                
                if (numeroMes == 11)
                    numeroMes = 1;
                else
                    numeroMes++;
            }

            columnChart.ChartAreas[0].Visible = true;
        }

        private void CambiarMedicionColumnChart()
        {
            VariablesColumnChart(ListaPlantas.numeroPlanta);
            GenerarColumnChart();
        }
        #endregion

        #region METODOS LINE CHART
        private void VariablesLineChart(int IDPlanta, string intervalo)
        {
            DateTime fechaFinal = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            DateTime fechaComienzo = Convert.ToDateTime("1/1/2021");

            switch (intervalo)
            {
                case "1D":
                    fechaComienzo = fechaFinal.AddDays(-1);
                    break;
                case "3D":
                    fechaComienzo = fechaFinal.AddDays(-3);
                    break;
                case "7D":
                    fechaComienzo = fechaFinal.AddDays(-7);
                    break;
                case "1M":
                    fechaComienzo = fechaFinal.AddDays(-30);
                    break;
            }

            Database.OpenConnection(conexion, comando);
            comando.CommandText = $"select Humedad, Luz, Fecha, Hora from Maceta where IDPlanta={IDPlanta} and Id>3 and Fecha between #{fechaComienzo:MM/dd/yyyy}# and #{fechaFinal:MM/dd/yyyy}#";
            OleDbDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                humedadLineChart.Add(Convert.ToInt32(reader["Humedad"]));
                luzLineChart.Add(Convert.ToInt32(reader["Luz"]));
                fechaLineChart.Add(reader["Fecha"].ToString().Substring(0, 5));
                horaLineChart.Add(reader["Hora"].ToString());
            }

            for (int i = 0; i < fechaLineChart.Count; i++)
            {
                string[] result = fechaLineChart[i].Split('/');
                fechaLineChart[i] = $"{result[0]}/{result[1]}";
            }

            conexion.Close();
        }

        private void CambiarIntervaloLineChart(Button boton)
        {
            if (btnActivoLineChart != boton)
            {
                btnActivoLineChart.BackColor = Color.Transparent;
                btnActivoLineChart.FlatAppearance.MouseOverBackColor = Color.Transparent;
                btnActivoLineChart = boton;
            }
            boton.BackColor = Color.DeepSkyBlue;
            boton.FlatAppearance.MouseOverBackColor = boton.BackColor;

            VariablesLineChart(ListaPlantas.numeroPlanta, boton.Text);

            if (boton.Text == "1D")
                generarLineChart(horaLineChart, boton);
            else
                generarLineChart(fechaLineChart, boton);
        }

        private void generarLineChart(List<string> tiempo, Button botonActivo)
        {
            if (tiempo.Count > 1)
            {
                previoBtnActivoLineChart = botonActivo;

                foreach (var serie in lineChart.Series)
                {
                    serie.Points.Clear();
                }
                
                for (int i = 0; i < tiempo.Count; i++)
                {
                    lineChart.Series[0].Points.AddXY(tiempo[i], humedadLineChart[i]);
                    lineChart.Series[1].Points.AddXY(tiempo[i], luzLineChart[i]);
                    lineChart.Series[2].Points.AddXY(tiempo[i], (Planta.rango_HumedadRecomendada[ListaPlantas.numeroPlanta - 1, 0] + Planta.rango_HumedadRecomendada[ListaPlantas.numeroPlanta - 1, 1]) / 2);
                    lineChart.Series[3].Points.AddXY(tiempo[i], (Planta.rango_LuzRecomendada[ListaPlantas.numeroPlanta - 1, 0] + Planta.rango_LuzRecomendada[ListaPlantas.numeroPlanta - 1, 1]) / 2);
                }

                fechaLineChart.Clear();
                horaLineChart.Clear();
                humedadLineChart.Clear();
                luzLineChart.Clear();

                btnGuardarGrafico.Visible = true;
                lineChart.ChartAreas[0].Visible = true;
                lineChart.Legends[0].Enabled = true;
            }
            else if (formLoad)
            {
                MessageBox.Show("No se han podido cargar datos para alguno de los graficos", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (botonActivo != btnMax)
            {
                MessageBox.Show("No hay datos suficientes para armar un grafico", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CambiarIntervaloLineChart(previoBtnActivoLineChart);
            }
        }
        #endregion

        #region BOTONES
        private void btnGuardarGrafico_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Imagenes (*.jpg; *.png)|*.jpg;*.png|Todos los archivos (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Bitmap imagen = new Bitmap(lineChart.Width, lineChart.Height))
                {
                    imagen.Save(saveFileDialog.FileName, ImageFormat.Png);
                }
                lineChart.SaveImage(saveFileDialog.FileName, ChartImageFormat.Png);
            }
        }

        private void btn1Dia_Click(object sender, EventArgs e)
        {
            CambiarIntervaloLineChart(btn1Dia);
        }

        private void btn3Dias_Click(object sender, EventArgs e)
        {
            CambiarIntervaloLineChart(btn3Dias);
        }

        private void btn7Dias_Click(object sender, EventArgs e)
        {
            CambiarIntervaloLineChart(btn7Dias);
        }

        private void btn1Mes_Click(object sender, EventArgs e)
        {
            CambiarIntervaloLineChart(btn1Mes);
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            CambiarIntervaloLineChart(btnMax);
        }
        #endregion

        #region FORM LOAD
        private void Dashboard_Load(object sender, EventArgs e)
        {
            valoresProgressBar();
            formLoad = true;
            CambiarMedicionColumnChart();
            previoBtnActivoLineChart = btnMax;
            btnActivoLineChart = btnMax;
            CambiarIntervaloLineChart(btnMax);
            formLoad = false;
            listaLabels = new List<Label>() { lblHumedad, lblLuz };
            listaBotones = new List<Button>() { btn1Dia, btn3Dias, btn7Dias, btn1Mes, btnMax };
            Fuente.CambiarFuente(listaLabels, listaBotones);
        }
        #endregion

        private void valoresProgressBar()
        {
            progressBarHumedad.Value = Maceta.humedad[ListaPlantas.numeroPlanta - 1];
            progressBarHumedad.Text = progressBarHumedad.Value.ToString() + "%";
            progressBarLuz.Value = Maceta.luz[ListaPlantas.numeroPlanta - 1];
            progressBarLuz.Text = progressBarLuz.Value.ToString() + "%";
        }

    }
}
