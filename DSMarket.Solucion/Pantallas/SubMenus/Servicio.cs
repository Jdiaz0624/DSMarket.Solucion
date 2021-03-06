﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.SubMenus
{
    public partial class Servicio : Form
    {
        public Servicio()
        {
            InitializeComponent();
        }

        Lazy<DSMarket.Logica.Logica.LogicaCaja.LogicaCaja> ObjDataCaja = new Lazy<Logica.Logica.LogicaCaja.LogicaCaja>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjdataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        DSMarket.Logica.Comunes.VariablesGlobales VariablsGlobales = new Logica.Comunes.VariablesGlobales();
        private void Servicio_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "MENU - SERVICIO";
            lbTitulo.ForeColor = Color.White;
            lbUsuario.Text = DSMarket.Solucion.Pantallas.MenuPrincipal.MenuPrincipal.IdUsuarioMantenimientos.ToString();
            VariablsGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();

            decimal IdNivelAcceso = DSMarket.Logica.Comunes.ValidarNivelUsuario.ValidarNivelAccesoUsuario(Convert.ToDecimal(lbUsuario.Text));
            if (IdNivelAcceso == 3) {
                button1.Enabled = false;
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.MenuPrincipal.MenuPrincipal menu = new MenuPrincipal.MenuPrincipal();
            if (menu.btnrestaurar.Visible == true) { }
            else {
                bool EstatusCaja = false;
                var CalidarCaja = ObjDataCaja.Value.BuscaEstatusCaja();
                foreach (var n in CalidarCaja)
                {
                    EstatusCaja = Convert.ToBoolean(n.Estatus0);
                }
                if (EstatusCaja == true)
                {
                    DSMarket.Solucion.Pantallas.Pantallas.Servicio.FacturacionProductosServicios FActuracion = new Pantallas.Servicio.FacturacionProductosServicios();
                    FActuracion.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbUsuario.Text);
                    FActuracion.VariablesGlobales.GenerarConector = true;
                    FActuracion.VariablesGlobales.SacarDataEspejo = false;
                    FActuracion.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No se puede acceder a esta pantalla por que la caja esta actualmente cerrada, favor de abrir la caja para poder facturar", VariablsGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
           
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Servicio.TipoPago MantenimientoTipoPago = new Pantallas.Servicio.TipoPago();
           // MantenimientoTipoPago
            MantenimientoTipoPago.ShowDialog();
        }

        private void btnCotizacion_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Historial.HistorialFacturacion Historial = new Pantallas.Historial.HistorialFacturacion();
            Historial.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbUsuario.Text);
            Historial.ShowDialog();
            //DSMarket.Solucion.Pantallas.Pantallas.Servicio.HistorialFActuracion Historial = new Pantallas.Servicio.HistorialFActuracion();
            //Historial.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbUsuario.Text);
            //Historial.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DSMarket.Solucion.Pantallas.Pantallas.Historial.HistorialCotizaciones Cotizciones = new Pantallas.Historial.HistorialCotizaciones();
            Cotizciones.VariablesGlobales.IdUsuario = Convert.ToDecimal(lbUsuario.Text);
            Cotizciones.ShowDialog();
        }
    }
}
