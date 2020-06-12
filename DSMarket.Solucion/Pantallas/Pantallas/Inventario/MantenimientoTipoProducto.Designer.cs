namespace DSMarket.Solucion.Pantallas.Pantallas.Inventario
{
    partial class MantenimientoTipoProducto
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtClaveSeguridad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbacumulativo = new System.Windows.Forms.CheckBox();
            this.cbEstatus = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipoProducto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PCerrar = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Clave de Seguridad";
            // 
            // txtClaveSeguridad
            // 
            this.txtClaveSeguridad.BackColor = System.Drawing.Color.Silver;
            this.txtClaveSeguridad.Location = new System.Drawing.Point(184, 205);
            this.txtClaveSeguridad.MaxLength = 20;
            this.txtClaveSeguridad.Name = "txtClaveSeguridad";
            this.txtClaveSeguridad.PasswordChar = '•';
            this.txtClaveSeguridad.Size = new System.Drawing.Size(212, 27);
            this.txtClaveSeguridad.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbacumulativo);
            this.groupBox1.Controls.Add(this.cbEstatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTipoProducto);
            this.groupBox1.Location = new System.Drawing.Point(5, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 153);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento de tipo de producto";
            // 
            // cbacumulativo
            // 
            this.cbacumulativo.AutoSize = true;
            this.cbacumulativo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbacumulativo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbacumulativo.Location = new System.Drawing.Point(156, 111);
            this.cbacumulativo.Name = "cbacumulativo";
            this.cbacumulativo.Size = new System.Drawing.Size(129, 25);
            this.cbacumulativo.TabIndex = 7;
            this.cbacumulativo.Text = "Acumulativo";
            this.toolTip1.SetToolTip(this.cbacumulativo, "Producto acumulativo");
            this.cbacumulativo.UseVisualStyleBackColor = true;
            this.cbacumulativo.CheckedChanged += new System.EventHandler(this.cbacumulativo_CheckedChanged);
            // 
            // cbEstatus
            // 
            this.cbEstatus.AutoSize = true;
            this.cbEstatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEstatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEstatus.Location = new System.Drawing.Point(156, 80);
            this.cbEstatus.Name = "cbEstatus";
            this.cbEstatus.Size = new System.Drawing.Size(83, 25);
            this.cbEstatus.TabIndex = 6;
            this.cbEstatus.Text = "Estatus";
            this.toolTip1.SetToolTip(this.cbEstatus, "Estatus de Tipo de Producto");
            this.cbEstatus.UseVisualStyleBackColor = true;
            this.cbEstatus.CheckedChanged += new System.EventHandler(this.cbEstatus_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo de Producto";
            // 
            // txtTipoProducto
            // 
            this.txtTipoProducto.BackColor = System.Drawing.Color.Silver;
            this.txtTipoProducto.Location = new System.Drawing.Point(156, 44);
            this.txtTipoProducto.MaxLength = 100;
            this.txtTipoProducto.Name = "txtTipoProducto";
            this.txtTipoProducto.Size = new System.Drawing.Size(235, 27);
            this.txtTipoProducto.TabIndex = 4;
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
            this.panel1.Size = new System.Drawing.Size(428, 40);
            this.panel1.TabIndex = 10;
            // 
            // PCerrar
            // 
            this.PCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PCerrar.Image = global::DSMarket.Solucion.Properties.Resources.Close_Window__2_48px;
            this.PCerrar.Location = new System.Drawing.Point(386, 5);
            this.PCerrar.Name = "PCerrar";
            this.PCerrar.Size = new System.Drawing.Size(30, 31);
            this.PCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCerrar.TabIndex = 15;
            this.PCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.PCerrar, "Cerrar");
            this.PCerrar.Click += new System.EventHandler(this.PCerrar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(15, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(57, 21);
            this.lbTitulo.TabIndex = 13;
            this.lbTitulo.Text = "label6";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 10;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::DSMarket.Solucion.Properties.Resources.Guardar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(5, 247);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(406, 43);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Accion";
            this.toolTip1.SetToolTip(this.btnGuardar, "Completar Operación");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // MantenimientoTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 307);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtClaveSeguridad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MantenimientoTipoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenimientoTipoProducto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MantenimientoTipoProducto_FormClosing);
            this.Load += new System.EventHandler(this.MantenimientoTipoProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtClaveSeguridad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbacumulativo;
        private System.Windows.Forms.CheckBox cbEstatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipoProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PCerrar;
        public System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}