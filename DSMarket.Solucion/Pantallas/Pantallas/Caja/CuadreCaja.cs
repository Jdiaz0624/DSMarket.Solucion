using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSMarket.Solucion.Pantallas.Pantallas.Caja
{
    public partial class CuadreCaja : Form
    {
        public CuadreCaja()
        {
            InitializeComponent();
        }

        private void CuadreCaja_Load(object sender, EventArgs e)
        {
            gbSeleccionar.BackColor = SystemColors.Control;
            this.BackColor = SystemColors.Control;
            cbCradreMail.Checked = false;
            cbCradreMail.ForeColor = Color.DarkRed;
            lbTitulo.Text = "CUADRE DE CAJA";
            lbTitulo.ForeColor = Color.WhiteSmoke;
        }

        private void CuadreCaja_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        private void PCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbCradreMail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCradreMail.Checked == true)
            {
                cbCradreMail.ForeColor = Color.LimeGreen;

            }
            else
            {
                cbCradreMail.ForeColor = Color.DarkRed;
            }
        }
    }
}
