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

namespace PAV3k6.Formularios.Tipo_Moneda
{
    public partial class Frm_ABM_TipoMoneda : Form
    {

        public string id_moneda { get; set; }

        public Frm_ABM_TipoMoneda()
        {
            InitializeComponent();
        }

        private void Frm_ABM_TipoMoneda_Load(object sender, EventArgs e)
        {
            id_moneda = "";
            ActualizarGrilla();
        }


        private void ActualizarGrilla()
        {
            NE_Tipo_Moneda moneda = new NE_Tipo_Moneda();
            DataTable tabla = new DataTable();
            tabla = moneda.RecuperarTodos();
            CargarGrilla(tabla);
        }


        private void CargarGrilla(DataTable tabla)
        {
            gdr_TipoMoneda.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                gdr_TipoMoneda.Rows.Add();
                gdr_TipoMoneda.Rows[i].Cells["Nombre"].Value = tabla.Rows[i]["nombre"].ToString();
                gdr_TipoMoneda.Rows[i].Cells["Porcentaje"].Value = tabla.Rows[i]["porcentaje_comision"].ToString();
                gdr_TipoMoneda.Rows[i].Cells["Id_moneda"].Value = tabla.Rows[i]["id_moneda"].ToString();
            }
        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            Frm_Alta_TipoMoneda alta = new Frm_Alta_TipoMoneda();
            alta.ShowDialog();
            ActualizarGrilla();
        }

        private void gdr_TipoMoneda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_moneda = gdr_TipoMoneda.CurrentRow.Cells["Id_moneda"].Value.ToString();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (id_moneda != "")
            {
                Frm_Modificar_TipoMoneda modificar = new Frm_Modificar_TipoMoneda();
                modificar.id_moneda = this.id_moneda;
                modificar.ShowDialog();
                ActualizarGrilla();
                id_moneda = "";
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un Tipo de moneda de la tabla para modificarlo");
            }
        }

        private void btn_Baja_Click(object sender, EventArgs e)
        {
            if (id_moneda != "")
            {
                Frm_Baja_TipoMoneda bajar = new Frm_Baja_TipoMoneda();
                bajar.id_moneda = this.id_moneda;
                bajar.ShowDialog();
                ActualizarGrilla();
                id_moneda = "";
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un Tipo de moneda de la tabla para modificarlo");
            }
        }
    }
}
