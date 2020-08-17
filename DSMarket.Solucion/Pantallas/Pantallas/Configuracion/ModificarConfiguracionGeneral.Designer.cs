namespace DSMarket.Solucion.Pantallas.Pantallas.Configuracion
{
    partial class ModificarConfiguracionGeneral
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
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PCerrar = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.txtClaveSeguridad = new System.Windows.Forms.TextBox();
            this.gbModificar = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSuma = new System.Windows.Forms.CheckBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.dtListado = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbCantidadRegistrosActivosTiirulo = new System.Windows.Forms.Label();
            this.LbCantidadRegistrosInactivosTirulo = new System.Windows.Forms.Label();
            this.LbCantidadRegistrosActivosVariable = new System.Windows.Forms.Label();
            this.LbCantidadRegistrosInactivosVariable = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).BeginInit();
            this.gbModificar.SuspendLayout();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestablecer.Enabled = false;
            this.btnRestablecer.FlatAppearance.BorderSize = 0;
            this.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestablecer.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecer.Image = global::DSMarket.Solucion.Properties.Resources.Restablecer;
            this.btnRestablecer.Location = new System.Drawing.Point(566, 43);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(42, 41);
            this.btnRestablecer.TabIndex = 112;
            this.toolTip1.SetToolTip(this.btnRestablecer, "Restablecer Pantalla");
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.BtnRestablecer_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::DSMarket.Solucion.Properties.Resources.Guardar;
            this.btnGuardar.Location = new System.Drawing.Point(832, 26);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(42, 41);
            this.btnGuardar.TabIndex = 106;
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardar");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::DSMarket.Solucion.Properties.Resources.Zoom_icon;
            this.btnNuevo.Location = new System.Drawing.Point(518, 43);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(42, 41);
            this.btnNuevo.TabIndex = 109;
            this.toolTip1.SetToolTip(this.btnNuevo, "Validar Clave de Seguridad");
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
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
            this.panel1.Size = new System.Drawing.Size(910, 38);
            this.panel1.TabIndex = 96;
            // 
            // PCerrar
            // 
            this.PCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PCerrar.Image = global::DSMarket.Solucion.Properties.Resources.Close_Window__2_48px;
            this.PCerrar.Location = new System.Drawing.Point(868, 5);
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
            this.lbTitulo.Size = new System.Drawing.Size(57, 21);
            this.lbTitulo.TabIndex = 13;
            this.lbTitulo.Text = "label6";
            // 
            // txtClaveSeguridad
            // 
            this.txtClaveSeguridad.Location = new System.Drawing.Point(163, 50);
            this.txtClaveSeguridad.MaxLength = 20;
            this.txtClaveSeguridad.Name = "txtClaveSeguridad";
            this.txtClaveSeguridad.PasswordChar = '•';
            this.txtClaveSeguridad.Size = new System.Drawing.Size(269, 27);
            this.txtClaveSeguridad.TabIndex = 107;
            // 
            // gbModificar
            // 
            this.gbModificar.Controls.Add(this.btnGuardar);
            this.gbModificar.Controls.Add(this.label2);
            this.gbModificar.Controls.Add(this.cbSuma);
            this.gbModificar.Controls.Add(this.txtDescripcion);
            this.gbModificar.Location = new System.Drawing.Point(18, 288);
            this.gbModificar.Name = "gbModificar";
            this.gbModificar.Size = new System.Drawing.Size(880, 95);
            this.gbModificar.TabIndex = 111;
            this.gbModificar.TabStop = false;
            this.gbModificar.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 106;
            this.label2.Text = "Descripción";
            // 
            // cbSuma
            // 
            this.cbSuma.AutoSize = true;
            this.cbSuma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSuma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSuma.Location = new System.Drawing.Point(108, 49);
            this.cbSuma.Name = "cbSuma";
            this.cbSuma.Size = new System.Drawing.Size(80, 25);
            this.cbSuma.TabIndex = 5;
            this.cbSuma.Text = "Activo";
            this.cbSuma.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(108, 16);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(370, 27);
            this.txtDescripcion.TabIndex = 2;
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.dtListado);
            this.gbListado.Location = new System.Drawing.Point(18, 85);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(880, 176);
            this.gbListado.TabIndex = 110;
            this.gbListado.TabStop = false;
            this.gbListado.Visible = false;
            // 
            // dtListado
            // 
            this.dtListado.AllowUserToAddRows = false;
            this.dtListado.AllowUserToDeleteRows = false;
            this.dtListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtListado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dtListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtListado.Location = new System.Drawing.Point(3, 23);
            this.dtListado.Name = "dtListado";
            this.dtListado.ReadOnly = true;
            this.dtListado.Size = new System.Drawing.Size(874, 150);
            this.dtListado.TabIndex = 0;
            this.dtListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtListado_CellContentClick);
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
            this.Select.Width = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 108;
            this.label1.Text = "Clave Seguridad";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbCantidadRegistrosActivosTiirulo
            // 
            this.lbCantidadRegistrosActivosTiirulo.AutoSize = true;
            this.lbCantidadRegistrosActivosTiirulo.Location = new System.Drawing.Point(24, 264);
            this.lbCantidadRegistrosActivosTiirulo.Name = "lbCantidadRegistrosActivosTiirulo";
            this.lbCantidadRegistrosActivosTiirulo.Size = new System.Drawing.Size(247, 21);
            this.lbCantidadRegistrosActivosTiirulo.TabIndex = 113;
            this.lbCantidadRegistrosActivosTiirulo.Text = "Cantidad de Registros Activos";
            this.lbCantidadRegistrosActivosTiirulo.Visible = false;
            // 
            // LbCantidadRegistrosInactivosTirulo
            // 
            this.LbCantidadRegistrosInactivosTirulo.AutoSize = true;
            this.LbCantidadRegistrosInactivosTirulo.Location = new System.Drawing.Point(435, 264);
            this.LbCantidadRegistrosInactivosTirulo.Name = "LbCantidadRegistrosInactivosTirulo";
            this.LbCantidadRegistrosInactivosTirulo.Size = new System.Drawing.Size(260, 21);
            this.LbCantidadRegistrosInactivosTirulo.TabIndex = 114;
            this.LbCantidadRegistrosInactivosTirulo.Text = "Cantidad de Registros Inactivos";
            this.LbCantidadRegistrosInactivosTirulo.Visible = false;
            // 
            // LbCantidadRegistrosActivosVariable
            // 
            this.LbCantidadRegistrosActivosVariable.AutoSize = true;
            this.LbCantidadRegistrosActivosVariable.Location = new System.Drawing.Point(277, 264);
            this.LbCantidadRegistrosActivosVariable.Name = "LbCantidadRegistrosActivosVariable";
            this.LbCantidadRegistrosActivosVariable.Size = new System.Drawing.Size(19, 21);
            this.LbCantidadRegistrosActivosVariable.TabIndex = 115;
            this.LbCantidadRegistrosActivosVariable.Text = "0";
            this.LbCantidadRegistrosActivosVariable.Visible = false;
            // 
            // LbCantidadRegistrosInactivosVariable
            // 
            this.LbCantidadRegistrosInactivosVariable.AutoSize = true;
            this.LbCantidadRegistrosInactivosVariable.Location = new System.Drawing.Point(701, 264);
            this.LbCantidadRegistrosInactivosVariable.Name = "LbCantidadRegistrosInactivosVariable";
            this.LbCantidadRegistrosInactivosVariable.Size = new System.Drawing.Size(19, 21);
            this.LbCantidadRegistrosInactivosVariable.TabIndex = 116;
            this.LbCantidadRegistrosInactivosVariable.Text = "0";
            this.LbCantidadRegistrosInactivosVariable.Visible = false;
            // 
            // ModificarConfiguracionGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 395);
            this.Controls.Add(this.LbCantidadRegistrosInactivosVariable);
            this.Controls.Add(this.LbCantidadRegistrosActivosVariable);
            this.Controls.Add(this.LbCantidadRegistrosInactivosTirulo);
            this.Controls.Add(this.lbCantidadRegistrosActivosTiirulo);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.txtClaveSeguridad);
            this.Controls.Add(this.gbModificar);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ModificarConfiguracionGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarConfiguracionGeneral";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificarConfiguracionGeneral_FormClosing);
            this.Load += new System.EventHandler(this.ModificarConfiguracionGeneral_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).EndInit();
            this.gbModificar.ResumeLayout(false);
            this.gbModificar.PerformLayout();
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PCerrar;
        public System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.TextBox txtClaveSeguridad;
        private System.Windows.Forms.GroupBox gbModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbSuma;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.DataGridView dtListado;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label LbCantidadRegistrosInactivosVariable;
        private System.Windows.Forms.Label LbCantidadRegistrosActivosVariable;
        private System.Windows.Forms.Label LbCantidadRegistrosInactivosTirulo;
        private System.Windows.Forms.Label lbCantidadRegistrosActivosTiirulo;
    }
}