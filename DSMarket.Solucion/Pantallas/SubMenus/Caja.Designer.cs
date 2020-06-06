﻿namespace DSMarket.Solucion.Pantallas.SubMenus
{
    partial class Caja
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caja));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbusuario = new System.Windows.Forms.Label();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.btnMonedas = new System.Windows.Forms.Button();
            this.btnAbirCerrarCaja = new System.Windows.Forms.Button();
            this.btnCuadreCaja = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Efecto = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PCerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.gbOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.PCerrar);
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Controls.Add(this.lbusuario);
            this.Efecto.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 44);
            this.panel1.TabIndex = 13;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.Efecto.SetDecoration(this.lbTitulo, BunifuAnimatorNS.DecorationType.None);
            this.lbTitulo.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(7, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(54, 20);
            this.lbTitulo.TabIndex = 13;
            this.lbTitulo.Text = "label6";
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.Efecto.SetDecoration(this.lbusuario, BunifuAnimatorNS.DecorationType.None);
            this.lbusuario.ForeColor = System.Drawing.Color.White;
            this.lbusuario.Location = new System.Drawing.Point(485, 10);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(51, 20);
            this.lbusuario.TabIndex = 10;
            this.lbusuario.Text = "label1";
            this.lbusuario.Visible = false;
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.btnMonedas);
            this.gbOpciones.Controls.Add(this.btnAbirCerrarCaja);
            this.gbOpciones.Controls.Add(this.btnCuadreCaja);
            this.Efecto.SetDecoration(this.gbOpciones, BunifuAnimatorNS.DecorationType.None);
            this.gbOpciones.Location = new System.Drawing.Point(10, 50);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(723, 114);
            this.gbOpciones.TabIndex = 12;
            this.gbOpciones.TabStop = false;
            this.gbOpciones.Text = "Caja - Seleccionar Opcion";
            // 
            // btnMonedas
            // 
            this.btnMonedas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Efecto.SetDecoration(this.btnMonedas, BunifuAnimatorNS.DecorationType.None);
            this.btnMonedas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonedas.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonedas.Location = new System.Drawing.Point(242, 29);
            this.btnMonedas.Name = "btnMonedas";
            this.btnMonedas.Size = new System.Drawing.Size(230, 68);
            this.btnMonedas.TabIndex = 7;
            this.btnMonedas.Text = "Monedas";
            this.btnMonedas.UseVisualStyleBackColor = true;
            this.btnMonedas.Click += new System.EventHandler(this.btnMonedas_Click);
            // 
            // btnAbirCerrarCaja
            // 
            this.btnAbirCerrarCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Efecto.SetDecoration(this.btnAbirCerrarCaja, BunifuAnimatorNS.DecorationType.None);
            this.btnAbirCerrarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbirCerrarCaja.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbirCerrarCaja.Location = new System.Drawing.Point(6, 29);
            this.btnAbirCerrarCaja.Name = "btnAbirCerrarCaja";
            this.btnAbirCerrarCaja.Size = new System.Drawing.Size(230, 68);
            this.btnAbirCerrarCaja.TabIndex = 6;
            this.btnAbirCerrarCaja.Text = "Abrir / Cerrar";
            this.btnAbirCerrarCaja.UseVisualStyleBackColor = true;
            this.btnAbirCerrarCaja.Click += new System.EventHandler(this.btnAbirCerrarCaja_Click);
            // 
            // btnCuadreCaja
            // 
            this.btnCuadreCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Efecto.SetDecoration(this.btnCuadreCaja, BunifuAnimatorNS.DecorationType.None);
            this.btnCuadreCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuadreCaja.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuadreCaja.Location = new System.Drawing.Point(478, 29);
            this.btnCuadreCaja.Name = "btnCuadreCaja";
            this.btnCuadreCaja.Size = new System.Drawing.Size(230, 68);
            this.btnCuadreCaja.TabIndex = 5;
            this.btnCuadreCaja.Text = "Cuadre";
            this.btnCuadreCaja.UseVisualStyleBackColor = true;
            this.btnCuadreCaja.Click += new System.EventHandler(this.btnCuadreCaja_Click);
            // 
            // Efecto
            // 
            this.Efecto.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.Efecto.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.Efecto.DefaultAnimation = animation2;
            // 
            // PCerrar
            // 
            this.PCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Efecto.SetDecoration(this.PCerrar, BunifuAnimatorNS.DecorationType.None);
            this.PCerrar.Image = global::DSMarket.Solucion.Properties.Resources.Close_Window__2_48px;
            this.PCerrar.Location = new System.Drawing.Point(700, 8);
            this.PCerrar.Name = "PCerrar";
            this.PCerrar.Size = new System.Drawing.Size(30, 30);
            this.PCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCerrar.TabIndex = 14;
            this.PCerrar.TabStop = false;
            this.PCerrar.Click += new System.EventHandler(this.PCerrar_Click);
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 180);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbOpciones);
            this.Efecto.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Caja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.Caja_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbusuario;
        public System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Button btnMonedas;
        private System.Windows.Forms.Button btnAbirCerrarCaja;
        private System.Windows.Forms.Button btnCuadreCaja;
        private System.Windows.Forms.ToolTip toolTip1;
        private BunifuAnimatorNS.BunifuTransition Efecto;
        private System.Windows.Forms.PictureBox PCerrar;
    }
}