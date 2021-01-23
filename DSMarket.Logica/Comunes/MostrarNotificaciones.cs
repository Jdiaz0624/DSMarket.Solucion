using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace DSMarket.Logica.Comunes
{
    public static class MostrarNotificaciones
    {
        public static void NotificacionInformacion(NotifyIcon Notificacion, string TExtoNotificacion, string TituloNotificacion, string MensajeNotificacion ) {

            // notifyIcon1.Icon = new System.Drawing.Icon(Path.GetFullPath(@"../../imagenes/if_user_285655.ico"));
            Notificacion.Text = "Este es mi canal MannyDevs";
            Notificacion.Visible = true;
            Notificacion.BalloonTipTitle = "Notificacion de MannyDevs";
            Notificacion.BalloonTipText = "Notificacion enviada";
            Notificacion.ShowBalloonTip(100);
        }
    }
}
