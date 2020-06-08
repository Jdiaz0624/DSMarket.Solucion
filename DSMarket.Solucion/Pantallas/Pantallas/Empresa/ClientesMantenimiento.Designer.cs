namespace DSMarket.Solucion.Pantallas.Pantallas.Empresa
{
    partial class ClientesMantenimiento
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PCerrar = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtapellidoCliente = new System.Windows.Forms.TextBox();
            this.txtTipoidentificcionCliente = new System.Windows.Forms.ComboBox();
            this.txtNumeroidentificacionCliente = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtSegundoTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtLimiteCredito = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTieneCredito = new System.Windows.Forms.CheckBox();
            this.cbEnvioEmail = new System.Windows.Forms.CheckBox();
            this.lbClaveSeguridad = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtClaveSeguridad = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
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
            this.panel1.Size = new System.Drawing.Size(538, 38);
            this.panel1.TabIndex = 78;
            // 
            // PCerrar
            // 
            this.PCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PCerrar.Image = global::DSMarket.Solucion.Properties.Resources.Close_Window__2_48px;
            this.PCerrar.Location = new System.Drawing.Point(496, 5);
            this.PCerrar.Name = "PCerrar";
            this.PCerrar.Size = new System.Drawing.Size(30, 30);
            this.PCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCerrar.TabIndex = 15;
            this.PCerrar.TabStop = false;
            this.PCerrar.Click += new System.EventHandler(this.PCerrar_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(15, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(54, 20);
            this.lbTitulo.TabIndex = 13;
            this.lbTitulo.Text = "label6";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEnvioEmail);
            this.groupBox1.Controls.Add(this.cbTieneCredito);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtComentario);
            this.groupBox1.Controls.Add(this.txtLimiteCredito);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtSegundoTelefono);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtNumeroidentificacionCliente);
            this.groupBox1.Controls.Add(this.txtTipoidentificcionCliente);
            this.groupBox1.Controls.Add(this.txtapellidoCliente);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 385);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo identificación:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero de Idenificación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Dirección:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Limite de Credito:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "2do Telefono:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.Color.Silver;
            this.txtNombreCliente.Location = new System.Drawing.Point(206, 26);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(291, 27);
            this.txtNombreCliente.TabIndex = 9;
            // 
            // txtapellidoCliente
            // 
            this.txtapellidoCliente.BackColor = System.Drawing.Color.Silver;
            this.txtapellidoCliente.Location = new System.Drawing.Point(206, 55);
            this.txtapellidoCliente.Name = "txtapellidoCliente";
            this.txtapellidoCliente.Size = new System.Drawing.Size(291, 27);
            this.txtapellidoCliente.TabIndex = 10;
            // 
            // txtTipoidentificcionCliente
            // 
            this.txtTipoidentificcionCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTipoidentificcionCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTipoidentificcionCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTipoidentificcionCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtTipoidentificcionCliente.FormattingEnabled = true;
            this.txtTipoidentificcionCliente.Location = new System.Drawing.Point(206, 87);
            this.txtTipoidentificcionCliente.Name = "txtTipoidentificcionCliente";
            this.txtTipoidentificcionCliente.Size = new System.Drawing.Size(291, 28);
            this.txtTipoidentificcionCliente.TabIndex = 11;
            // 
            // txtNumeroidentificacionCliente
            // 
            this.txtNumeroidentificacionCliente.BackColor = System.Drawing.Color.Silver;
            this.txtNumeroidentificacionCliente.Location = new System.Drawing.Point(206, 122);
            this.txtNumeroidentificacionCliente.Name = "txtNumeroidentificacionCliente";
            this.txtNumeroidentificacionCliente.Size = new System.Drawing.Size(291, 27);
            this.txtNumeroidentificacionCliente.TabIndex = 12;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Silver;
            this.txtTelefono.Location = new System.Drawing.Point(206, 155);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(291, 27);
            this.txtTelefono.TabIndex = 13;
            // 
            // txtSegundoTelefono
            // 
            this.txtSegundoTelefono.BackColor = System.Drawing.Color.Silver;
            this.txtSegundoTelefono.Location = new System.Drawing.Point(206, 188);
            this.txtSegundoTelefono.Name = "txtSegundoTelefono";
            this.txtSegundoTelefono.Size = new System.Drawing.Size(291, 27);
            this.txtSegundoTelefono.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(206, 221);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(291, 27);
            this.txtEmail.TabIndex = 15;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.Silver;
            this.txtDireccion.Location = new System.Drawing.Point(206, 254);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(291, 27);
            this.txtDireccion.TabIndex = 16;
            // 
            // txtLimiteCredito
            // 
            this.txtLimiteCredito.BackColor = System.Drawing.Color.Silver;
            this.txtLimiteCredito.Location = new System.Drawing.Point(206, 287);
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.Size = new System.Drawing.Size(291, 27);
            this.txtLimiteCredito.TabIndex = 17;
            // 
            // txtComentario
            // 
            this.txtComentario.BackColor = System.Drawing.Color.Silver;
            this.txtComentario.Location = new System.Drawing.Point(206, 320);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(291, 27);
            this.txtComentario.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(102, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Comentario:";
            // 
            // cbTieneCredito
            // 
            this.cbTieneCredito.AutoSize = true;
            this.cbTieneCredito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTieneCredito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTieneCredito.Location = new System.Drawing.Point(206, 354);
            this.cbTieneCredito.Name = "cbTieneCredito";
            this.cbTieneCredito.Size = new System.Drawing.Size(127, 24);
            this.cbTieneCredito.TabIndex = 20;
            this.cbTieneCredito.Text = "Tiene Credito";
            this.toolTip1.SetToolTip(this.cbTieneCredito, "Habilitarle credito a este cliente");
            this.cbTieneCredito.UseVisualStyleBackColor = true;
            // 
            // cbEnvioEmail
            // 
            this.cbEnvioEmail.AutoSize = true;
            this.cbEnvioEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEnvioEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEnvioEmail.Location = new System.Drawing.Point(341, 354);
            this.cbEnvioEmail.Name = "cbEnvioEmail";
            this.cbEnvioEmail.Size = new System.Drawing.Size(140, 24);
            this.cbEnvioEmail.TabIndex = 21;
            this.cbEnvioEmail.Text = "Envio de Email";
            this.toolTip1.SetToolTip(this.cbEnvioEmail, "Enviar Email a este cliente");
            this.cbEnvioEmail.UseVisualStyleBackColor = true;
            // 
            // lbClaveSeguridad
            // 
            this.lbClaveSeguridad.AutoSize = true;
            this.lbClaveSeguridad.Location = new System.Drawing.Point(59, 435);
            this.lbClaveSeguridad.Name = "lbClaveSeguridad";
            this.lbClaveSeguridad.Size = new System.Drawing.Size(153, 20);
            this.lbClaveSeguridad.TabIndex = 24;
            this.lbClaveSeguridad.Text = "Clave de Seguridad";
            this.lbClaveSeguridad.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 10;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::DSMarket.Solucion.Properties.Resources.Guardar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(52, 472);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(406, 41);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Accion";
            this.toolTip1.SetToolTip(this.btnGuardar, "Completar Operación");
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtClaveSeguridad
            // 
            this.txtClaveSeguridad.BackColor = System.Drawing.Color.Silver;
            this.txtClaveSeguridad.Location = new System.Drawing.Point(218, 432);
            this.txtClaveSeguridad.MaxLength = 20;
            this.txtClaveSeguridad.Name = "txtClaveSeguridad";
            this.txtClaveSeguridad.Size = new System.Drawing.Size(225, 27);
            this.txtClaveSeguridad.TabIndex = 23;
            this.txtClaveSeguridad.Visible = false;
            // 
            // ClientesMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 532);
            this.Controls.Add(this.lbClaveSeguridad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtClaveSeguridad);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientesMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientesMantenimiento";
            this.Load += new System.EventHandler(this.ClientesMantenimiento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PCerrar;
        public System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtapellidoCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.CheckBox cbEnvioEmail;
        private System.Windows.Forms.CheckBox cbTieneCredito;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.TextBox txtLimiteCredito;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSegundoTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNumeroidentificacionCliente;
        private System.Windows.Forms.ComboBox txtTipoidentificcionCliente;
        private System.Windows.Forms.Label lbClaveSeguridad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtClaveSeguridad;
    }
}