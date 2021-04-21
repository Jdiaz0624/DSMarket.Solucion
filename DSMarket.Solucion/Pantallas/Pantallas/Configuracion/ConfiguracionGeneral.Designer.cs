
namespace DSMarket.Solucion.Pantallas.Pantallas.Configuracion
{
    partial class ConfiguracionGeneral
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.PCerrar = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.gbValidar = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClaveSeguridad = new System.Windows.Forms.TextBox();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.cbFiltrarPorFiltro = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlModulo = new System.Windows.Forms.ComboBox();
            this.dtListado = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).BeginInit();
            this.gbValidar.SuspendLayout();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).BeginInit();
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
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 38);
            this.panel1.TabIndex = 103;
            // 
            // PCerrar
            // 
            this.PCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PCerrar.Image = global::DSMarket.Solucion.Properties.Resources.Close_Window__2_48px;
            this.PCerrar.Location = new System.Drawing.Point(934, 5);
            this.PCerrar.Name = "PCerrar";
            this.PCerrar.Size = new System.Drawing.Size(30, 30);
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
            // gbValidar
            // 
            this.gbValidar.Controls.Add(this.txtClaveSeguridad);
            this.gbValidar.Controls.Add(this.label1);
            this.gbValidar.Location = new System.Drawing.Point(19, 45);
            this.gbValidar.Name = "gbValidar";
            this.gbValidar.Size = new System.Drawing.Size(470, 71);
            this.gbValidar.TabIndex = 104;
            this.gbValidar.TabStop = false;
            this.gbValidar.Text = "Validar Clave de Seguridad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave de Seguridad";
            // 
            // txtClaveSeguridad
            // 
            this.txtClaveSeguridad.Location = new System.Drawing.Point(170, 33);
            this.txtClaveSeguridad.Name = "txtClaveSeguridad";
            this.txtClaveSeguridad.PasswordChar = '•';
            this.txtClaveSeguridad.Size = new System.Drawing.Size(284, 26);
            this.txtClaveSeguridad.TabIndex = 1;
            this.txtClaveSeguridad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveSeguridad_KeyPress);
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.dtListado);
            this.gbListado.Location = new System.Drawing.Point(19, 122);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(945, 328);
            this.gbListado.TabIndex = 105;
            this.gbListado.TabStop = false;
            // 
            // cbFiltrarPorFiltro
            // 
            this.cbFiltrarPorFiltro.AutoSize = true;
            this.cbFiltrarPorFiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFiltrarPorFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbFiltrarPorFiltro.Location = new System.Drawing.Point(496, 59);
            this.cbFiltrarPorFiltro.Name = "cbFiltrarPorFiltro";
            this.cbFiltrarPorFiltro.Size = new System.Drawing.Size(150, 24);
            this.cbFiltrarPorFiltro.TabIndex = 106;
            this.cbFiltrarPorFiltro.Text = "Filtrar Por modulo";
            this.cbFiltrarPorFiltro.UseVisualStyleBackColor = true;
            this.cbFiltrarPorFiltro.CheckedChanged += new System.EventHandler(this.cbFiltrarPorFiltro_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 107;
            this.label2.Text = "Modulo";
            // 
            // ddlModulo
            // 
            this.ddlModulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlModulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlModulo.FormattingEnabled = true;
            this.ddlModulo.Location = new System.Drawing.Point(562, 85);
            this.ddlModulo.Name = "ddlModulo";
            this.ddlModulo.Size = new System.Drawing.Size(358, 28);
            this.ddlModulo.TabIndex = 108;
            this.ddlModulo.SelectedIndexChanged += new System.EventHandler(this.ddlModulo_SelectedIndexChanged);
            // 
            // dtListado
            // 
            this.dtListado.AllowUserToAddRows = false;
            this.dtListado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dtListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtListado.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtListado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dtListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.dtListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtListado.EnableHeadersVisualStyles = false;
            this.dtListado.Location = new System.Drawing.Point(3, 22);
            this.dtListado.Name = "dtListado";
            this.dtListado.ReadOnly = true;
            this.dtListado.RowTemplate.Height = 24;
            this.dtListado.Size = new System.Drawing.Size(939, 303);
            this.dtListado.TabIndex = 5;
            // 
            // Select
            // 
            this.Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select.HeaderText = "Cambiar";
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Text = "Cambiar";
            this.Select.ToolTipText = "Cambiar";
            this.Select.UseColumnTextForButtonValue = true;
            this.Select.Width = 74;
            // 
            // ConfiguracionGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 462);
            this.Controls.Add(this.ddlModulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFiltrarPorFiltro);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbValidar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ConfiguracionGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfiguracionGeneral";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfiguracionGeneral_FormClosing);
            this.Load += new System.EventHandler(this.ConfiguracionGeneral_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCerrar)).EndInit();
            this.gbValidar.ResumeLayout(false);
            this.gbValidar.PerformLayout();
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox ddlModulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbFiltrarPorFiltro;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.GroupBox gbValidar;
        private System.Windows.Forms.TextBox txtClaveSeguridad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PCerrar;
        public System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.DataGridView dtListado;
        private System.Windows.Forms.DataGridViewButtonColumn Select;
    }
}