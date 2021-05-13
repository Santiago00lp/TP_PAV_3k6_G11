using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV3k6.Negocio;

namespace PAV3k6.Formularios
{
    public partial class Frm_Modificar_Propiedades : Form
    {
        public string designacionCatastral { get; set; }

        NE_Propiedades propiedad = new NE_Propiedades();

        public Frm_Modificar_Propiedades()
        {
            InitializeComponent();
        }

        private void Frm_Modificar_Propiedades_Load(object sender, EventArgs e)
        {
            cmb_barrio.CargarCombo("SELECT " + cmb_barrio.Pp_Pk + ", " + cmb_barrio.Pp_descripcion + " FROM " + cmb_barrio.Pp_tabla_origen);
            cmb_tipo_propiedad.CargarCombo("SELECT " + cmb_tipo_propiedad.Pp_Pk + ", " + cmb_tipo_propiedad.Pp_descripcion + " FROM " + cmb_tipo_propiedad.Pp_tabla_origen);
            MostrarDatos(propiedad.RecuperarDesignacion(designacionCatastral));
        }


        private void MostrarDatos(DataTable tabla)
        {
            txt_designacion.Text = tabla.Rows[0]["designacion_catastral"].ToString();
            txt_calle.Text = tabla.Rows[0]["calle"].ToString();
            txt_numero.Text = tabla.Rows[0]["numero"].ToString();
            txt_piso.Text = tabla.Rows[0]["piso"].ToString();
            txt_departamento.Text = tabla.Rows[0]["departamento"].ToString();
            cmb_barrio.SelectedValue = int.Parse(tabla.Rows[0]["id_barrio"].ToString());
            cmb_tipo_propiedad.SelectedValue = int.Parse(tabla.Rows[0]["id_tipo_propiedad"].ToString());
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            NE_Propiedades propiedad = new NE_Propiedades();

            if (txt_calle.Text == "")
            {
                MessageBox.Show("Se nececita cargar la calle.");
                return;
            }

            if (txt_numero.Text == "")
            {
                MessageBox.Show("Se nececita cargar el numero de domicilio.");
                return;
            }

            if (txt_departamento.Text == "")
            {
                propiedad.modificarSinDepto(designacionCatastral, txt_calle.Text, txt_numero.Text, cmb_barrio.SelectedValue.ToString(), cmb_tipo_propiedad.SelectedValue.ToString());
                this.Close();
            }
            else
            {
                propiedad.modificarCompleto(designacionCatastral, txt_calle.Text, txt_numero.Text, txt_piso.Text, txt_departamento.Text, cmb_barrio.SelectedValue.ToString(), cmb_tipo_propiedad.SelectedValue.ToString());
                this.Close();
            }
        }
    }
}
