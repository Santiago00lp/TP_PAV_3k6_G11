
namespace PAV3k6.Formularios.Tipo_Moneda
{
    partial class Frm_ABM_TipoMoneda
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
            this.gdr_TipoMoneda = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Alta = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Baja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdr_TipoMoneda)).BeginInit();
            this.SuspendLayout();
            // 
            // gdr_TipoMoneda
            // 
            this.gdr_TipoMoneda.AllowUserToAddRows = false;
            this.gdr_TipoMoneda.AllowUserToDeleteRows = false;
            this.gdr_TipoMoneda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdr_TipoMoneda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Porcentaje,
            this.Id_moneda});
            this.gdr_TipoMoneda.Location = new System.Drawing.Point(12, 12);
            this.gdr_TipoMoneda.Name = "gdr_TipoMoneda";
            this.gdr_TipoMoneda.ReadOnly = true;
            this.gdr_TipoMoneda.Size = new System.Drawing.Size(301, 202);
            this.gdr_TipoMoneda.TabIndex = 0;
            this.gdr_TipoMoneda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdr_TipoMoneda_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Porcentaje
            // 
            this.Porcentaje.DataPropertyName = "porcentaje_comision";
            this.Porcentaje.HeaderText = "Porcentaje (%)";
            this.Porcentaje.Name = "Porcentaje";
            this.Porcentaje.ReadOnly = true;
            // 
            // Id_moneda
            // 
            this.Id_moneda.DataPropertyName = "id_moneda";
            this.Id_moneda.HeaderText = "Id_moneda";
            this.Id_moneda.Name = "Id_moneda";
            this.Id_moneda.ReadOnly = true;
            this.Id_moneda.Visible = false;
            // 
            // btn_Alta
            // 
            this.btn_Alta.Location = new System.Drawing.Point(12, 230);
            this.btn_Alta.Name = "btn_Alta";
            this.btn_Alta.Size = new System.Drawing.Size(75, 23);
            this.btn_Alta.TabIndex = 1;
            this.btn_Alta.Text = "Alta";
            this.btn_Alta.UseVisualStyleBackColor = true;
            this.btn_Alta.Click += new System.EventHandler(this.btn_Alta_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(123, 230);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 2;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Baja
            // 
            this.btn_Baja.Location = new System.Drawing.Point(238, 230);
            this.btn_Baja.Name = "btn_Baja";
            this.btn_Baja.Size = new System.Drawing.Size(75, 23);
            this.btn_Baja.TabIndex = 3;
            this.btn_Baja.Text = "Baja";
            this.btn_Baja.UseVisualStyleBackColor = true;
            this.btn_Baja.Click += new System.EventHandler(this.btn_Baja_Click);
            // 
            // Frm_ABM_TipoMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 267);
            this.Controls.Add(this.btn_Baja);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Alta);
            this.Controls.Add(this.gdr_TipoMoneda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_ABM_TipoMoneda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ABM_TipoMoneda";
            this.Load += new System.EventHandler(this.Frm_ABM_TipoMoneda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdr_TipoMoneda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gdr_TipoMoneda;
        private System.Windows.Forms.Button btn_Alta;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Baja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_moneda;
    }
}