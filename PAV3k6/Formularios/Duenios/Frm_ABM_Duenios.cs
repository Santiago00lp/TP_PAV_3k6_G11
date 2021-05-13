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
using PAV3k6.Formularios.Duenios;

namespace PAV3k6.Formularios.Dueños
{
    public partial class Frm_ABM_Duenios : Form
    {
        DataTable tabla = new DataTable();
        NE_duenios duenio = new NE_duenios();

        public string numero_documento_selecionado { get; set; }
        public string id_tipo_documento_selecionado { get; set; }


        public Frm_ABM_Duenios()
        {
            InitializeComponent();
        }

        private void CargarGrilla(DataTable tabla)
        {
            grid_duenios.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_duenios.Rows.Add();
                grid_duenios.Rows[i].Cells[0].Value = tabla.Rows[i]["numero_documento"].ToString();
                grid_duenios.Rows[i].Cells[1].Value = tabla.Rows[i]["id_tipo_documento"].ToString();
                grid_duenios.Rows[i].Cells[2].Value = tabla.Rows[i]["tipo_documento_nombre"].ToString();
                grid_duenios.Rows[i].Cells[3].Value = tabla.Rows[i]["nombre"].ToString();
                grid_duenios.Rows[i].Cells[4].Value = tabla.Rows[i]["telefono"].ToString();
                grid_duenios.Rows[i].Cells[5].Value = tabla.Rows[i]["domicilio"].ToString();
            }
        }

        private void ABM_Dueños_Load(object sender, EventArgs e)
        {
            tabla = duenio.RecuperarTodos();
            CargarGrilla(tabla);

            cmb_tipo_documento.CargarCombo("SELECT " + cmb_tipo_documento.Pp_Pk + ", " + cmb_tipo_documento.Pp_descripcion + " FROM " + cmb_tipo_documento.Pp_tabla_origen);

            numero_documento_selecionado = grid_duenios.CurrentRow.Cells["numero_documento"].Value.ToString();
            id_tipo_documento_selecionado = grid_duenios.CurrentRow.Cells["id_tipo_documento"].Value.ToString();

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_numero_documento.Text == "")
            {
                MessageBox.Show("Ingrese un Numero de documento para la busqueda.");
                return;
            }
            else
            {
                tabla = duenio.RecuperarDocumento(txt_numero_documento.Text, cmb_tipo_documento.SelectedValue.ToString());
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se ha encontrado dueño con los datos ingresados");
                    return;
                }
                else
                {
                    CargarGrilla(tabla);
                }

            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Frm_Alta_Duenios alta = new Frm_Alta_Duenios();

            alta.ShowDialog();

            tabla = duenio.RecuperarTodos();
            CargarGrilla(tabla);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Frm_Modificar_Duenios modificar = new Frm_Modificar_Duenios();
            modificar.Pp_numero_documento = numero_documento_selecionado;
            modificar.Pp_tipo_documento = id_tipo_documento_selecionado;

            modificar.ShowDialog();

            tabla = duenio.RecuperarTodos();
            CargarGrilla(tabla);

        }

        private void grid_duenios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numero_documento_selecionado = grid_duenios.CurrentRow.Cells["numero_documento"].Value.ToString();
            id_tipo_documento_selecionado = grid_duenios.CurrentRow.Cells["id_tipo_documento"].Value.ToString();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            Frm_Borrar_Duenios borrar = new Frm_Borrar_Duenios();
            borrar.Pp_numero_documento = numero_documento_selecionado;
            borrar.Pp_tipo_documento = id_tipo_documento_selecionado;
            borrar.ShowDialog();

            tabla = duenio.RecuperarTodos();
            CargarGrilla(tabla);
        }
    }
}
