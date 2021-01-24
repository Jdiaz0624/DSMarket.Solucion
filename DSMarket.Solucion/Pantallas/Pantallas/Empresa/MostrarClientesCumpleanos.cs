using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Empresa
{
    public partial class MostrarClientesCumpleanos : Form
    {
        public MostrarClientesCumpleanos()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaEmpresa.LogicaEmpresa> ObjDtaEmpresa = new Lazy<Logica.Logica.LogicaEmpresa.LogicaEmpresa>();
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        private void MostrarListadoCumpleanos() {
            MANProcesarClientes(0, VariablesGlobales.IdUsuario, 0, "", "", "DELETEALL");


            var MostrarListado = ObjDtaEmpresa.Value.MostrarCumpleanosClientes(
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = MostrarListado;

            lbCantidadRegistrosVariable.Text = MostrarListado.Count.ToString("N0");

            this.dtListado.Columns["CodigoCliente"].Visible = false;
            this.dtListado.Columns["MesNacimiento"].Visible = false;
            this.dtListado.Columns["MesActual"].Visible = false;
            this.dtListado.Columns["Cumpleanos"].Visible = false;

        
            foreach (var n in MostrarListado) {

                //BUSCAMOS LOIdClienteS DATOS DEL CLIENTE
                var BuscarCliente = ObjDtaEmpresa.Value.BuscaClientes(
                    (decimal)n.CodigoCliente, null, null, null, null, null, 1, 1);
                foreach (var n2 in BuscarCliente) {
                    MANProcesarClientes(
                        0,
                        VariablesGlobales.IdUsuario,
                        (decimal)n2.IdCliente,
                        n2.Nombre,
                        n2.Email,
                        "INSERT");
                }
            }
            MostrarCorreosProcesar(null, VariablesGlobales.IdUsuario, null);
        }

        private void MostrarCorreosProcesar(decimal? IdRegistro, decimal IdUsuario, decimal? IdCliente) {
            var MostrarCorreosProcesar = ObjDtaEmpresa.Value.BuscaCorreosClientes(
                    IdRegistro,
                    IdUsuario,
                    IdCliente);
            dtCorreosProcesar.DataSource = MostrarCorreosProcesar;
            this.dtCorreosProcesar.Columns["IdRegistro"].Visible = false;
            this.dtCorreosProcesar.Columns["IdUsuario"].Visible = false;
            this.dtCorreosProcesar.Columns["IdCliente"].Visible = false;
        }

        private void MANProcesarClientes(decimal IdRegistro, decimal IdUsuario, decimal IdCliente, string Nombre, string Correo, string Accion) {
            DSMarket.Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionCorreosClienteDinamico Procesar = new Logica.Comunes.ProcesarInformacion.Empresa.ProcesarInformacionCorreosClienteDinamico(
                IdRegistro,
                IdUsuario,
                IdCliente,
                Nombre,
                Correo,
                Accion);
            Procesar.ProcesarInformacion();
        }
        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DSMarket.Solucion.Pantallas.Pantallas.Empresa.ClientesConsulta Consulta = new ClientesConsulta();
            Consulta.VariablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            Consulta.ShowDialog();
        }

        private void MostrarClientesCumpleanos_Load(object sender, EventArgs e)
        {
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            lbCantidadRegistrosVariable.ForeColor = Color.White;
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Text = "Listado de Cumpleaños";
            MostrarListadoCumpleanos();
            gbEnvioCorreo.Visible = false;
            
        }

        private void MostrarClientesCumpleanos_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason) {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void cbEnvioMasivo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEnvioMasivo.Checked == true)
            {
                gbEnvioCorreo.Visible = true;
                MostrarListadoCumpleanos();
            }
            else {
                gbEnvioCorreo.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string CorreoBD = "";
            string AliasBD = VariablesGlobales.NombreSistema;
            string Asunto = string.IsNullOrEmpty(txtAsunto.Text.Trim()) ? null : txtAsunto.Text.Trim();
            string ClaveCorreo = "";
            int PuertoCorreo = 0;
            string smtpCorreoBD = "";

            var SacarInformacionCorreo = ObjDataConfiguracion.Value.BuscaMail(1);
            foreach (var nCorreo in SacarInformacionCorreo) {
                CorreoBD = nCorreo.Mail;
                ClaveCorreo = DSMarket.Logica.Comunes.SeguridadEncriptacion.DesEncriptar(nCorreo.Clave);
                PuertoCorreo = (int)nCorreo.Puerto;
                smtpCorreoBD = nCorreo.smtp;
            }
            DSMarket.Logica.Comunes.Correo Envio = new Logica.Comunes.Correo
            {
                Mail = CorreoBD,
                Alias = AliasBD,
                Asunto = Asunto,
                Clave = ClaveCorreo,
                Puerto = PuertoCorreo,
                smtp = smtpCorreoBD,
                RutaImagen = VariablesGlobales.RutaImagen,
                Cuerpo=txtCuerpo.Text,
                Destinatarios = new List<string>(),
                Adjuntos=new List<string>()
            };

            var SacarCorreosEnviar = ObjDtaEmpresa.Value.BuscaCorreosClientes(
                new Nullable<decimal>(),
                VariablesGlobales.IdUsuario,
                null);
            if (SacarCorreosEnviar.Count() < 1)
            {
                MessageBox.Show("No se encontraron destinos a los que enviar los correos, favor de verificar.", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                foreach (var nEnviar in SacarCorreosEnviar)
                {
                    Envio.Destinatarios.Add(nEnviar.Correo);
                }

                foreach (DataGridViewRow fila in dtArchivos.Rows)
                {
                    string Destino = fila.Cells["CnArchivo"].Value.ToString();

                    if (!string.IsNullOrEmpty(Destino))
                    {
                        Envio.Adjuntos.Add(Destino);
                    }
                }

                if (Envio.Enviar(Envio))
                {
                    MessageBox.Show("Correo Exitosamente", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtArchivos.DataSource = null;
                    pictureBox2.Image = null;
                    dtCorreosProcesar.DataSource = null;
                    cbEnvioMasivo.Checked = false;
                    txtAsunto.Text = string.Empty;
                    txtCuerpo.Text = string.Empty;
                    dtArchivos.DataSource = null;
                    dtCorreosProcesar.DataSource = null;
                    lbCantidadArchivos.Text = "0";
                }
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog Imagen = new OpenFileDialog();
                Imagen.InitialDirectory = "C://";
                Imagen.Filter = "All files(*.*)|*.*";
                Imagen.FilterIndex = 2;
                Imagen.RestoreDirectory = true;
                if (Imagen.ShowDialog() == DialogResult.OK)
                {
                    this.VariablesGlobales.RutaImagen = Imagen.FileName;
                    pictureBox2.ImageLocation = VariablesGlobales.RutaImagen;
                }
            }
            catch (Exception) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog Abrir = new OpenFileDialog();
            Abrir.Title = "Seleccionar Archivo";
            Abrir.Multiselect = true;
            if (Abrir.ShowDialog() == DialogResult.OK) {
                var archivos = Abrir.FileNames;
                foreach (var Item in archivos) {
                    dtArchivos.Rows.Add(Item);
                }
                var Cantidad = archivos.Count();
                lbCantidadArchivos.Text = Cantidad.ToString();
            }
            Abrir.Dispose();
        }

        private void dtCorreosProcesar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres Quitar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                decimal IdRegistro = Convert.ToDecimal(dtCorreosProcesar.CurrentRow.Cells["IdRegistro"].Value.ToString());
                decimal IdUsuario = Convert.ToDecimal(dtCorreosProcesar.CurrentRow.Cells["IdUsuario"].Value.ToString());
                decimal IdCliente = Convert.ToDecimal(dtCorreosProcesar.CurrentRow.Cells["IdCliente"].Value.ToString());

                MANProcesarClientes(IdRegistro, IdUsuario, IdCliente, "", "", "DELETE");
                MostrarCorreosProcesar(null, VariablesGlobales.IdUsuario, null);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = null;
        }

        private void dtArchivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Quieres eliminar este registro?", VariablesGlobales.NombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                dtArchivos.Rows.RemoveAt(dtArchivos.CurrentRow.Index);
            }
        }
    }
}
