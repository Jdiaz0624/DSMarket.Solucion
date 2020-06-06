namespace DSMarket.Solucion.Pantallas.Pantallas.Inventario
{
    partial class ModelosConsulta
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
            this.txtNumeroRegistros = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtListado = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbNumeroRegistros = new System.Windows.Forms.Label();
            this.txtNumeroPagina = new System.Windows.Forms.NumericUpDown();
            this.lbNumeroPagina = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModelos = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCantidadRegistrosVariable = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbCantidadRegistrosTitulo = new System.Windows.Forms.Label();
            this.ddlSeleccionarMarcas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.PCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroRegistros)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPagina)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // txtNumeroRegistros
            // 
            this.txtNumeroRegistros.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeroRegistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumeroRegistros.Location = new System.Drawing.Point(261, 500);
            this.txtNumeroRegistros.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtNumeroRegistros.Name = "txtNumeroRegistros";
            this.txtNumeroRegistros.Size = new System.Drawing.Size(51, 27);
            this.txtNumeroRegistros.TabIndex = 84;
            this.txtNumeroRegistros.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtListado);
            this.groupBox2.Location = new System.Drawing.Point(7, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1059, 282);
            this.groupBox2.TabIndex = 80;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de modelos registrados";
            // 
            // dtListado
            // 
            this.dtListado.AllowUserToAddRows = false;
            this.dtListado.AllowUserToDeleteRows = false;
            this.dtListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtListado.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtListado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dtListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtListado.Location = new System.Drawing.Point(3, 23);
            this.dtListado.Name = "dtListado";
            this.dtListado.ReadOnly = true;
            this.dtListado.RowTemplate.Height = 24;
            this.dtListado.Size = new System.Drawing.Size(1053, 256);
            this.dtListado.TabIndex = 0;
            // 
            // Select
            // 
            this.Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Text = "Select";
            this.Select.ToolTipText = "Select";
            this.Select.UseColumnTextForButtonValue = true;
            this.Select.Width = 59;
            // 
            // lbNumeroRegistros
            // 
            this.lbNumeroRegistros.AutoSize = true;
            this.lbNumeroRegistros.Location = new System.Drawing.Point(152, 501);
            this.lbNumeroRegistros.Name = "lbNumeroRegistros";
            this.lbNumeroRegistros.Size = new System.Drawing.Size(103, 20);
            this.lbNumeroRegistros.TabIndex = 83;
            this.lbNumeroRegistros.Text = "No.Registros";
            // 
            // txtNumeroPagina
            // 
            this.txtNumeroPagina.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeroPagina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumeroPagina.Location = new System.Drawing.Point(97, 497);
            this.txtNumeroPagina.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtNumeroPagina.Name = "txtNumeroPagina";
            this.txtNumeroPagina.Size = new System.Drawing.Size(51, 27);
            this.txtNumeroPagina.TabIndex = 82;
            this.txtNumeroPagina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbNumeroPagina
            // 
            this.lbNumeroPagina.AutoSize = true;
            this.lbNumeroPagina.Location = new System.Drawing.Point(6, 500);
            this.lbNumeroPagina.Name = "lbNumeroPagina";
            this.lbNumeroPagina.Size = new System.Drawing.Size(87, 20);
            this.lbNumeroPagina.TabIndex = 81;
            this.lbNumeroPagina.Text = "No.Pagina";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ddlSeleccionarMarcas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtModelos);
            this.groupBox1.Location = new System.Drawing.Point(3, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 103);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modelos - Filtros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modelos";
            // 
            // txtModelos
            // 
            this.txtModelos.BackColor = System.Drawing.Color.Silver;
            this.txtModelos.Location = new System.Drawing.Point(75, 60);
            this.txtModelos.Name = "txtModelos";
            this.txtModelos.Size = new System.Drawing.Size(284, 27);
            this.txtModelos.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.btnDeshabilitar);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1078, 58);
            this.panel2.TabIndex = 78;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.lbCantidadRegistrosVariable);
            this.panel1.Controls.Add(this.PCerrar);
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Controls.Add(this.lbCantidadRegistrosTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 38);
            this.panel1.TabIndex = 77;
            // 
            // lbCantidadRegistrosVariable
            // 
            this.lbCantidadRegistrosVariable.AutoSize = true;
            this.lbCantidadRegistrosVariable.Location = new System.Drawing.Point(607, 9);
            this.lbCantidadRegistrosVariable.Name = "lbCantidadRegistrosVariable";
            this.lbCantidadRegistrosVariable.Size = new System.Drawing.Size(18, 20);
            this.lbCantidadRegistrosVariable.TabIndex = 31;
            this.lbCantidadRegistrosVariable.Text = "0";
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
            // lbCantidadRegistrosTitulo
            // 
            this.lbCantidadRegistrosTitulo.AutoSize = true;
            this.lbCantidadRegistrosTitulo.Location = new System.Drawing.Point(429, 9);
            this.lbCantidadRegistrosTitulo.Name = "lbCantidadRegistrosTitulo";
            this.lbCantidadRegistrosTitulo.Size = new System.Drawing.Size(172, 20);
            this.lbCantidadRegistrosTitulo.TabIndex = 30;
            this.lbCantidadRegistrosTitulo.Text = "Cantidad de Registros";
            // 
            // ddlSeleccionarMarcas
            // 
            this.ddlSeleccionarMarcas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ddlSeleccionarMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlSeleccionarMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSeleccionarMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlSeleccionarMarcas.FormattingEnabled = true;
            this.ddlSeleccionarMarcas.Location = new System.Drawing.Point(75, 26);
            this.ddlSeleccionarMarcas.Name = "ddlSeleccionarMarcas";
            this.ddlSeleccionarMarcas.Size = new System.Drawing.Size(284, 28);
            this.ddlSeleccionarMarcas.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 86;
            this.label2.Text = "Marcas";
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeshabilitar.FlatAppearance.BorderSize = 0;
            this.btnDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeshabilitar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitar.Image = global::DSMarket.Solucion.Properties.Resources.Deshabilitar;
            this.btnDeshabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeshabilitar.Location = new System.Drawing.Point(531, 7);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(170, 41);
            this.btnDeshabilitar.TabIndex = 67;
            this.btnDeshabilitar.Text = "      Deshabilitar";
            this.toolTip1.SetToolTip(this.btnDeshabilitar, "Deshabilitar registro seleccionado");
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::DSMarket.Solucion.Properties.Resources.Editar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(355, 7);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(170, 41);
            this.btnEditar.TabIndex = 66;
            this.btnEditar.Text = "      Editar";
            this.toolTip1.SetToolTip(this.btnEditar, "Modificar registro seleccionado");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::DSMarket.Solucion.Properties.Resources.Agregar;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(179, 7);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(170, 41);
            this.btnNuevo.TabIndex = 65;
            this.btnNuevo.Text = "      Nuevo";
            this.toolTip1.SetToolTip(this.btnNuevo, "Crear registro nuevo");
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::DSMarket.Solucion.Properties.Resources.Zoom_icon;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(3, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(170, 41);
            this.btnBuscar.TabIndex = 64;
            this.btnBuscar.Text = "      Buscar";
            this.toolTip1.SetToolTip(this.btnBuscar, "Consultar registros");
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // PCerrar
            // 
            this.PCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PCerrar.Image = global::DSMarket.Solucion.Properties.Resources.Close_Window__2_48px;
            this.PCerrar.Location = new System.Drawing.Point(1036, 5);
            this.PCerrar.Name = "PCerrar";
            this.PCerrar.Size = new System.Drawing.Size(30, 30);
            this.PCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCerrar.TabIndex = 15;
            this.PCerrar.TabStop = false;
            this.PCerrar.Click += new System.EventHandler(this.PCerrar_Click);
            // 
            // ModelosConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 538);
            this.Controls.Add(this.txtNumeroRegistros);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbNumeroRegistros);
            this.Controls.Add(this.txtNumeroPagina);
            this.Controls.Add(this.lbNumeroPagina);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModelosConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModelosConsulta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelosConsulta_FormClosing);
            this.Load += new System.EventHandler(this.ModelosConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroRegistros)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPagina)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown txtNumeroRegistros;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtListado;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.Label lbNumeroRegistros;
        private System.Windows.Forms.NumericUpDown txtNumeroPagina;
        private System.Windows.Forms.Label lbNumeroPagina;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModelos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCantidadRegistrosVariable;
        private System.Windows.Forms.PictureBox PCerrar;
        public System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbCantidadRegistrosTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlSeleccionarMarcas;
    }
}