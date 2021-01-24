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
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();


        //public void send()
        //{
        //    EMailSetting eMailSetting = _boEnterprise.EMailSetting();
        //    EEnterprise enterprise = _boEnterprise.GetEnterpriseData();

        //    string htmlBody = "<html><body><h1>Picture</h1><br><img src=\"cid:Imagen1\"></body></html>";
        //    AlternateView avHtml = AlternateView.CreateAlternateViewFromString
        //       (htmlBody, null, MediaTypeNames.Text.Html);

        //    LinkedResource inline = new LinkedResource("Imagen1.jpg", MediaTypeNames.Image.Jpeg);
        //    inline.ContentId = Guid.NewGuid().ToString();
        //    avHtml.LinkedResources.Add(inline);

        //    MailMessage mail = new MailMessage();
        //    mail.AlternateViews.Add(avHtml);

        //    Attachment att = new Attachment(@"D:\...\Debug\Imagen1.jpg");
        //    att.ContentDisposition.Inline = true;

        //    mail.From = new MailAddress(eMailSetting.UserName);
        //    mail.To.Add("xxxxxx@hotmail.com");
        //    mail.Subject = "Client: ffffff Has Sent You A Screenshot";
        //    mail.Body = String.Format(
        //               "<h3>Client: yyyyy Has Sent You A Screenshot</h3>" +
        //               @"<img src=""cid:{0}"" />", inline.ContentId);

        //    mail.IsBodyHtml = true;
        //    mail.Attachments.Add(att);

        //    SmtpClient smtp = new SmtpClient
        //    {
        //        Credentials =
        //            new NetworkCredential(eMailSetting.UserName, eMailSetting.Password),
        //        Host = eMailSetting.Servidor,
        //        Port = eMailSetting.Puerto,
        //        EnableSsl = eMailSetting.Ssl
        //    };
        //    smtp.Send(mail);
        //    mail.Dispose();
        //}
        private void MostrarListadoCumpleanos() {
            var MostrarListado = ObjDtaEmpresa.Value.MostrarCumpleanosClientes(
                Convert.ToInt32(txtNumeroPagina.Value),
                Convert.ToInt32(txtNumeroRegistros.Value));
            dtListado.DataSource = MostrarListado;

            lbCantidadRegistrosVariable.Text = MostrarListado.Count.ToString("N0");

            this.dtListado.Columns["CodigoCliente"].Visible = false;
            this.dtListado.Columns["MesNacimiento"].Visible = false;
            this.dtListado.Columns["MesActual"].Visible = false;
            this.dtListado.Columns["Cumpleanos"].Visible = false;
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
            lbCantidadRegistrosTitulo.ForeColor = Color.White;
            lbCantidadRegistrosVariable.ForeColor = Color.White;
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
            }
            else {
                gbEnvioCorreo.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DSMarket.Logica.Comunes.Correo Envio = new Logica.Comunes.Correo
            {
                Mail = "ing.juanmarcelinom.diaz@hotmail.com",
                Alias = "DSMarket",
                Asunto = txtAsunto.Text,
                Clave = "!@Pa$$W0rd!@0624",
                Puerto = 587,
                smtp = "smtp.live.com",
                RutaImagen = VariablesGlobales.RutaImagen,
                Cuerpo=txtCuerpo.Text,
                Destinatarios = new List<string>(),
                Adjuntos=new List<string>()
            };

            Envio.Destinatarios.Add("ing.juanmarcelinom.diaz@gmail.com");
            Envio.Destinatarios.Add("jmdiaz@amigosseguros.com");
            Envio.Destinatarios.Add("juanmarcelinoo0624@gmail.com");
            Envio.Destinatarios.Add("angela.diaz.reyes0624@gmail.com");

            foreach (DataGridViewRow fila in dtArchivos.Rows) {
                string Destino = fila.Cells["CnArchivo"].Value.ToString();

                if (!string.IsNullOrEmpty(Destino)) {
                    Envio.Adjuntos.Add(Destino);
                }
            }

            if (Envio.Enviar(Envio)) {
                MessageBox.Show("OK");
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
            }
            Abrir.Dispose();
        }
    }
}
