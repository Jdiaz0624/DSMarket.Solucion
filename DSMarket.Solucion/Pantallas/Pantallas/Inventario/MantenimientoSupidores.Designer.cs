namespace DSMarket.Solucion.Pantallas.Pantallas.Inventario
{
    partial class MantenimientoSupidores
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbEstatus = new System.Windows.Forms.CheckBox();
            this.PCerrar = new System.Windows.Forms.PictureBox();
            this.lbclaveSeguridad = new System.Windows.Forms.Label();
            this.txtClaveSeguridad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlSeleccionarTipoSuplidor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSuplidor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 10;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::DSMarket.Solucion.Properties.Resources.Guardar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(12, 321);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(406, 41);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.Text = "Accion";
            this.toolTip1.SetToolTip(this.btnGuardar, "Completar Operación");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbEstatus
            // 
            this.cbEstatus.AutoSize = true;
            this.cbEstatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEstatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEstatus.Location = new System.Drawing.Point(76, 207);
            this.cbEstatus.Name = "cbEstatus";
            this.cbEstatus.Size = new System.Drawing.Size(83, 25);
            this.cbEstatus.TabIndex = 6;
            this.cbEstatus.Text = "Estatus";
            this.toolTip1.SetToolTip(this.cbEstatus, "Estatus de Tipo de Producto");
            this.cbEstatus.UseVisualStyleBackColor = true;
            this.cbEstatus.CheckedChanged += new System.EventHandler(this.cbEstatus_CheckedChanged);
            // 
            // PCerrar
            // 
            this.PCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PCerrar.Image = global::DSMarket.Solucion.Properties.Resources.Close_Window__2_48px;
            this.PCerrar.Location = new System.Drawing.Point(388, 5);
            this.PCerrar.Name = "PCerrar";
            this.PCerrar.Size = new System.Drawing.Size(30, 30);
            this.PCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCerrar.TabIndex = 15;
            this.PCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.PCerrar, "Cerrar");
            this.PCerrar.Click += new System.EventHandler(this.PCerrar_Click);
            // 
            // lbclaveSeguridad
            // 
            this.lbclaveSeguridad.AutoSize = true;
            this.lbclaveSeguridad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbclaveSeguridad.Location = new System.Drawing.Point(10, 291);
            this.lbclaveSeguridad.Name = "lbclaveSeguridad";
            this.lbclaveSeguridad.Size = new System.Drawing.Size(166, 21);
            this.lbclaveSeguridad.TabIndex = 39;
            this.lbclaveSeguridad.Text = "Clave de Seguridad";
            // 
            // txtClaveSeguridad
            // 
            this.txtClaveSeguridad.BackColor = System.Drawing.Color.Silver;
            this.txtClaveSeguridad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveSeguridad.Location = new System.Drawing.Point(182, 288);
            this.txtClaveSeguridad.MaxLength = 20;
            this.txtClaveSeguridad.Name = "txtClaveSeguridad";
            this.txtClaveSeguridad.PasswordChar = '•';
            this.txtClaveSeguridad.Size = new System.Drawing.Size(225, 27);
            this.txtClaveSeguridad.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtContacto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ddlSeleccionarTipoSuplidor);
            this.groupBox1.Controls.Add(this.cbEstatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSuplidor);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 237);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mantenimiento de suplidores";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 96;
            this.label6.Text = "Contacto";
            // 
            // txtContacto
            // 
            this.txtContacto.BackColor = System.Drawing.Color.Silver;
            this.txtContacto.Location = new System.Drawing.Point(96, 177);
            this.txtContacto.MaxLength = 20;
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(274, 27);
            this.txtContacto.TabIndex = 95;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 94;
            this.label5.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.Silver;
            this.txtDireccion.Location = new System.Drawing.Point(96, 147);
            this.txtDireccion.MaxLength = 20;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(274, 27);
            this.txtDireccion.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 21);
            this.label4.TabIndex = 92;
            this.label4.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(96, 117);
            this.txtEmail.MaxLength = 20;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(274, 27);
            this.txtEmail.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 21);
            this.label3.TabIndex = 90;
            this.label3.Text = "Tel.";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Silver;
            this.txtTelefono.Location = new System.Drawing.Point(96, 87);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(274, 27);
            this.txtTelefono.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 88;
            this.label2.Text = "Tipo *";
            // 
            // ddlSeleccionarTipoSuplidor
            // 
            this.ddlSeleccionarTipoSuplidor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ddlSeleccionarTipoSuplidor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlSeleccionarTipoSuplidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSeleccionarTipoSuplidor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlSeleccionarTipoSuplidor.FormattingEnabled = true;
            this.ddlSeleccionarTipoSuplidor.Location = new System.Drawing.Point(96, 25);
            this.ddlSeleccionarTipoSuplidor.Name = "ddlSeleccionarTipoSuplidor";
            this.ddlSeleccionarTipoSuplidor.Size = new System.Drawing.Size(274, 29);
            this.ddlSeleccionarTipoSuplidor.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Suplidor *";
            // 
            // txtSuplidor
            // 
            this.txtSuplidor.BackColor = System.Drawing.Color.Silver;
            this.txtSuplidor.Location = new System.Drawing.Point(96, 57);
            this.txtSuplidor.MaxLength = 20;
            this.txtSuplidor.Name = "txtSuplidor";
            this.txtSuplidor.Size = new System.Drawing.Size(274, 27);
            this.txtSuplidor.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.PCerrar);
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 38);
            this.panel1.TabIndex = 35;
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
            // MantenimientoSupidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 378);
            this.Controls.Add(this.lbclaveSeguridad);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtClaveSeguridad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MantenimientoSupidores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenimientoSupidores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MantenimientoSupidores_FormClosing);
            this.Load += new System.EventHandler(this.MantenimientoSupidores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbclaveSeguridad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtClaveSeguridad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlSeleccionarTipoSuplidor;
        private System.Windows.Forms.CheckBox cbEstatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSuplidor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PCerrar;
        public System.Windows.Forms.Label lbTitulo;
    }
}