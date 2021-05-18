
namespace DSMarket.Solucion.Pantallas.Pantallas.Historial
{
    partial class HistorialFacturacion
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
            this.btnAnularfactura = new System.Windows.Forms.Button();
            this.btnReporteventa = new System.Windows.Forms.Button();
            this.btnEstadisticaVenta = new System.Windows.Forms.Button();
            this.btnrestablecer = new System.Windows.Forms.Button();
            this.btnItemsAgregados = new System.Windows.Forms.Button();
            this.btnReImprimir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbGananciaVariable = new System.Windows.Forms.Label();
            this.lbGananciaTitulo = new System.Windows.Forms.Label();
            this.PCerrar = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.txtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.ddlUsuario = new System.Windows.Forms.ComboBox();
            this.txtFacturadoA = new System.Windows.Forms.TextBox();
            this.txtNumerofactura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAgregarUsuario = new System.Windows.Forms.CheckBox();
            this.cbAgregarRangoFecha = new System.Windows.Forms.CheckBox();
            this.gbListadoFacturas = new System.Windows.Forms.GroupBox();
            this.dtListado = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtNumeroRegistros = new System.Windows.Forms.NumericUpDown();
            this.lbNumeroRegistros = new System.Windows.Forms.Label();
            this.txtNumeroPagina = new System.Windows.Forms.NumericUpDown();
            this.lbNumeroPagina = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbListadoFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPagina)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnAnularfactura
            // 
            this.btnAnularfactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnularfactura.Enabled = false;
            this.btnAnularfactura.FlatAppearance.BorderSize = 0;
            this.btnAnularfactura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnularfactura.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnularfactura.Image = global::DSMarket.Solucion.Properties.Resources.Anular;
            this.btnAnularfactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnularfactura.Location = new System.Drawing.Point(883, 7);
            this.btnAnularfactura.Name = "btnAnularfactura";
            this.btnAnularfactura.Size = new System.Drawing.Size(170, 41);
            this.btnAnularfactura.TabIndex = 70;
            this.btnAnularfactura.Text = "      Anular";
            this.toolTip1.SetToolTip(this.btnAnularfactura, "Anular Factura");
            this.btnAnularfactura.UseVisualStyleBackColor = true;
            this.btnAnularfactura.Click += new System.EventHandler(this.btnAnularfactura_Click);
            // 
            // btnReporteventa
            // 
            this.btnReporteventa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReporteventa.FlatAppearance.BorderSize = 0;
            this.btnReporteventa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReporteventa.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteventa.Image = global::DSMarket.Solucion.Properties.Resources.Facturar;
            this.btnReporteventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteventa.Location = new System.Drawing.Point(707, 7);
            this.btnReporteventa.Name = "btnReporteventa";
            this.btnReporteventa.Size = new System.Drawing.Size(170, 41);
            this.btnReporteventa.TabIndex = 69;
            this.btnReporteventa.Text = "      Reporte";
            this.toolTip1.SetToolTip(this.btnReporteventa, "Reporte de Ventas");
            this.btnReporteventa.UseVisualStyleBackColor = true;
            this.btnReporteventa.Click += new System.EventHandler(this.btnReporteventa_Click);
            // 
            // btnEstadisticaVenta
            // 
            this.btnEstadisticaVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadisticaVenta.FlatAppearance.BorderSize = 0;
            this.btnEstadisticaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEstadisticaVenta.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticaVenta.Image = global::DSMarket.Solucion.Properties.Resources.Estadistica;
            this.btnEstadisticaVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadisticaVenta.Location = new System.Drawing.Point(531, 7);
            this.btnEstadisticaVenta.Name = "btnEstadisticaVenta";
            this.btnEstadisticaVenta.Size = new System.Drawing.Size(170, 41);
            this.btnEstadisticaVenta.TabIndex = 68;
            this.btnEstadisticaVenta.Text = "      Estadistica";
            this.toolTip1.SetToolTip(this.btnEstadisticaVenta, "Estadistica de Venta");
            this.btnEstadisticaVenta.UseVisualStyleBackColor = true;
            this.btnEstadisticaVenta.Click += new System.EventHandler(this.btnEstadisticaVenta_Click);
            // 
            // btnrestablecer
            // 
            this.btnrestablecer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrestablecer.FlatAppearance.BorderSize = 0;
            this.btnrestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrestablecer.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestablecer.Image = global::DSMarket.Solucion.Properties.Resources.Restablecer;
            this.btnrestablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrestablecer.Location = new System.Drawing.Point(1059, 7);
            this.btnrestablecer.Name = "btnrestablecer";
            this.btnrestablecer.Size = new System.Drawing.Size(170, 41);
            this.btnrestablecer.TabIndex = 67;
            this.btnrestablecer.Text = "      Restablecer";
            this.toolTip1.SetToolTip(this.btnrestablecer, "Restablecer Pantalla");
            this.btnrestablecer.UseVisualStyleBackColor = true;
            this.btnrestablecer.Click += new System.EventHandler(this.btnrestablecer_Click);
            // 
            // btnItemsAgregados
            // 
            this.btnItemsAgregados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemsAgregados.Enabled = false;
            this.btnItemsAgregados.FlatAppearance.BorderSize = 0;
            this.btnItemsAgregados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnItemsAgregados.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemsAgregados.Image = global::DSMarket.Solucion.Properties.Resources.Reporte;
            this.btnItemsAgregados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItemsAgregados.Location = new System.Drawing.Point(355, 7);
            this.btnItemsAgregados.Name = "btnItemsAgregados";
            this.btnItemsAgregados.Size = new System.Drawing.Size(170, 41);
            this.btnItemsAgregados.TabIndex = 66;
            this.btnItemsAgregados.Text = "      Items";
            this.toolTip1.SetToolTip(this.btnItemsAgregados, "Mostrar los Items de la factura seleccionada");
            this.btnItemsAgregados.UseVisualStyleBackColor = true;
            this.btnItemsAgregados.Click += new System.EventHandler(this.btnItemsAgregados_Click);
            // 
            // btnReImprimir
            // 
            this.btnReImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReImprimir.Enabled = false;
            this.btnReImprimir.FlatAppearance.BorderSize = 0;
            this.btnReImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReImprimir.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReImprimir.Image = global::DSMarket.Solucion.Properties.Resources.Imprimir;
            this.btnReImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReImprimir.Location = new System.Drawing.Point(179, 7);
            this.btnReImprimir.Name = "btnReImprimir";
            this.btnReImprimir.Size = new System.Drawing.Size(170, 41);
            this.btnReImprimir.TabIndex = 65;
            this.btnReImprimir.Text = "      Re-Imprimir";
            this.toolTip1.SetToolTip(this.btnReImprimir, "Reimprimir la factura seleccionada");
            this.btnReImprimir.UseVisualStyleBackColor = true;
            this.btnReImprimir.Click += new System.EventHandler(this.btnReImprimir_Click);
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
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.lbGananciaVariable);
            this.panel1.Controls.Add(this.lbGananciaTitulo);
            this.panel1.Controls.Add(this.PCerrar);
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 38);
            this.panel1.TabIndex = 102;
            // 
            // lbGananciaVariable
            // 
            this.lbGananciaVariable.AutoSize = true;
            this.lbGananciaVariable.Location = new System.Drawing.Point(676, 9);
            this.lbGananciaVariable.Name = "lbGananciaVariable";
            this.lbGananciaVariable.Size = new System.Drawing.Size(51, 20);
            this.lbGananciaVariable.TabIndex = 17;
            this.lbGananciaVariable.Text = "label6";
            this.lbGananciaVariable.Visible = false;
            // 
            // lbGananciaTitulo
            // 
            this.lbGananciaTitulo.AutoSize = true;
            this.lbGananciaTitulo.Location = new System.Drawing.Point(595, 9);
            this.lbGananciaTitulo.Name = "lbGananciaTitulo";
            this.lbGananciaTitulo.Size = new System.Drawing.Size(86, 20);
            this.lbGananciaTitulo.TabIndex = 16;
            this.lbGananciaTitulo.Text = "Ganancia: ";
            this.lbGananciaTitulo.Visible = false;
            // 
            // PCerrar
            // 
            this.PCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PCerrar.Image = global::DSMarket.Solucion.Properties.Resources.Close_Window__2_48px;
            this.PCerrar.Location = new System.Drawing.Point(1198, 5);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Linen;
            this.panel2.Controls.Add(this.btnAnularfactura);
            this.panel2.Controls.Add(this.btnReporteventa);
            this.panel2.Controls.Add(this.btnEstadisticaVenta);
            this.panel2.Controls.Add(this.btnrestablecer);
            this.panel2.Controls.Add(this.btnItemsAgregados);
            this.panel2.Controls.Add(this.btnReImprimir);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1240, 58);
            this.panel2.TabIndex = 103;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFechaHasta);
            this.groupBox1.Controls.Add(this.txtFechaDesde);
            this.groupBox1.Controls.Add(this.ddlUsuario);
            this.groupBox1.Controls.Add(this.txtFacturadoA);
            this.groupBox1.Controls.Add(this.txtNumerofactura);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbAgregarUsuario);
            this.groupBox1.Controls.Add(this.cbAgregarRangoFecha);
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1216, 124);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Historial";
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaHasta.Location = new System.Drawing.Point(467, 89);
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(118, 26);
            this.txtFechaHasta.TabIndex = 11;
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaDesde.Location = new System.Drawing.Point(153, 89);
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(118, 26);
            this.txtFechaDesde.TabIndex = 10;
            // 
            // ddlUsuario
            // 
            this.ddlUsuario.FormattingEnabled = true;
            this.ddlUsuario.Location = new System.Drawing.Point(895, 61);
            this.ddlUsuario.Name = "ddlUsuario";
            this.ddlUsuario.Size = new System.Drawing.Size(315, 28);
            this.ddlUsuario.TabIndex = 9;
            this.ddlUsuario.Visible = false;
            // 
            // txtFacturadoA
            // 
            this.txtFacturadoA.Location = new System.Drawing.Point(467, 61);
            this.txtFacturadoA.Name = "txtFacturadoA";
            this.txtFacturadoA.Size = new System.Drawing.Size(352, 26);
            this.txtFacturadoA.TabIndex = 8;
            this.txtFacturadoA.TextChanged += new System.EventHandler(this.txtFacturadoA_TextChanged);
            // 
            // txtNumerofactura
            // 
            this.txtNumerofactura.Location = new System.Drawing.Point(153, 61);
            this.txtNumerofactura.Name = "txtNumerofactura";
            this.txtNumerofactura.Size = new System.Drawing.Size(205, 26);
            this.txtNumerofactura.TabIndex = 7;
            this.txtNumerofactura.TextChanged += new System.EventHandler(this.txtNumerofactura_TextChanged);
            this.txtNumerofactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerofactura_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(828, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Facturado A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de factura";
            // 
            // cbAgregarUsuario
            // 
            this.cbAgregarUsuario.AutoSize = true;
            this.cbAgregarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbAgregarUsuario.Location = new System.Drawing.Point(219, 25);
            this.cbAgregarUsuario.Name = "cbAgregarUsuario";
            this.cbAgregarUsuario.Size = new System.Drawing.Size(139, 24);
            this.cbAgregarUsuario.TabIndex = 1;
            this.cbAgregarUsuario.Text = "Agregar usuario";
            this.cbAgregarUsuario.UseVisualStyleBackColor = true;
            this.cbAgregarUsuario.Visible = false;
            // 
            // cbAgregarRangoFecha
            // 
            this.cbAgregarRangoFecha.AutoSize = true;
            this.cbAgregarRangoFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAgregarRangoFecha.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbAgregarRangoFecha.Location = new System.Drawing.Point(7, 25);
            this.cbAgregarRangoFecha.Name = "cbAgregarRangoFecha";
            this.cbAgregarRangoFecha.Size = new System.Drawing.Size(206, 24);
            this.cbAgregarRangoFecha.TabIndex = 0;
            this.cbAgregarRangoFecha.Text = "Agregar Rango de Fecha";
            this.cbAgregarRangoFecha.UseVisualStyleBackColor = true;
            // 
            // gbListadoFacturas
            // 
            this.gbListadoFacturas.Controls.Add(this.dtListado);
            this.gbListadoFacturas.Location = new System.Drawing.Point(12, 233);
            this.gbListadoFacturas.Name = "gbListadoFacturas";
            this.gbListadoFacturas.Size = new System.Drawing.Size(1216, 347);
            this.gbListadoFacturas.TabIndex = 105;
            this.gbListadoFacturas.TabStop = false;
            this.gbListadoFacturas.Text = "Listado de facturas";
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
            this.dtListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dtListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtListado.EnableHeadersVisualStyles = false;
            this.dtListado.Location = new System.Drawing.Point(3, 22);
            this.dtListado.Name = "dtListado";
            this.dtListado.ReadOnly = true;
            this.dtListado.RowTemplate.Height = 24;
            this.dtListado.Size = new System.Drawing.Size(1210, 322);
            this.dtListado.TabIndex = 4;
            this.dtListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtListado_CellContentClick);
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
            this.Select.Width = 60;
            // 
            // txtNumeroRegistros
            // 
            this.txtNumeroRegistros.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeroRegistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumeroRegistros.Location = new System.Drawing.Point(270, 583);
            this.txtNumeroRegistros.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtNumeroRegistros.Name = "txtNumeroRegistros";
            this.txtNumeroRegistros.Size = new System.Drawing.Size(51, 26);
            this.txtNumeroRegistros.TabIndex = 112;
            this.txtNumeroRegistros.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtNumeroRegistros.ValueChanged += new System.EventHandler(this.txtNumeroRegistros_ValueChanged);
            // 
            // lbNumeroRegistros
            // 
            this.lbNumeroRegistros.AutoSize = true;
            this.lbNumeroRegistros.Location = new System.Drawing.Point(166, 586);
            this.lbNumeroRegistros.Name = "lbNumeroRegistros";
            this.lbNumeroRegistros.Size = new System.Drawing.Size(101, 20);
            this.lbNumeroRegistros.TabIndex = 111;
            this.lbNumeroRegistros.Text = "No.Registros";
            // 
            // txtNumeroPagina
            // 
            this.txtNumeroPagina.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeroPagina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumeroPagina.Location = new System.Drawing.Point(108, 583);
            this.txtNumeroPagina.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtNumeroPagina.Name = "txtNumeroPagina";
            this.txtNumeroPagina.Size = new System.Drawing.Size(51, 26);
            this.txtNumeroPagina.TabIndex = 110;
            this.txtNumeroPagina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNumeroPagina.ValueChanged += new System.EventHandler(this.txtNumeroPagina_ValueChanged);
            // 
            // lbNumeroPagina
            // 
            this.lbNumeroPagina.AutoSize = true;
            this.lbNumeroPagina.Location = new System.Drawing.Point(23, 586);
            this.lbNumeroPagina.Name = "lbNumeroPagina";
            this.lbNumeroPagina.Size = new System.Drawing.Size(82, 20);
            this.lbNumeroPagina.TabIndex = 109;
            this.lbNumeroPagina.Text = "No.Pagina";
            // 
            // HistorialFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 620);
            this.Controls.Add(this.txtNumeroRegistros);
            this.Controls.Add(this.gbListadoFacturas);
            this.Controls.Add(this.lbNumeroRegistros);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNumeroPagina);
            this.Controls.Add(this.lbNumeroPagina);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HistorialFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistorialFacturacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HistorialFacturacion_FormClosing);
            this.Load += new System.EventHandler(this.HistorialFacturacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbListadoFacturas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPagina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PCerrar;
        public System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAnularfactura;
        private System.Windows.Forms.Button btnReporteventa;
        private System.Windows.Forms.Button btnEstadisticaVenta;
        private System.Windows.Forms.Button btnrestablecer;
        private System.Windows.Forms.Button btnItemsAgregados;
        private System.Windows.Forms.Button btnReImprimir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtFechaHasta;
        private System.Windows.Forms.DateTimePicker txtFechaDesde;
        private System.Windows.Forms.ComboBox ddlUsuario;
        private System.Windows.Forms.TextBox txtFacturadoA;
        private System.Windows.Forms.TextBox txtNumerofactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbAgregarUsuario;
        private System.Windows.Forms.CheckBox cbAgregarRangoFecha;
        private System.Windows.Forms.GroupBox gbListadoFacturas;
        private System.Windows.Forms.DataGridView dtListado;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
        private System.Windows.Forms.NumericUpDown txtNumeroRegistros;
        private System.Windows.Forms.Label lbNumeroRegistros;
        private System.Windows.Forms.NumericUpDown txtNumeroPagina;
        private System.Windows.Forms.Label lbNumeroPagina;
        public System.Windows.Forms.Label lbGananciaVariable;
        public System.Windows.Forms.Label lbGananciaTitulo;
    }
}