using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace DSMarket.Solucion.Pantallas.Pantallas.Configuracion
{
    public partial class InformacionEmpresa : Form
    {
        public InformacionEmpresa()
        {
            InitializeComponent();
        }
        Lazy<DSMarket.Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion> ObjDataConfiguracion = new Lazy<Logica.Logica.LogicaConfiguracion.LogicaCOnfiguracion>();
        Lazy<DSMarket.Logica.Logica.LogicaSeguridad.LogicaSeguridad> ObjDataSeguridad = new Lazy<Logica.Logica.LogicaSeguridad.LogicaSeguridad>();
        public DSMarket.Logica.Comunes.VariablesGlobales VariablesGlobales = new Logica.Comunes.VariablesGlobales();

        #region MOSTRAR LOGO
        private void MostrarImagenPorDefecto(PictureBox Imagen)
        {
            try {
                SqlCommand comando = new SqlCommand("select LogoEmpresa from Configuracion.ImagenesSistema where IdLogoEmpresa = 1", DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion());
                SqlDataAdapter adaptar = new SqlDataAdapter(comando);
                DataSet ds = new DataSet("LogoEmpresa");
                adaptar.Fill(ds, "LogoEmpresa");
                byte[] DATOS = new byte[0];
                DataRow dr = ds.Tables["LogoEmpresa"].Rows[0];
                DATOS = (byte[])dr["LogoEmpresa"];
                MemoryStream ms = new MemoryStream(DATOS);
                Imagen.Image = System.Drawing.Bitmap.FromStream(ms);
            }
            catch (Exception) { }
        }
        #endregion
        #region MOSIFICAR LOGO EMPRESA

        private void ModificarLogoEmpresa() {
            try {
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "EXEC [Configuracion].[SP_MODIFICAR_LOGO_EMPRESA] @IdLogoEmpresa,@Descripcion,@LogoEmpresa";
                comando.Connection = DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();

                comando.Parameters.Add("@IdLogoEmpresa", SqlDbType.Decimal);
                comando.Parameters.Add("@Descripcion", SqlDbType.VarChar);
                comando.Parameters.Add("@LogoEmpresa", SqlDbType.Image);

                comando.Parameters["@IdLogoEmpresa"].Value = 1;
                comando.Parameters["@Descripcion"].Value = "Logo Empresa";

                MemoryStream ms = new MemoryStream();
                pbLogo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                comando.Parameters["@LogoEmpresa"].Value = ms.GetBuffer();

            

                DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion();
                comando.ExecuteNonQuery();
                DSMarket.Data.Conexion.ConexionADO.BDConexion.ObtenerConexion().Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Error al modificar el logo, codigo de error: " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region MODIFICAR INFORMACION DE EMPRESA
        private void ModificarInformacion() {
            try {
                if (string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()))
                {
                    MessageBox.Show("El campo clave de seguridad no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    string _claveIngresada = string.IsNullOrEmpty(txtClaveSeguridad.Text.Trim()) ? null : txtClaveSeguridad.Text.Trim();

                    var ValidarClave = ObjDataSeguridad.Value.BuscaClaveSeguridad(
                        new Nullable<decimal>(),
                        null,
                        DSMarket.Logica.Comunes.SeguridadEncriptacion.Encriptar(_claveIngresada),
                        1, 1);
                    if (ValidarClave.Count() < 1)
                    {
                        MessageBox.Show("La clave de seguridad ingresada no es valida, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else {
                        DSMarket.Logica.Comunes.ModificarInformacionEmpresa Modificar = new Logica.Comunes.ModificarInformacionEmpresa(
                   1,
                   txtNombreEmpresa.Text,
                   txtRNC.Text,
                   txtDireccion.Text,
                   txtEmail.Text,
                   txtEmail2.Text,
                   txtFacebook.Text,
                   txtInstagram.Text,
                   txtTelefonos.Text,
                   1,
                   "UPDATE");
                        Modificar.ModificarInformacion();
                        if (cbCambiarLogo.Checked)
                        {
                            ModificarLogoEmpresa();
                        }
                        MessageBox.Show("Información modificada con exito", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }
            catch (Exception ex) {
                MessageBox.Show("Error al modificar la informacion de la empresa, codigo de error: " + ex.Message, VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        private void SacarInformacionEMpresa() {
            var SacarInformacionEmpresa = ObjDataConfiguracion.Value.BuscaInformacionEmpresa();
            foreach (var n in SacarInformacionEmpresa) {
                txtNombreEmpresa.Text = n.NombreEmpresa;
                txtRNC.Text = n.RNC;
                txtDireccion.Text = n.Direccion;
                txtEmail.Text = n.Email;
                txtEmail2.Text = n.Email2;
                txtFacebook.Text = n.Facebook;
                txtInstagram.Text = n.Instagran;
                txtTelefonos.Text = n.Telefonos;
            }

            //SACAMOS EL LOGO DE LA EMPRESA
        }
        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbCambiarLogo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCambiarLogo.Checked == true)
            {
                cbCambiarLogo.ForeColor = Color.LimeGreen;
                btnBucaImagen.Enabled = true;
            }
            else
            {
                cbCambiarLogo.ForeColor = Color.DarkRed;
                btnBucaImagen.Enabled = false;
            }
        }

        private void InformacionEmpresa_Load(object sender, EventArgs e)
        {
            cbCambiarLogo.ForeColor = Color.LimeGreen;
            cbCambiarLogo.Checked = false;
            this.BackColor = SystemColors.Control;
            txtClaveSeguridad.PasswordChar = '•';
            lbTitulo.Text = "INFORMACION DE EMPRESA";
            lbTitulo.ForeColor = Color.WhiteSmoke;

            txtClaveSeguridad.BackColor = Color.WhiteSmoke;
            txtDireccion.BackColor = Color.WhiteSmoke;
            txtEmail.BackColor = Color.WhiteSmoke;
            txtEmail2.BackColor = Color.WhiteSmoke;
            txtFacebook.BackColor = Color.WhiteSmoke;
            txtInstagram.BackColor = Color.WhiteSmoke;
            txtNombreEmpresa.BackColor = Color.WhiteSmoke;
            txtRNC.BackColor = Color.WhiteSmoke;
            txtTelefonos.BackColor = Color.WhiteSmoke;
            SacarInformacionEMpresa();
            MostrarImagenPorDefecto(pbLogo);
            VariablesGlobales.NombreSistema = DSMarket.Logica.Comunes.InformacionEmpresa.SacarNombreEmpresa();
            
        }

        private void InformacionEmpresa_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void btnBucaImagen_Click(object sender, EventArgs e)
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
                    pbLogo.ImageLocation = VariablesGlobales.RutaImagen;
                }
            }
            catch (Exception) { }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreEmpresa.Text.Trim()))
            {
                MessageBox.Show("El campo nombre de empresa no puede estar vacio, favor de verificar", VariablesGlobales.NombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                ModificarInformacion();
            }
        }

        private void btnPoliticas_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Configuracion.PoliticasEmpresa politicas = new PoliticasEmpresa();
            politicas.variablesGlobales.IdUsuario = VariablesGlobales.IdUsuario;
            politicas.ShowDialog();
        }
    }
}
