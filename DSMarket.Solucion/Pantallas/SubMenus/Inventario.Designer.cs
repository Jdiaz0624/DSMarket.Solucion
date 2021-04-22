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
            this.PCerrar = new System.Windows.Forms.PictureBox();
            this.lbIdUsuario = new System.Windows.Forms.Label();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.btnCapacidad = new System.Windows.Forms.Button();
            this.btnCondiciones = new System.Windows.Forms.Button();
            this.btnColores = new System.Windows.Forms.Button();
            this.btnUnidadMedida = new System.Windows.Forms.Button();
            this.btnModelo = new System.Windows.Forms.Button();
            this.btnSuplidores = new System.Windows.Forms.Button();
            this.btnTipoSuplidores = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnMArcas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.panel1.Size = new System.Drawing.Size(606, 44);
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
            this.PCerrar.Location = new System.Drawing.Point(564, 10);
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
            this.gbOpciones.Controls.Add(this.btnCapacidad);
            this.gbOpciones.Controls.Add(this.btnCondiciones);
            this.gbOpciones.Controls.Add(this.btnColores);
            this.gbOpciones.Controls.Add(this.btnUnidadMedida);
            this.gbOpciones.Controls.Add(this.btnModelo);
            this.gbOpciones.Controls.Add(this.btnSuplidores);
            this.gbOpciones.Controls.Add(this.btnTipoSuplidores);
            this.gbOpciones.Controls.Add(this.btnCategoria);
            this.gbOpciones.Controls.Add(this.btnMArcas);
            this.gbOpciones.Controls.Add(this.btnProductos);
            this.gbOpciones.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpciones.Location = new System.Drawing.Point(12, 50);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(584, 290);
            this.gbOpciones.TabIndex = 16;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Inventario - Seleccionar Opción";
            this.gbOpciones.Enter += new System.EventHandler(this.gbOpciones_Enter);
            // 
            // btnCapacidad
            // 
            this.btnCapacidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapacidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapacidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapacidad.Location = new System.Drawing.Point(7, 215);
            this.btnCapacidad.Name = "btnCapacidad";
            this.btnCapacidad.Size = new System.Drawing.Size(186, 56);
            this.btnCapacidad.TabIndex = 12;
            this.btnCapacidad.Text = "Capacidad";
            this.toolTip1.SetToolTip(this.btnCapacidad, "Mantenimiento de Capacidad");
            this.btnCapacidad.UseVisualStyleBackColor = true;
            // 
            // btnCondiciones
            // 
            this.btnCondiciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCondiciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCondiciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCondiciones.Location = new System.Drawing.Point(390, 154);
            this.btnCondiciones.Name = "btnCondiciones";
            this.btnCondiciones.Size = new System.Drawing.Size(186, 56);
            this.btnCondiciones.TabIndex = 11;
            this.btnCondiciones.Text = "Condiciones";
            this.toolTip1.SetToolTip(this.btnCondiciones, "Mantenimiento de Condiciones");
            this.btnCondiciones.UseVisualStyleBackColor = true;
            // 
            // btnColores
            // 
            this.btnColores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColores.Location = new System.Drawing.Point(199, 153);
            this.btnColores.Name = "btnColores";
            this.btnColores.Size = new System.Drawing.Size(186, 56);
            this.btnColores.TabIndex = 10;
            this.btnColores.Text = "Colores";
            this.toolTip1.SetToolTip(this.btnColores, "Mantenimiento de Colores");
            this.btnColores.UseVisualStyleBackColor = true;
            // 
            // btnUnidadMedida
            // 
            this.btnUnidadMedida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnidadMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnidadMedida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnidadMedida.Location = new System.Drawing.Point(6, 153);
            this.btnUnidadMedida.Name = "btnUnidadMedida";
            this.btnUnidadMedida.Size = new System.Drawing.Size(186, 56);
            this.btnUnidadMedida.TabIndex = 9;
            this.btnUnidadMedida.Text = "Unidad de Medida";
            this.toolTip1.SetToolTip(this.btnUnidadMedida, "Mantenimiento de Unidad de Medida");
            this.btnUnidadMedida.UseVisualStyleBackColor = true;
            this.btnUnidadMedida.Click += new System.EventHandler(this.btnUnidadMedida_Click);
            // 
            // btnModelo
            // 
            this.btnModelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModelo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModelo.Location = new System.Drawing.Point(390, 92);
            this.btnModelo.Name = "btnModelo";
            this.btnModelo.Size = new System.Drawing.Size(186, 56);
            this.btnModelo.TabIndex = 8;
            this.btnModelo.Text = "Modelos";
            this.toolTip1.SetToolTip(this.btnModelo, "Mantenimiento de Modelos");
            this.btnModelo.UseVisualStyleBackColor = true;
            this.btnModelo.Click += new System.EventHandler(this.btnModelo_Click);
            // 
            // btnSuplidores
            // 
            this.btnSuplidores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuplidores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuplidores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuplidores.Location = new System.Drawing.Point(199, 91);
            this.btnSuplidores.Name = "btnSuplidores";
            this.btnSuplidores.Size = new System.Drawing.Size(186, 56);
            this.btnSuplidores.TabIndex = 7;
            this.btnSuplidores.Text = "Suplidores";
            this.toolTip1.SetToolTip(this.btnSuplidores, "Mantenimiento de suplidores");
            this.btnSuplidores.UseVisualStyleBackColor = true;
            this.btnSuplidores.Click += new System.EventHandler(this.btnSuplidores_Click);
            // 
            // btnTipoSuplidores
            // 
            this.btnTipoSuplidores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTipoSuplidores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoSuplidores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoSuplidores.Location = new System.Drawing.Point(7, 91);
            this.btnTipoSuplidores.Name = "btnTipoSuplidores";
            this.btnTipoSuplidores.Size = new System.Drawing.Size(186, 56);
            this.btnTipoSuplidores.TabIndex = 6;
            this.btnTipoSuplidores.Text = "Tipo de Suplidores";
            this.toolTip1.SetToolTip(this.btnTipoSuplidores, "Mantenimiento de tipo de suplidores");
            this.btnTipoSuplidores.UseVisualStyleBackColor = true;
            this.btnTipoSuplidores.Click += new System.EventHandler(this.btnTipoSuplidores_Click);
            // 
            // btnCategoria
            // 
            this.btnCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.Location = new System.Drawing.Point(198, 29);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(186, 56);
            this.btnCategoria.TabIndex = 5;
            this.btnCategoria.Text = "Categoria";
            this.toolTip1.SetToolTip(this.btnCategoria, "Mantenimiento de Categorias");
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnMArcas
            // 
            this.btnMArcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMArcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMArcas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMArcas.Location = new System.Drawing.Point(390, 30);
            this.btnMArcas.Name = "btnMArcas";
            this.btnMArcas.Size = new System.Drawing.Size(186, 56);
            this.btnMArcas.TabIndex = 4;
            this.btnMArcas.Text = "Marcas";
            this.toolTip1.SetToolTip(this.btnMArcas, "Mantenimiento de Marcas");
            this.btnMArcas.UseVisualStyleBackColor = true;
            this.btnMArcas.Click += new System.EventHandler(this.btnMArcas_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Location = new System.Drawing.Point(6, 29);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(186, 56);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "Producto / Inventario";
            this.toolTip1.SetToolTip(this.btnProductos, "Inventario");
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 351);
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
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnMArcas;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.PictureBox PCerrar;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnSuplidores;
        private System.Windows.Forms.Button btnTipoSuplidores;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCapacidad;
        private System.Windows.Forms.Button btnCondiciones;
        private System.Windows.Forms.Button btnColores;
        private System.Windows.Forms.Button btnUnidadMedida;
        private System.Windows.Forms.Button btnModelo;
    }
}