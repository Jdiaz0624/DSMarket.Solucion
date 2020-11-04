namespace DSMarket.Solucion.Pantallas.Pantallas.Seguridad
{
    partial class Login
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNombreEmpresa = new System.Windows.Forms.Label();
            this.btnMiniminzar = new System.Windows.Forms.PictureBox();
            this.PCerrar = new System.Windows.Forms.PictureBox();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.pbLogolargo = new System.Windows.Forms.PictureBox();
            this.btnServicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Efecto = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.EfectosBotones = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMiniminzar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).BeginInit();
            this.gbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogolargo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbNombreEmpresa);
            this.panel1.Controls.Add(this.btnMiniminzar);
            this.panel1.Controls.Add(this.PCerrar);
            this.EfectosBotones.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.Efecto.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 53);
            this.panel1.TabIndex = 0;
            // 
            // lbNombreEmpresa
            // 
            this.lbNombreEmpresa.AutoSize = true;
            this.Efecto.SetDecoration(this.lbNombreEmpresa, BunifuAnimatorNS.DecorationType.None);
            this.EfectosBotones.SetDecoration(this.lbNombreEmpresa, BunifuAnimatorNS.DecorationType.None);
            this.lbNombreEmpresa.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreEmpresa.ForeColor = System.Drawing.SystemColors.Control;
            this.lbNombreEmpresa.Location = new System.Drawing.Point(12, 12);
            this.lbNombreEmpresa.Name = "lbNombreEmpresa";
            this.lbNombreEmpresa.Size = new System.Drawing.Size(314, 29);
            this.lbNombreEmpresa.TabIndex = 8;
            this.lbNombreEmpresa.Text = "NOMBRE DE EMPRESA";
            // 
            // btnMiniminzar
            // 
            this.btnMiniminzar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMiniminzar.BackColor = System.Drawing.Color.Transparent;
            this.btnMiniminzar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Efecto.SetDecoration(this.btnMiniminzar, BunifuAnimatorNS.DecorationType.None);
            this.EfectosBotones.SetDecoration(this.btnMiniminzar, BunifuAnimatorNS.DecorationType.None);
            this.btnMiniminzar.Image = global::DSMarket.Solucion.Properties.Resources.Minimize_Window_2_48px;
            this.btnMiniminzar.Location = new System.Drawing.Point(560, 12);
            this.btnMiniminzar.Name = "btnMiniminzar";
            this.btnMiniminzar.Size = new System.Drawing.Size(30, 30);
            this.btnMiniminzar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMiniminzar.TabIndex = 3;
            this.btnMiniminzar.TabStop = false;
            this.btnMiniminzar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PCerrar
            // 
            this.PCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PCerrar.BackColor = System.Drawing.Color.Transparent;
            this.PCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Efecto.SetDecoration(this.PCerrar, BunifuAnimatorNS.DecorationType.None);
            this.EfectosBotones.SetDecoration(this.PCerrar, BunifuAnimatorNS.DecorationType.None);
            this.PCerrar.Image = global::DSMarket.Solucion.Properties.Resources.Close_Window__2_48px;
            this.PCerrar.Location = new System.Drawing.Point(596, 12);
            this.PCerrar.Name = "PCerrar";
            this.PCerrar.Size = new System.Drawing.Size(30, 30);
            this.PCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCerrar.TabIndex = 2;
            this.PCerrar.TabStop = false;
            this.PCerrar.Click += new System.EventHandler(this.PCerrar_Click);
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.pbLogolargo);
            this.gbLogin.Controls.Add(this.btnServicio);
            this.gbLogin.Controls.Add(this.txtclave);
            this.gbLogin.Controls.Add(this.txtUsuario);
            this.gbLogin.Controls.Add(this.label2);
            this.gbLogin.Controls.Add(this.label1);
            this.EfectosBotones.SetDecoration(this.gbLogin, BunifuAnimatorNS.DecorationType.None);
            this.Efecto.SetDecoration(this.gbLogin, BunifuAnimatorNS.DecorationType.None);
            this.gbLogin.Location = new System.Drawing.Point(30, 78);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(596, 296);
            this.gbLogin.TabIndex = 1;
            this.gbLogin.TabStop = false;
            // 
            // pbLogolargo
            // 
            this.pbLogolargo.BackColor = System.Drawing.Color.Transparent;
            this.Efecto.SetDecoration(this.pbLogolargo, BunifuAnimatorNS.DecorationType.None);
            this.EfectosBotones.SetDecoration(this.pbLogolargo, BunifuAnimatorNS.DecorationType.None);
            this.pbLogolargo.Image = global::DSMarket.Solucion.Properties.Resources.DeveSoft;
            this.pbLogolargo.Location = new System.Drawing.Point(452, 10);
            this.pbLogolargo.Name = "pbLogolargo";
            this.pbLogolargo.Size = new System.Drawing.Size(140, 23);
            this.pbLogolargo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogolargo.TabIndex = 8;
            this.pbLogolargo.TabStop = false;
            // 
            // btnServicio
            // 
            this.btnServicio.Active = false;
            this.btnServicio.Activecolor = System.Drawing.Color.Transparent;
            this.btnServicio.BackColor = System.Drawing.Color.Transparent;
            this.btnServicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServicio.BorderRadius = 0;
            this.btnServicio.ButtonText = "      ENTRAR";
            this.btnServicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectosBotones.SetDecoration(this.btnServicio, BunifuAnimatorNS.DecorationType.None);
            this.Efecto.SetDecoration(this.btnServicio, BunifuAnimatorNS.DecorationType.None);
            this.btnServicio.DisabledColor = System.Drawing.Color.Gray;
            this.btnServicio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnServicio.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnServicio.Iconimage")));
            this.btnServicio.Iconimage_right = null;
            this.btnServicio.Iconimage_right_Selected = null;
            this.btnServicio.Iconimage_Selected = null;
            this.btnServicio.IconMarginLeft = 0;
            this.btnServicio.IconMarginRight = 0;
            this.btnServicio.IconRightVisible = true;
            this.btnServicio.IconRightZoom = 0D;
            this.btnServicio.IconVisible = true;
            this.btnServicio.IconZoom = 90D;
            this.btnServicio.IsTab = false;
            this.btnServicio.Location = new System.Drawing.Point(241, 189);
            this.btnServicio.Name = "btnServicio";
            this.btnServicio.Normalcolor = System.Drawing.Color.Transparent;
            this.btnServicio.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnServicio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnServicio.selected = false;
            this.btnServicio.Size = new System.Drawing.Size(172, 48);
            this.btnServicio.TabIndex = 7;
            this.btnServicio.Text = "      ENTRAR";
            this.btnServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicio.Textcolor = System.Drawing.Color.White;
            this.btnServicio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicio.Click += new System.EventHandler(this.btnServicio_Click);
            // 
            // txtclave
            // 
            this.Efecto.SetDecoration(this.txtclave, BunifuAnimatorNS.DecorationType.None);
            this.EfectosBotones.SetDecoration(this.txtclave, BunifuAnimatorNS.DecorationType.None);
            this.txtclave.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclave.Location = new System.Drawing.Point(185, 134);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(356, 36);
            this.txtclave.TabIndex = 3;
            this.txtclave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtclave_KeyDown);
            this.txtclave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtclave_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Efecto.SetDecoration(this.txtUsuario, BunifuAnimatorNS.DecorationType.None);
            this.EfectosBotones.SetDecoration(this.txtUsuario, BunifuAnimatorNS.DecorationType.None);
            this.txtUsuario.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(185, 94);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(356, 36);
            this.txtUsuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.Efecto.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.EfectosBotones.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(108, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.Efecto.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.EfectosBotones.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(81, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // Efecto
            // 
            this.Efecto.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.Efecto.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Efecto.DefaultAnimation = animation1;
            // 
            // EfectosBotones
            // 
            this.EfectosBotones.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.EfectosBotones.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 1;
            animation2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 2F;
            animation2.TransparencyCoeff = 0F;
            this.EfectosBotones.DefaultAnimation = animation2;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 65;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(652, 414);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.panel1);
            this.Efecto.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.EfectosBotones.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMiniminzar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).EndInit();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogolargo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.PictureBox btnMiniminzar;
        private System.Windows.Forms.PictureBox PCerrar;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnServicio;
        private System.Windows.Forms.Label lbNombreEmpresa;
        private BunifuAnimatorNS.BunifuTransition Efecto;
        private BunifuAnimatorNS.BunifuTransition EfectosBotones;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pbLogolargo;
    }
}