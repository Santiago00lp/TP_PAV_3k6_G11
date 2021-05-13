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

namespace PAV3k6.Formularios.Dueños
{
    public partial class Frm_Alta_Duenios : Form
    {
        public Frm_Alta_Duenios()
        {
            InitializeComponent();
        }

        private void Frm_Alta_Duenios_Load(object sender, EventArgs e)
        {
            cmb_tipo_documento.CargarCombo("SELECT " + cmb_tipo_documento.Pp_Pk + ", " + cmb_tipo_documento.Pp_descripcion + " FROM " + cmb_tipo_documento.Pp_tabla_origen);
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            NE_duenios duenio = new NE_duenios();

            if (txt_numero_documento.Text == "")
            {
                MessageBox.Show("Falta ingresar un documento.");
                return;
            }

            else
            {
                tabla = duenio.RecuperarDocumento( txt_numero_documento.Text, cmb_tipo_documento.SelectedValue.ToString());
                if (tabla.Rows.Count != 0)
                {
                    MessageBox.Show("Ya existe un dueño registrado con ese documento.");
                    return;
                }
            
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
                    duenio.insertarDuenio(txt_numero_documento.Text, cmb_tipo_documento.SelectedValue.ToString(), txt_nombre.Text, txt_telefono.Text, txt_domicilio.Text);
                    MessageBox.Show("Dueño Registrado Correctamente.");
                    this.Close();
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
