namespace DSMarket.Solucion.Pantallas.Pantallas.Inventario
{
    partial class AgregarQuitarProductos
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
            this.txtClaveSeguridad = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.rbSacarProducto = new System.Windows.Forms.RadioButton();
            this.rbIngresarProducto = new System.Windows.Forms.RadioButton();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTipoProductoVariable = new System.Windows.Forms.Label();
            this.lbStockMinimoVariable = new System.Windows.Forms.Label();
            this.lbStickVariable = new System.Windows.Forms.Label();
            this.lbPrecioVentaVariable = new System.Windows.Forms.Label();
            this.lbDescripcionVariable = new System.Windows.Forms.Label();
            this.lbStockMinimo = new System.Windows.Forms.Label();
            this.lbStock = new System.Windows.Forms.Label();
            this.lbPrecioVenta = new System.Windows.Forms.Label();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.lbTipoProducto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PCerrar = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbMarcaVariable = new System.Windows.Forms.Label();
            this.lbMarca = new System.Windows.Forms.Label();
            this.lbCategoriaVariable = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClaveSeguridad
            // 
            this.txtClaveSeguridad.BackColor = System.Drawing.Color.Silver;
            this.txtClaveSeguridad.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveSeguridad.Location = new System.Drawing.Point(191, 332);
            this.txtClaveSeguridad.MaxLength = 100;
            this.txtClaveSeguridad.Name = "txtClaveSeguridad";
            this.txtClaveSeguridad.PasswordChar = '•';
            this.txtClaveSeguridad.Size = new System.Drawing.Size(193, 27);
            this.txtClaveSeguridad.TabIndex = 31;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(32, 335);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(153, 20);
            this.label24.TabIndex = 30;
            this.label24.Text = "Clave de Seguridad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.rbSacarProducto);
            this.groupBox2.Controls.Add(this.rbIngresarProducto);
            this.groupBox2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 70);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Operación";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.Silver;
            this.txtCantidad.Location = new System.Drawing.Point(438, 26);
            this.txtCantidad.MaxLength = 100;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(204, 27);
            this.txtCantidad.TabIndex = 22;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(356, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 20);
            this.label18.TabIndex = 86;
            this.label18.Text = "Cantidad";
            // 
            // rbSacarProducto
            // 
            this.rbSacarProducto.AutoSize = true;
            this.rbSacarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSacarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbSacarProducto.Location = new System.Drawing.Point(177, 30);
            this.rbSacarProducto.Name = "rbSacarProducto";
            this.rbSacarProducto.Size = new System.Drawing.Size(138, 24);
            this.rbSacarProducto.TabIndex = 1;
            this.rbSacarProducto.TabStop = true;
            this.rbSacarProducto.Text = "Sacar Producto";
            this.toolTip1.SetToolTip(this.rbSacarProducto, "Sacar producto de inventario");
            this.rbSacarProducto.UseVisualStyleBackColor = true;
            this.rbSacarProducto.CheckedChanged += new System.EventHandler(this.rbSacarProducto_CheckedChanged);
            // 
            // rbIngresarProducto
            // 
            this.rbIngresarProducto.AutoSize = true;
            this.rbIngresarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbIngresarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbIngresarProducto.Location = new System.Drawing.Point(11, 30);
            this.rbIngresarProducto.Name = "rbIngresarProducto";
            this.rbIngresarProducto.Size = new System.Drawing.Size(160, 24);
            this.rbIngresarProducto.TabIndex = 0;
            this.rbIngresarProducto.TabStop = true;
            this.rbIngresarProducto.Text = "Ingresar Producto";
            this.toolTip1.SetToolTip(this.rbIngresarProducto, "Ingresar producto a inventario");
            this.rbIngresarProducto.UseVisualStyleBackColor = true;
            this.rbIngresarProducto.CheckedChanged += new System.EventHandler(this.rbIngresarProducto_CheckedChanged);
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.SystemColors.Control;
            this.btnProcesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.Image = global::DSMarket.Solucion.Properties.Resources.Completar;
            this.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesar.Location = new System.Drawing.Point(442, 323);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(231, 49);
            this.btnProcesar.TabIndex = 28;
            this.btnProcesar.Text = "Procesar";
            this.toolTip1.SetToolTip(this.btnProcesar, "Procesar Data");
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClaveSeguridad);
            this.groupBox1.Controls.Add(this.btnProcesar);
            this.groupBox1.Controls.Add(this.lbTipoProductoVariable);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.lbStockMinimoVariable);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lbStickVariable);
            this.groupBox1.Controls.Add(this.lbPrecioVentaVariable);
            this.groupBox1.Controls.Add(this.lbDescripcionVariable);
            this.groupBox1.Controls.Add(this.lbMarcaVariable);
            this.groupBox1.Controls.Add(this.lbCategoriaVariable);
            this.groupBox1.Controls.Add(this.lbStockMinimo);
            this.groupBox1.Controls.Add(this.lbStock);
            this.groupBox1.Controls.Add(this.lbPrecioVenta);
            this.groupBox1.Controls.Add(this.lbDescripcion);
            this.groupBox1.Controls.Add(this.lbMarca);
            this.groupBox1.Controls.Add(this.lbCategoria);
            this.groupBox1.Controls.Add(this.lbTipoProducto);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 387);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle del Producto Seleccionado";
            // 
            // lbTipoProductoVariable
            // 
            this.lbTipoProductoVariable.AutoSize = true;
            this.lbTipoProductoVariable.Location = new System.Drawing.Point(163, 33);
            this.lbTipoProductoVariable.Name = "lbTipoProductoVariable";
            this.lbTipoProductoVariable.Size = new System.Drawing.Size(50, 21);
            this.lbTipoProductoVariable.TabIndex = 85;
            this.lbTipoProductoVariable.Text = "Dato";
            // 
            // lbStockMinimoVariable
            // 
            this.lbStockMinimoVariable.AutoSize = true;
            this.lbStockMinimoVariable.Location = new System.Drawing.Point(163, 137);
            this.lbStockMinimoVariable.Name = "lbStockMinimoVariable";
            this.lbStockMinimoVariable.Size = new System.Drawing.Size(50, 21);
            this.lbStockMinimoVariable.TabIndex = 83;
            this.lbStockMinimoVariable.Text = "Dato";
            // 
            // lbStickVariable
            // 
            this.lbStickVariable.AutoSize = true;
            this.lbStickVariable.Location = new System.Drawing.Point(163, 114);
            this.lbStickVariable.Name = "lbStickVariable";
            this.lbStickVariable.Size = new System.Drawing.Size(50, 21);
            this.lbStickVariable.TabIndex = 82;
            this.lbStickVariable.Text = "Dato";
            // 
            // lbPrecioVentaVariable
            // 
            this.lbPrecioVentaVariable.AutoSize = true;
            this.lbPrecioVentaVariable.Location = new System.Drawing.Point(163, 94);
            this.lbPrecioVentaVariable.Name = "lbPrecioVentaVariable";
            this.lbPrecioVentaVariable.Size = new System.Drawing.Size(50, 21);
            this.lbPrecioVentaVariable.TabIndex = 81;
            this.lbPrecioVentaVariable.Text = "Dato";
            // 
            // lbDescripcionVariable
            // 
            this.lbDescripcionVariable.AutoSize = true;
            this.lbDescripcionVariable.Location = new System.Drawing.Point(164, 159);
            this.lbDescripcionVariable.Name = "lbDescripcionVariable";
            this.lbDescripcionVariable.Size = new System.Drawing.Size(50, 21);
            this.lbDescripcionVariable.TabIndex = 76;
            this.lbDescripcionVariable.Text = "Dato";
            // 
            // lbStockMinimo
            // 
            this.lbStockMinimo.AutoSize = true;
            this.lbStockMinimo.Location = new System.Drawing.Point(51, 137);
            this.lbStockMinimo.Name = "lbStockMinimo";
            this.lbStockMinimo.Size = new System.Drawing.Size(113, 21);
            this.lbStockMinimo.TabIndex = 65;
            this.lbStockMinimo.Text = "Stock Minimo";
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Location = new System.Drawing.Point(111, 115);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(53, 21);
            this.lbStock.TabIndex = 64;
            this.lbStock.Text = "Stock";
            // 
            // lbPrecioVenta
            // 
            this.lbPrecioVenta.AutoSize = true;
            this.lbPrecioVenta.Location = new System.Drawing.Point(29, 94);
            this.lbPrecioVenta.Name = "lbPrecioVenta";
            this.lbPrecioVenta.Size = new System.Drawing.Size(135, 21);
            this.lbPrecioVenta.TabIndex = 63;
            this.lbPrecioVenta.Text = "Precio de Venta";
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(64, 160);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(100, 21);
            this.lbDescripcion.TabIndex = 59;
            this.lbDescripcion.Text = "Descripción";
            // 
            // lbTipoProducto
            // 
            this.lbTipoProducto.AutoSize = true;
            this.lbTipoProducto.Location = new System.Drawing.Point(21, 33);
            this.lbTipoProducto.Name = "lbTipoProducto";
            this.lbTipoProducto.Size = new System.Drawing.Size(143, 21);
            this.lbTipoProducto.TabIndex = 52;
            this.lbTipoProducto.Text = "Tipo de Producto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.PCerrar);
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 44);
            this.panel1.TabIndex = 26;
            // 
            // PCerrar
            // 
            this.PCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PCerrar.Image = global::DSMarket.Solucion.Properties.Resources.Close_Window__2_48px;
            this.PCerrar.Location = new System.Drawing.Point(661, 10);
            this.PCerrar.Name = "PCerrar";
            this.PCerrar.Size = new System.Drawing.Size(30, 30);
            this.PCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCerrar.TabIndex = 28;
            this.PCerrar.TabStop = false;
            this.PCerrar.Click += new System.EventHandler(this.PCerrar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(19, 10);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(59, 21);
            this.lbTitulo.TabIndex = 18;
            this.lbTitulo.Text = "label6";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lbMarcaVariable
            // 
            this.lbMarcaVariable.AutoSize = true;
            this.lbMarcaVariable.Location = new System.Drawing.Point(164, 73);
            this.lbMarcaVariable.Name = "lbMarcaVariable";
            this.lbMarcaVariable.Size = new System.Drawing.Size(50, 21);
            this.lbMarcaVariable.TabIndex = 72;
            this.lbMarcaVariable.Text = "Dato";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Location = new System.Drawing.Point(103, 73);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(62, 21);
            this.lbMarca.TabIndex = 55;
            this.lbMarca.Text = "Marca";
            // 
            // lbCategoriaVariable
            // 
            this.lbCategoriaVariable.AutoSize = true;
            this.lbCategoriaVariable.Location = new System.Drawing.Point(163, 53);
            this.lbCategoriaVariable.Name = "lbCategoriaVariable";
            this.lbCategoriaVariable.Size = new System.Drawing.Size(50, 21);
            this.lbCategoriaVariable.TabIndex = 70;
            this.lbCategoriaVariable.Text = "Dato";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(73, 53);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(91, 21);
            this.lbCategoria.TabIndex = 53;
            this.lbCategoria.Text = "Categoria";
            // 
            // AgregarQuitarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarQuitarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarQuitarProductos";
            this.Load += new System.EventHandler(this.AgregarQuitarProductos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtClaveSeguridad;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSacarProducto;
        private System.Windows.Forms.RadioButton rbIngresarProducto;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbTipoProductoVariable;
        private System.Windows.Forms.Label lbStockMinimoVariable;
        private System.Windows.Forms.Label lbStickVariable;
        private System.Windows.Forms.Label lbPrecioVentaVariable;
        private System.Windows.Forms.Label lbDescripcionVariable;
        private System.Windows.Forms.Label lbStockMinimo;
        private System.Windows.Forms.Label lbStock;
        private System.Windows.Forms.Label lbPrecioVenta;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Label lbTipoProducto;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox PCerrar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbMarcaVariable;
        private System.Windows.Forms.Label lbCategoriaVariable;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.Label lbCategoria;
    }
}