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
            this.cbEstatus = new System.Windows.Forms.CheckBox();
            this.cbEnvioEmail = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbalertacumpleanos = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PCerrar = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.ddlSeleccionarComprobantes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.txtLimiteCredito = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNumeroidentificacionCliente = new System.Windows.Forms.TextBox();
            this.ddlTipIdentificacion = new System.Windows.Forms.ComboBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbClaveSeguridad = new System.Windows.Forms.Label();
            this.txtClaveSeguridad = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // cbEstatus
            // 
            this.cbEstatus.AutoSize = true;
            this.cbEstatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEstatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEstatus.Location = new System.Drawing.Point(134, 352);
            this.cbEstatus.Name = "cbEstatus";
            this.cbEstatus.Size = new System.Drawing.Size(83, 24);
            this.cbEstatus.TabIndex = 20;
            this.cbEstatus.Text = "Estatus";
            this.toolTip1.SetToolTip(this.cbEstatus, "Estatus de Cliente");
            this.cbEstatus.UseVisualStyleBackColor = true;
            // 
            // cbEnvioEmail
            // 
            this.cbEnvioEmail.AutoSize = true;
            this.cbEnvioEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEnvioEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbEnvioEmail.Location = new System.Drawing.Point(219, 352);
            this.cbEnvioEmail.Name = "cbEnvioEmail";
            this.cbEnvioEmail.Size = new System.Drawing.Size(140, 24);
            this.cbEnvioEmail.TabIndex = 21;
            this.cbEnvioEmail.Text = "Envio de Email";
            this.toolTip1.SetToolTip(this.cbEnvioEmail, "Enviar Email a este cliente");
            this.cbEnvioEmail.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 10;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::DSMarket.Solucion.Properties.Resources.Guardar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(55, 466);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(491, 41);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "Accion";
            this.toolTip1.SetToolTip(this.btnGuardar, "Completar Operación");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbalertacumpleanos
            // 
            this.cbalertacumpleanos.AutoSize = true;
            this.cbalertacumpleanos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbalertacumpleanos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbalertacumpleanos.Location = new System.Drawing.Point(365, 352);
            this.cbalertacumpleanos.Name = "cbalertacumpleanos";
            this.cbalertacumpleanos.Size = new System.Drawing.Size(169, 24);
            this.cbalertacumpleanos.TabIndex = 24;
            this.cbalertacumpleanos.Text = "Alerta Cumpleaños";
            this.toolTip1.SetToolTip(this.cbalertacumpleanos, "Alerta Cumpleaños");
            this.cbalertacumpleanos.UseVisualStyleBackColor = true;
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
            this.panel1.Size = new System.Drawing.Size(571, 38);
            this.panel1.TabIndex = 78;
            // 
            // PCerrar
            // 
            this.PCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PCerrar.Image = global::DSMarket.Solucion.Properties.Resources.Close_Window__2_48px;
            this.PCerrar.Location = new System.Drawing.Point(529, 5);
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
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFechaNacimiento);
            this.groupBox1.Controls.Add(this.cbalertacumpleanos);
            this.groupBox1.Controls.Add(this.ddlSeleccionarComprobantes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbEnvioEmail);
            this.groupBox1.Controls.Add(this.cbEstatus);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtComentario);
            this.groupBox1.Controls.Add(this.txtLimiteCredito);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtNumeroidentificacionCliente);
            this.groupBox1.Controls.Add(this.ddlTipIdentificacion);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 382);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Fecha de Nacimiento:";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(206, 320);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(135, 27);
            this.txtFechaNacimiento.TabIndex = 25;
            // 
            // ddlSeleccionarComprobantes
            // 
            this.ddlSeleccionarComprobantes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ddlSeleccionarComprobantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlSeleccionarComprobantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSeleccionarComprobantes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlSeleccionarComprobantes.FormattingEnabled = true;
            this.ddlSeleccionarComprobantes.Location = new System.Drawing.Point(206, 55);
            this.ddlSeleccionarComprobantes.Name = "ddlSeleccionarComprobantes";
            this.ddlSeleccionarComprobantes.Size = new System.Drawing.Size(291, 28);
            this.ddlSeleccionarComprobantes.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Comprobante";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(102, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Comentario:";
            // 
            // txtComentario
            // 
            this.txtComentario.BackColor = System.Drawing.Color.Silver;
            this.txtComentario.Location = new System.Drawing.Point(206, 287);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(291, 27);
            this.txtComentario.TabIndex = 18;
            // 
            // txtLimiteCredito
            // 
            this.txtLimiteCredito.BackColor = System.Drawing.Color.Silver;
            this.txtLimiteCredito.Location = new System.Drawing.Point(206, 254);
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.Size = new System.Drawing.Size(291, 27);
            this.txtLimiteCredito.TabIndex = 17;
            this.txtLimiteCredito.Text = "0";
            this.txtLimiteCredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLimiteCredito_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.Silver;
            this.txtDireccion.Location = new System.Drawing.Point(206, 221);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(291, 27);
            this.txtDireccion.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(206, 188);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(291, 27);
            this.txtEmail.TabIndex = 15;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Silver;
            this.txtTelefono.Location = new System.Drawing.Point(206, 155);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(291, 27);
            this.txtTelefono.TabIndex = 13;
            // 
            // txtNumeroidentificacionCliente
            // 
            this.txtNumeroidentificacionCliente.BackColor = System.Drawing.Color.Silver;
            this.txtNumeroidentificacionCliente.Location = new System.Drawing.Point(206, 122);
            this.txtNumeroidentificacionCliente.Name = "txtNumeroidentificacionCliente";
            this.txtNumeroidentificacionCliente.Size = new System.Drawing.Size(291, 27);
            this.txtNumeroidentificacionCliente.TabIndex = 12;
            // 
            // ddlTipIdentificacion
            // 
            this.ddlTipIdentificacion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ddlTipIdentificacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlTipIdentificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTipIdentificacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlTipIdentificacion.FormattingEnabled = true;
            this.ddlTipIdentificacion.Location = new System.Drawing.Point(206, 88);
            this.ddlTipIdentificacion.Name = "ddlTipIdentificacion";
            this.ddlTipIdentificacion.Size = new System.Drawing.Size(291, 28);
            this.ddlTipIdentificacion.TabIndex = 11;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.Color.Silver;
            this.txtNombreCliente.Location = new System.Drawing.Point(206, 26);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(291, 27);
            this.txtNombreCliente.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Limite de Credito:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Dirección:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Numero de Idenificación:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // lbClaveSeguridad
            // 
            this.lbClaveSeguridad.AutoSize = true;
            this.lbClaveSeguridad.Location = new System.Drawing.Point(72, 436);
            this.lbClaveSeguridad.Name = "lbClaveSeguridad";
            this.lbClaveSeguridad.Size = new System.Drawing.Size(153, 20);
            this.lbClaveSeguridad.TabIndex = 24;
            this.lbClaveSeguridad.Text = "Clave de Seguridad";
            this.lbClaveSeguridad.Visible = false;
            // 
            // txtClaveSeguridad
            // 
            this.txtClaveSeguridad.BackColor = System.Drawing.Color.Silver;
            this.txtClaveSeguridad.Location = new System.Drawing.Point(231, 433);
            this.txtClaveSeguridad.MaxLength = 20;
            this.txtClaveSeguridad.Name = "txtClaveSeguridad";
            this.txtClaveSeguridad.PasswordChar = '•';
            this.txtClaveSeguridad.Size = new System.Drawing.Size(225, 27);
            this.txtClaveSeguridad.TabIndex = 23;
            this.txtClaveSeguridad.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ClientesMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 522);
            this.Controls.Add(this.lbClaveSeguridad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtClaveSeguridad);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.CheckBox cbEnvioEmail;
        private System.Windows.Forms.CheckBox cbEstatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.TextBox txtLimiteCredito;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNumeroidentificacionCliente;
        private System.Windows.Forms.ComboBox ddlTipIdentificacion;
        private System.Windows.Forms.Label lbClaveSeguridad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtClaveSeguridad;
        private System.Windows.Forms.ComboBox ddlSeleccionarComprobantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtFechaNacimiento;
        private System.Windows.Forms.CheckBox cbalertacumpleanos;
    }
}