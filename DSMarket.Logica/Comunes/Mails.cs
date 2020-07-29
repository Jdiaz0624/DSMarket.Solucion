using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace DSMarket.Logica.Comunes
{
    public class Mails
    {
        MailMessage Mensaje = new MailMessage();
        SmtpClient smtp = new SmtpClient();

        private string CorreoOrigen = "";
        private string ClaveCorreoOrigen = "";
        private string CorreoDestino = "";
        private string CuerpoCorreo = "";
        private string AsuntoCorreo = "";
        private string SMTP = "";
        private int Puerto = 0;

        public Mails(
            string CorreoOrigenCON,
            string ClaveCOrreoOrigenCON,
            string CorreoDestinoCON,
            string CorreoCuerpoCON,
            string AsuntoCorreoCON,
            string SMTPCON,
            int PuertoCON)
        {
            CorreoOrigen = CorreoOrigenCON;
            ClaveCorreoOrigen = ClaveCOrreoOrigenCON;
            CorreoDestino = CorreoDestinoCON;
            CuerpoCorreo = CorreoCuerpoCON;
            AsuntoCorreo = AsuntoCorreoCON;
            SMTP = SMTPCON;
            Puerto = PuertoCON;
        }

        public bool EnviarCorreo()
        {
            try
            {
                Mensaje.From = new MailAddress(CorreoOrigen);
                Mensaje.Bcc.Add(new MailAddress(CorreoDestino));
                Mensaje.Subject = AsuntoCorreo;
                Mensaje.Body = CuerpoCorreo;
                smtp.Host = SMTP;
                smtp.Port = Puerto;
                smtp.Credentials = new NetworkCredential(CorreoOrigen, ClaveCorreoOrigen);
                smtp.EnableSsl = true;
                //    smtp.Timeout = 999999999;
                smtp.Send(Mensaje);
                Mensaje.Bcc.Clear();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
