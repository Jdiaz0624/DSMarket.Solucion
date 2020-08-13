namespace DSMarket.Solucion.Pantallas.SubMenus
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PCerrar = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbIdUsuario = new System.Windows.Forms.Label();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnAbirCerrarCaja = new System.Windows.Forms.Button();
            this.btnCuadreCaja = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).BeginInit();
            this.gbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.PCerrar);
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Controls.Add(this.lbIdUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 44);
            this.panel1.TabIndex = 13;
            // 
            // PCerrar
            // 
            this.PCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PCerrar.Image = global::DSMarket.Solucion.Properties.Resources.Close_Window__2_48px;
            this.PCerrar.Location = new System.Drawing.Point(563, 8);
            this.PCerrar.Name = "PCerrar";
            this.PCerrar.Size = new System.Drawing.Size(30, 30);
            this.PCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCerrar.TabIndex = 14;
            this.PCerrar.TabStop = false;
            this.PCerrar.Click += new System.EventHandler(this.PCerrar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(7, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(54, 20);
            this.lbTitulo.TabIndex = 13;
            this.lbTitulo.Text = "label6";
            // 
            // lbIdUsuario
            // 
            this.lbIdUsuario.AutoSize = true;
            this.lbIdUsuario.ForeColor = System.Drawing.Color.White;
            this.lbIdUsuario.Location = new System.Drawing.Point(485, 10);
            this.lbIdUsuario.Name = "lbIdUsuario";
            this.lbIdUsuario.Size = new System.Drawing.Size(51, 20);
            this.lbIdUsuario.TabIndex = 10;
            this.lbIdUsuario.Text = "label1";
            this.lbIdUsuario.Visible = false;
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.btnConfiguracion);
            this.gbOpciones.Controls.Add(this.btnAbirCerrarCaja);
            this.gbOpciones.Controls.Add(this.btnCuadreCaja);
            this.gbOpciones.Location = new System.Drawing.Point(10, 50);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(587, 99);
            this.gbOpciones.TabIndex = 12;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Caja - Seleccionar Opcion";
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.Location = new System.Drawing.Point(390, 29);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(186, 56);
            this.btnConfiguracion.TabIndex = 7;
            this.btnConfiguracion.Text = "Configurar";
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnMonedas_Click);
            // 
            // btnAbirCerrarCaja
            // 
            this.btnAbirCerrarCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbirCerrarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbirCerrarCaja.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbirCerrarCaja.Location = new System.Drawing.Point(6, 29);
            this.btnAbirCerrarCaja.Name = "btnAbirCerrarCaja";
            this.btnAbirCerrarCaja.Size = new System.Drawing.Size(186, 56);
            this.btnAbirCerrarCaja.TabIndex = 6;
            this.btnAbirCerrarCaja.Text = "Abrir / Cerrar";
            this.btnAbirCerrarCaja.UseVisualStyleBackColor = true;
            this.btnAbirCerrarCaja.Click += new System.EventHandler(this.btnAbirCerrarCaja_Click);
            // 
            // btnCuadreCaja
            // 
            this.btnCuadreCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuadreCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuadreCaja.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuadreCaja.Location = new System.Drawing.Point(198, 29);
            this.btnCuadreCaja.Name = "btnCuadreCaja";
            this.btnCuadreCaja.Size = new System.Drawing.Size(186, 56);
            this.btnCuadreCaja.TabIndex = 5;
            this.btnCuadreCaja.Text = "Cuadre";
            this.btnCuadreCaja.UseVisualStyleBackColor = true;
            this.btnCuadreCaja.Click += new System.EventHandler(this.btnCuadreCaja_Click);
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 156);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbOpciones);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Caja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.Caja_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).EndInit();
            this.gbOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbIdUsuario;
        public System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnAbirCerrarCaja;
        private System.Windows.Forms.Button btnCuadreCaja;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox PCerrar;
    }
}