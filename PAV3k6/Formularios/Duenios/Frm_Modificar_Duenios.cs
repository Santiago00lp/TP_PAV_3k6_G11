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

namespace PAV3k6.Formularios.Duenios
{
    public partial class Frm_Modificar_Duenios : Form
    {
        public string Pp_numero_documento { get; set; }
        public string Pp_tipo_documento { get; set; }

        DataTable tabla = new DataTable();
        NE_duenios duenio = new NE_duenios();

        public Frm_Modificar_Duenios()
        {
            InitializeComponent();
        }

        private void Frm_Modificar_Duenios_Load(object sender, EventArgs e)
        {
            cmb_tipo_documento.CargarCombo("SELECT " + cmb_tipo_documento.Pp_Pk + ", " + cmb_tipo_documento.Pp_descripcion + " FROM " + cmb_tipo_documento.Pp_tabla_origen);
            tabla = duenio.RecuperarDocumento(Pp_numero_documento, Pp_tipo_documento);
            MostrarDatos(tabla);
            
        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_numero_documento.Text = tabla.Rows[0]["numero_documento"].ToString();
            cmb_tipo_documento.SelectedValue = int.Parse(tabla.Rows[0]["id_tipo_documento"].ToString());
            txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
            txt_telefono.Text = tabla.Rows[0]["telefono"].ToString();
            txt_domicilio.Text = tabla.Rows[0]["domicilio"].ToString();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            NE_duenios duenio = new NE_duenios();

                if (txt_nombre.Text == "")
                {
                    MessageBox.Show("Falta ingresar un el nombre del dueño.");
                    return;
                }

                if (txt_telefono.Text == "")
                {
                    MessageBox.Show("Falta ingresar un telefono.");
                    return;
                }

                if (txt_domicilio.Text == "")
                {
                    MessageBox.Show("Falta ingresar un el domicilio del dueño.");
                    return;
                }

                else
                {
                    duenio.modificarDuenio(txt_numero_documento.Text, cmb_tipo_documento.SelectedValue.ToString(), txt_nombre.Text, txt_telefono.Text, txt_domicilio.Text);
                    MessageBox.Show("Dueño Modificado Correctamente.");
                    this.Close();
                }
            }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
