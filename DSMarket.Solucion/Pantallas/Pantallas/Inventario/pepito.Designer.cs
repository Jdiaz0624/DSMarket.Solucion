namespace DSMarket.Solucion.Pantallas.Pantallas.Inventario
{
    partial class pepito
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
            this.btnBoton = new System.Windows.Forms.Button();
            this.txtMEnsaje = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnBoton
            // 
            this.btnBoton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBoton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoton.Location = new System.Drawing.Point(527, 244);
            this.btnBoton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBoton.Name = "btnBoton";
            this.btnBoton.Size = new System.Drawing.Size(203, 69);
            this.btnBoton.TabIndex = 0;
            this.btnBoton.Text = "Pulsar";
            this.toolTip1.SetToolTip(this.btnBoton, "Pulsar");
            this.btnBoton.UseVisualStyleBackColor = true;
            this.btnBoton.Click += new System.EventHandler(this.btnBoton_Click);
            // 
            // txtMEnsaje
            // 
            this.txtMEnsaje.Location = new System.Drawing.Point(412, 173);
            this.txtMEnsaje.Name = "txtMEnsaje";
            this.txtMEnsaje.Size = new System.Drawing.Size(408, 27);
            this.txtMEnsaje.TabIndex = 1;
            this.txtMEnsaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMEnsaje_KeyPress);
            // 
            // pepito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 727);
            this.Controls.Add(this.txtMEnsaje);
            this.Controls.Add(this.btnBoton);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "pepito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pepito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBoton;
        private System.Windows.Forms.TextBox txtMEnsaje;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}