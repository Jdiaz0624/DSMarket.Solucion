namespace DSMarket.Solucion.Pantallas.Pantallas.Inventario
{
    partial class MantenimientoProductoDefectuoso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoProductoDefectuoso));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.PCerrar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumeroSeguimiento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadIngresar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClaveSeguridad = new System.Windows.Forms.TextBox();
            this.lbCLaveSeguridad = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.ddlSeleccionarSuplidor = new System.Windows.Forms.ComboBox();
            this.ddlSeleccionarTipoSuplidor = new System.Windows.Forms.ComboBox();
            this.ddlSeleccionarModelo = new System.Windows.Forms.ComboBox();
            this.ddlSeleccionarMarca = new System.Windows.Forms.ComboBox();
            this.ddlSeleccionarUnidadMedida = new System.Windows.Forms.ComboBox();
            this.ddlSeleccionarCategoria = new System.Windows.Forms.ComboBox();
            this.ddlSeleccionarTipoProducto = new System.Windows.Forms.ComboBox();
            this.lbComentario = new System.Windows.Forms.Label();
            this.lbPrecioVenta = new System.Windows.Forms.Label();
            this.lbPrecioCOmpra = new System.Windows.Forms.Label();
            this.lbReferencia = new System.Windows.Forms.Label();
            this.lbCodigoBarra = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbSuplidor = new System.Windows.Forms.Label();
            this.lbTipoSuplidor = new System.Windows.Forms.Label();
            this.lbModelo = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbUnidadMedida = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbTipoProducto = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ddlSeleccionarCondicion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlSeleccionarCapacidad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlSeleccionarColor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.PCerrar.Location = new System.Drawing.Point(992, 5);
            this.PCerrar.Name = "PCerrar";
            this.PCerrar.Size = new System.Drawing.Size(30, 30);
            this.PCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCerrar.TabIndex = 15;
            this.PCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.PCerrar, "Cerrar");
            this.PCerrar.Click += new System.EventHandler(this.PCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.ddlSeleccionarCondicion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ddlSeleccionarCapacidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ddlSeleccionarColor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNumeroSeguimiento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCantidadIngresar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtClaveSeguridad);
            this.groupBox1.Controls.Add(this.lbCLaveSeguridad);
            this.groupBox1.Controls.Add(this.txtComentario);
            this.groupBox1.Controls.Add(this.txtPrecioVenta);
            this.groupBox1.Controls.Add(this.txtPrecioCompra);
            this.groupBox1.Controls.Add(this.txtReferencia);
            this.groupBox1.Controls.Add(this.txtCodigoBarra);
            this.groupBox1.Controls.Add(this.txtdescripcion);
            this.groupBox1.Controls.Add(this.ddlSeleccionarSuplidor);
            this.groupBox1.Controls.Add(this.ddlSeleccionarTipoSuplidor);
            this.groupBox1.Controls.Add(this.ddlSeleccionarModelo);
            this.groupBox1.Controls.Add(this.ddlSeleccionarMarca);
            this.groupBox1.Controls.Add(this.ddlSeleccionarUnidadMedida);
            this.groupBox1.Controls.Add(this.ddlSeleccionarCategoria);
            this.groupBox1.Controls.Add(this.ddlSeleccionarTipoProducto);
            this.groupBox1.Controls.Add(this.lbComentario);
            this.groupBox1.Controls.Add(this.lbPrecioVenta);
            this.groupBox1.Controls.Add(this.lbPrecioCOmpra);
            this.groupBox1.Controls.Add(this.lbReferencia);
            this.groupBox1.Controls.Add(this.lbCodigoBarra);
            this.groupBox1.Controls.Add(this.lbDescripcion);
            this.groupBox1.Controls.Add(this.lbSuplidor);
            this.groupBox1.Controls.Add(this.lbTipoSuplidor);
            this.groupBox1.Controls.Add(this.lbModelo);
            this.groupBox1.Controls.Add(this.lbMarca);
            this.groupBox1.Controls.Add(this.lbUnidadMedida);
            this.groupBox1.Controls.Add(this.lbCategoria);
            this.groupBox1.Controls.Add(this.lbTipoProducto);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1005, 457);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Producto";
            this.toolTip1.SetToolTip(this.groupBox1, "Buscar Foto del Articulo");
            // 
            // txtNumeroSeguimiento
            // 
            this.txtNumeroSeguimiento.BackColor = System.Drawing.Color.Silver;
            this.txtNumeroSeguimiento.Location = new System.Drawing.Point(696, 183);
            this.txtNumeroSeguimiento.Name = "txtNumeroSeguimiento";
            this.txtNumeroSeguimiento.Size = new System.Drawing.Size(250, 27);
            this.txtNumeroSeguimiento.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 21);
            this.label2.TabIndex = 53;
            this.label2.Text = "Numero de Seguimiento";
            // 
            // txtCantidadIngresar
            // 
            this.txtCantidadIngresar.BackColor = System.Drawing.Color.Silver;
            this.txtCantidadIngresar.Location = new System.Drawing.Point(696, 153);
            this.txtCantidadIngresar.Name = "txtCantidadIngresar";
            this.txtCantidadIngresar.Size = new System.Drawing.Size(250, 27);
            this.txtCantidadIngresar.TabIndex = 52;
            this.txtCantidadIngresar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadIngresar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 21);
            this.label1.TabIndex = 51;
            this.label1.Text = "Cantidad Ingresar *";
            // 
            // txtClaveSeguridad
            // 
            this.txtClaveSeguridad.BackColor = System.Drawing.Color.Silver;
            this.txtClaveSeguridad.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveSeguridad.Location = new System.Drawing.Point(345, 404);
            this.txtClaveSeguridad.Name = "txtClaveSeguridad";
            this.txtClaveSeguridad.PasswordChar = '•';
            this.txtClaveSeguridad.Size = new System.Drawing.Size(349, 27);
            this.txtClaveSeguridad.TabIndex = 50;
            // 
            // lbCLaveSeguridad
            // 
            this.lbCLaveSeguridad.AutoSize = true;
            this.lbCLaveSeguridad.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCLaveSeguridad.Location = new System.Drawing.Point(443, 381);
            this.lbCLaveSeguridad.Name = "lbCLaveSeguridad";
            this.lbCLaveSeguridad.Size = new System.Drawing.Size(153, 20);
            this.lbCLaveSeguridad.TabIndex = 49;
            this.lbCLaveSeguridad.Text = "Clave de Seguridad";
            // 
            // txtComentario
            // 
            this.txtComentario.BackColor = System.Drawing.Color.Silver;
            this.txtComentario.Location = new System.Drawing.Point(143, 352);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(792, 27);
            this.txtComentario.TabIndex = 47;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.Color.Silver;
            this.txtPrecioVenta.Location = new System.Drawing.Point(696, 122);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(250, 27);
            this.txtPrecioVenta.TabIndex = 29;
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadIngresar_KeyPress);
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BackColor = System.Drawing.Color.Silver;
            this.txtPrecioCompra.Location = new System.Drawing.Point(696, 90);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(250, 27);
            this.txtPrecioCompra.TabIndex = 28;
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadIngresar_KeyPress);
            // 
            // txtReferencia
            // 
            this.txtReferencia.BackColor = System.Drawing.Color.Silver;
            this.txtReferencia.Location = new System.Drawing.Point(696, 57);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(250, 27);
            this.txtReferencia.TabIndex = 27;
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.BackColor = System.Drawing.Color.Silver;
            this.txtCodigoBarra.Location = new System.Drawing.Point(696, 26);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(250, 27);
            this.txtCodigoBarra.TabIndex = 26;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.Color.Silver;
            this.txtdescripcion.Location = new System.Drawing.Point(143, 322);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(792, 27);
            this.txtdescripcion.TabIndex = 25;
            // 
            // ddlSeleccionarSuplidor
            // 
            this.ddlSeleccionarSuplidor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ddlSeleccionarSuplidor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlSeleccionarSuplidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSeleccionarSuplidor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlSeleccionarSuplidor.FormattingEnabled = true;
            this.ddlSeleccionarSuplidor.Location = new System.Drawing.Point(169, 219);
            this.ddlSeleccionarSuplidor.Name = "ddlSeleccionarSuplidor";
            this.ddlSeleccionarSuplidor.Size = new System.Drawing.Size(235, 29);
            this.ddlSeleccionarSuplidor.TabIndex = 24;
            // 
            // ddlSeleccionarTipoSuplidor
            // 
            this.ddlSeleccionarTipoSuplidor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ddlSeleccionarTipoSuplidor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlSeleccionarTipoSuplidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSeleccionarTipoSuplidor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlSeleccionarTipoSuplidor.FormattingEnabled = true;
            this.ddlSeleccionarTipoSuplidor.Location = new System.Drawing.Point(169, 187);
            this.ddlSeleccionarTipoSuplidor.Name = "ddlSeleccionarTipoSuplidor";
            this.ddlSeleccionarTipoSuplidor.Size = new System.Drawing.Size(235, 29);
            this.ddlSeleccionarTipoSuplidor.TabIndex = 23;
            this.ddlSeleccionarTipoSuplidor.SelectedIndexChanged += new System.EventHandler(this.ddlSeleccionarTipoSuplidor_SelectedIndexChanged);
            // 
            // ddlSeleccionarModelo
            // 
            this.ddlSeleccionarModelo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ddlSeleccionarModelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlSeleccionarModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSeleccionarModelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlSeleccionarModelo.FormattingEnabled = true;
            this.ddlSeleccionarModelo.Location = new System.Drawing.Point(169, 155);
            this.ddlSeleccionarModelo.Name = "ddlSeleccionarModelo";
            this.ddlSeleccionarModelo.Size = new System.Drawing.Size(235, 29);
            this.ddlSeleccionarModelo.TabIndex = 22;
            // 
            // ddlSeleccionarMarca
            // 
            this.ddlSeleccionarMarca.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ddlSeleccionarMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlSeleccionarMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSeleccionarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlSeleccionarMarca.FormattingEnabled = true;
            this.ddlSeleccionarMarca.Location = new System.Drawing.Point(169, 122);
            this.ddlSeleccionarMarca.Name = "ddlSeleccionarMarca";
            this.ddlSeleccionarMarca.Size = new System.Drawing.Size(235, 29);
            this.ddlSeleccionarMarca.TabIndex = 21;
            this.ddlSeleccionarMarca.SelectedIndexChanged += new System.EventHandler(this.ddlSeleccionarMarca_SelectedIndexChanged);
            // 
            // ddlSeleccionarUnidadMedida
            // 
            this.ddlSeleccionarUnidadMedida.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ddlSeleccionarUnidadMedida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlSeleccionarUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSeleccionarUnidadMedida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlSeleccionarUnidadMedida.FormattingEnabled = true;
            this.ddlSeleccionarUnidadMedida.Location = new System.Drawing.Point(169, 90);
            this.ddlSeleccionarUnidadMedida.Name = "ddlSeleccionarUnidadMedida";
            this.ddlSeleccionarUnidadMedida.Size = new System.Drawing.Size(235, 29);
            this.ddlSeleccionarUnidadMedida.TabIndex = 20;
            // 
            // ddlSeleccionarCategoria
            // 
            this.ddlSeleccionarCategoria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ddlSeleccionarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlSeleccionarCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSeleccionarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlSeleccionarCategoria.FormattingEnabled = true;
            this.ddlSeleccionarCategoria.Location = new System.Drawing.Point(169, 58);
            this.ddlSeleccionarCategoria.Name = "ddlSeleccionarCategoria";
            this.ddlSeleccionarCategoria.Size = new System.Drawing.Size(235, 29);
            this.ddlSeleccionarCategoria.TabIndex = 19;
            this.ddlSeleccionarCategoria.SelectedIndexChanged += new System.EventHandler(this.ddlSeleccionarCategoria_SelectedIndexChanged);
            // 
            // ddlSeleccionarTipoProducto
            // 
            this.ddlSeleccionarTipoProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ddlSeleccionarTipoProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlSeleccionarTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSeleccionarTipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlSeleccionarTipoProducto.FormattingEnabled = true;
            this.ddlSeleccionarTipoProducto.Location = new System.Drawing.Point(169, 26);
            this.ddlSeleccionarTipoProducto.Name = "ddlSeleccionarTipoProducto";
            this.ddlSeleccionarTipoProducto.Size = new System.Drawing.Size(235, 29);
            this.ddlSeleccionarTipoProducto.TabIndex = 18;
            this.ddlSeleccionarTipoProducto.SelectedIndexChanged += new System.EventHandler(this.ddlSeleccionarTipoProducto_SelectedIndexChanged);
            // 
            // lbComentario
            // 
            this.lbComentario.AutoSize = true;
            this.lbComentario.Location = new System.Drawing.Point(36, 355);
            this.lbComentario.Name = "lbComentario";
            this.lbComentario.Size = new System.Drawing.Size(104, 21);
            this.lbComentario.TabIndex = 16;
            this.lbComentario.Text = "Comentario";
            // 
            // lbPrecioVenta
            // 
            this.lbPrecioVenta.AutoSize = true;
            this.lbPrecioVenta.Location = new System.Drawing.Point(549, 125);
            this.lbPrecioVenta.Name = "lbPrecioVenta";
            this.lbPrecioVenta.Size = new System.Drawing.Size(145, 21);
            this.lbPrecioVenta.TabIndex = 11;
            this.lbPrecioVenta.Text = "Precio de Venta *";
            // 
            // lbPrecioCOmpra
            // 
            this.lbPrecioCOmpra.AutoSize = true;
            this.lbPrecioCOmpra.Location = new System.Drawing.Point(533, 93);
            this.lbPrecioCOmpra.Name = "lbPrecioCOmpra";
            this.lbPrecioCOmpra.Size = new System.Drawing.Size(161, 21);
            this.lbPrecioCOmpra.TabIndex = 10;
            this.lbPrecioCOmpra.Text = "Precio de Compra *";
            // 
            // lbReferencia
            // 
            this.lbReferencia.AutoSize = true;
            this.lbReferencia.Location = new System.Drawing.Point(599, 60);
            this.lbReferencia.Name = "lbReferencia";
            this.lbReferencia.Size = new System.Drawing.Size(94, 21);
            this.lbReferencia.TabIndex = 9;
            this.lbReferencia.Text = "Referencia";
            // 
            // lbCodigoBarra
            // 
            this.lbCodigoBarra.AutoSize = true;
            this.lbCodigoBarra.Location = new System.Drawing.Point(555, 29);
            this.lbCodigoBarra.Name = "lbCodigoBarra";
            this.lbCodigoBarra.Size = new System.Drawing.Size(138, 21);
            this.lbCodigoBarra.TabIndex = 8;
            this.lbCodigoBarra.Text = "Codigo de Barra";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(30, 325);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(110, 21);
            this.lbDescripcion.TabIndex = 7;
            this.lbDescripcion.Text = "Descripción *";
            // 
            // lbSuplidor
            // 
            this.lbSuplidor.AutoSize = true;
            this.lbSuplidor.Location = new System.Drawing.Point(83, 224);
            this.lbSuplidor.Name = "lbSuplidor";
            this.lbSuplidor.Size = new System.Drawing.Size(81, 21);
            this.lbSuplidor.TabIndex = 6;
            this.lbSuplidor.Text = "Suplidor *";
            // 
            // lbTipoSuplidor
            // 
            this.lbTipoSuplidor.AutoSize = true;
            this.lbTipoSuplidor.Location = new System.Drawing.Point(22, 192);
            this.lbTipoSuplidor.Name = "lbTipoSuplidor";
            this.lbTipoSuplidor.Size = new System.Drawing.Size(142, 21);
            this.lbTipoSuplidor.TabIndex = 5;
            this.lbTipoSuplidor.Text = "Tipo de Suplidor *";
            // 
            // lbModelo
            // 
            this.lbModelo.AutoSize = true;
            this.lbModelo.Location = new System.Drawing.Point(87, 159);
            this.lbModelo.Name = "lbModelo";
            this.lbModelo.Size = new System.Drawing.Size(79, 21);
            this.lbModelo.TabIndex = 4;
            this.lbModelo.Text = "Modelo *";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(93, 126);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(72, 21);
            this.lbMarca.TabIndex = 3;
            this.lbMarca.Text = "Marca *";
            // 
            // lbUnidadMedida
            // 
            this.lbUnidadMedida.AutoSize = true;
            this.lbUnidadMedida.Location = new System.Drawing.Point(-3, 94);
            this.lbUnidadMedida.Name = "lbUnidadMedida";
            this.lbUnidadMedida.Size = new System.Drawing.Size(167, 21);
            this.lbUnidadMedida.TabIndex = 2;
            this.lbUnidadMedida.Text = "Unidad de Medida *";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(64, 63);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(101, 21);
            this.lbCategoria.TabIndex = 1;
            this.lbCategoria.Text = "Categoria *";
            // 
            // lbTipoProducto
            // 
            this.lbTipoProducto.AutoSize = true;
            this.lbTipoProducto.Location = new System.Drawing.Point(12, 30);
            this.lbTipoProducto.Name = "lbTipoProducto";
            this.lbTipoProducto.Size = new System.Drawing.Size(153, 21);
            this.lbTipoProducto.TabIndex = 0;
            this.lbTipoProducto.Text = "Tipo de Producto *";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 10;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::DSMarket.Solucion.Properties.Resources.Guardar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(325, 509);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(406, 41);
            this.btnGuardar.TabIndex = 51;
            this.btnGuardar.Text = "Accion";
            this.toolTip1.SetToolTip(this.btnGuardar, "Completar Operación");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.panel1.Size = new System.Drawing.Size(1034, 38);
            this.panel1.TabIndex = 5;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // ddlSeleccionarCondicion
            // 
            this.ddlSeleccionarCondicion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ddlSeleccionarCondicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlSeleccionarCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSeleccionarCondicion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlSeleccionarCondicion.FormattingEnabled = true;
            this.ddlSeleccionarCondicion.Location = new System.Drawing.Point(696, 214);
            this.ddlSeleccionarCondicion.Name = "ddlSeleccionarCondicion";
            this.ddlSeleccionarCondicion.Size = new System.Drawing.Size(250, 29);
            this.ddlSeleccionarCondicion.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 70;
            this.label4.Text = "Condición *";
            // 
            // ddlSeleccionarCapacidad
            // 
            this.ddlSeleccionarCapacidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ddlSeleccionarCapacidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlSeleccionarCapacidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSeleccionarCapacidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlSeleccionarCapacidad.FormattingEnabled = true;
            this.ddlSeleccionarCapacidad.Location = new System.Drawing.Point(169, 287);
            this.ddlSeleccionarCapacidad.Name = "ddlSeleccionarCapacidad";
            this.ddlSeleccionarCapacidad.Size = new System.Drawing.Size(235, 29);
            this.ddlSeleccionarCapacidad.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 68;
            this.label3.Text = "Capacidad *";
            // 
            // ddlSeleccionarColor
            // 
            this.ddlSeleccionarColor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ddlSeleccionarColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlSeleccionarColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSeleccionarColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlSeleccionarColor.FormattingEnabled = true;
            this.ddlSeleccionarColor.Location = new System.Drawing.Point(169, 254);
            this.ddlSeleccionarColor.Name = "ddlSeleccionarColor";
            this.ddlSeleccionarColor.Size = new System.Drawing.Size(235, 29);
            this.ddlSeleccionarColor.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 66;
            this.label5.Text = "Color *";
            // 
            // MantenimientoProductoDefectuoso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MantenimientoProductoDefectuoso";
            this.Text = "MantenimientoProductoDefectuoso";
            this.Load += new System.EventHandler(this.MantenimientoProductoDefectuoso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtClaveSeguridad;
        private System.Windows.Forms.Label lbCLaveSeguridad;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.ComboBox ddlSeleccionarSuplidor;
        private System.Windows.Forms.ComboBox ddlSeleccionarTipoSuplidor;
        private System.Windows.Forms.ComboBox ddlSeleccionarModelo;
        private System.Windows.Forms.ComboBox ddlSeleccionarMarca;
        private System.Windows.Forms.ComboBox ddlSeleccionarUnidadMedida;
        private System.Windows.Forms.ComboBox ddlSeleccionarCategoria;
        private System.Windows.Forms.ComboBox ddlSeleccionarTipoProducto;
        private System.Windows.Forms.Label lbComentario;
        private System.Windows.Forms.Label lbPrecioVenta;
        private System.Windows.Forms.Label lbPrecioCOmpra;
        private System.Windows.Forms.Label lbReferencia;
        private System.Windows.Forms.Label lbCodigoBarra;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbSuplidor;
        private System.Windows.Forms.Label lbTipoSuplidor;
        private System.Windows.Forms.Label lbModelo;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbUnidadMedida;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbTipoProducto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtCantidadIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroSeguimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlSeleccionarCondicion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlSeleccionarCapacidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ddlSeleccionarColor;
        private System.Windows.Forms.Label label5;
    }
}