using PAV3k6.Clases;

namespace PAV3k6.Formularios.Escribanos
{
    partial class Frm_ABM_Escribano
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Filtrar = new System.Windows.Forms.Button();
            this.grp_Filtro2 = new System.Windows.Forms.GroupBox();
            this.txt_PatronFiltro = new PAV3k6.Clases.TextBoxHeredado();
            this.grp_Filtro = new System.Windows.Forms.GroupBox();
            this.rd_Matricula = new System.Windows.Forms.RadioButton();
            this.rd_Apellido = new System.Windows.Forms.RadioButton();
            this.rdNombre = new System.Windows.Forms.RadioButton();
            this.chk_Filtro = new System.Windows.Forms.CheckBox();
            this.gdr_Escribanos = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AltaEscribano = new System.Windows.Forms.Button();
            this.btn_BajaEscribano = new System.Windows.Forms.Button();
            this.btn_ModificarEscribano = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grp_Filtro2.SuspendLayout();
            this.grp_Filtro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdr_Escribanos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Filtrar);
            this.groupBox1.Controls.Add(this.grp_Filtro2);
            this.groupBox1.Controls.Add(this.grp_Filtro);
            this.groupBox1.Controls.Add(this.chk_Filtro);
            this.groupBox1.Controls.Add(this.gdr_Escribanos);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 372);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escribanos en el sistema";
            // 
            // btn_Filtrar
            // 
            this.btn_Filtrar.Enabled = false;
            this.btn_Filtrar.Location = new System.Drawing.Point(42, 300);
            this.btn_Filtrar.Name = "btn_Filtrar";
            this.btn_Filtrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Filtrar.TabIndex = 6;
            this.btn_Filtrar.Text = "Filtrar";
            this.btn_Filtrar.UseVisualStyleBackColor = true;
            this.btn_Filtrar.Click += new System.EventHandler(this.btn_Filtrar_Click);
            // 
            // grp_Filtro2
            // 
            this.grp_Filtro2.Controls.Add(this.txt_PatronFiltro);
            this.grp_Filtro2.Enabled = false;
            this.grp_Filtro2.Location = new System.Drawing.Point(42, 223);
            this.grp_Filtro2.Name = "grp_Filtro2";
            this.grp_Filtro2.Size = new System.Drawing.Size(234, 71);
            this.grp_Filtro2.TabIndex = 5;
            this.grp_Filtro2.TabStop = false;
            this.grp_Filtro2.Text = "Patron:";
            // 
            // txt_PatronFiltro
            // 
            this.txt_PatronFiltro.Location = new System.Drawing.Point(30, 31);
            this.txt_PatronFiltro.Name = "txt_PatronFiltro";
            this.txt_PatronFiltro.Pp_MensajeError = null;
            this.txt_PatronFiltro.Pp_NombreCampo = null;
            this.txt_PatronFiltro.Pp_NombreTabla = null;
            this.txt_PatronFiltro.Pp_Validable = false;
            this.txt_PatronFiltro.Size = new System.Drawing.Size(182, 23);
            this.txt_PatronFiltro.TabIndex = 0;
            // 
            // grp_Filtro
            // 
            this.grp_Filtro.Controls.Add(this.rd_Matricula);
            this.grp_Filtro.Controls.Add(this.rd_Apellido);
            this.grp_Filtro.Controls.Add(this.rdNombre);
            this.grp_Filtro.Enabled = false;
            this.grp_Filtro.Location = new System.Drawing.Point(42, 100);
            this.grp_Filtro.Name = "grp_Filtro";
            this.grp_Filtro.Size = new System.Drawing.Size(150, 116);
            this.grp_Filtro.TabIndex = 4;
            this.grp_Filtro.TabStop = false;
            this.grp_Filtro.Text = "Filtrar por:";
            // 
            // rd_Matricula
            // 
            this.rd_Matricula.AutoSize = true;
            this.rd_Matricula.Location = new System.Drawing.Point(30, 87);
            this.rd_Matricula.Name = "rd_Matricula";
            this.rd_Matricula.Size = new System.Drawing.Size(83, 21);
            this.rd_Matricula.TabIndex = 2;
            this.rd_Matricula.TabStop = true;
            this.rd_Matricula.Text = "Matricula";
            this.rd_Matricula.UseVisualStyleBackColor = true;
            // 
            // rd_Apellido
            // 
            this.rd_Apellido.AutoSize = true;
            this.rd_Apellido.Location = new System.Drawing.Point(30, 60);
            this.rd_Apellido.Name = "rd_Apellido";
            this.rd_Apellido.Size = new System.Drawing.Size(76, 21);
            this.rd_Apellido.TabIndex = 1;
            this.rd_Apellido.TabStop = true;
            this.rd_Apellido.Text = "Apellido";
            this.rd_Apellido.UseVisualStyleBackColor = true;
            // 
            // rdNombre
            // 
            this.rdNombre.AutoSize = true;
            this.rdNombre.Location = new System.Drawing.Point(30, 33);
            this.rdNombre.Name = "rdNombre";
            this.rdNombre.Size = new System.Drawing.Size(76, 21);
            this.rdNombre.TabIndex = 0;
            this.rdNombre.TabStop = true;
            this.rdNombre.Text = "Nombre";
            this.rdNombre.UseVisualStyleBackColor = true;
            // 
            // chk_Filtro
            // 
            this.chk_Filtro.AutoSize = true;
            this.chk_Filtro.Location = new System.Drawing.Point(42, 62);
            this.chk_Filtro.Name = "chk_Filtro";
            this.chk_Filtro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_Filtro.Size = new System.Drawing.Size(79, 21);
            this.chk_Filtro.TabIndex = 3;
            this.chk_Filtro.Text = "?Filtrar¿";
            this.chk_Filtro.UseVisualStyleBackColor = true;
            this.chk_Filtro.CheckedChanged += new System.EventHandler(this.chk_Filtro_CheckedChanged);
            // 
            // gdr_Escribanos
            // 
            this.gdr_Escribanos.AllowUserToAddRows = false;
            this.gdr_Escribanos.AllowUserToDeleteRows = false;
            this.gdr_Escribanos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdr_Escribanos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.Apellido,
            this.matricula});
            this.gdr_Escribanos.Location = new System.Drawing.Point(336, 47);
            this.gdr_Escribanos.Name = "gdr_Escribanos";
            this.gdr_Escribanos.ReadOnly = true;
            this.gdr_Escribanos.Size = new System.Drawing.Size(443, 298);
            this.gdr_Escribanos.TabIndex = 2;
            this.gdr_Escribanos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdr_Escribanos_CellClick);
            this.gdr_Escribanos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdr_Escribanos_CellDoubleClick);
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "Nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 150;
            // 
            // matricula
            // 
            this.matricula.DataPropertyName = "Matricula";
            this.matricula.HeaderText = "Matricula";
            this.matricula.Name = "matricula";
            this.matricula.ReadOnly = true;
            // 
            // btn_AltaEscribano
            // 
            this.btn_AltaEscribano.Location = new System.Drawing.Point(92, 417);
            this.btn_AltaEscribano.Name = "btn_AltaEscribano";
            this.btn_AltaEscribano.Size = new System.Drawing.Size(75, 23);
            this.btn_AltaEscribano.TabIndex = 1;
            this.btn_AltaEscribano.Text = "Alta";
            this.btn_AltaEscribano.UseVisualStyleBackColor = true;
            this.btn_AltaEscribano.Click += new System.EventHandler(this.btn_AltaEscribano_Click);
            // 
            // btn_BajaEscribano
            // 
            this.btn_BajaEscribano.Location = new System.Drawing.Point(517, 417);
            this.btn_BajaEscribano.Name = "btn_BajaEscribano";
            this.btn_BajaEscribano.Size = new System.Drawing.Size(75, 23);
            this.btn_BajaEscribano.TabIndex = 3;
            this.btn_BajaEscribano.Text = "Baja";
            this.btn_BajaEscribano.UseVisualStyleBackColor = true;
            this.btn_BajaEscribano.Click += new System.EventHandler(this.btn_BajaEscribano_Click);
            // 
            // btn_ModificarEscribano
            // 
            this.btn_ModificarEscribano.Location = new System.Drawing.Point(314, 417);
            this.btn_ModificarEscribano.Name = "btn_ModificarEscribano";
            this.btn_ModificarEscribano.Size = new System.Drawing.Size(75, 23);
            this.btn_ModificarEscribano.TabIndex = 2;
            this.btn_ModificarEscribano.Text = "Modificar";
            this.btn_ModificarEscribano.UseVisualStyleBackColor = true;
            this.btn_ModificarEscribano.Click += new System.EventHandler(this.btn_ModificarEscribano_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(775, 417);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(51, 43);
            this.btn_Salir.TabIndex = 4;
            this.btn_Salir.Text = "salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Frm_ABM_Escribano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 484);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_ModificarEscribano);
            this.Controls.Add(this.btn_BajaEscribano);
            this.Controls.Add(this.btn_AltaEscribano);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ABM_Escribano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion de Escribanos";
            this.Load += new System.EventHandler(this.Frm_ABM_Escribano_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_Filtro2.ResumeLayout(false);
            this.grp_Filtro2.PerformLayout();
            this.grp_Filtro.ResumeLayout(false);
            this.grp_Filtro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdr_Escribanos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gdr_Escribanos;
        private System.Windows.Forms.Button btn_AltaEscribano;
        private System.Windows.Forms.Button btn_BajaEscribano;
        private System.Windows.Forms.Button btn_ModificarEscribano;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.GroupBox grp_Filtro;
        private System.Windows.Forms.CheckBox chk_Filtro;
        private System.Windows.Forms.GroupBox grp_Filtro2;
        private TextBoxHeredado txt_PatronFiltro;
        private System.Windows.Forms.Button btn_Filtrar;
        private System.Windows.Forms.RadioButton rd_Matricula;
        private System.Windows.Forms.RadioButton rd_Apellido;
        private System.Windows.Forms.RadioButton rdNombre;
    }
}