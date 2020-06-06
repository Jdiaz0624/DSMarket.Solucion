namespace DSMarket.Solucion.Pantallas.Pantallas.Caja
{
    partial class Caja
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.Monto = new System.Windows.Forms.Label();
            this.rbSacar = new System.Windows.Forms.RadioButton();
            this.rbIngresar = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.gbDatosCaja = new System.Windows.Forms.GroupBox();
            this.txtCodigoCaja = new System.Windows.Forms.TextBox();
            this.lbNombreCaja = new System.Windows.Forms.Label();
            this.lbMonto = new System.Windows.Forms.Label();
            this.lbEstatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PCerrar = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.gbDatosCaja.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtConcepto);
            this.groupBox1.Controls.Add(this.btnProcesar);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.Monto);
            this.groupBox1.Controls.Add(this.rbSacar);
            this.groupBox1.Controls.Add(this.rbIngresar);
            this.groupBox1.Location = new System.Drawing.Point(400, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 230);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Concepto";
            // 
            // txtConcepto
            // 
            this.txtConcepto.BackColor = System.Drawing.Color.White;
            this.txtConcepto.Location = new System.Drawing.Point(122, 115);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(221, 27);
            this.txtConcepto.TabIndex = 10;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Location = new System.Drawing.Point(46, 175);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(304, 36);
            this.btnProcesar.TabIndex = 5;
            this.btnProcesar.Text = "Procesar";
            this.toolTip1.SetToolTip(this.btnProcesar, "Procesar");
            this.btnProcesar.UseVisualStyleBackColor = true;
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.White;
            this.txtMonto.Location = new System.Drawing.Point(122, 81);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(221, 27);
            this.txtMonto.TabIndex = 9;
            // 
            // Monto
            // 
            this.Monto.AutoSize = true;
            this.Monto.Location = new System.Drawing.Point(31, 84);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(68, 20);
            this.Monto.TabIndex = 8;
            this.Monto.Text = "Monto *";
            // 
            // rbSacar
            // 
            this.rbSacar.AutoSize = true;
            this.rbSacar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSacar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbSacar.Location = new System.Drawing.Point(215, 32);
            this.rbSacar.Name = "rbSacar";
            this.rbSacar.Size = new System.Drawing.Size(132, 24);
            this.rbSacar.TabIndex = 1;
            this.rbSacar.TabStop = true;
            this.rbSacar.Text = "Sacar Efectivo";
            this.rbSacar.UseVisualStyleBackColor = true;
            // 
            // rbIngresar
            // 
            this.rbIngresar.AutoSize = true;
            this.rbIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbIngresar.Location = new System.Drawing.Point(17, 32);
            this.rbIngresar.Name = "rbIngresar";
            this.rbIngresar.Size = new System.Drawing.Size(154, 24);
            this.rbIngresar.TabIndex = 0;
            this.rbIngresar.TabStop = true;
            this.rbIngresar.Text = "Ingresar Efectivo";
            this.rbIngresar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(382, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Abrir / Cerrar";
            this.toolTip1.SetToolTip(this.button1, "Abrir / Cerrar Caja");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // gbDatosCaja
            // 
            this.gbDatosCaja.Controls.Add(this.txtCodigoCaja);
            this.gbDatosCaja.Controls.Add(this.lbNombreCaja);
            this.gbDatosCaja.Controls.Add(this.lbMonto);
            this.gbDatosCaja.Controls.Add(this.lbEstatus);
            this.gbDatosCaja.Controls.Add(this.label4);
            this.gbDatosCaja.Controls.Add(this.label3);
            this.gbDatosCaja.Controls.Add(this.label2);
            this.gbDatosCaja.Controls.Add(this.label1);
            this.gbDatosCaja.Location = new System.Drawing.Point(12, 45);
            this.gbDatosCaja.Name = "gbDatosCaja";
            this.gbDatosCaja.Size = new System.Drawing.Size(382, 188);
            this.gbDatosCaja.TabIndex = 6;
            this.gbDatosCaja.TabStop = false;
            this.gbDatosCaja.Text = "Abrir / Cerrar";
            // 
            // txtCodigoCaja
            // 
            this.txtCodigoCaja.BackColor = System.Drawing.Color.White;
            this.txtCodigoCaja.Enabled = false;
            this.txtCodigoCaja.Location = new System.Drawing.Point(187, 42);
            this.txtCodigoCaja.Name = "txtCodigoCaja";
            this.txtCodigoCaja.Size = new System.Drawing.Size(120, 27);
            this.txtCodigoCaja.TabIndex = 7;
            // 
            // lbNombreCaja
            // 
            this.lbNombreCaja.AutoSize = true;
            this.lbNombreCaja.Location = new System.Drawing.Point(183, 81);
            this.lbNombreCaja.Name = "lbNombreCaja";
            this.lbNombreCaja.Size = new System.Drawing.Size(68, 20);
            this.lbNombreCaja.TabIndex = 6;
            this.lbNombreCaja.Text = "Nombre";
            // 
            // lbMonto
            // 
            this.lbMonto.AutoSize = true;
            this.lbMonto.Location = new System.Drawing.Point(183, 115);
            this.lbMonto.Name = "lbMonto";
            this.lbMonto.Size = new System.Drawing.Size(109, 20);
            this.lbMonto.TabIndex = 5;
            this.lbMonto.Text = "Monto Actual";
            // 
            // lbEstatus
            // 
            this.lbEstatus.AutoSize = true;
            this.lbEstatus.Location = new System.Drawing.Point(183, 155);
            this.lbEstatus.Name = "lbEstatus";
            this.lbEstatus.Size = new System.Drawing.Size(66, 20);
            this.lbEstatus.TabIndex = 4;
            this.lbEstatus.Text = "Estatus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estatus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Caja";
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
            this.panel1.Size = new System.Drawing.Size(814, 38);
            this.panel1.TabIndex = 5;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(5, 7);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(54, 20);
            this.lbTitulo.TabIndex = 12;
            this.lbTitulo.Text = "label6";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // PCerrar
            // 
            this.PCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PCerrar.Image = global::DSMarket.Solucion.Properties.Resources.Close_Window__2_48px;
            this.PCerrar.Location = new System.Drawing.Point(772, 5);
            this.PCerrar.Name = "PCerrar";
            this.PCerrar.Size = new System.Drawing.Size(30, 30);
            this.PCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCerrar.TabIndex = 16;
            this.PCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.PCerrar, "Cerrar");
            this.PCerrar.Click += new System.EventHandler(this.PCerrar_Click);
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 296);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbDatosCaja);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Caja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.Caja_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbDatosCaja.ResumeLayout(false);
            this.gbDatosCaja.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label Monto;
        private System.Windows.Forms.RadioButton rbSacar;
        private System.Windows.Forms.RadioButton rbIngresar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbDatosCaja;
        private System.Windows.Forms.TextBox txtCodigoCaja;
        private System.Windows.Forms.Label lbNombreCaja;
        private System.Windows.Forms.Label lbMonto;
        private System.Windows.Forms.Label lbEstatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitulo;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox PCerrar;
    }
}