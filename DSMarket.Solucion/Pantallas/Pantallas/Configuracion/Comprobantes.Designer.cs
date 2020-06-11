namespace DSMarket.Solucion.Pantallas.Pantallas.Configuracion
{
    partial class Comprobantes
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbPorDefecto = new System.Windows.Forms.CheckBox();
            this.cbEstatus = new System.Windows.Forms.CheckBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PCerrar = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gnConfiguracion = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtClaveSeguridad = new System.Windows.Forms.TextBox();
            this.txtPociciones = new System.Windows.Forms.TextBox();
            this.txtValidoHasta = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.txtSecuenciaFinal = new System.Windows.Forms.TextBox();
            this.txtSecuenciaInicial = new System.Windows.Forms.TextBox();
            this.txtSecuencial = new System.Windows.Forms.TextBox();
            this.txtTipoComprobante = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtListado = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).BeginInit();
            this.panel2.SuspendLayout();
            this.gnConfiguracion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::DSMarket.Solucion.Properties.Resources.Guardar;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(3, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(170, 41);
            this.btnBuscar.TabIndex = 64;
            this.btnBuscar.Text = "      Guardar";
            this.toolTip1.SetToolTip(this.btnBuscar, "Consultar registros");
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cbPorDefecto
            // 
            this.cbPorDefecto.AutoSize = true;
            this.cbPorDefecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPorDefecto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPorDefecto.Location = new System.Drawing.Point(276, 189);
            this.cbPorDefecto.Name = "cbPorDefecto";
            this.cbPorDefecto.Size = new System.Drawing.Size(110, 24);
            this.cbPorDefecto.TabIndex = 21;
            this.cbPorDefecto.Text = "Por Defecto";
            this.toolTip1.SetToolTip(this.cbPorDefecto, "Asignar un Comprobante por defecto");
            this.cbPorDefecto.UseVisualStyleBackColor = true;
            this.cbPorDefecto.CheckedChanged += new System.EventHandler(this.cbPorDefecto_CheckedChanged);
            // 
            // cbEstatus
            // 
            this.cbEstatus.AutoSize = true;
            this.cbEstatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEstatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEstatus.Location = new System.Drawing.Point(187, 189);
            this.cbEstatus.Name = "cbEstatus";
            this.cbEstatus.Size = new System.Drawing.Size(83, 24);
            this.cbEstatus.TabIndex = 20;
            this.cbEstatus.Text = "Estatus";
            this.toolTip1.SetToolTip(this.cbEstatus, "Estatus de Comprobante");
            this.cbEstatus.UseVisualStyleBackColor = true;
            this.cbEstatus.CheckedChanged += new System.EventHandler(this.cbEstatus_CheckedChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::DSMarket.Solucion.Properties.Resources.Restablecer;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(179, 7);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(170, 41);
            this.btnNuevo.TabIndex = 65;
            this.btnNuevo.Text = "      Restablecer";
            this.toolTip1.SetToolTip(this.btnNuevo, "Crear registro nuevo");
            this.btnNuevo.UseVisualStyleBackColor = true;
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
            this.panel1.Size = new System.Drawing.Size(1040, 38);
            this.panel1.TabIndex = 96;
            // 
            // PCerrar
            // 
            this.PCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PCerrar.Image = global::DSMarket.Solucion.Properties.Resources.Close_Window__2_48px;
            this.PCerrar.Location = new System.Drawing.Point(998, 5);
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
            this.lbTitulo.Size = new System.Drawing.Size(54, 20);
            this.lbTitulo.TabIndex = 13;
            this.lbTitulo.Text = "label6";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1040, 58);
            this.panel2.TabIndex = 97;
            // 
            // gnConfiguracion
            // 
            this.gnConfiguracion.Controls.Add(this.label10);
            this.gnConfiguracion.Controls.Add(this.cbPorDefecto);
            this.gnConfiguracion.Controls.Add(this.cbEstatus);
            this.gnConfiguracion.Controls.Add(this.txtClaveSeguridad);
            this.gnConfiguracion.Controls.Add(this.txtPociciones);
            this.gnConfiguracion.Controls.Add(this.txtValidoHasta);
            this.gnConfiguracion.Controls.Add(this.txtLimite);
            this.gnConfiguracion.Controls.Add(this.txtSecuenciaFinal);
            this.gnConfiguracion.Controls.Add(this.txtSecuenciaInicial);
            this.gnConfiguracion.Controls.Add(this.txtSecuencial);
            this.gnConfiguracion.Controls.Add(this.txtTipoComprobante);
            this.gnConfiguracion.Controls.Add(this.txtSerie);
            this.gnConfiguracion.Controls.Add(this.txtDescripcion);
            this.gnConfiguracion.Controls.Add(this.label9);
            this.gnConfiguracion.Controls.Add(this.label8);
            this.gnConfiguracion.Controls.Add(this.label7);
            this.gnConfiguracion.Controls.Add(this.label6);
            this.gnConfiguracion.Controls.Add(this.label5);
            this.gnConfiguracion.Controls.Add(this.label4);
            this.gnConfiguracion.Controls.Add(this.label3);
            this.gnConfiguracion.Controls.Add(this.label2);
            this.gnConfiguracion.Controls.Add(this.label1);
            this.gnConfiguracion.Location = new System.Drawing.Point(11, 435);
            this.gnConfiguracion.Name = "gnConfiguracion";
            this.gnConfiguracion.Size = new System.Drawing.Size(1017, 217);
            this.gnConfiguracion.TabIndex = 99;
            this.gnConfiguracion.TabStop = false;
            this.gnConfiguracion.Text = "Configuración De Comprobante";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(601, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Clave *";
            // 
            // txtClaveSeguridad
            // 
            this.txtClaveSeguridad.BackColor = System.Drawing.Color.LightGray;
            this.txtClaveSeguridad.Location = new System.Drawing.Point(669, 157);
            this.txtClaveSeguridad.Name = "txtClaveSeguridad";
            this.txtClaveSeguridad.Size = new System.Drawing.Size(336, 27);
            this.txtClaveSeguridad.TabIndex = 22;
            // 
            // txtPociciones
            // 
            this.txtPociciones.BackColor = System.Drawing.Color.LightGray;
            this.txtPociciones.Enabled = false;
            this.txtPociciones.Location = new System.Drawing.Point(669, 125);
            this.txtPociciones.Name = "txtPociciones";
            this.txtPociciones.Size = new System.Drawing.Size(336, 27);
            this.txtPociciones.TabIndex = 17;
            // 
            // txtValidoHasta
            // 
            this.txtValidoHasta.BackColor = System.Drawing.Color.LightGray;
            this.txtValidoHasta.Location = new System.Drawing.Point(669, 92);
            this.txtValidoHasta.Name = "txtValidoHasta";
            this.txtValidoHasta.Size = new System.Drawing.Size(336, 27);
            this.txtValidoHasta.TabIndex = 16;
            // 
            // txtLimite
            // 
            this.txtLimite.BackColor = System.Drawing.Color.LightGray;
            this.txtLimite.Location = new System.Drawing.Point(669, 59);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(336, 27);
            this.txtLimite.TabIndex = 15;
            // 
            // txtSecuenciaFinal
            // 
            this.txtSecuenciaFinal.BackColor = System.Drawing.Color.LightGray;
            this.txtSecuenciaFinal.Location = new System.Drawing.Point(669, 26);
            this.txtSecuenciaFinal.Name = "txtSecuenciaFinal";
            this.txtSecuenciaFinal.Size = new System.Drawing.Size(336, 27);
            this.txtSecuenciaFinal.TabIndex = 14;
            // 
            // txtSecuenciaInicial
            // 
            this.txtSecuenciaInicial.BackColor = System.Drawing.Color.LightGray;
            this.txtSecuenciaInicial.Location = new System.Drawing.Point(187, 156);
            this.txtSecuenciaInicial.Name = "txtSecuenciaInicial";
            this.txtSecuenciaInicial.Size = new System.Drawing.Size(336, 27);
            this.txtSecuenciaInicial.TabIndex = 13;
            // 
            // txtSecuencial
            // 
            this.txtSecuencial.BackColor = System.Drawing.Color.LightGray;
            this.txtSecuencial.Location = new System.Drawing.Point(187, 123);
            this.txtSecuencial.Name = "txtSecuencial";
            this.txtSecuencial.Size = new System.Drawing.Size(336, 27);
            this.txtSecuencial.TabIndex = 12;
            // 
            // txtTipoComprobante
            // 
            this.txtTipoComprobante.BackColor = System.Drawing.Color.LightGray;
            this.txtTipoComprobante.Enabled = false;
            this.txtTipoComprobante.Location = new System.Drawing.Point(187, 90);
            this.txtTipoComprobante.Name = "txtTipoComprobante";
            this.txtTipoComprobante.Size = new System.Drawing.Size(336, 27);
            this.txtTipoComprobante.TabIndex = 11;
            // 
            // txtSerie
            // 
            this.txtSerie.BackColor = System.Drawing.Color.LightGray;
            this.txtSerie.Enabled = false;
            this.txtSerie.Location = new System.Drawing.Point(187, 58);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(336, 27);
            this.txtSerie.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.LightGray;
            this.txtDescripcion.Location = new System.Drawing.Point(187, 26);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(336, 27);
            this.txtDescripcion.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(568, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Pocisiones *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(548, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Valido Hasta *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(595, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Limite *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Secuencia Final *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Secuencia Inicial *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Secuencial *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Comprobante *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Serie *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción *";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtListado);
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 329);
            this.groupBox1.TabIndex = 98;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Comprobantes";
            // 
            // dtListado
            // 
            this.dtListado.AllowUserToAddRows = false;
            this.dtListado.AllowUserToDeleteRows = false;
            this.dtListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtListado.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dtListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtListado.Location = new System.Drawing.Point(3, 23);
            this.dtListado.Name = "dtListado";
            this.dtListado.ReadOnly = true;
            this.dtListado.RowTemplate.Height = 24;
            this.dtListado.Size = new System.Drawing.Size(1010, 303);
            this.dtListado.TabIndex = 0;
            // 
            // Select
            // 
            this.Select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Text = "Select";
            this.Select.ToolTipText = "Select";
            this.Select.UseColumnTextForButtonValue = true;
            this.Select.Width = 59;
            // 
            // Comprobantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 663);
            this.Controls.Add(this.gnConfiguracion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Comprobantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprobantes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Comprobantes_FormClosing);
            this.Load += new System.EventHandler(this.Comprobantes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.gnConfiguracion.ResumeLayout(false);
            this.gnConfiguracion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PCerrar;
        public System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox gnConfiguracion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox cbPorDefecto;
        private System.Windows.Forms.CheckBox cbEstatus;
        private System.Windows.Forms.TextBox txtClaveSeguridad;
        private System.Windows.Forms.TextBox txtPociciones;
        private System.Windows.Forms.TextBox txtValidoHasta;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.TextBox txtSecuenciaFinal;
        private System.Windows.Forms.TextBox txtSecuenciaInicial;
        private System.Windows.Forms.TextBox txtSecuencial;
        private System.Windows.Forms.TextBox txtTipoComprobante;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtListado;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
    }
}