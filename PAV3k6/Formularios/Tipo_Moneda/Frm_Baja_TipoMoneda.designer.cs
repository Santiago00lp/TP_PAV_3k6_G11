
namespace PAV3k6.Formularios.Tipo_Moneda
{
    partial class Frm_Baja_TipoMoneda
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
            this.grp_TipoMoneda = new System.Windows.Forms.GroupBox();
            this.txt_Porcentaje = new PAV3k6.Clases.MaskedTextBoxHeredado();
            this.txt_Nombre = new PAV3k6.Clases.TextBoxHeredado();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.grp_TipoMoneda.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_TipoMoneda
            // 
            this.grp_TipoMoneda.Controls.Add(this.txt_Porcentaje);
            this.grp_TipoMoneda.Controls.Add(this.txt_Nombre);
            this.grp_TipoMoneda.Controls.Add(this.label3);
            this.grp_TipoMoneda.Controls.Add(this.label2);
            this.grp_TipoMoneda.Controls.Add(this.label1);
            this.grp_TipoMoneda.Enabled = false;
            this.grp_TipoMoneda.Location = new System.Drawing.Point(13, 28);
            this.grp_TipoMoneda.Margin = new System.Windows.Forms.Padding(4);
            this.grp_TipoMoneda.Name = "grp_TipoMoneda";
            this.grp_TipoMoneda.Padding = new System.Windows.Forms.Padding(4);
            this.grp_TipoMoneda.Size = new System.Drawing.Size(418, 137);
            this.grp_TipoMoneda.TabIndex = 0;
            this.grp_TipoMoneda.TabStop = false;
            this.grp_TipoMoneda.Text = "Datos del Tipo de Moneda";
            // 
            // txt_Porcentaje
            // 
            this.txt_Porcentaje.Location = new System.Drawing.Point(210, 81);
            this.txt_Porcentaje.Mask = "999,99";
            this.txt_Porcentaje.Name = "txt_Porcentaje";
            this.txt_Porcentaje.Pp_MaskxDefecto = "   .";
            this.txt_Porcentaje.Pp_MensajeError = "\"Porcentaje de comision vacio\"";
            this.txt_Porcentaje.Pp_NombreCampo = "porcentaje_comision";
            this.txt_Porcentaje.Pp_NombreTabla = null;
            this.txt_Porcentaje.Pp_Validable = false;
            this.txt_Porcentaje.Size = new System.Drawing.Size(47, 23);
            this.txt_Porcentaje.TabIndex = 6;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(210, 45);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Pp_MensajeError = "\"Nombre esta vacio\"";
            this.txt_Nombre.Pp_NombreCampo = "nombre";
            this.txt_Nombre.Pp_NombreTabla = null;
            this.txt_Nombre.Pp_Validable = false;
            this.txt_Nombre.Size = new System.Drawing.Size(125, 23);
            this.txt_Nombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Porcentaje de comision:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(89, 70);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 1;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(242, 70);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.btn_Aceptar);
            this.panel1.Location = new System.Drawing.Point(12, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 120);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(402, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "¿Seguro que desea eliminr este tipo de moneda?";
            // 
            // Frm_Baja_TipoMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 304);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grp_TipoMoneda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Frm_Baja_TipoMoneda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Bajar_TipoMoneda";
            this.Load += new System.EventHandler(this.Frm_Baja_TipoMoneda_Load);
            this.grp_TipoMoneda.ResumeLayout(false);
            this.grp_TipoMoneda.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_TipoMoneda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private Clases.MaskedTextBoxHeredado txt_Porcentaje;
        private Clases.TextBoxHeredado txt_Nombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}