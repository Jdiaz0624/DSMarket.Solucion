namespace DSMarket.Solucion.Pantallas.MenuPrincipal
{
    partial class InformacionUsuarioConectado
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbNivelAcceso = new System.Windows.Forms.Label();
            this.lbusuarioConectado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DSMarket.Solucion.Properties.Resources.tulogo;
            this.pictureBox2.Location = new System.Drawing.Point(230, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(315, 217);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // lbNivelAcceso
            // 
            this.lbNivelAcceso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbNivelAcceso.AutoSize = true;
            this.lbNivelAcceso.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNivelAcceso.ForeColor = System.Drawing.Color.Black;
            this.lbNivelAcceso.Location = new System.Drawing.Point(12, 397);
            this.lbNivelAcceso.Name = "lbNivelAcceso";
            this.lbNivelAcceso.Size = new System.Drawing.Size(211, 30);
            this.lbNivelAcceso.TabIndex = 18;
            this.lbNivelAcceso.Text = "Nivel de Acceso";
            // 
            // lbusuarioConectado
            // 
            this.lbusuarioConectado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbusuarioConectado.AutoSize = true;
            this.lbusuarioConectado.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusuarioConectado.ForeColor = System.Drawing.Color.Black;
            this.lbusuarioConectado.Location = new System.Drawing.Point(12, 367);
            this.lbusuarioConectado.Name = "lbusuarioConectado";
            this.lbusuarioConectado.Size = new System.Drawing.Size(245, 30);
            this.lbusuarioConectado.TabIndex = 17;
            this.lbusuarioConectado.Text = "Usuario Conectado";
            // 
            // InformacionUsuarioConectado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbNivelAcceso);
            this.Controls.Add(this.lbusuarioConectado);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InformacionUsuarioConectado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformacionUsuarioConectado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbNivelAcceso;
        private System.Windows.Forms.Label lbusuarioConectado;
    }
}