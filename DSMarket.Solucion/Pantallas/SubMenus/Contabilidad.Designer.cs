namespace DSMarket.Solucion.Pantallas.SubMenus
{
    partial class Contabilidad
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
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.btnInformacionEmpresa = new System.Windows.Forms.Button();
            this.lbusuario = new System.Windows.Forms.Label();
            this.gbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.btnInformacionEmpresa);
            this.gbOpciones.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpciones.Location = new System.Drawing.Point(12, 12);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(584, 218);
            this.gbOpciones.TabIndex = 18;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Contabilidad - Seleccionar Opcion";
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
            this.btnInformacionEmpresa.Text = "Catalogo de Cuentas";
            this.btnInformacionEmpresa.UseVisualStyleBackColor = true;
            this.btnInformacionEmpresa.Click += new System.EventHandler(this.btnInformacionEmpresa_Click);
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.Location = new System.Drawing.Point(269, 0);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(57, 21);
            this.lbusuario.TabIndex = 19;
            this.lbusuario.Text = "label1";
            this.lbusuario.Visible = false;
            // 
            // Contabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 240);
            this.Controls.Add(this.lbusuario);
            this.Controls.Add(this.gbOpciones);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Contabilidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Contabilidad";
            this.Load += new System.EventHandler(this.Contabilidad_Load);
            this.gbOpciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Button btnInformacionEmpresa;
        public System.Windows.Forms.Label lbusuario;
    }
}