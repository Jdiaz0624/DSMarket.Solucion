namespace DSMarket.Solucion.Pantallas.SubMenus
{
    partial class Configuracion
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
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.btnRutaArchivotxt = new System.Windows.Forms.Button();
            this.btnComfiguracionGeneral = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnInformacionEmpresa = new System.Windows.Forms.Button();
            this.btnComprobantes = new System.Windows.Forms.Button();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button4 = new System.Windows.Forms.Button();
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
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 44);
            this.panel1.TabIndex = 18;
            // 
            // PCerrar
            // 
            this.PCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PCerrar.BackColor = System.Drawing.Color.Transparent;
            this.PCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PCerrar.Image = global::DSMarket.Solucion.Properties.Resources.Close_Window__2_48px;
            this.PCerrar.Location = new System.Drawing.Point(562, 10);
            this.PCerrar.Name = "PCerrar";
            this.PCerrar.Size = new System.Drawing.Size(30, 30);
            this.PCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCerrar.TabIndex = 19;
            this.PCerrar.TabStop = false;
            this.PCerrar.Click += new System.EventHandler(this.PCerrar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(13, 10);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(51, 20);
            this.lbTitulo.TabIndex = 16;
            this.lbTitulo.Text = "label1";
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.button4);
            this.gbOpciones.Controls.Add(this.btnRutaArchivotxt);
            this.gbOpciones.Controls.Add(this.btnComfiguracionGeneral);
            this.gbOpciones.Controls.Add(this.button3);
            this.gbOpciones.Controls.Add(this.button2);
            this.gbOpciones.Controls.Add(this.button1);
            this.gbOpciones.Controls.Add(this.btnReportes);
            this.gbOpciones.Controls.Add(this.btnInformacionEmpresa);
            this.gbOpciones.Controls.Add(this.btnComprobantes);
            this.gbOpciones.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpciones.Location = new System.Drawing.Point(12, 60);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(584, 218);
            this.gbOpciones.TabIndex = 17;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Configuración - Seleccionar Opcion";
            this.toolTip1.SetToolTip(this.gbOpciones, "Configurar la ruta donde se van a guardar los archivos txt");
            // 
            // btnRutaArchivotxt
            // 
            this.btnRutaArchivotxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRutaArchivotxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutaArchivotxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutaArchivotxt.Location = new System.Drawing.Point(198, 153);
            this.btnRutaArchivotxt.Name = "btnRutaArchivotxt";
            this.btnRutaArchivotxt.Size = new System.Drawing.Size(186, 56);
            this.btnRutaArchivotxt.TabIndex = 14;
            this.btnRutaArchivotxt.Text = "Ruta Archivo TXT";
            this.toolTip1.SetToolTip(this.btnRutaArchivotxt, "Configuración General");
            this.btnRutaArchivotxt.UseVisualStyleBackColor = true;
            this.btnRutaArchivotxt.Click += new System.EventHandler(this.BtnRutaArchivotxt_Click);
            // 
            // btnComfiguracionGeneral
            // 
            this.btnComfiguracionGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComfiguracionGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComfiguracionGeneral.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComfiguracionGeneral.Location = new System.Drawing.Point(6, 153);
            this.btnComfiguracionGeneral.Name = "btnComfiguracionGeneral";
            this.btnComfiguracionGeneral.Size = new System.Drawing.Size(186, 56);
            this.btnComfiguracionGeneral.TabIndex = 13;
            this.btnComfiguracionGeneral.Text = "General";
            this.toolTip1.SetToolTip(this.btnComfiguracionGeneral, "Configuración General");
            this.btnComfiguracionGeneral.UseVisualStyleBackColor = true;
            this.btnComfiguracionGeneral.Click += new System.EventHandler(this.BtnComfiguracionGeneral_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(390, 91);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 56);
            this.button3.TabIndex = 12;
            this.button3.Text = "Impuestos";
            this.toolTip1.SetToolTip(this.button3, "Modificacion de impuesto");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(198, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 56);
            this.button2.TabIndex = 11;
            this.button2.Text = "Backup BD";
            this.toolTip1.SetToolTip(this.button2, "Configuración del backup de BD");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 56);
            this.button1.TabIndex = 10;
            this.button1.Text = "Mail";
            this.toolTip1.SetToolTip(this.button1, "Configuración de mail");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Location = new System.Drawing.Point(390, 29);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(186, 56);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "Reportes";
            this.toolTip1.SetToolTip(this.btnReportes, "Modificar las rutas de los reportes.");
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnInformacionEmpresa
            // 
            this.btnInformacionEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformacionEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacionEmpresa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacionEmpresa.Location = new System.Drawing.Point(6, 29);
            this.btnInformacionEmpresa.Name = "btnInformacionEmpresa";
            this.btnInformacionEmpresa.Size = new System.Drawing.Size(186, 56);
            this.btnInformacionEmpresa.TabIndex = 3;
            this.btnInformacionEmpresa.Text = "Información de Empresa";
            this.toolTip1.SetToolTip(this.btnInformacionEmpresa, "Modificar los datos de la empresa");
            this.btnInformacionEmpresa.UseVisualStyleBackColor = true;
            this.btnInformacionEmpresa.Click += new System.EventHandler(this.btnInformacionEmpresa_Click);
            // 
            // btnComprobantes
            // 
            this.btnComprobantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprobantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprobantes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobantes.Location = new System.Drawing.Point(198, 29);
            this.btnComprobantes.Name = "btnComprobantes";
            this.btnComprobantes.Size = new System.Drawing.Size(186, 56);
            this.btnComprobantes.TabIndex = 1;
            this.btnComprobantes.Text = "Comprobantes";
            this.toolTip1.SetToolTip(this.btnComprobantes, "Modificar de los comprobantes fiscales");
            this.btnComprobantes.UseVisualStyleBackColor = true;
            this.btnComprobantes.Click += new System.EventHandler(this.btnComprobantes_Click);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(362, 47);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(51, 20);
            this.lbUsuario.TabIndex = 9;
            this.lbUsuario.Text = "label1";
            this.lbUsuario.Visible = false;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(390, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 56);
            this.button4.TabIndex = 15;
            this.button4.Text = "% Descuento Productos";
            this.toolTip1.SetToolTip(this.button4, "Moificar el % de Descuento por defecto de los productos");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 287);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbOpciones);
            this.Controls.Add(this.lbUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Configuracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).EndInit();
            this.gbOpciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitulo;
        public System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnInformacionEmpresa;
        private System.Windows.Forms.Button btnComprobantes;
        private System.Windows.Forms.PictureBox PCerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnComfiguracionGeneral;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnRutaArchivotxt;
        private System.Windows.Forms.Button button4;
    }
}