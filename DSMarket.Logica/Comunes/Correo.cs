using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mime;
using System.Net;

namespace DSMarket.Logica.Comunes
{
    public class Correo
    {
      

        public string Mail { get; set; }
        public string Alias { get; set; }
        public string Clave { get; set; }
        public int Puerto { get; set; }
        public string smtp { get; set; }
        public string Asunto { get; set; }
        public string Cuerpo { get; set; }
        public List<string> Destinatarios { get; set; }
        public List<string> Adjuntos { get; set; }
        public string RutaImagen { get; set; }

        public  bool Enviar(Correo correo) {

            try {
                SmtpClient Cliente = new SmtpClient(correo.smtp, correo.Puerto);
                MailMessage Mail = new MailMessage();
                Mail.From = new MailAddress(correo.Mail, correo.Alias);

                Mail.BodyEncoding = System.Text.Encoding.UTF8;
                Mail.IsBodyHtml = true;

                if (!string.IsNullOrEmpty(correo.RutaImagen))
                {
                    AlternateView avHTML = AlternateView.CreateAlternateViewFromString(correo.Cuerpo + "<br/><img src=cid:Imagen1>", null, "text/html");
                    LinkedResource lr = new LinkedResource(correo.RutaImagen, MediaTypeNames.Image.Jpeg);
                    lr.ContentId = "Imagen1";
                    avHTML.LinkedResources.Add(lr);
                    Mail.AlternateViews.Add(avHTML);
                    Mail.Body = lr.ContentId;
                }
                else {
                    Mail.Body = correo.Cuerpo;
                }

                Mail.Subject = correo.Asunto;
                Mail.SubjectEncoding = System.Text.Encoding.UTF8;

                //AGREGAMOS LOS DESTINATARIOS
                foreach (var Destinos in correo.Destinatarios) {
                    if (!string.IsNullOrEmpty(Destinos)) {
                        Mail.Bcc.Add(Destinos);
                    }
                }

                //ADJUNTOS
                foreach (var Adjuntos in correo.Adjuntos)
                {
                    if (!string.IsNullOrEmpty(Adjuntos))
                    {
                        Mail.Attachments.Add(new Attachment(Adjuntos));
                    }
                }
                Cliente.Credentials = new NetworkCredential(correo.Mail, correo.Clave);
                Cliente.EnableSsl = true;
                Cliente.Send(Mail);
                return true;
            }
            catch (Exception ex) {
                MessageBox.Show("Error al enviar el correo, codigo de error: " + ex.Message, "Error de envio de correo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
