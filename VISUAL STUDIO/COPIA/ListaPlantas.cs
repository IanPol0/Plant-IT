using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Text;

namespace COPIA
{
    public partial class ListaPlantas : Form
    {
        public static int numeroPlanta;
        private List<Label> listaLabels;
 
        public ListaPlantas()
        {
            InitializeComponent();
            AsignarObjetos();
            listaLabels = new List<Label>() { lblNombre1, lblNombre2, lblNombre3, lblHumedad1, lblHumedad2, lblHumedad3, lblLuz1, lblLuz2, lblLuz3 };
            Fuente.CambiarFuente(listaLabels);
        }

        #region FUNCIONES
        public static void ActualizarObjetos()
        {
            for (int i = 0; i < 3; i++)
            {
                lblNombre[i].Font = new Font("Comfortaa", 28.2f);
                lblHumedad[i].Font = new Font("Comfortaa", 13.8f);
                lblLuz[i].Font = new Font("Comfortaa", 13.8f);

                lblNombre[i].Text = Planta.nombre[i];
                lblHumedad[i].Text = Maceta.humedad[i] != 0 ? "Humedad: " + Maceta.humedad[i] + "% " + Maceta.estadoHumedad[i] : "Humedad: --";
                lblLuz[i].Text = Maceta.luz[i] != 0 ? "Luz: " + Maceta.luz[i] + "% " + Maceta.estadoLuz[i] : "Luz: --";
           

                switch (Planta.IDFamilia[i])
                {
                    case 0:
                        pictureBoxes[i].BackgroundImage = null;
                        break;
                    case 1:
                        pictureBoxes[i].BackgroundImage = Properties.Resources.BotonBonsai;
                        break;
                    case 2:
                        pictureBoxes[i].BackgroundImage = Properties.Resources.BotonCactus;
                        break;
                    case 3:
                        pictureBoxes[i].BackgroundImage = Properties.Resources.BotonFlor;
                        break;
                    case 4:
                        pictureBoxes[i].BackgroundImage = Properties.Resources.BotonPasto;
                        break;
                    case 5:
                        pictureBoxes[i].BackgroundImage = Properties.Resources.BotonSuculenta;
                        break;
                    case 6:
                        pictureBoxes[i].BackgroundImage = null;
                        break;
                }

                bool cambio = Planta.IDFamilia[i] != 0;

                btnAgregar[i].Visible = !cambio;
                btnInfo[i].Visible = cambio;
                btnEdit[i].Visible = cambio;
                btnBorrar[i].Visible = cambio;
            }
        }

        private void BotonBorrar(int id)
        {
            if (MessageBox.Show("¿Está seguro de que desea borrar? Se eliminarán todos los datos relacionados con esta Planta.", "Borrar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Database.BorrarDatos(id);
                Maceta.ActualizarVariables();
                Planta.ActualizarVariables();

                ActualizarObjetos();

                MessageBox.Show("Registro borrado exitosamente", "Registro borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AsignarObjetos()
        {
            lblNombre = new Label[] { lblNombre1, lblNombre2, lblNombre3 };
            lblHumedad = new Label[] { lblHumedad1, lblHumedad2, lblHumedad3 };
            lblLuz = new Label[] { lblLuz1, lblLuz2, lblLuz3 };
            pictureBoxes = new PictureBox[] { pictureBox_Planta1, pictureBox_Planta2, pictureBox_Planta3 };
            btnAgregar = new Button[] { btnAgregar1, btnAgregar2, btnAgregar3 };
            btnInfo = new Button[] { btnInfo1, btnInfo2, btnInfo3 };
            btnEdit = new Button[] { btnEdit1, btnEdit2, btnEdit3 };
            btnBorrar = new Button[] { btnBorrar1, btnBorrar2, btnBorrar3 };
        }
        #endregion

        #region NUEVAS VENTANAS
        private void OpenTipoPlanta(int num)
        {
            numeroPlanta = num;
            TipoPlanta tipoPlanta = new TipoPlanta();
            tipoPlanta.Show();
        }

        private void OpenDashboard(int num)
        {
            numeroPlanta = num;
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void OpenEdicion(int num)
        {
            numeroPlanta = num;
            Edicion edicion = new Edicion();
            edicion.Show();
        }
        #endregion
        
        #region BOTONES
        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            OpenTipoPlanta(0);
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            OpenTipoPlanta(1);
        }

        private void btnAgregar3_Click(object sender, EventArgs e)
        {
            OpenTipoPlanta(2);
        }

        private void btnInfo1_Click(object sender, EventArgs e)
        {
            OpenDashboard(1);
        }

        private void btnInfo2_Click(object sender, EventArgs e)
        {
            OpenDashboard(2);
        }

        private void btnInfo3_Click(object sender, EventArgs e)
        {
            OpenDashboard(3);
        }

        private void btnEdit1_Click(object sender, EventArgs e)
        {
            OpenEdicion(0);
        }

        private void btnEdit2_Click(object sender, EventArgs e)
        {
            OpenEdicion(1);
        }

        private void btnEdit3_Click(object sender, EventArgs e)
        {
            OpenEdicion(2);
        }

        private void btnBorrar1_Click(object sender, EventArgs e)
        {
            BotonBorrar(1);
        }

        private void btnBorrar2_Click(object sender, EventArgs e)
        {
            BotonBorrar(2);
        }

        private void btnBorrar3_Click(object sender, EventArgs e)
        {
            BotonBorrar(3);
        }

        private void btnConexionSerialPort_Click(object sender, EventArgs e)
        {
            RecibirDatos recibirDatos = new RecibirDatos();
            recibirDatos.Show();
        }

        private void btnConfiguracionNotificaciones_Click(object sender, EventArgs e)
        {
            Notificaciones notificaciones = new Notificaciones();
            notificaciones.Show();
        }
        #endregion

        #region FORM LOAD
        private void ListaPlantas_Load(object sender, EventArgs e)
        {
            Maceta.ActualizarVariables();
            Planta.ActualizarVariables();
            Usuario.ActualizarVariables();

            ActualizarObjetos();
        }
        #endregion

        #region MOUSE DOWN & LEAVE
        private void btnAgregar1_MouseDown(object sender, MouseEventArgs e)
        {
            AnimacionBotones.Btn_MouseDown(btnAgregar1);
        }

        private void btnAgregar1_MouseLeave(object sender, EventArgs e)
        {
            AnimacionBotones.Btn_MouseLeave(btnAgregar1);
        }


        private void btnAgregar2_MouseDown(object sender, MouseEventArgs e)
        {
            AnimacionBotones.Btn_MouseDown(btnAgregar2);
        }

        private void btnAgregar2_MouseLeave(object sender, EventArgs e)
        {
            AnimacionBotones.Btn_MouseLeave(btnAgregar2);
        }

        private void btnAgregar3_MouseDown(object sender, MouseEventArgs e)
        {
            AnimacionBotones.Btn_MouseDown(btnAgregar3);
        }

        private void btnAgregar3_MouseLeave(object sender, EventArgs e)
        {
            AnimacionBotones.Btn_MouseLeave(btnAgregar3);
        }

        private void btnInfo1_MouseDown(object sender, MouseEventArgs e)
        {
            AnimacionBotones.Btn_MouseDown(btnInfo1);
        }

        private void btnInfo1_MouseLeave(object sender, EventArgs e)
        {
            AnimacionBotones.Btn_MouseLeave(btnInfo1);
        }

        private void btnInfo2_MouseDown(object sender, MouseEventArgs e)
        {
            AnimacionBotones.Btn_MouseDown(btnInfo2);
        }

        private void btnInfo2_MouseLeave(object sender, EventArgs e)
        {
            AnimacionBotones.Btn_MouseLeave(btnInfo2);
        }

        private void btnInfo3_MouseDown(object sender, MouseEventArgs e)
        {
            AnimacionBotones.Btn_MouseDown(btnInfo3);
        }

        private void btnInfo3_MouseLeave(object sender, EventArgs e)
        {
            AnimacionBotones.Btn_MouseLeave(btnInfo3);
        }

        private void btnEdit1_MouseDown(object sender, MouseEventArgs e)
        {
            AnimacionBotones.Btn_MouseDown(btnEdit1);
        }

        private void btnEdit1_MouseLeave(object sender, EventArgs e)
        {
            AnimacionBotones.Btn_MouseLeave(btnEdit1);
        }
        
        private void btnEdit2_MouseDown(object sender, MouseEventArgs e)
        {
            AnimacionBotones.Btn_MouseDown(btnEdit2);
        }

        private void btnEdit2_MouseLeave(object sender, EventArgs e)
        {
            AnimacionBotones.Btn_MouseLeave(btnEdit2);
        }

        private void btnEdit3_MouseDown(object sender, MouseEventArgs e)
        {
            AnimacionBotones.Btn_MouseDown(btnEdit3);
        }

        private void btnEdit3_MouseLeave(object sender, EventArgs e)
        {
            AnimacionBotones.Btn_MouseLeave(btnEdit3);
        }

        private void btnBorrar1_MouseDown(object sender, MouseEventArgs e)
        {
            AnimacionBotones.Btn_MouseDown(btnBorrar1);
        }

        private void btnBorrar1_MouseLeave(object sender, EventArgs e)
        {
            AnimacionBotones.Btn_MouseLeave(btnBorrar1);
        }

        private void btnBorrar2_MouseDown(object sender, MouseEventArgs e)
        {
            AnimacionBotones.Btn_MouseDown(btnBorrar2);
        }

        private void btnBorrar2_MouseLeave(object sender, EventArgs e)
        {
            AnimacionBotones.Btn_MouseLeave(btnBorrar2);
        }

        private void btnBorrar3_MouseDown(object sender, MouseEventArgs e)
        {
            AnimacionBotones.Btn_MouseDown(btnBorrar3);
        }

        private void btnBorrar3_MouseLeave(object sender, EventArgs e)
        {
            AnimacionBotones.Btn_MouseLeave(btnBorrar3);
        }

        private void btn_RecibirDatos_MouseDown(object sender, MouseEventArgs e)
        {
            AnimacionBotones.Btn_MouseDown(btn_RecibirDatos);
        }

        private void btn_RecibirDatos_MouseLeave(object sender, EventArgs e)
        {
            AnimacionBotones.Btn_MouseLeave(btn_RecibirDatos);
        }

        private void btn_ConfiguracionNotificaciones_MouseDown(object sender, MouseEventArgs e)
        {
            AnimacionBotones.Btn_MouseDown(btn_ConfiguracionNotificaciones);
        }

        private void btn_ConfiguracionNotificaciones_MouseLeave(object sender, EventArgs e)
        {
            AnimacionBotones.Btn_MouseLeave(btn_ConfiguracionNotificaciones);
        }
        #endregion

    }
}
