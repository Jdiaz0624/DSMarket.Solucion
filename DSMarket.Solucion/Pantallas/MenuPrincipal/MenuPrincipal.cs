using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.MenuPrincipal
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        public static decimal IdUsuarioMantenimientos;
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataCOnfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDataEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        public  DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();


        #region FUNCION PARA LLAMAR LOS FORMULARIOS
        private void AbrirPantallasEnPanel(object Pantalla)
        {
            if (PanelCuerpo.Controls.Count > 0)
                this.PanelCuerpo.Controls.RemoveAt(0);
            Form Formulario = Pantalla as Form;
            Formulario.TopLevel = false;
            Formulario.Dock = DockStyle.Fill;
            this.PanelCuerpo.Controls.Add(Formulario);
            this.PanelCuerpo.Tag = Formulario;
           // VariablesGlobales.NombreSistema = lbUsuarioConectado.Text;

            Formulario.Show();
        }
        #endregion
        #region APLICAR TEMA
        private void TemaGenerico()
        {
            //COLOR DE FONDO
            this.BackColor = Color.FloralWhite;


        }
        #endregion
        #region SACAR LA INFORMACION DE LA EMPRESA
        private void SacarInformacionEmpresa()
        {
            var SacarInformacionEmpresa = ObjDataCOnfiguracion.Value.BuscaInformacionEmpresa();
            foreach (var n in SacarInformacionEmpresa)
            {
                VariablesGlobales.NombreSistema = n.NombreEmpresa;
               lbNombreEmpresa.Text = VariablesGlobales.NombreSistema;
            }
        }
        #endregion
        private void MostrarNotificaciones() {
            bool AlertaCumpleaños = DSMarket.Logica.Comunes.ValidarConfiguracionGeneral.Validar(15);
            if (AlertaCumpleaños == true) {
                //SACAR LA CANTIDAD PERSONAS DE FIESTA DE CUMPLEAÑOS
                var Cantidad = ObjDataEmpresa.Value.MostrarCumpleanosClientes(1, 999999999);
                string CantidadRegistros = Cantidad.Count.ToString();
                int CantidadRegistrosEntero = Cantidad.Count;
                string ClientePlural = "";

                if (CantidadRegistrosEntero != 0) {

                    if (CantidadRegistrosEntero == 1) {
                        ClientePlural = "Cliente";
                    }
                    else {
                        ClientePlural = "Clientes";
                    }

                    NotificacionCumpleanos.Icon = new System.Drawing.Icon(Path.GetFullPath(@"../../Resources/DSMarket-Icono-1024x1024.ico"));
                    NotificacionCumpleanos.Text = "DeveSoft - DSMarket";
                    NotificacionCumpleanos.Visible = true;
                    NotificacionCumpleanos.BalloonTipTitle = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
                    NotificacionCumpleanos.BalloonTipText = "Se han encontrado " + CantidadRegistros + " " + ClientePlural + " que estan de cumpleaños el dia de hoy";
                    NotificacionCumpleanos.ShowBalloonTip(100);
                }
            }






            
        }
        private void PCerrar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Quieres salir del sistema?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void PMinimizar_Click(object sender, EventArgs e)
        {
            try {
                PanelCuerpo.Visible = false;
                PanelMenu.Visible = false;
                PanelOpciones.Visible = false;
               // PanelTop.Visible = false;
                this.WindowState = FormWindowState.Minimized;
                PanelCuerpo.Visible = true;
                btnrestaurar.Visible = true;
                btnrestaurar.Width = 1049;
                btnrestaurar.Height = 53;
            }
            catch (Exception) { }
        }

        private void PMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            PMaximizar.Visible = false;
            PRestaurar.Visible = true;
            groupBox1.Width = 117;
           // groupBox1.Height = 100;

        }

        private void PRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            PMaximizar.Visible = true;
            PRestaurar.Visible = false;
            groupBox1.Width = 117;
           // groupBox1.Height = 100;
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            
            SacarInformacionEmpresa();
            TemaGenerico();
            //btnServicio.Visible = false;
            //EfectoBotones.Show(btnServicio);
            //btnInventario.Visible = false;
            //EfectoBotones.Show(btnInventario);
            //btnCaja.Visible = false;
            //EfectoBotones.Show(btnCaja);
            //btneEmpresa.Visible = false;
            //EfectoBotones.Show(btneEmpresa);
            //btnContabilidad.Visible = false;
            //EfectoBotones.Show(btnContabilidad);
            //btnReportesSistema.Visible = false;
            //EfectoBotones.Show(btnReportesSistema);
            //btnConfiguracion.Visible = false;
            //EfectoBotones.Show(btnConfiguracion);
            //btnSeguridad.Visible = false;
            //EfectoBotones.Show(btnSeguridad);
            //btnCerrarSesion.Visible = false;
            //EfectoBotones.Show(btnCerrarSesion);

            //SACAMOS LOS DATOS DEL USUARIO
            var SacarDatosUsuario = ObjdataSeguridad.Value.BuscaUsuarios(VariablesGlobales.IdUsuario, null, null, null, null, 1, 1);
            foreach (var n in SacarDatosUsuario)
            {
                lbIdUsuario.Text = n.IdUsuario.ToString();
                lbIdNivel.Text = n.IdNivelAcceso.ToString();
                lbusuarioConectado.Text = n.Persona;
                lbNivelAcceso.Text = n.Nivel;
            }
            lbusuarioConectado.ForeColor = Color.WhiteSmoke;
            lbNivelAcceso.ForeColor = Color.WhiteSmoke;

            btnServicio.Enabled = true;
            btnInventario.Enabled = true;
            btnCaja.Enabled = true;
            btneEmpresa.Enabled = true;
            btnConfiguracion.Enabled = true;
            btnSeguridad.Enabled = true;
            btnReportesSistema.Enabled = true;

            if (VariablesGlobales.IdNivelAcceso == 3) {
                btnCaja.Enabled = false;
                btneEmpresa.Enabled = false;
                btnConfiguracion.Enabled = false;
                btnSeguridad.Enabled = false;
                btnContabilidad.Enabled = false;
            }
            MostrarNotificaciones();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (PanelOpciones.Width == 270)
            {
                PanelOpciones.Visible = false;
                PanelOpciones.Width = 68;
                PanelMenu.Width = 90;
                Separador.Width = 52;
                pbLogolargo.Visible = false;
                lbLogoCorto.Visible = true;
                EfectoIda.Show(PanelOpciones);
            }
            else
            {
                PanelOpciones.Visible = false;
                PanelOpciones.Width = 270;
                PanelMenu.Width = 300;
                Separador.Width = 252;
                pbLogolargo.Visible = true;
                lbLogoCorto.Visible = false;
                EfectoIda.Show(PanelOpciones);
            }
        }



        private void btnServicio_Click(object sender, EventArgs e)
        {
            IdUsuarioMantenimientos = Convert.ToDecimal(lbIdUsuario.Text);
            AbrirPantallasEnPanel(new DSMarket.Solucion.Pantallas.SubMenus.Servicio());
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            IdUsuarioMantenimientos = Convert.ToDecimal(lbIdUsuario.Text);
            AbrirPantallasEnPanel(new DSMarket.Solucion.Pantallas.SubMenus.Inventario());
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            IdUsuarioMantenimientos = Convert.ToDecimal(lbIdUsuario.Text);
            AbrirPantallasEnPanel(new DSMarket.Solucion.Pantallas.SubMenus.Caja());
        }

        private void btneEmpresa_Click(object sender, EventArgs e)
        {
            IdUsuarioMantenimientos = Convert.ToDecimal(lbIdUsuario.Text);
            AbrirPantallasEnPanel(new DSMarket.Solucion.Pantallas.SubMenus.Nomina());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            IdUsuarioMantenimientos = Convert.ToDecimal(lbIdUsuario.Text);
            AbrirPantallasEnPanel(new DSMarket.Solucion.Pantallas.SubMenus.Reportes());
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            IdUsuarioMantenimientos = Convert.ToDecimal(lbIdUsuario.Text);
            AbrirPantallasEnPanel(new DSMarket.Solucion.Pantallas.SubMenus.Configuracion());
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            IdUsuarioMantenimientos = Convert.ToDecimal(lbIdUsuario.Text);
            AbrirPantallasEnPanel(new DSMarket.Solucion.Pantallas.SubMenus.Seguridad());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Quieres cerrar sesión?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void PanelCuerpo_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void BtnReportesSistema_Click(object sender, EventArgs e)
        {
            IdUsuarioMantenimientos = Convert.ToDecimal(lbIdUsuario.Text);
            AbrirPantallasEnPanel(new DSMarket.Solucion.Pantallas.SubMenus.Reportes());
        }

        private void btnContabilidad_Click(object sender, EventArgs e)
        {
            IdUsuarioMantenimientos = Convert.ToDecimal(lbIdUsuario.Text);
            AbrirPantallasEnPanel(new DSMarket.Solucion.Pantallas.SubMenus.Contabilidad());
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            PanelCuerpo.Visible = true;
            PanelMenu.Visible = true;
            PanelOpciones.Visible = true;
            PanelTop.Visible = true;
            btnrestaurar.Visible = false;
        }
    }
}
