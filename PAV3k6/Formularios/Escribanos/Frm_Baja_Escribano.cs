using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV3k6.Clases;
using PAV3k6.Negocio;

namespace PAV3k6.Formularios.Escribanos
{
    public partial class Frm_Baja_Escribano : Form
    {

        public string Matricula { get; set; }

        public Frm_Baja_Escribano()
        {
            InitializeComponent();
        }

        private void Frm_Baja_Escribano_Load(object sender, EventArgs e)
        {
            cmb_TipoDoc.CargarCombo();

            NE_Escribanos escribano = new NE_Escribanos();
            MostrarDatos(escribano.Recuperar_x_Matricula(Matricula));

        }

        private void MostrarDatos(DataTable tabla)                                                 //<---- Se puede automatizar.. similar a como se hizo el Select
        {
            txt_Matricula.Text = tabla.Rows[0]["Matricula"].ToString();
            txt_Nombre.Text = tabla.Rows[0]["Nombre"].ToString();
            txt_Apellido.Text = tabla.Rows[0]["Apellido"].ToString();
            txt_NroDoc.Text = tabla.Rows[0]["Documento"].ToString();
            cmb_TipoDoc.SelectedValue = tabla.Rows[0]["IdDocumento"].ToString();

        }



        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {

            NE_Escribanos escribano = new NE_Escribanos();
            escribano.Borrar(this.Matricula);
            MessageBox.Show("El Borrado ha sido exitoso");
            this.Close();
            

        }

        
    }
}
