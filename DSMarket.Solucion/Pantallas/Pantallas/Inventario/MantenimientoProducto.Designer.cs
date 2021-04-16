namespace DSMarket.Solucion.Pantallas.Pantallas.Inventario
{
    partial class MantenimientoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoProducto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PCerrar = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAplicaParaImpuesto = new System.Windows.Forms.CheckBox();
            this.cbLlevagarantia = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.ddlMarca = new System.Windows.Forms.ComboBox();
            this.ddlCategoria = new System.Windows.Forms.ComboBox();
            this.ddlTipoProducto = new System.Windows.Forms.ComboBox();
            this.ddlTipoSuplidor = new System.Windows.Forms.ComboBox();
            this.ddlSuplidor = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtcodigobarra = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.txtNumeroSeguimiento = new System.Windows.Forms.TextBox();
            this.txtCodigoproducto = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtstockminimo = new System.Windows.Forms.TextBox();
            this.txtUnidadMedinda = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.ddlTipoGarantia = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtTiempoGarantia = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.PCerrar);
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 38);
            this.panel1.TabIndex = 3;
            // 
            // PCerrar
            // 
            this.PCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PCerrar.Image = global::DSMarket.Solucion.Properties.Resources.Close_Window__2_48px;
            this.PCerrar.Location = new System.Drawing.Point(1302, 5);
            this.PCerrar.Name = "PCerrar";
            this.PCerrar.Size = new System.Drawing.Size(30, 30);
            this.PCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCerrar.TabIndex = 15;
            this.PCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.PCerrar, "Cerrar");
            this.PCerrar.Click += new System.EventHandler(this.PCerrar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(15, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(54, 20);
            this.lbTitulo.TabIndex = 13;
            this.lbTitulo.Text = "label6";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTiempoGarantia);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.ddlTipoGarantia);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtComentario);
            this.groupBox1.Controls.Add(this.txtCapacidad);
            this.groupBox1.Controls.Add(this.txtCondicion);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.txtUnidadMedinda);
            this.groupBox1.Controls.Add(this.txtstockminimo);
            this.groupBox1.Controls.Add(this.txtstock);
            this.groupBox1.Controls.Add(this.txtPrecioVenta);
            this.groupBox1.Controls.Add(this.txtPrecioCompra);
            this.groupBox1.Controls.Add(this.txtCodigoproducto);
            this.groupBox1.Controls.Add(this.txtNumeroSeguimiento);
            this.groupBox1.Controls.Add(this.txtReferencia);
            this.groupBox1.Controls.Add(this.txtcodigobarra);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.ddlSuplidor);
            this.groupBox1.Controls.Add(this.ddlTipoSuplidor);
            this.groupBox1.Controls.Add(this.ddlMarca);
            this.groupBox1.Controls.Add(this.ddlCategoria);
            this.groupBox1.Controls.Add(this.ddlTipoProducto);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbLlevagarantia);
            this.groupBox1.Controls.Add(this.cbAplicaParaImpuesto);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1291, 311);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Item";
            // 
            // cbAplicaParaImpuesto
            // 
            this.cbAplicaParaImpuesto.AutoSize = true;
            this.cbAplicaParaImpuesto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAplicaParaImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbAplicaParaImpuesto.Location = new System.Drawing.Point(15, 26);
            this.cbAplicaParaImpuesto.Name = "cbAplicaParaImpuesto";
            this.cbAplicaParaImpuesto.Size = new System.Drawing.Size(184, 24);
            this.cbAplicaParaImpuesto.TabIndex = 0;
            this.cbAplicaParaImpuesto.Text = "Aplica para Impuesto";
            this.cbAplicaParaImpuesto.UseVisualStyleBackColor = true;
            // 
            // cbLlevagarantia
            // 
            this.cbLlevagarantia.AutoSize = true;
            this.cbLlevagarantia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLlevagarantia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbLlevagarantia.Location = new System.Drawing.Point(207, 26);
            this.cbLlevagarantia.Name = "cbLlevagarantia";
            this.cbLlevagarantia.Size = new System.Drawing.Size(139, 24);
            this.cbLlevagarantia.TabIndex = 1;
            this.cbLlevagarantia.Text = "Lleva Garantia";
            this.cbLlevagarantia.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Producto *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoria *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(912, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marca *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo de Suplidor *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Suplidor *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(875, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Descripción *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Codigo de Barra";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(492, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Referencia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(850, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "No. Seguimiento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Codigo de Producto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(70, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Comentario";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(79, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Capacidad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(898, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 20);
            this.label13.TabIndex = 19;
            this.label13.Text = "Condición";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(531, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 20);
            this.label14.TabIndex = 18;
            this.label14.Text = "Color";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(104, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 20);
            this.label15.TabIndex = 17;
            this.label15.Text = "Modelo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(837, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(144, 20);
            this.label16.TabIndex = 16;
            this.label16.Text = "Unidad de Medida";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(458, 189);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(122, 20);
            this.label17.TabIndex = 15;
            this.label17.Text = "Stock Minimo *";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(105, 188);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 20);
            this.label18.TabIndex = 14;
            this.label18.Text = "Stock *";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(844, 160);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(137, 20);
            this.label19.TabIndex = 13;
            this.label19.Text = "Precio de Venta *";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(429, 158);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(151, 20);
            this.label20.TabIndex = 12;
            this.label20.Text = "Precio de Compra *";
            // 
            // ddlMarca
            // 
            this.ddlMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlMarca.FormattingEnabled = true;
            this.ddlMarca.Location = new System.Drawing.Point(984, 62);
            this.ddlMarca.Name = "ddlMarca";
            this.ddlMarca.Size = new System.Drawing.Size(251, 28);
            this.ddlMarca.TabIndex = 24;
            // 
            // ddlCategoria
            // 
            this.ddlCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlCategoria.FormattingEnabled = true;
            this.ddlCategoria.Location = new System.Drawing.Point(583, 60);
            this.ddlCategoria.Name = "ddlCategoria";
            this.ddlCategoria.Size = new System.Drawing.Size(251, 28);
            this.ddlCategoria.TabIndex = 23;
            this.ddlCategoria.SelectedIndexChanged += new System.EventHandler(this.ddlCategoria_SelectedIndexChanged);
            // 
            // ddlTipoProducto
            // 
            this.ddlTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlTipoProducto.FormattingEnabled = true;
            this.ddlTipoProducto.Location = new System.Drawing.Point(169, 60);
            this.ddlTipoProducto.Name = "ddlTipoProducto";
            this.ddlTipoProducto.Size = new System.Drawing.Size(251, 28);
            this.ddlTipoProducto.TabIndex = 22;
            this.ddlTipoProducto.SelectedIndexChanged += new System.EventHandler(this.ddlTipoProducto_SelectedIndexChanged);
            // 
            // ddlTipoSuplidor
            // 
            this.ddlTipoSuplidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTipoSuplidor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlTipoSuplidor.FormattingEnabled = true;
            this.ddlTipoSuplidor.Location = new System.Drawing.Point(169, 94);
            this.ddlTipoSuplidor.Name = "ddlTipoSuplidor";
            this.ddlTipoSuplidor.Size = new System.Drawing.Size(251, 28);
            this.ddlTipoSuplidor.TabIndex = 25;
            this.ddlTipoSuplidor.SelectedIndexChanged += new System.EventHandler(this.ddlTipoSuplidor_SelectedIndexChanged);
            // 
            // ddlSuplidor
            // 
            this.ddlSuplidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSuplidor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlSuplidor.FormattingEnabled = true;
            this.ddlSuplidor.Location = new System.Drawing.Point(583, 92);
            this.ddlSuplidor.Name = "ddlSuplidor";
            this.ddlSuplidor.Size = new System.Drawing.Size(251, 28);
            this.ddlSuplidor.TabIndex = 26;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(984, 95);
            this.txtDescripcion.MaxLength = 200;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(251, 27);
            this.txtDescripcion.TabIndex = 27;
            // 
            // txtcodigobarra
            // 
            this.txtcodigobarra.Location = new System.Drawing.Point(169, 126);
            this.txtcodigobarra.MaxLength = 50;
            this.txtcodigobarra.Name = "txtcodigobarra";
            this.txtcodigobarra.Size = new System.Drawing.Size(251, 27);
            this.txtcodigobarra.TabIndex = 28;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(583, 126);
            this.txtReferencia.MaxLength = 50;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(251, 27);
            this.txtReferencia.TabIndex = 29;
            // 
            // txtNumeroSeguimiento
            // 
            this.txtNumeroSeguimiento.Location = new System.Drawing.Point(984, 126);
            this.txtNumeroSeguimiento.MaxLength = 50;
            this.txtNumeroSeguimiento.Name = "txtNumeroSeguimiento";
            this.txtNumeroSeguimiento.Size = new System.Drawing.Size(251, 27);
            this.txtNumeroSeguimiento.TabIndex = 30;
            // 
            // txtCodigoproducto
            // 
            this.txtCodigoproducto.Location = new System.Drawing.Point(169, 156);
            this.txtCodigoproducto.MaxLength = 50;
            this.txtCodigoproducto.Name = "txtCodigoproducto";
            this.txtCodigoproducto.Size = new System.Drawing.Size(251, 27);
            this.txtCodigoproducto.TabIndex = 31;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(583, 155);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(251, 27);
            this.txtPrecioCompra.TabIndex = 32;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(984, 156);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(251, 27);
            this.txtPrecioVenta.TabIndex = 33;
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(169, 185);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(251, 27);
            this.txtstock.TabIndex = 34;
            // 
            // txtstockminimo
            // 
            this.txtstockminimo.Location = new System.Drawing.Point(583, 185);
            this.txtstockminimo.Name = "txtstockminimo";
            this.txtstockminimo.Size = new System.Drawing.Size(251, 27);
            this.txtstockminimo.TabIndex = 35;
            // 
            // txtUnidadMedinda
            // 
            this.txtUnidadMedinda.Location = new System.Drawing.Point(984, 186);
            this.txtUnidadMedinda.MaxLength = 100;
            this.txtUnidadMedinda.Name = "txtUnidadMedinda";
            this.txtUnidadMedinda.Size = new System.Drawing.Size(251, 27);
            this.txtUnidadMedinda.TabIndex = 36;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(169, 215);
            this.txtModelo.MaxLength = 100;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(251, 27);
            this.txtModelo.TabIndex = 37;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(583, 215);
            this.txtColor.MaxLength = 100;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(251, 27);
            this.txtColor.TabIndex = 38;
            // 
            // txtCondicion
            // 
            this.txtCondicion.Location = new System.Drawing.Point(984, 215);
            this.txtCondicion.MaxLength = 100;
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.Size = new System.Drawing.Size(251, 27);
            this.txtCondicion.TabIndex = 39;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(169, 245);
            this.txtCapacidad.MaxLength = 100;
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(251, 27);
            this.txtCapacidad.TabIndex = 40;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(169, 275);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(1066, 27);
            this.txtComentario.TabIndex = 41;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 10;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::DSMarket.Solucion.Properties.Resources.Guardar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(473, 362);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(406, 41);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Accion";
            this.toolTip1.SetToolTip(this.btnGuardar, "Completar Operación");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ddlTipoGarantia
            // 
            this.ddlTipoGarantia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTipoGarantia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlTipoGarantia.FormattingEnabled = true;
            this.ddlTipoGarantia.Location = new System.Drawing.Point(584, 245);
            this.ddlTipoGarantia.Name = "ddlTipoGarantia";
            this.ddlTipoGarantia.Size = new System.Drawing.Size(251, 28);
            this.ddlTipoGarantia.TabIndex = 43;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(450, 249);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(131, 20);
            this.label21.TabIndex = 42;
            this.label21.Text = "Tipo de garantia";
            // 
            // txtTiempoGarantia
            // 
            this.txtTiempoGarantia.Location = new System.Drawing.Point(984, 244);
            this.txtTiempoGarantia.MaxLength = 100;
            this.txtTiempoGarantia.Name = "txtTiempoGarantia";
            this.txtTiempoGarantia.Size = new System.Drawing.Size(251, 27);
            this.txtTiempoGarantia.TabIndex = 45;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(917, 248);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(64, 20);
            this.label22.TabIndex = 44;
            this.label22.Text = "Tiempo";
            // 
            // MantenimientoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 414);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MantenimientoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenimientoProducto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MantenimientoProducto_FormClosing);
            this.Load += new System.EventHandler(this.MantenimientoProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PCerrar;
        public System.Windows.Forms.Label lbTitulo;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbLlevagarantia;
        private System.Windows.Forms.CheckBox cbAplicaParaImpuesto;
        private System.Windows.Forms.ComboBox ddlSuplidor;
        private System.Windows.Forms.ComboBox ddlTipoSuplidor;
        private System.Windows.Forms.ComboBox ddlMarca;
        private System.Windows.Forms.ComboBox ddlCategoria;
        private System.Windows.Forms.ComboBox ddlTipoProducto;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtCondicion;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtUnidadMedinda;
        private System.Windows.Forms.TextBox txtstockminimo;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtCodigoproducto;
        private System.Windows.Forms.TextBox txtNumeroSeguimiento;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.TextBox txtcodigobarra;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtTiempoGarantia;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox ddlTipoGarantia;
        private System.Windows.Forms.Label label21;
    }
}