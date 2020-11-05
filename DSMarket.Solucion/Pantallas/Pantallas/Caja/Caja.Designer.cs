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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.Monto = new System.Windows.Forms.Label();
            this.rbSacar = new System.Windows.Forms.RadioButton();
            this.rbIngresar = new System.Windows.Forms.RadioButton();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnAbrirCerrar = new System.Windows.Forms.Button();
            this.gbDatosCaja = new System.Windows.Forms.GroupBox();
            this.lbNombreCaja = new System.Windows.Forms.Label();
            this.lbMonto = new System.Windows.Forms.Label();
            this.lbEstatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClaveSegrudiad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PCerrar = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.txtFechaHAsta = new System.Windows.Forms.DateTimePicker();
            this.txtNumeroRegistros = new System.Windows.Forms.NumericUpDown();
            this.lbNumeroRegistros = new System.Windows.Forms.Label();
            this.txtNumeroPagina = new System.Windows.Forms.NumericUpDown();
            this.lbNumeroPagina = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.gbDatosCaja.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPagina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtConcepto);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.Monto);
            this.groupBox1.Controls.Add(this.rbSacar);
            this.groupBox1.Controls.Add(this.rbIngresar);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(400, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 188);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
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
            this.Monto.Location = new System.Drawing.Point(46, 84);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(72, 21);
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
            this.rbSacar.Size = new System.Drawing.Size(140, 25);
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
            this.rbIngresar.Size = new System.Drawing.Size(158, 25);
            this.rbIngresar.TabIndex = 0;
            this.rbIngresar.TabStop = true;
            this.rbIngresar.Text = "Ingresar Efectivo";
            this.rbIngresar.UseVisualStyleBackColor = true;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesar.Enabled = false;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Location = new System.Drawing.Point(400, 239);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(399, 36);
            this.btnProcesar.TabIndex = 5;
            this.btnProcesar.Text = "Procesar";
            this.toolTip1.SetToolTip(this.btnProcesar, "Procesar");
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnAbrirCerrar
            // 
            this.btnAbrirCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirCerrar.Enabled = false;
            this.btnAbrirCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCerrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCerrar.Location = new System.Drawing.Point(12, 239);
            this.btnAbrirCerrar.Name = "btnAbrirCerrar";
            this.btnAbrirCerrar.Size = new System.Drawing.Size(382, 36);
            this.btnAbrirCerrar.TabIndex = 7;
            this.btnAbrirCerrar.Text = "Abrir / Cerrar";
            this.toolTip1.SetToolTip(this.btnAbrirCerrar, "Abrir / Cerrar Caja");
            this.btnAbrirCerrar.UseVisualStyleBackColor = true;
            this.btnAbrirCerrar.Click += new System.EventHandler(this.btnAbrirCerrar_Click);
            // 
            // gbDatosCaja
            // 
            this.gbDatosCaja.Controls.Add(this.lbNombreCaja);
            this.gbDatosCaja.Controls.Add(this.lbMonto);
            this.gbDatosCaja.Controls.Add(this.lbEstatus);
            this.gbDatosCaja.Controls.Add(this.label4);
            this.gbDatosCaja.Controls.Add(this.label3);
            this.gbDatosCaja.Controls.Add(this.label2);
            this.gbDatosCaja.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosCaja.Location = new System.Drawing.Point(12, 45);
            this.gbDatosCaja.Name = "gbDatosCaja";
            this.gbDatosCaja.Size = new System.Drawing.Size(382, 188);
            this.gbDatosCaja.TabIndex = 6;
            this.gbDatosCaja.TabStop = false;
            this.gbDatosCaja.Text = "Abrir / Cerrar";
            // 
            // lbNombreCaja
            // 
            this.lbNombreCaja.AutoSize = true;
            this.lbNombreCaja.Location = new System.Drawing.Point(183, 52);
            this.lbNombreCaja.Name = "lbNombreCaja";
            this.lbNombreCaja.Size = new System.Drawing.Size(73, 21);
            this.lbNombreCaja.TabIndex = 6;
            this.lbNombreCaja.Text = "Nombre";
            // 
            // lbMonto
            // 
            this.lbMonto.AutoSize = true;
            this.lbMonto.Location = new System.Drawing.Point(183, 86);
            this.lbMonto.Name = "lbMonto";
            this.lbMonto.Size = new System.Drawing.Size(120, 21);
            this.lbMonto.TabIndex = 5;
            this.lbMonto.Text = "Monto Actual";
            // 
            // lbEstatus
            // 
            this.lbEstatus.AutoSize = true;
            this.lbEstatus.Location = new System.Drawing.Point(183, 126);
            this.lbEstatus.Name = "lbEstatus";
            this.lbEstatus.Size = new System.Drawing.Size(66, 21);
            this.lbEstatus.TabIndex = 4;
            this.lbEstatus.Text = "Estatus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estatus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // txtClaveSegrudiad
            // 
            this.txtClaveSegrudiad.BackColor = System.Drawing.Color.White;
            this.txtClaveSegrudiad.Location = new System.Drawing.Point(181, 298);
            this.txtClaveSegrudiad.MaxLength = 20;
            this.txtClaveSegrudiad.Name = "txtClaveSegrudiad";
            this.txtClaveSegrudiad.PasswordChar = '•';
            this.txtClaveSegrudiad.Size = new System.Drawing.Size(213, 27);
            this.txtClaveSegrudiad.TabIndex = 7;
            this.txtClaveSegrudiad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveSegrudiad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave de Seguridad";
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
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(5, 7);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(54, 20);
            this.lbTitulo.TabIndex = 12;
            this.lbTitulo.Text = "label6";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(400, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Validar";
            this.toolTip1.SetToolTip(this.button2, "Validar Clave de Seguridad");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(439, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "Buscar";
            this.toolTip1.SetToolTip(this.button1, "Validar Clave de Seguridad");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(13, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(786, 211);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historial de Cierre de Caja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Desde";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Hasta";
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaDesde.Location = new System.Drawing.Point(98, 344);
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(135, 27);
            this.txtFechaDesde.TabIndex = 13;
            // 
            // txtFechaHAsta
            // 
            this.txtFechaHAsta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFechaHAsta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaHAsta.Location = new System.Drawing.Point(298, 344);
            this.txtFechaHAsta.Name = "txtFechaHAsta";
            this.txtFechaHAsta.Size = new System.Drawing.Size(135, 27);
            this.txtFechaHAsta.TabIndex = 14;
            // 
            // txtNumeroRegistros
            // 
            this.txtNumeroRegistros.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeroRegistros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumeroRegistros.Location = new System.Drawing.Point(272, 582);
            this.txtNumeroRegistros.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtNumeroRegistros.Name = "txtNumeroRegistros";
            this.txtNumeroRegistros.Size = new System.Drawing.Size(51, 27);
            this.txtNumeroRegistros.TabIndex = 88;
            this.txtNumeroRegistros.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lbNumeroRegistros
            // 
            this.lbNumeroRegistros.AutoSize = true;
            this.lbNumeroRegistros.Location = new System.Drawing.Point(165, 586);
            this.lbNumeroRegistros.Name = "lbNumeroRegistros";
            this.lbNumeroRegistros.Size = new System.Drawing.Size(103, 20);
            this.lbNumeroRegistros.TabIndex = 87;
            this.lbNumeroRegistros.Text = "No.Registros";
            // 
            // txtNumeroPagina
            // 
            this.txtNumeroPagina.BackColor = System.Drawing.Color.LightGray;
            this.txtNumeroPagina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtNumeroPagina.Location = new System.Drawing.Point(110, 584);
            this.txtNumeroPagina.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtNumeroPagina.Name = "txtNumeroPagina";
            this.txtNumeroPagina.Size = new System.Drawing.Size(51, 27);
            this.txtNumeroPagina.TabIndex = 86;
            this.txtNumeroPagina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbNumeroPagina
            // 
            this.lbNumeroPagina.AutoSize = true;
            this.lbNumeroPagina.Location = new System.Drawing.Point(19, 588);
            this.lbNumeroPagina.Name = "lbNumeroPagina";
            this.lbNumeroPagina.Size = new System.Drawing.Size(87, 20);
            this.lbNumeroPagina.TabIndex = 85;
            this.lbNumeroPagina.Text = "No.Pagina";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(780, 185);
            this.dataGridView1.TabIndex = 3;
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
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 622);
            this.Controls.Add(this.txtNumeroRegistros);
            this.Controls.Add(this.lbNumeroRegistros);
            this.Controls.Add(this.txtNumeroPagina);
            this.Controls.Add(this.lbNumeroPagina);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFechaHAsta);
            this.Controls.Add(this.txtFechaDesde);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtClaveSegrudiad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAbrirCerrar);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.gbDatosCaja);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
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
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroPagina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnAbrirCerrar;
        private System.Windows.Forms.GroupBox gbDatosCaja;
        private System.Windows.Forms.TextBox txtClaveSegrudiad;
        private System.Windows.Forms.Label lbNombreCaja;
        private System.Windows.Forms.Label lbMonto;
        private System.Windows.Forms.Label lbEstatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox PCerrar;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker txtFechaHAsta;
        private System.Windows.Forms.DateTimePicker txtFechaDesde;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown txtNumeroRegistros;
        private System.Windows.Forms.Label lbNumeroRegistros;
        private System.Windows.Forms.NumericUpDown txtNumeroPagina;
        private System.Windows.Forms.Label lbNumeroPagina;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
    }
}