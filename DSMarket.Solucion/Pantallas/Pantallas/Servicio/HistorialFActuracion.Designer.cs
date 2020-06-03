namespace DSMarket.Solucion.Pantallas.Pantallas.Servicio
{
    partial class HistorialFActuracion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNoagregarRangofecha = new System.Windows.Forms.CheckBox();
            this.rbTipoPago = new System.Windows.Forms.RadioButton();
            this.rbTipoFacturacion = new System.Windows.Forms.RadioButton();
            this.rbEstatus = new System.Windows.Forms.RadioButton();
            this.rbNumero = new System.Windows.Forms.RadioButton();
            this.rbGenerar = new System.Windows.Forms.RadioButton();
            this.txtNumeroRegistros = new System.Windows.Forms.NumericUpDown();
            this.lbNumeroRegistros = new System.Windows.Forms.Label();
            this.txtNumeroPagina = new System.Windows.Forms.NumericUpDown();
            this.lbNumeroPagina = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtListado = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbCantidadRegistrosTitulo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ddlSeleccionar = new System.Windows.Forms.ComboBox();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.txtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.txtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lbFechaHAsta = new System.Windows.Forms.Label();
            this.lbFechaDesde = new System.Windows.Forms.Label();
            this.lbSeleccionar = new System.Windows.Forms.Label();
            this.lbParametro = new System.Windows.Forms.Label();
            this.btnEstadistica = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.PCerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPagina)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).BeginInit();
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
            this.panel1.Controls.Add(this.lbCantidadRegistrosTitulo);
            this.panel1.Controls.Add(this.PCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 38);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.btnEstadistica);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnDeshabilitar);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1233, 58);
            this.panel2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNoagregarRangofecha);
            this.groupBox1.Controls.Add(this.rbTipoPago);
            this.groupBox1.Controls.Add(this.rbTipoFacturacion);
            this.groupBox1.Controls.Add(this.rbEstatus);
            this.groupBox1.Controls.Add(this.rbNumero);
            this.groupBox1.Controls.Add(this.rbGenerar);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1041, 72);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Tipo de Filtros";
            // 
            // cbNoagregarRangofecha
            // 
            this.cbNoagregarRangofecha.AutoSize = true;
            this.cbNoagregarRangofecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbNoagregarRangofecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbNoagregarRangofecha.Location = new System.Drawing.Point(775, 32);
            this.cbNoagregarRangofecha.Name = "cbNoagregarRangofecha";
            this.cbNoagregarRangofecha.Size = new System.Drawing.Size(231, 24);
            this.cbNoagregarRangofecha.TabIndex = 7;
            this.cbNoagregarRangofecha.Text = "No agregar Rango de Fecha";
            this.toolTip1.SetToolTip(this.cbNoagregarRangofecha, "Aregar o no agregar el rango de fecha");
            this.cbNoagregarRangofecha.UseVisualStyleBackColor = true;
            this.cbNoagregarRangofecha.CheckedChanged += new System.EventHandler(this.cbNoagregarRangofecha_CheckedChanged);
            // 
            // rbTipoPago
            // 
            this.rbTipoPago.AutoSize = true;
            this.rbTipoPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbTipoPago.Location = new System.Drawing.Point(648, 32);
            this.rbTipoPago.Name = "rbTipoPago";
            this.rbTipoPago.Size = new System.Drawing.Size(121, 24);
            this.rbTipoPago.TabIndex = 5;
            this.rbTipoPago.TabStop = true;
            this.rbTipoPago.Text = "Tipo de Pago";
            this.toolTip1.SetToolTip(this.rbTipoPago, "Mostrar el historial mediante el tipo de pago");
            this.rbTipoPago.UseVisualStyleBackColor = true;
            this.rbTipoPago.CheckedChanged += new System.EventHandler(this.rbTipoPago_CheckedChanged);
            // 
            // rbTipoFacturacion
            // 
            this.rbTipoFacturacion.AutoSize = true;
            this.rbTipoFacturacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTipoFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbTipoFacturacion.Location = new System.Drawing.Point(469, 32);
            this.rbTipoFacturacion.Name = "rbTipoFacturacion";
            this.rbTipoFacturacion.Size = new System.Drawing.Size(173, 24);
            this.rbTipoFacturacion.TabIndex = 4;
            this.rbTipoFacturacion.TabStop = true;
            this.rbTipoFacturacion.Text = "Tipo de Facturación";
            this.toolTip1.SetToolTip(this.rbTipoFacturacion, "Mostrar el historial mediante el tipo de facturación\r\n");
            this.rbTipoFacturacion.UseVisualStyleBackColor = true;
            this.rbTipoFacturacion.CheckedChanged += new System.EventHandler(this.rbTipoFacturacion_CheckedChanged);
            // 
            // rbEstatus
            // 
            this.rbEstatus.AutoSize = true;
            this.rbEstatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbEstatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbEstatus.Location = new System.Drawing.Point(380, 32);
            this.rbEstatus.Name = "rbEstatus";
            this.rbEstatus.Size = new System.Drawing.Size(83, 24);
            this.rbEstatus.TabIndex = 3;
            this.rbEstatus.TabStop = true;
            this.rbEstatus.Text = "Estatus";
            this.toolTip1.SetToolTip(this.rbEstatus, "Mostrar el historial mediante el estatus del registro\r\n");
            this.rbEstatus.UseVisualStyleBackColor = true;
            this.rbEstatus.CheckedChanged += new System.EventHandler(this.rbEstatus_CheckedChanged);
            // 
            // rbNumero
            // 
            this.rbNumero.AutoSize = true;
            this.rbNumero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbNumero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbNumero.Location = new System.Drawing.Point(113, 32);
            this.rbNumero.Name = "rbNumero";
            this.rbNumero.Size = new System.Drawing.Size(260, 24);
            this.rbNumero.TabIndex = 2;
            this.rbNumero.TabStop = true;
            this.rbNumero.Text = "Numero de Factura / Cotización";
            this.toolTip1.SetToolTip(this.rbNumero, "Mostrar el historial mediante el numero largo de factura");
            this.rbNumero.UseVisualStyleBackColor = true;
            this.rbNumero.CheckedChanged += new System.EventHandler(this.rbNumero_CheckedChanged);
            // 
            // rbGenerar
            // 
            this.rbGenerar.AutoSize = true;
            this.rbGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbGenerar.Location = new System.Drawing.Point(22, 32);
            this.rbGenerar.Name = "rbGenerar";
            this.rbGenerar.Size = new System.Drawing.Size(85, 24);
            this.rbGenerar.TabIndex = 0;
            this.rbGenerar.TabStop = true;
            this.rbGenerar.Text = "General";
            this.toolTip1.SetToolTip(this.rbGenerar, "Mostrar listado general");
            this.rbGenerar.UseVisualStyleBackColor = true;
            this.rbGenerar.CheckedChanged += new System.EventHandler(this.rbGenerar_CheckedChanged);
            // 
            // txtNumeroRegistros
            // 
            this.txtNumeroRegistros.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeroRegistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumeroRegistros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroRegistros.Location = new System.Drawing.Point(324, 597);
            this.txtNumeroRegistros.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtNumeroRegistros.Name = "txtNumeroRegistros";
            this.txtNumeroRegistros.Size = new System.Drawing.Size(51, 27);
            this.txtNumeroRegistros.TabIndex = 24;
            this.toolTip1.SetToolTip(this.txtNumeroRegistros, "Numro de registros");
            this.txtNumeroRegistros.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lbNumeroRegistros
            // 
            this.lbNumeroRegistros.AutoSize = true;
            this.lbNumeroRegistros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroRegistros.Location = new System.Drawing.Point(188, 600);
            this.lbNumeroRegistros.Name = "lbNumeroRegistros";
            this.lbNumeroRegistros.Size = new System.Drawing.Size(100, 19);
            this.lbNumeroRegistros.TabIndex = 23;
            this.lbNumeroRegistros.Text = "No.Registros";
            // 
            // txtNumeroPagina
            // 
            this.txtNumeroPagina.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeroPagina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumeroPagina.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroPagina.Location = new System.Drawing.Point(131, 597);
            this.txtNumeroPagina.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtNumeroPagina.Name = "txtNumeroPagina";
            this.txtNumeroPagina.Size = new System.Drawing.Size(51, 27);
            this.txtNumeroPagina.TabIndex = 22;
            this.toolTip1.SetToolTip(this.txtNumeroPagina, "Numero de pagina");
            this.txtNumeroPagina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbNumeroPagina
            // 
            this.lbNumeroPagina.AutoSize = true;
            this.lbNumeroPagina.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroPagina.Location = new System.Drawing.Point(15, 600);
            this.lbNumeroPagina.Name = "lbNumeroPagina";
            this.lbNumeroPagina.Size = new System.Drawing.Size(91, 19);
            this.lbNumeroPagina.TabIndex = 21;
            this.lbNumeroPagina.Text = "No.Pagina";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtListado);
            this.groupBox5.Location = new System.Drawing.Point(16, 316);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1210, 281);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            // 
            // dtListado
            // 
            this.dtListado.AllowUserToAddRows = false;
            this.dtListado.AllowUserToDeleteRows = false;
            this.dtListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtListado.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtListado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtListado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dtListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtListado.Location = new System.Drawing.Point(3, 23);
            this.dtListado.Name = "dtListado";
            this.dtListado.ReadOnly = true;
            this.dtListado.RowTemplate.Height = 24;
            this.dtListado.Size = new System.Drawing.Size(1204, 255);
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
            // lbCantidadRegistrosTitulo
            // 
            this.lbCantidadRegistrosTitulo.AutoSize = true;
            this.lbCantidadRegistrosTitulo.Location = new System.Drawing.Point(12, 9);
            this.lbCantidadRegistrosTitulo.Name = "lbCantidadRegistrosTitulo";
            this.lbCantidadRegistrosTitulo.Size = new System.Drawing.Size(188, 20);
            this.lbCantidadRegistrosTitulo.TabIndex = 32;
            this.lbCantidadRegistrosTitulo.Text = "Historial de Facturación";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ddlSeleccionar);
            this.groupBox2.Controls.Add(this.txtParametro);
            this.groupBox2.Controls.Add(this.txtFechaHasta);
            this.groupBox2.Controls.Add(this.txtFechaDesde);
            this.groupBox2.Controls.Add(this.lbFechaHAsta);
            this.groupBox2.Controls.Add(this.lbFechaDesde);
            this.groupBox2.Controls.Add(this.lbSeleccionar);
            this.groupBox2.Controls.Add(this.lbParametro);
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 135);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // ddlSeleccionar
            // 
            this.ddlSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlSeleccionar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlSeleccionar.FormattingEnabled = true;
            this.ddlSeleccionar.Location = new System.Drawing.Point(159, 87);
            this.ddlSeleccionar.Name = "ddlSeleccionar";
            this.ddlSeleccionar.Size = new System.Drawing.Size(471, 28);
            this.ddlSeleccionar.TabIndex = 7;
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(159, 56);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(471, 27);
            this.txtParametro.TabIndex = 6;
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaHasta.Location = new System.Drawing.Point(467, 25);
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(163, 27);
            this.txtFechaHasta.TabIndex = 5;
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaDesde.Location = new System.Drawing.Point(159, 25);
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(163, 27);
            this.txtFechaDesde.TabIndex = 4;
            // 
            // lbFechaHAsta
            // 
            this.lbFechaHAsta.AutoSize = true;
            this.lbFechaHAsta.Location = new System.Drawing.Point(362, 28);
            this.lbFechaHAsta.Name = "lbFechaHAsta";
            this.lbFechaHAsta.Size = new System.Drawing.Size(102, 20);
            this.lbFechaHAsta.TabIndex = 3;
            this.lbFechaHAsta.Text = "Fecha Hasta";
            // 
            // lbFechaDesde
            // 
            this.lbFechaDesde.AutoSize = true;
            this.lbFechaDesde.Location = new System.Drawing.Point(53, 28);
            this.lbFechaDesde.Name = "lbFechaDesde";
            this.lbFechaDesde.Size = new System.Drawing.Size(102, 20);
            this.lbFechaDesde.TabIndex = 2;
            this.lbFechaDesde.Text = "Fecha Desde";
            // 
            // lbSeleccionar
            // 
            this.lbSeleccionar.AutoSize = true;
            this.lbSeleccionar.Location = new System.Drawing.Point(62, 90);
            this.lbSeleccionar.Name = "lbSeleccionar";
            this.lbSeleccionar.Size = new System.Drawing.Size(93, 20);
            this.lbSeleccionar.TabIndex = 1;
            this.lbSeleccionar.Text = "Seleccionar";
            // 
            // lbParametro
            // 
            this.lbParametro.AutoSize = true;
            this.lbParametro.Location = new System.Drawing.Point(67, 59);
            this.lbParametro.Name = "lbParametro";
            this.lbParametro.Size = new System.Drawing.Size(88, 20);
            this.lbParametro.TabIndex = 0;
            this.lbParametro.Text = "Parametro";
            // 
            // btnEstadistica
            // 
            this.btnEstadistica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadistica.FlatAppearance.BorderSize = 0;
            this.btnEstadistica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEstadistica.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadistica.Image = global::DSMarket.Solucion.Properties.Resources.Estadistica;
            this.btnEstadistica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadistica.Location = new System.Drawing.Point(883, 7);
            this.btnEstadistica.Name = "btnEstadistica";
            this.btnEstadistica.Size = new System.Drawing.Size(170, 41);
            this.btnEstadistica.TabIndex = 70;
            this.btnEstadistica.Text = "      Estadistica";
            this.toolTip1.SetToolTip(this.btnEstadistica, "Generar Reporte estadistico de facturación");
            this.btnEstadistica.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::DSMarket.Solucion.Properties.Resources.Anular2;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(1056, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 41);
            this.button4.TabIndex = 69;
            this.button4.Text = "      Anular";
            this.toolTip1.SetToolTip(this.button4, "Anular factura");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::DSMarket.Solucion.Properties.Resources.Reporte;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(707, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 41);
            this.button3.TabIndex = 68;
            this.button3.Text = "      Reporte";
            this.toolTip1.SetToolTip(this.button3, "Generar Reporte de Facturación");
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeshabilitar.FlatAppearance.BorderSize = 0;
            this.btnDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeshabilitar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitar.Image = global::DSMarket.Solucion.Properties.Resources.Restablecer;
            this.btnDeshabilitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeshabilitar.Location = new System.Drawing.Point(531, 7);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(170, 41);
            this.btnDeshabilitar.TabIndex = 67;
            this.btnDeshabilitar.Text = "      Restablecer";
            this.toolTip1.SetToolTip(this.btnDeshabilitar, "Restablecer pantalla");
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::DSMarket.Solucion.Properties.Resources.Imprimir;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(355, 7);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(170, 41);
            this.btnEditar.TabIndex = 66;
            this.btnEditar.Text = "      Imprimir";
            this.toolTip1.SetToolTip(this.btnEditar, "Imprimir registro seleccionado");
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::DSMarket.Solucion.Properties.Resources.Facturar;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(179, 7);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(170, 41);
            this.btnNuevo.TabIndex = 65;
            this.btnNuevo.Text = "      Facturar";
            this.toolTip1.SetToolTip(this.btnNuevo, "Facturar cotización seleccionada");
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
            this.toolTip1.SetToolTip(this.btnBuscar, "Consultar Registros");
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // PCerrar
            // 
            this.PCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PCerrar.Image = global::DSMarket.Solucion.Properties.Resources.Close_Window__2_48px;
            this.PCerrar.Location = new System.Drawing.Point(1189, 5);
            this.PCerrar.Margin = new System.Windows.Forms.Padding(5);
            this.PCerrar.Name = "PCerrar";
            this.PCerrar.Size = new System.Drawing.Size(30, 30);
            this.PCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCerrar.TabIndex = 15;
            this.PCerrar.TabStop = false;
            // 
            // HistorialFActuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1233, 636);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtNumeroRegistros);
            this.Controls.Add(this.lbNumeroRegistros);
            this.Controls.Add(this.txtNumeroPagina);
            this.Controls.Add(this.lbNumeroPagina);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HistorialFActuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistorialFActuracion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HistorialFActuracion_FormClosing);
            this.Load += new System.EventHandler(this.HistorialFActuracion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPagina)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbNoagregarRangofecha;
        private System.Windows.Forms.RadioButton rbTipoPago;
        private System.Windows.Forms.RadioButton rbTipoFacturacion;
        private System.Windows.Forms.RadioButton rbEstatus;
        private System.Windows.Forms.RadioButton rbNumero;
        private System.Windows.Forms.RadioButton rbGenerar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ddlSeleccionar;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.DateTimePicker txtFechaHasta;
        private System.Windows.Forms.DateTimePicker txtFechaDesde;
        private System.Windows.Forms.Label lbFechaHAsta;
        private System.Windows.Forms.Label lbFechaDesde;
        private System.Windows.Forms.Label lbSeleccionar;
        private System.Windows.Forms.Label lbParametro;
        private System.Windows.Forms.NumericUpDown txtNumeroRegistros;
        private System.Windows.Forms.Label lbNumeroRegistros;
        private System.Windows.Forms.NumericUpDown txtNumeroPagina;
        private System.Windows.Forms.Label lbNumeroPagina;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtListado;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.Button btnEstadistica;
        private System.Windows.Forms.Label lbCantidadRegistrosTitulo;
    }
}