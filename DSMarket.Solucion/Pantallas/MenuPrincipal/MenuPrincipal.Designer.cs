namespace DSMarket.Solucion.Pantallas.MenuPrincipal
{
    partial class MenuPrincipal
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.PanelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PanelCuerpo = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Curva = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CurvaForms = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.EfectoIda = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.EfectoBotones = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnServicio = new System.Windows.Forms.Button();
            this.PanelOpciones = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbLogoCorto = new System.Windows.Forms.PictureBox();
            this.Separador = new Bunifu.Framework.UI.BunifuSeparator();
            this.pbLogolargo = new System.Windows.Forms.PictureBox();
            this.PRestaurar = new System.Windows.Forms.PictureBox();
            this.PMinimizar = new System.Windows.Forms.PictureBox();
            this.PMaximizar = new System.Windows.Forms.PictureBox();
            this.PCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnCaja = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnNomina = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnSeguridad = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.PanelTop.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.PanelCuerpo.SuspendLayout();
            this.PanelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbLogoCorto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogolargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.PanelTop.Controls.Add(this.PRestaurar);
            this.PanelTop.Controls.Add(this.label1);
            this.PanelTop.Controls.Add(this.PMinimizar);
            this.PanelTop.Controls.Add(this.PMaximizar);
            this.PanelTop.Controls.Add(this.PCerrar);
            this.PanelTop.Controls.Add(this.pictureBox1);
            this.EfectoBotones.SetDecoration(this.PanelTop, BunifuAnimatorNS.DecorationType.None);
            this.EfectoIda.SetDecoration(this.PanelTop, BunifuAnimatorNS.DecorationType.None);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1400, 80);
            this.PanelTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.EfectoIda.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.EfectoBotones.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(48, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Empresa";
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.PanelMenu.Controls.Add(this.PanelOpciones);
            this.EfectoBotones.SetDecoration(this.PanelMenu, BunifuAnimatorNS.DecorationType.None);
            this.EfectoIda.SetDecoration(this.PanelMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 80);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(300, 820);
            this.PanelMenu.TabIndex = 1;
            // 
            // PanelCuerpo
            // 
            this.PanelCuerpo.Controls.Add(this.label3);
            this.PanelCuerpo.Controls.Add(this.label2);
            this.EfectoBotones.SetDecoration(this.PanelCuerpo, BunifuAnimatorNS.DecorationType.None);
            this.EfectoIda.SetDecoration(this.PanelCuerpo, BunifuAnimatorNS.DecorationType.None);
            this.PanelCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCuerpo.Location = new System.Drawing.Point(300, 80);
            this.PanelCuerpo.Name = "PanelCuerpo";
            this.PanelCuerpo.Size = new System.Drawing.Size(1100, 820);
            this.PanelCuerpo.TabIndex = 1;
            // 
            // Curva
            // 
            this.Curva.ElipseRadius = 10;
            this.Curva.TargetControl = this.PanelOpciones;
            // 
            // CurvaForms
            // 
            this.CurvaForms.ElipseRadius = 20;
            this.CurvaForms.TargetControl = this;
            // 
            // EfectoIda
            // 
            this.EfectoIda.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.EfectoIda.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 20;
            animation3.Padding = new System.Windows.Forms.Padding(30);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.EfectoIda.DefaultAnimation = animation3;
            // 
            // EfectoBotones
            // 
            this.EfectoBotones.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.EfectoBotones.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.EfectoBotones.DefaultAnimation = animation4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.EfectoIda.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.EfectoBotones.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 789);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario Conectado";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.EfectoIda.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.EfectoBotones.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(429, 789);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nivel de Acceso";
            // 
            // btnServicio
            // 
            this.btnServicio.BackColor = System.Drawing.Color.Transparent;
            this.btnServicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.btnServicio, BunifuAnimatorNS.DecorationType.None);
            this.EfectoBotones.SetDecoration(this.btnServicio, BunifuAnimatorNS.DecorationType.None);
            this.btnServicio.FlatAppearance.BorderSize = 0;
            this.btnServicio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnServicio.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicio.ForeColor = System.Drawing.Color.White;
            this.btnServicio.Image = global::DSMarket.Solucion.Properties.Resources.Ventas_48px;
            this.btnServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicio.Location = new System.Drawing.Point(12, 83);
            this.btnServicio.Name = "btnServicio";
            this.btnServicio.Size = new System.Drawing.Size(241, 48);
            this.btnServicio.TabIndex = 7;
            this.btnServicio.Text = "      SERVICIO";
            this.btnServicio.UseVisualStyleBackColor = false;
            this.btnServicio.Click += new System.EventHandler(this.btnServicio_Click_1);
            // 
            // PanelOpciones
            // 
            this.PanelOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelOpciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelOpciones.BackgroundImage")));
            this.PanelOpciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelOpciones.Controls.Add(this.btnCerrarSesion);
            this.PanelOpciones.Controls.Add(this.btnSeguridad);
            this.PanelOpciones.Controls.Add(this.btnConfiguracion);
            this.PanelOpciones.Controls.Add(this.btnNomina);
            this.PanelOpciones.Controls.Add(this.btnClientes);
            this.PanelOpciones.Controls.Add(this.btnCaja);
            this.PanelOpciones.Controls.Add(this.btnInventario);
            this.PanelOpciones.Controls.Add(this.btnServicio);
            this.PanelOpciones.Controls.Add(this.lbLogoCorto);
            this.PanelOpciones.Controls.Add(this.Separador);
            this.PanelOpciones.Controls.Add(this.pbLogolargo);
            this.EfectoBotones.SetDecoration(this.PanelOpciones, BunifuAnimatorNS.DecorationType.None);
            this.EfectoIda.SetDecoration(this.PanelOpciones, BunifuAnimatorNS.DecorationType.None);
            this.PanelOpciones.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.PanelOpciones.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.PanelOpciones.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(21)))), ((int)(((byte)(80)))));
            this.PanelOpciones.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.PanelOpciones.Location = new System.Drawing.Point(12, 6);
            this.PanelOpciones.Name = "PanelOpciones";
            this.PanelOpciones.Quality = 10;
            this.PanelOpciones.Size = new System.Drawing.Size(270, 793);
            this.PanelOpciones.TabIndex = 0;
            // 
            // lbLogoCorto
            // 
            this.lbLogoCorto.BackColor = System.Drawing.Color.Transparent;
            this.EfectoIda.SetDecoration(this.lbLogoCorto, BunifuAnimatorNS.DecorationType.None);
            this.EfectoBotones.SetDecoration(this.lbLogoCorto, BunifuAnimatorNS.DecorationType.None);
            this.lbLogoCorto.Image = global::DSMarket.Solucion.Properties.Resources.Iniciales;
            this.lbLogoCorto.Location = new System.Drawing.Point(3, 3);
            this.lbLogoCorto.Name = "lbLogoCorto";
            this.lbLogoCorto.Size = new System.Drawing.Size(60, 44);
            this.lbLogoCorto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lbLogoCorto.TabIndex = 15;
            this.lbLogoCorto.TabStop = false;
            this.lbLogoCorto.Visible = false;
            // 
            // Separador
            // 
            this.Separador.BackColor = System.Drawing.Color.Transparent;
            this.EfectoBotones.SetDecoration(this.Separador, BunifuAnimatorNS.DecorationType.None);
            this.EfectoIda.SetDecoration(this.Separador, BunifuAnimatorNS.DecorationType.None);
            this.Separador.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Separador.LineThickness = 1;
            this.Separador.Location = new System.Drawing.Point(9, 53);
            this.Separador.Name = "Separador";
            this.Separador.Size = new System.Drawing.Size(250, 1);
            this.Separador.TabIndex = 0;
            this.Separador.Transparency = 255;
            this.Separador.Vertical = false;
            // 
            // pbLogolargo
            // 
            this.pbLogolargo.BackColor = System.Drawing.Color.Transparent;
            this.EfectoIda.SetDecoration(this.pbLogolargo, BunifuAnimatorNS.DecorationType.None);
            this.EfectoBotones.SetDecoration(this.pbLogolargo, BunifuAnimatorNS.DecorationType.None);
            this.pbLogolargo.Image = global::DSMarket.Solucion.Properties.Resources.DeveSoft;
            this.pbLogolargo.Location = new System.Drawing.Point(4, 3);
            this.pbLogolargo.Name = "pbLogolargo";
            this.pbLogolargo.Size = new System.Drawing.Size(256, 44);
            this.pbLogolargo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogolargo.TabIndex = 5;
            this.pbLogolargo.TabStop = false;
            // 
            // PRestaurar
            // 
            this.PRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.PRestaurar, BunifuAnimatorNS.DecorationType.None);
            this.EfectoBotones.SetDecoration(this.PRestaurar, BunifuAnimatorNS.DecorationType.None);
            this.PRestaurar.Image = global::DSMarket.Solucion.Properties.Resources.Restore_Window_2_48px;
            this.PRestaurar.Location = new System.Drawing.Point(1326, 29);
            this.PRestaurar.Name = "PRestaurar";
            this.PRestaurar.Size = new System.Drawing.Size(30, 30);
            this.PRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PRestaurar.TabIndex = 4;
            this.PRestaurar.TabStop = false;
            this.toolTip1.SetToolTip(this.PRestaurar, "Restaurar");
            this.PRestaurar.Visible = false;
            this.PRestaurar.Click += new System.EventHandler(this.PRestaurar_Click);
            // 
            // PMinimizar
            // 
            this.PMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.PMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.EfectoBotones.SetDecoration(this.PMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.PMinimizar.Image = global::DSMarket.Solucion.Properties.Resources.Minimize_Window_2_48px;
            this.PMinimizar.Location = new System.Drawing.Point(1294, 29);
            this.PMinimizar.Name = "PMinimizar";
            this.PMinimizar.Size = new System.Drawing.Size(30, 30);
            this.PMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PMinimizar.TabIndex = 3;
            this.PMinimizar.TabStop = false;
            this.toolTip1.SetToolTip(this.PMinimizar, "Minimizar");
            this.PMinimizar.Click += new System.EventHandler(this.PMinimizar_Click);
            // 
            // PMaximizar
            // 
            this.PMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.PMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.EfectoBotones.SetDecoration(this.PMaximizar, BunifuAnimatorNS.DecorationType.None);
            this.PMaximizar.Image = global::DSMarket.Solucion.Properties.Resources.Maximize_Window_2_48px;
            this.PMaximizar.Location = new System.Drawing.Point(1326, 29);
            this.PMaximizar.Name = "PMaximizar";
            this.PMaximizar.Size = new System.Drawing.Size(30, 30);
            this.PMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PMaximizar.TabIndex = 2;
            this.PMaximizar.TabStop = false;
            this.toolTip1.SetToolTip(this.PMaximizar, "Maximizar");
            this.PMaximizar.Click += new System.EventHandler(this.PMaximizar_Click);
            // 
            // PCerrar
            // 
            this.PCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.PCerrar, BunifuAnimatorNS.DecorationType.None);
            this.EfectoBotones.SetDecoration(this.PCerrar, BunifuAnimatorNS.DecorationType.None);
            this.PCerrar.Image = global::DSMarket.Solucion.Properties.Resources.Close_Window__2_48px;
            this.PCerrar.Location = new System.Drawing.Point(1358, 29);
            this.PCerrar.Name = "PCerrar";
            this.PCerrar.Size = new System.Drawing.Size(30, 30);
            this.PCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCerrar.TabIndex = 1;
            this.PCerrar.TabStop = false;
            this.toolTip1.SetToolTip(this.PCerrar, "Salir del Sistema");
            this.PCerrar.Click += new System.EventHandler(this.PCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.EfectoBotones.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::DSMarket.Solucion.Properties.Resources.Menu_48px;
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.Transparent;
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.btnInventario, BunifuAnimatorNS.DecorationType.None);
            this.EfectoBotones.SetDecoration(this.btnInventario, BunifuAnimatorNS.DecorationType.None);
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInventario.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Image = global::DSMarket.Solucion.Properties.Resources.Ventas_48px;
            this.btnInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.Location = new System.Drawing.Point(12, 133);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(241, 48);
            this.btnInventario.TabIndex = 16;
            this.btnInventario.Text = "      SERVICIO";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click_1);
            // 
            // btnCaja
            // 
            this.btnCaja.BackColor = System.Drawing.Color.Transparent;
            this.btnCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.btnCaja, BunifuAnimatorNS.DecorationType.None);
            this.EfectoBotones.SetDecoration(this.btnCaja, BunifuAnimatorNS.DecorationType.None);
            this.btnCaja.FlatAppearance.BorderSize = 0;
            this.btnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCaja.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaja.ForeColor = System.Drawing.Color.White;
            this.btnCaja.Image = global::DSMarket.Solucion.Properties.Resources.Ventas_48px;
            this.btnCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaja.Location = new System.Drawing.Point(12, 184);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(241, 48);
            this.btnCaja.TabIndex = 17;
            this.btnCaja.Text = "      SERVICIO";
            this.btnCaja.UseVisualStyleBackColor = false;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click_1);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
            this.EfectoBotones.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = global::DSMarket.Solucion.Properties.Resources.Ventas_48px;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(12, 235);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(241, 48);
            this.btnClientes.TabIndex = 18;
            this.btnClientes.Text = "      SERVICIO";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click_1);
            // 
            // btnNomina
            // 
            this.btnNomina.BackColor = System.Drawing.Color.Transparent;
            this.btnNomina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.btnNomina, BunifuAnimatorNS.DecorationType.None);
            this.EfectoBotones.SetDecoration(this.btnNomina, BunifuAnimatorNS.DecorationType.None);
            this.btnNomina.FlatAppearance.BorderSize = 0;
            this.btnNomina.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNomina.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNomina.ForeColor = System.Drawing.Color.White;
            this.btnNomina.Image = global::DSMarket.Solucion.Properties.Resources.Ventas_48px;
            this.btnNomina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNomina.Location = new System.Drawing.Point(12, 286);
            this.btnNomina.Name = "btnNomina";
            this.btnNomina.Size = new System.Drawing.Size(241, 48);
            this.btnNomina.TabIndex = 19;
            this.btnNomina.Text = "      SERVICIO";
            this.btnNomina.UseVisualStyleBackColor = false;
            this.btnNomina.Click += new System.EventHandler(this.btnNomina_Click_1);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.btnCerrarSesion, BunifuAnimatorNS.DecorationType.None);
            this.EfectoBotones.SetDecoration(this.btnCerrarSesion, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = global::DSMarket.Solucion.Properties.Resources.Ventas_48px;
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesion.Location = new System.Drawing.Point(12, 439);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(241, 48);
            this.btnCerrarSesion.TabIndex = 22;
            this.btnCerrarSesion.Text = "      SERVICIO";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click_1);
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.BackColor = System.Drawing.Color.Transparent;
            this.btnSeguridad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.btnSeguridad, BunifuAnimatorNS.DecorationType.None);
            this.EfectoBotones.SetDecoration(this.btnSeguridad, BunifuAnimatorNS.DecorationType.None);
            this.btnSeguridad.FlatAppearance.BorderSize = 0;
            this.btnSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeguridad.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguridad.ForeColor = System.Drawing.Color.White;
            this.btnSeguridad.Image = global::DSMarket.Solucion.Properties.Resources.Ventas_48px;
            this.btnSeguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridad.Location = new System.Drawing.Point(12, 388);
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.Size = new System.Drawing.Size(241, 48);
            this.btnSeguridad.TabIndex = 21;
            this.btnSeguridad.Text = "      SERVICIO";
            this.btnSeguridad.UseVisualStyleBackColor = false;
            this.btnSeguridad.Click += new System.EventHandler(this.btnSeguridad_Click_1);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EfectoIda.SetDecoration(this.btnConfiguracion, BunifuAnimatorNS.DecorationType.None);
            this.EfectoBotones.SetDecoration(this.btnConfiguracion, BunifuAnimatorNS.DecorationType.None);
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfiguracion.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracion.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracion.Image = global::DSMarket.Solucion.Properties.Resources.Ventas_48px;
            this.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.Location = new System.Drawing.Point(12, 337);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(241, 48);
            this.btnConfiguracion.TabIndex = 20;
            this.btnConfiguracion.Text = "      SERVICIO";
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click_1);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.PanelCuerpo);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.PanelTop);
            this.EfectoBotones.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.EfectoIda.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.PanelMenu.ResumeLayout(false);
            this.PanelCuerpo.ResumeLayout(false);
            this.PanelCuerpo.PerformLayout();
            this.PanelOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbLogoCorto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogolargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelCuerpo;
        private System.Windows.Forms.PictureBox PRestaurar;
        private System.Windows.Forms.PictureBox PMinimizar;
        private System.Windows.Forms.PictureBox PMaximizar;
        private System.Windows.Forms.PictureBox PCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelOpciones;
        private System.Windows.Forms.PictureBox pbLogolargo;
        private Bunifu.Framework.UI.BunifuSeparator Separador;
        private Bunifu.Framework.UI.BunifuElipse Curva;
        private Bunifu.Framework.UI.BunifuElipse CurvaForms;
        private System.Windows.Forms.PictureBox lbLogoCorto;
        private BunifuAnimatorNS.BunifuTransition EfectoIda;
        private BunifuAnimatorNS.BunifuTransition EfectoBotones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnServicio;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnSeguridad;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnNomina;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Button btnInventario;
    }
}