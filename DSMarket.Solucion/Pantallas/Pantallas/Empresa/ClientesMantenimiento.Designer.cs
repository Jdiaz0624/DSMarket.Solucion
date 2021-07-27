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
            this.lbFechaNAcimiento = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.ddlSeleccionarComprobantes = new System.Windows.Forms.ComboBox();
            this.lbComprobante = new System.Windows.Forms.Label();
            this.lbComentario = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.txtLimiteCredito = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNumeroidentificacionCliente = new System.Windows.Forms.TextBox();
            this.ddlTipIdentificacion = new System.Windows.Forms.ComboBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.LimiteCredito = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.lbNumeroIdentificacion = new System.Windows.Forms.Label();
            this.lbTipoIdentificacion = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
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
            this.cbEstatus.Size = new System.Drawing.Size(100, 27);
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
            this.cbEnvioEmail.Size = new System.Drawing.Size(170, 27);
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
            this.cbalertacumpleanos.Size = new System.Drawing.Size(206, 27);
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
            this.lbTitulo.Size = new System.Drawing.Size(65, 23);
            this.lbTitulo.TabIndex = 13;
            this.lbTitulo.Text = "label6";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbFechaNAcimiento);
            this.groupBox1.Controls.Add(this.txtFechaNacimiento);
            this.groupBox1.Controls.Add(this.cbalertacumpleanos);
            this.groupBox1.Controls.Add(this.ddlSeleccionarComprobantes);
            this.groupBox1.Controls.Add(this.lbComprobante);
            this.groupBox1.Controls.Add(this.cbEnvioEmail);
            this.groupBox1.Controls.Add(this.cbEstatus);
            this.groupBox1.Controls.Add(this.lbComentario);
            this.groupBox1.Controls.Add(this.txtComentario);
            this.groupBox1.Controls.Add(this.txtLimiteCredito);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtNumeroidentificacionCliente);
            this.groupBox1.Controls.Add(this.ddlTipIdentificacion);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.LimiteCredito);
            this.groupBox1.Controls.Add(this.Direccion);
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Controls.Add(this.Telefono);
            this.groupBox1.Controls.Add(this.lbNumeroIdentificacion);
            this.groupBox1.Controls.Add(this.lbTipoIdentificacion);
            this.groupBox1.Controls.Add(this.lbNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 382);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // lbFechaNAcimiento
            // 
            this.lbFechaNAcimiento.AutoSize = true;
            this.lbFechaNAcimiento.Location = new System.Drawing.Point(35, 323);
            this.lbFechaNAcimiento.Name = "lbFechaNAcimiento";
            this.lbFechaNAcimiento.Size = new System.Drawing.Size(210, 23);
            this.lbFechaNAcimiento.TabIndex = 26;
            this.lbFechaNAcimiento.Text = "Fecha de Nacimiento:";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(206, 320);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(135, 32);
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
            this.ddlSeleccionarComprobantes.Size = new System.Drawing.Size(291, 31);
            this.ddlSeleccionarComprobantes.TabIndex = 23;
            // 
            // lbComprobante
            // 
            this.lbComprobante.AutoSize = true;
            this.lbComprobante.Location = new System.Drawing.Point(93, 59);
            this.lbComprobante.Name = "lbComprobante";
            this.lbComprobante.Size = new System.Drawing.Size(134, 23);
            this.lbComprobante.TabIndex = 22;
            this.lbComprobante.Text = "Comprobante";
            // 
            // lbComentario
            // 
            this.lbComentario.AutoSize = true;
            this.lbComentario.Location = new System.Drawing.Point(102, 291);
            this.lbComentario.Name = "lbComentario";
            this.lbComentario.Size = new System.Drawing.Size(124, 23);
            this.lbComentario.TabIndex = 19;
            this.lbComentario.Text = "Comentario:";
            // 
            // txtComentario
            // 
            this.txtComentario.BackColor = System.Drawing.Color.Silver;
            this.txtComentario.Location = new System.Drawing.Point(206, 287);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(291, 32);
            this.txtComentario.TabIndex = 18;
            // 
            // txtLimiteCredito
            // 
            this.txtLimiteCredito.BackColor = System.Drawing.Color.Silver;
            this.txtLimiteCredito.Location = new System.Drawing.Point(206, 254);
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.Size = new System.Drawing.Size(291, 32);
            this.txtLimiteCredito.TabIndex = 17;
            this.txtLimiteCredito.Text = "0";
            this.txtLimiteCredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLimiteCredito_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.Silver;
            this.txtDireccion.Location = new System.Drawing.Point(206, 221);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(291, 32);
            this.txtDireccion.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Silver;
            this.txtEmail.Location = new System.Drawing.Point(206, 188);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(291, 32);
            this.txtEmail.TabIndex = 15;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Silver;
            this.txtTelefono.Location = new System.Drawing.Point(206, 155);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(291, 32);
            this.txtTelefono.TabIndex = 13;
            // 
            // txtNumeroidentificacionCliente
            // 
            this.txtNumeroidentificacionCliente.BackColor = System.Drawing.Color.Silver;
            this.txtNumeroidentificacionCliente.Location = new System.Drawing.Point(206, 122);
            this.txtNumeroidentificacionCliente.Name = "txtNumeroidentificacionCliente";
            this.txtNumeroidentificacionCliente.Size = new System.Drawing.Size(291, 32);
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
            this.ddlTipIdentificacion.Size = new System.Drawing.Size(291, 31);
            this.ddlTipIdentificacion.TabIndex = 11;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.Color.Silver;
            this.txtNombreCliente.Location = new System.Drawing.Point(206, 26);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(291, 32);
            this.txtNombreCliente.TabIndex = 9;
            // 
            // LimiteCredito
            // 
            this.LimiteCredito.AutoSize = true;
            this.LimiteCredito.Location = new System.Drawing.Point(60, 257);
            this.LimiteCredito.Name = "LimiteCredito";
            this.LimiteCredito.Size = new System.Drawing.Size(178, 23);
            this.LimiteCredito.TabIndex = 8;
            this.LimiteCredito.Text = "Limite de Credito:";
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Location = new System.Drawing.Point(120, 224);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(103, 23);
            this.Direccion.TabIndex = 7;
            this.Direccion.Text = "Dirección:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(144, 191);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(71, 23);
            this.lbEmail.TabIndex = 6;
            this.lbEmail.Text = "Email:";
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Location = new System.Drawing.Point(126, 158);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(94, 23);
            this.Telefono.TabIndex = 4;
            this.Telefono.Text = "Telefono:";
            // 
            // lbNumeroIdentificacion
            // 
            this.lbNumeroIdentificacion.AutoSize = true;
            this.lbNumeroIdentificacion.Location = new System.Drawing.Point(9, 125);
            this.lbNumeroIdentificacion.Name = "lbNumeroIdentificacion";
            this.lbNumeroIdentificacion.Size = new System.Drawing.Size(241, 23);
            this.lbNumeroIdentificacion.TabIndex = 3;
            this.lbNumeroIdentificacion.Text = "Numero de Idenificación:";
            // 
            // lbTipoIdentificacion
            // 
            this.lbTipoIdentificacion.AutoSize = true;
            this.lbTipoIdentificacion.Location = new System.Drawing.Point(53, 91);
            this.lbTipoIdentificacion.Name = "lbTipoIdentificacion";
            this.lbTipoIdentificacion.Size = new System.Drawing.Size(185, 23);
            this.lbTipoIdentificacion.TabIndex = 2;
            this.lbTipoIdentificacion.Text = "Tipo identificación:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(130, 29);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(90, 23);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbClaveSeguridad
            // 
            this.lbClaveSeguridad.AutoSize = true;
            this.lbClaveSeguridad.Location = new System.Drawing.Point(72, 436);
            this.lbClaveSeguridad.Name = "lbClaveSeguridad";
            this.lbClaveSeguridad.Size = new System.Drawing.Size(189, 23);
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
            this.txtClaveSeguridad.Size = new System.Drawing.Size(225, 32);
            this.txtClaveSeguridad.TabIndex = 23;
            this.txtClaveSeguridad.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ClientesMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
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
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.Label lbNumeroIdentificacion;
        private System.Windows.Forms.Label lbTipoIdentificacion;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label LimiteCredito;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.CheckBox cbEnvioEmail;
        private System.Windows.Forms.CheckBox cbEstatus;
        private System.Windows.Forms.Label lbComentario;
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
        private System.Windows.Forms.Label lbComprobante;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbFechaNAcimiento;
        private System.Windows.Forms.DateTimePicker txtFechaNacimiento;
        private System.Windows.Forms.CheckBox cbalertacumpleanos;
    }
}