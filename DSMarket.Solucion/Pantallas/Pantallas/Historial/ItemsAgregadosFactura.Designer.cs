
namespace DSMarket.Solucion.Pantallas.Pantallas.Historial
{
    partial class ItemsAgregadosFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.PCerrar = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNumeroFacturavariable = new System.Windows.Forms.Label();
            this.lbFacturadoAvariable = new System.Windows.Forms.Label();
            this.lbfechaFacturacionvariable = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbCantidadProductosvariable = new System.Windows.Forms.Label();
            this.lbCantidadServiciosVariable = new System.Windows.Forms.Label();
            this.lbNumeroItemsvariable = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtListado = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lbfacturaAnuladavariable = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.PCerrar);
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 38);
            this.panel1.TabIndex = 102;
            // 
            // PCerrar
            // 
            this.PCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PCerrar.Image = global::DSMarket.Solucion.Properties.Resources.Close_Window__2_48px;
            this.PCerrar.Location = new System.Drawing.Point(1158, 5);
            this.PCerrar.Name = "PCerrar";
            this.PCerrar.Size = new System.Drawing.Size(30, 30);
            this.PCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCerrar.TabIndex = 15;
            this.PCerrar.TabStop = false;
            this.PCerrar.Click += new System.EventHandler(this.PCerrar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(15, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(51, 20);
            this.lbTitulo.TabIndex = 13;
            this.lbTitulo.Text = "label6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 103;
            this.label1.Text = "Numero de Factura: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 104;
            this.label2.Text = "Facturado A: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(829, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 105;
            this.label3.Text = "Fecha de Facturación: ";
            // 
            // lbNumeroFacturavariable
            // 
            this.lbNumeroFacturavariable.AutoSize = true;
            this.lbNumeroFacturavariable.Location = new System.Drawing.Point(194, 65);
            this.lbNumeroFacturavariable.Name = "lbNumeroFacturavariable";
            this.lbNumeroFacturavariable.Size = new System.Drawing.Size(154, 20);
            this.lbNumeroFacturavariable.TabIndex = 106;
            this.lbNumeroFacturavariable.Text = "Numero de Factura: ";
            // 
            // lbFacturadoAvariable
            // 
            this.lbFacturadoAvariable.AutoSize = true;
            this.lbFacturadoAvariable.Location = new System.Drawing.Point(463, 65);
            this.lbFacturadoAvariable.Name = "lbFacturadoAvariable";
            this.lbFacturadoAvariable.Size = new System.Drawing.Size(105, 20);
            this.lbFacturadoAvariable.TabIndex = 107;
            this.lbFacturadoAvariable.Text = "Facturado A: ";
            // 
            // lbfechaFacturacionvariable
            // 
            this.lbfechaFacturacionvariable.AutoSize = true;
            this.lbfechaFacturacionvariable.Location = new System.Drawing.Point(1021, 66);
            this.lbfechaFacturacionvariable.Name = "lbfechaFacturacionvariable";
            this.lbfechaFacturacionvariable.Size = new System.Drawing.Size(172, 20);
            this.lbfechaFacturacionvariable.TabIndex = 108;
            this.lbfechaFacturacionvariable.Text = "Fecha de Facturación: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 20);
            this.label7.TabIndex = 109;
            this.label7.Text = "Cantidad de Productos: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(438, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 20);
            this.label8.TabIndex = 110;
            this.label8.Text = "Cantidad de Servicios: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(813, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 20);
            this.label9.TabIndex = 111;
            this.label9.Text = "Numero de Items: ";
            // 
            // lbCantidadProductosvariable
            // 
            this.lbCantidadProductosvariable.AutoSize = true;
            this.lbCantidadProductosvariable.Location = new System.Drawing.Point(224, 103);
            this.lbCantidadProductosvariable.Name = "lbCantidadProductosvariable";
            this.lbCantidadProductosvariable.Size = new System.Drawing.Size(179, 20);
            this.lbCantidadProductosvariable.TabIndex = 112;
            this.lbCantidadProductosvariable.Text = "Cantidad de Productos: ";
            // 
            // lbCantidadServiciosVariable
            // 
            this.lbCantidadServiciosVariable.AutoSize = true;
            this.lbCantidadServiciosVariable.Location = new System.Drawing.Point(625, 103);
            this.lbCantidadServiciosVariable.Name = "lbCantidadServiciosVariable";
            this.lbCantidadServiciosVariable.Size = new System.Drawing.Size(170, 20);
            this.lbCantidadServiciosVariable.TabIndex = 113;
            this.lbCantidadServiciosVariable.Text = "Cantidad de Servicios: ";
            // 
            // lbNumeroItemsvariable
            // 
            this.lbNumeroItemsvariable.AutoSize = true;
            this.lbNumeroItemsvariable.Location = new System.Drawing.Point(963, 103);
            this.lbNumeroItemsvariable.Name = "lbNumeroItemsvariable";
            this.lbNumeroItemsvariable.Size = new System.Drawing.Size(139, 20);
            this.lbNumeroItemsvariable.TabIndex = 114;
            this.lbNumeroItemsvariable.Text = "Numero de Items: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtListado);
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1176, 512);
            this.groupBox1.TabIndex = 115;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Items de factura";
            // 
            // dtListado
            // 
            this.dtListado.AllowUserToAddRows = false;
            this.dtListado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtListado.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtListado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtListado.EnableHeadersVisualStyles = false;
            this.dtListado.Location = new System.Drawing.Point(3, 22);
            this.dtListado.Name = "dtListado";
            this.dtListado.ReadOnly = true;
            this.dtListado.RowTemplate.Height = 24;
            this.dtListado.Size = new System.Drawing.Size(1170, 487);
            this.dtListado.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 116;
            this.label4.Text = "Factura Anulada: ";
            // 
            // lbfacturaAnuladavariable
            // 
            this.lbfacturaAnuladavariable.AutoSize = true;
            this.lbfacturaAnuladavariable.Location = new System.Drawing.Point(175, 136);
            this.lbfacturaAnuladavariable.Name = "lbfacturaAnuladavariable";
            this.lbfacturaAnuladavariable.Size = new System.Drawing.Size(127, 20);
            this.lbfacturaAnuladavariable.TabIndex = 117;
            this.lbfacturaAnuladavariable.Text = "Factura Anulada";
            // 
            // ItemsAgregadosFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.lbfacturaAnuladavariable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbNumeroItemsvariable);
            this.Controls.Add(this.lbCantidadServiciosVariable);
            this.Controls.Add(this.lbCantidadProductosvariable);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbfechaFacturacionvariable);
            this.Controls.Add(this.lbFacturadoAvariable);
            this.Controls.Add(this.lbNumeroFacturavariable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ItemsAgregadosFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemsAgregadosFactura";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemsAgregadosFactura_FormClosing);
            this.Load += new System.EventHandler(this.ItemsAgregadosFactura_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PCerrar;
        public System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbNumeroItemsvariable;
        private System.Windows.Forms.Label lbCantidadServiciosVariable;
        private System.Windows.Forms.Label lbCantidadProductosvariable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbfechaFacturacionvariable;
        private System.Windows.Forms.Label lbFacturadoAvariable;
        private System.Windows.Forms.Label lbNumeroFacturavariable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtListado;
        private System.Windows.Forms.Label lbfacturaAnuladavariable;
        private System.Windows.Forms.Label label4;
    }
}