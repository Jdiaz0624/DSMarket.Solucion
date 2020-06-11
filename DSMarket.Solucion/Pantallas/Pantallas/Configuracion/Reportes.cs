using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Configuracion
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DSMarket.Solucion.Pantallas.Pantallas.Configuracion.CredencialesBD Credenciales = new CredencialesBD();
            Credenciales.ShowDialog();
  
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            lbTitulo.Text = "CONFIGURACION DE REPORTES DEL SISTEMA";
            lbTitulo.ForeColor = Color.WhiteSmoke;
            dtListado.BackgroundColor = SystemColors.Control;
        }

        private void Reportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
