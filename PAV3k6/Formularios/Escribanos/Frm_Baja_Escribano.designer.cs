
namespace PAV3k6.Formularios.Escribanos
{
    partial class Frm_Baja_Escribano
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
            this.txt_Matricula = new PAV3k6.Clases.TextBoxHeredado();
            this.cmb_TipoDoc = new PAV3k6.Clases.ComboBoxHeredada();
            this.txt_NroDoc = new PAV3k6.Clases.TextBoxHeredado();
            this.txt_Apellido = new PAV3k6.Clases.TextBoxHeredado();
            this.txt_Nombre = new PAV3k6.Clases.TextBoxHeredado();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Matricula
            // 
            this.txt_Matricula.Enabled = false;
            this.txt_Matricula.Location = new System.Drawing.Point(200, 44);
            this.txt_Matricula.Name = "txt_Matricula";
            this.txt_Matricula.Pp_MensajeError = "\"Matricula\" se encuentra vacio";
            this.txt_Matricula.Pp_NombreCampo = "Matricula";
            this.txt_Matricula.Pp_NombreTabla = null;
            this.txt_Matricula.Pp_Validable = false;
            this.txt_Matricula.Size = new System.Drawing.Size(121, 23);
            this.txt_Matricula.TabIndex = 0;
            // 
            // cmb_TipoDoc
            // 
            this.cmb_TipoDoc.Enabled = false;
            this.cmb_TipoDoc.FormattingEnabled = true;
            this.cmb_TipoDoc.Location = new System.Drawing.Point(200, 131);
            this.cmb_TipoDoc.Name = "cmb_TipoDoc";
            this.cmb_TipoDoc.Pp_Conseleccion = false;
            this.cmb_TipoDoc.Pp_descripcion = "Nombre_tipo_documento";
            this.cmb_TipoDoc.Pp_MensajeError = "\"Tipo de documento\" se encuentra vacio";
            this.cmb_TipoDoc.Pp_NombreCampo = "IdDocumento";
            this.cmb_TipoDoc.Pp_NombreTabla = null;
            this.cmb_TipoDoc.Pp_Pk = "Id_tipo_documento";
            this.cmb_TipoDoc.Pp_tabla_origen = "tipo_documento";
            this.cmb_TipoDoc.Pp_Validable = false;
            this.cmb_TipoDoc.Size = new System.Drawing.Size(121, 24);
            this.cmb_TipoDoc.TabIndex = 3;
            // 
            // txt_NroDoc
            // 
            this.txt_NroDoc.Enabled = false;
            this.txt_NroDoc.Location = new System.Drawing.Point(200, 161);
            this.txt_NroDoc.Name = "txt_NroDoc";
            this.txt_NroDoc.Pp_MensajeError = "\"Numero de documento\" se encuentra vacio";
            this.txt_NroDoc.Pp_NombreCampo = "Documento";
            this.txt_NroDoc.Pp_NombreTabla = null;
            this.txt_NroDoc.Pp_Validable = false;
            this.txt_NroDoc.Size = new System.Drawing.Size(121, 23);
            this.txt_NroDoc.TabIndex = 4;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Enabled = false;
            this.txt_Apellido.Location = new System.Drawing.Point(200, 102);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Pp_MensajeError = "\"Apellido\" se encuentra vacio";
            this.txt_Apellido.Pp_NombreCampo = "Apellido";
            this.txt_Apellido.Pp_NombreTabla = null;
            this.txt_Apellido.Pp_Validable = false;
            this.txt_Apellido.Size = new System.Drawing.Size(121, 23);
            this.txt_Apellido.TabIndex = 2;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Enabled = false;
            this.txt_Nombre.Location = new System.Drawing.Point(200, 73);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Pp_MensajeError = "\"Nombre\" se encuentra vacio";
            this.txt_Nombre.Pp_NombreCampo = "Nombre";
            this.txt_Nombre.Pp_NombreTabla = null;
            this.txt_Nombre.Pp_Validable = false;
            this.txt_Nombre.Size = new System.Drawing.Size(121, 23);
            this.txt_Nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Matricula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de documento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numero de documento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Matricula);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_NroDoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_TipoDoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Apellido);
            this.groupBox1.Controls.Add(this.txt_Nombre);
            this.groupBox1.Location = new System.Drawing.Point(22, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Escribano";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(79, 72);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 1;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(231, 72);
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
            this.panel1.Location = new System.Drawing.Point(22, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 120);
            this.panel1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(356, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "¿Seguro que desea eliminr este escribano?";
            // 
            // Frm_Baja_Escribano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 444);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Baja_Escribano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Bajar_Escribano";
            this.Load += new System.EventHandler(this.Frm_Baja_Escribano_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Clases.TextBoxHeredado txt_Matricula;
        private Clases.ComboBoxHeredada cmb_TipoDoc;
        private Clases.TextBoxHeredado txt_NroDoc;
        private Clases.TextBoxHeredado txt_Apellido;
        private Clases.TextBoxHeredado txt_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}