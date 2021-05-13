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
    public partial class Frm_Borrar_Duenios : Form
    {
        public string Pp_numero_documento { get; set; }
        public string Pp_tipo_documento { get; set; }

        DataTable tabla = new DataTable();
        NE_duenios duenio = new NE_duenios();

        public Frm_Borrar_Duenios()
        {
            InitializeComponent();
        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_numero_documento.Text = tabla.Rows[0]["numero_documento"].ToString();
            cmb_tipo_documento.SelectedValue = int.Parse(tabla.Rows[0]["id_tipo_documento"].ToString());
            txt_nombre.Text = tabla.Rows[0]["nombre"].ToString();
            txt_telefono.Text = tabla.Rows[0]["telefono"].ToString();
            txt_domicilio.Text = tabla.Rows[0]["domicilio"].ToString();
        }

        private void Frm_Borrar_Duenios_Load(object sender, EventArgs e)
        {
            cmb_tipo_documento.CargarCombo("SELECT " + cmb_tipo_documento.Pp_Pk + ", " + cmb_tipo_documento.Pp_descripcion + " FROM " + cmb_tipo_documento.Pp_tabla_origen);
            tabla = duenio.RecuperarDocumento(Pp_numero_documento, Pp_tipo_documento);
            MostrarDatos(tabla);
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de Borrar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                duenio.borrar(Pp_numero_documento, Pp_tipo_documento);
                MessageBox.Show("Se borró correctamente el dueño.");
                this.Close();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
