namespace DSMarket.Solucion.Pantallas.SubMenus
{
    partial class Inventario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbIdUsuario = new System.Windows.Forms.Label();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnMArcas = new System.Windows.Forms.Button();
            this.btnUnidaMedida = new System.Windows.Forms.Button();
            this.btnMonedas = new System.Windows.Forms.Button();
            this.btnTipoProducto = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.PCerrar = new System.Windows.Forms.PictureBox();
            this.btnTipoSuplidores = new System.Windows.Forms.Button();
            this.btnSuplidores = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.gbOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Controls.Add(this.PCerrar);
            this.panel1.Controls.Add(this.lbIdUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 44);
            this.panel1.TabIndex = 17;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(15, 10);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(54, 20);
            this.lbTitulo.TabIndex = 16;
            this.lbTitulo.Text = "label6";
            // 
            // lbIdUsuario
            // 
            this.lbIdUsuario.AutoSize = true;
            this.lbIdUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbIdUsuario.Location = new System.Drawing.Point(496, 10);
            this.lbIdUsuario.Name = "lbIdUsuario";
            this.lbIdUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbIdUsuario.TabIndex = 9;
            this.lbIdUsuario.Text = "label1";
            this.lbIdUsuario.Visible = false;
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.btnSuplidores);
            this.gbOpciones.Controls.Add(this.btnTipoSuplidores);
            this.gbOpciones.Controls.Add(this.btnCategoria);
            this.gbOpciones.Controls.Add(this.btnMArcas);
            this.gbOpciones.Controls.Add(this.btnUnidaMedida);
            this.gbOpciones.Controls.Add(this.btnMonedas);
            this.gbOpciones.Controls.Add(this.btnTipoProducto);
            this.gbOpciones.Controls.Add(this.btnProductos);
            this.gbOpciones.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpciones.Location = new System.Drawing.Point(12, 50);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(957, 184);
            this.gbOpciones.TabIndex = 16;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Inventario - Seleccionar Opcion";
            // 
            // btnCategoria
            // 
            this.btnCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.Location = new System.Drawing.Point(478, 29);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(230, 68);
            this.btnCategoria.TabIndex = 5;
            this.btnCategoria.Text = "Categoria";
            this.toolTip1.SetToolTip(this.btnCategoria, "Mantenimiento de Categorias");
            this.btnCategoria.UseVisualStyleBackColor = true;
            // 
            // btnMArcas
            // 
            this.btnMArcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMArcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMArcas.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMArcas.Location = new System.Drawing.Point(242, 103);
            this.btnMArcas.Name = "btnMArcas";
            this.btnMArcas.Size = new System.Drawing.Size(230, 68);
            this.btnMArcas.TabIndex = 4;
            this.btnMArcas.Text = "Marcas";
            this.toolTip1.SetToolTip(this.btnMArcas, "Mantenimiento de marcas");
            this.btnMArcas.UseVisualStyleBackColor = true;
            // 
            // btnUnidaMedida
            // 
            this.btnUnidaMedida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnidaMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnidaMedida.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnidaMedida.Location = new System.Drawing.Point(6, 103);
            this.btnUnidaMedida.Name = "btnUnidaMedida";
            this.btnUnidaMedida.Size = new System.Drawing.Size(230, 68);
            this.btnUnidaMedida.TabIndex = 3;
            this.btnUnidaMedida.Text = "Unidad de Medida";
            this.toolTip1.SetToolTip(this.btnUnidaMedida, "Mantenimiento de unidad de medida");
            this.btnUnidaMedida.UseVisualStyleBackColor = true;
            // 
            // btnMonedas
            // 
            this.btnMonedas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonedas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonedas.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonedas.Location = new System.Drawing.Point(478, 103);
            this.btnMonedas.Name = "btnMonedas";
            this.btnMonedas.Size = new System.Drawing.Size(230, 68);
            this.btnMonedas.TabIndex = 2;
            this.btnMonedas.Text = "Modelos";
            this.toolTip1.SetToolTip(this.btnMonedas, "Mantenimeinto de modelos");
            this.btnMonedas.UseVisualStyleBackColor = true;
            this.btnMonedas.Visible = false;
            // 
            // btnTipoProducto
            // 
            this.btnTipoProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoProducto.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoProducto.Location = new System.Drawing.Point(242, 29);
            this.btnTipoProducto.Name = "btnTipoProducto";
            this.btnTipoProducto.Size = new System.Drawing.Size(230, 68);
            this.btnTipoProducto.TabIndex = 1;
            this.btnTipoProducto.Text = "Tipo de Producto";
            this.toolTip1.SetToolTip(this.btnTipoProducto, "Mantenimiento de tipo de producto");
            this.btnTipoProducto.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Location = new System.Drawing.Point(6, 29);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(230, 68);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "Producto / Inventario";
            this.toolTip1.SetToolTip(this.btnProductos, "Inventario");
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // PCerrar
            // 
            this.PCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PCerrar.Image = global::DSMarket.Solucion.Properties.Resources.Close_Window__2_48px;
            this.PCerrar.Location = new System.Drawing.Point(937, 10);
            this.PCerrar.Name = "PCerrar";
            this.PCerrar.Size = new System.Drawing.Size(30, 30);
            this.PCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCerrar.TabIndex = 15;
            this.PCerrar.TabStop = false;
            this.PCerrar.Click += new System.EventHandler(this.PCerrar_Click);
            // 
            // btnTipoSuplidores
            // 
            this.btnTipoSuplidores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTipoSuplidores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoSuplidores.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoSuplidores.Location = new System.Drawing.Point(714, 29);
            this.btnTipoSuplidores.Name = "btnTipoSuplidores";
            this.btnTipoSuplidores.Size = new System.Drawing.Size(230, 68);
            this.btnTipoSuplidores.TabIndex = 6;
            this.btnTipoSuplidores.Text = "Tipo de Suplidores";
            this.toolTip1.SetToolTip(this.btnTipoSuplidores, "Mantenimiento de tipo de suplidores");
            this.btnTipoSuplidores.UseVisualStyleBackColor = true;
            this.btnTipoSuplidores.Visible = false;
            // 
            // btnSuplidores
            // 
            this.btnSuplidores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuplidores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuplidores.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuplidores.Location = new System.Drawing.Point(714, 103);
            this.btnSuplidores.Name = "btnSuplidores";
            this.btnSuplidores.Size = new System.Drawing.Size(230, 68);
            this.btnSuplidores.TabIndex = 7;
            this.btnSuplidores.Text = "Suplidores";
            this.toolTip1.SetToolTip(this.btnSuplidores, "Mantenimiento de suplidores");
            this.btnSuplidores.UseVisualStyleBackColor = true;
            this.btnSuplidores.Visible = false;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 246);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbIdUsuario;
        public System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnMArcas;
        private System.Windows.Forms.Button btnUnidaMedida;
        private System.Windows.Forms.Button btnMonedas;
        private System.Windows.Forms.Button btnTipoProducto;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.PictureBox PCerrar;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnSuplidores;
        private System.Windows.Forms.Button btnTipoSuplidores;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}