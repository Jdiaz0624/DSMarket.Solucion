using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSMarket.Logica.Comunes.ProcesarInformacion.Servicio
{
    public class ProcesarInformacionFacturacionClientes
    {
        readonly DSMarket.Logica.Logica.LogicaServicio.LogicaServicio ObjData = new Logica.LogicaServicio.LogicaServicio();

        private decimal IdFactura = 0;
        private decimal NumeroConector = 0;
        private decimal IdEstatusFacturacion = 0;
        private decimal IdComprobante = 0;
        private string Nombre = "";
        private string Telefono = "";
        private string Email = "";



        /*DSMarket.Logica.Entidades.EntidadesServicio.EFacturacionClientes ManClientes = new Logica.Entidades.EntidadesServicio.EFacturacionClientes();

            ManClientes.IdFactura = IdFactura;
            ManClientes.NumeroConector = VariablesGlobales.NumeroConector;
            ManClientes.IdEstatusFacturacion = IdEstatusFacturacion;
            ManClientes.IdComprobante = Convert.ToDecimal(ddlTipoFacturacion.SelectedValue);
            ManClientes. = txtNombrePaciente.Text;
            ManClientes. = txtTelefono.Text;
            ManClientes. = txtEmail.Text;
            ManClientes.IdTipoIdentificacion = Convert.ToDecimal(ddlTipoIdentificacion.SelectedValue);
            ManClientes.NumeroIdentificacion = txtIdentificacion.Text;
            ManClientes.Direccion = txtDireccion.Text;
            ManClientes.Comentario = txtComentario.Text;
            ManClientes.IdTipoVenta = Convert.ToDecimal(ddlTipoVenta.SelectedValue);
            ManClientes.IdCantidadDias = Convert.ToDecimal(ddlCantidadDias.SelectedValue);
            ManClientes.IdUsuario = VariablesGlobales.IdUsuario;
            ManClientes.AplicaGarantia = VariablesGlobales.AplicaGanancia;
            ManClientes.DiasGarantia = Convert.ToInt32(txtCantidadDiasGarantia.Value);
            ManClientes.IdTipoIngreso = Convert.ToInt32(ddlSeleccionarTipoIngres.SelectedValue);
            ManClientes.IdTipoAnulaicon = 0;
            ManClientes.TipoTiempoGarantia =TipoTiempoGarantia;

            var MAN = ObjDataServicio.Value.GuardarFacturacionClientes(ManClientes, Accion);*/
    }
}
