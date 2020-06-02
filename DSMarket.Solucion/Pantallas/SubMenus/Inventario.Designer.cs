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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.PCerrar = new System.Windows.Forms.PictureBox();
            this.lbIdUsuario = new System.Windows.Forms.Label();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.btnTipoEmpaque = new System.Windows.Forms.Button();
            this.btnModelos = new System.Windows.Forms.Button();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.btnCotizacion = new System.Windows.Forms.Button();
            this.btnTipoProducto = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).BeginInit();
            this.gbOpciones.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(745, 44);
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
            // PCerrar
            // 
            this.PCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PCerrar.Image = global::DSMarket.Solucion.Properties.Resources.Close_Window__2_48px;
            this.PCerrar.Location = new System.Drawing.Point(703, 10);
            this.PCerrar.Name = "PCerrar";
            this.PCerrar.Size = new System.Drawing.Size(30, 30);
            this.PCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCerrar.TabIndex = 15;
            this.PCerrar.TabStop = false;
            this.PCerrar.Click += new System.EventHandler(this.PCerrar_Click);
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
            this.gbOpciones.Controls.Add(this.btnTipoEmpaque);
            this.gbOpciones.Controls.Add(this.btnModelos);
            this.gbOpciones.Controls.Add(this.btnMarcas);
            this.gbOpciones.Controls.Add(this.btnCotizacion);
            this.gbOpciones.Controls.Add(this.btnTipoProducto);
            this.gbOpciones.Controls.Add(this.btnProductos);
            this.gbOpciones.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpciones.Location = new System.Drawing.Point(12, 50);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(721, 181);
            this.gbOpciones.TabIndex = 16;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Inventario - Seleccionar Opcion";
            // 
            // btnTipoEmpaque
            // 
            this.btnTipoEmpaque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTipoEmpaque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoEmpaque.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoEmpaque.Location = new System.Drawing.Point(478, 29);
            this.btnTipoEmpaque.Name = "btnTipoEmpaque";
            this.btnTipoEmpaque.Size = new System.Drawing.Size(230, 68);
            this.btnTipoEmpaque.TabIndex = 5;
            this.btnTipoEmpaque.Text = "Tipo de Empaque";
            this.btnTipoEmpaque.UseVisualStyleBackColor = true;
            // 
            // btnModelos
            // 
            this.btnModelos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModelos.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModelos.Location = new System.Drawing.Point(242, 103);
            this.btnModelos.Name = "btnModelos";
            this.btnModelos.Size = new System.Drawing.Size(230, 68);
            this.btnModelos.TabIndex = 4;
            this.btnModelos.Text = "Modelos";
            this.btnModelos.UseVisualStyleBackColor = true;
            // 
            // btnMarcas
            // 
            this.btnMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcas.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcas.Location = new System.Drawing.Point(6, 103);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Size = new System.Drawing.Size(230, 68);
            this.btnMarcas.TabIndex = 3;
            this.btnMarcas.Text = "Marcas";
            this.btnMarcas.UseVisualStyleBackColor = true;
            // 
            // btnCotizacion
            // 
            this.btnCotizacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCotizacion.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizacion.Location = new System.Drawing.Point(478, 103);
            this.btnCotizacion.Name = "btnCotizacion";
            this.btnCotizacion.Size = new System.Drawing.Size(230, 68);
            this.btnCotizacion.TabIndex = 2;
            this.btnCotizacion.Text = "Tipo de Producto";
            this.btnCotizacion.UseVisualStyleBackColor = true;
            this.btnCotizacion.Visible = false;
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
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 241);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbOpciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).EndInit();
            this.gbOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbIdUsuario;
        public System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Button btnTipoEmpaque;
        private System.Windows.Forms.Button btnModelos;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Button btnCotizacion;
        private System.Windows.Forms.Button btnTipoProducto;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.PictureBox PCerrar;
        private System.Windows.Forms.Label lbTitulo;
    }
}