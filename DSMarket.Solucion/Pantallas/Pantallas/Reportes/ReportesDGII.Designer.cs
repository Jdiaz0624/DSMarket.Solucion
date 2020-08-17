namespace DSMarket.Solucion.Pantallas.Pantallas.Reportes
{
    partial class ReportesDGII
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PCerrar = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbReporte606 = new System.Windows.Forms.RadioButton();
            this.rbReporte607 = new System.Windows.Forms.RadioButton();
            this.rbReporte608 = new System.Windows.Forms.RadioButton();
            this.rbArchivotxt = new System.Windows.Forms.RadioButton();
            this.rbPorPantalla = new System.Windows.Forms.RadioButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.DateTimePicker();
            this.txtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PCerrar
            // 
            this.PCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PCerrar.Image = global::DSMarket.Solucion.Properties.Resources.Close_Window__2_48px;
            this.PCerrar.Location = new System.Drawing.Point(560, 5);
            this.PCerrar.Name = "PCerrar";
            this.PCerrar.Size = new System.Drawing.Size(30, 31);
            this.PCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCerrar.TabIndex = 15;
            this.PCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.PCerrar, "Cerrar");
            this.PCerrar.Click += new System.EventHandler(this.PCerrar_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(19, 206);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "GENERAR REPORTE";
            this.toolTip1.SetToolTip(this.button1, "Gererar los reportes de la DGII");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // rbReporte606
            // 
            this.rbReporte606.AutoSize = true;
            this.rbReporte606.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbReporte606.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbReporte606.Location = new System.Drawing.Point(18, 27);
            this.rbReporte606.Name = "rbReporte606";
            this.rbReporte606.Size = new System.Drawing.Size(149, 25);
            this.rbReporte606.TabIndex = 0;
            this.rbReporte606.TabStop = true;
            this.rbReporte606.Text = "Reporte del 606";
            this.toolTip1.SetToolTip(this.rbReporte606, "Generar Reporte del 606");
            this.rbReporte606.UseVisualStyleBackColor = true;
            // 
            // rbReporte607
            // 
            this.rbReporte607.AutoSize = true;
            this.rbReporte607.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbReporte607.Enabled = false;
            this.rbReporte607.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbReporte607.Location = new System.Drawing.Point(173, 27);
            this.rbReporte607.Name = "rbReporte607";
            this.rbReporte607.Size = new System.Drawing.Size(149, 25);
            this.rbReporte607.TabIndex = 1;
            this.rbReporte607.TabStop = true;
            this.rbReporte607.Text = "Reporte del 607";
            this.toolTip1.SetToolTip(this.rbReporte607, "Generar Reporte del 607");
            this.rbReporte607.UseVisualStyleBackColor = true;
            // 
            // rbReporte608
            // 
            this.rbReporte608.AutoSize = true;
            this.rbReporte608.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbReporte608.Enabled = false;
            this.rbReporte608.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbReporte608.Location = new System.Drawing.Point(328, 27);
            this.rbReporte608.Name = "rbReporte608";
            this.rbReporte608.Size = new System.Drawing.Size(149, 25);
            this.rbReporte608.TabIndex = 2;
            this.rbReporte608.TabStop = true;
            this.rbReporte608.Text = "Reporte del 608";
            this.toolTip1.SetToolTip(this.rbReporte608, "Generar Reporte del 608");
            this.rbReporte608.UseVisualStyleBackColor = true;
            // 
            // rbArchivotxt
            // 
            this.rbArchivotxt.AutoSize = true;
            this.rbArchivotxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbArchivotxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbArchivotxt.Location = new System.Drawing.Point(144, 27);
            this.rbArchivotxt.Name = "rbArchivotxt";
            this.rbArchivotxt.Size = new System.Drawing.Size(114, 25);
            this.rbArchivotxt.TabIndex = 1;
            this.rbArchivotxt.TabStop = true;
            this.rbArchivotxt.Text = "Archivo txt";
            this.toolTip1.SetToolTip(this.rbArchivotxt, "Generar Reporte en un archivo txt");
            this.rbArchivotxt.UseVisualStyleBackColor = true;
            // 
            // rbPorPantalla
            // 
            this.rbPorPantalla.AutoSize = true;
            this.rbPorPantalla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPorPantalla.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbPorPantalla.Location = new System.Drawing.Point(18, 27);
            this.rbPorPantalla.Name = "rbPorPantalla";
            this.rbPorPantalla.Size = new System.Drawing.Size(120, 25);
            this.rbPorPantalla.TabIndex = 0;
            this.rbPorPantalla.TabStop = true;
            this.rbPorPantalla.Text = "Por Pantalla";
            this.toolTip1.SetToolTip(this.rbPorPantalla, "Generar reporte por pantalla");
            this.rbPorPantalla.UseVisualStyleBackColor = true;
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
            this.panel1.Size = new System.Drawing.Size(602, 40);
            this.panel1.TabIndex = 11;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(15, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(57, 21);
            this.lbTitulo.TabIndex = 13;
            this.lbTitulo.Text = "label6";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbReporte608);
            this.groupBox1.Controls.Add(this.rbReporte607);
            this.groupBox1.Controls.Add(this.rbReporte606);
            this.groupBox1.Location = new System.Drawing.Point(19, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 69);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Reporye";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbArchivotxt);
            this.groupBox2.Controls.Add(this.rbPorPantalla);
            this.groupBox2.Location = new System.Drawing.Point(19, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 69);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccionar Tipo de Formato";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFechaHasta);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtFechaDesde);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtPeriodo);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(293, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 124);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seleccionar Parametros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Periodo";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtPeriodo.Location = new System.Drawing.Point(122, 27);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(132, 27);
            this.txtPeriodo.TabIndex = 1;
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaDesde.Location = new System.Drawing.Point(122, 56);
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(132, 27);
            this.txtFechaDesde.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Desde";
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaHasta.Location = new System.Drawing.Point(122, 85);
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(132, 27);
            this.txtFechaHasta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Hasta";
            // 
            // ReportesDGII
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 277);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ReportesDGII";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportesDGII";
            this.Load += new System.EventHandler(this.ReportesDGII_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PCerrar;
        public System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbArchivotxt;
        private System.Windows.Forms.RadioButton rbPorPantalla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbReporte608;
        private System.Windows.Forms.RadioButton rbReporte607;
        private System.Windows.Forms.RadioButton rbReporte606;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker txtFechaHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtFechaDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtPeriodo;
        private System.Windows.Forms.Label label1;
    }
}