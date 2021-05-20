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
    public partial class Frm_ABM_Escribano : Form
    {

        public string Matricula { get; set; }

        public Frm_ABM_Escribano()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Escribano_Load(object sender, EventArgs e)
        {
            Matricula = "";
            ActualizarGrilla();
            return;
        }

        private void btn_AltaEscribano_Click(object sender, EventArgs e)
        {
            Frm_Alta_Escribano alta = new Frm_Alta_Escribano();
            alta.ShowDialog();
            ActualizarGrilla();
        }

        private void gdr_Escribanos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Matricula = gdr_Escribanos.CurrentRow.Cells["Matricula"].Value.ToString();
        }


        private void btn_ModificarEscribano_Click(object sender, EventArgs e)
        {
            if (Matricula != "")
            {
                Frm_Modificar_Escribano modificar = new Frm_Modificar_Escribano();
                modificar.Matricula = this.Matricula;
                modificar.ShowDialog();
                ActualizarGrilla();
                Matricula = "";
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un Escribano de la tabla para modificarlo");
            }

        }

        private void btn_BajaEscribano_Click(object sender, EventArgs e)
        {
            if (Matricula != "")
            {
                Frm_Baja_Escribano bajar = new Frm_Baja_Escribano();
                bajar.Matricula = this.Matricula;
                bajar.ShowDialog();
                ActualizarGrilla();
                Matricula = "";
            }
            else
            {
                MessageBox.Show("Se debe seleccionar un Escribano de la tabla para Eliminarlo");
            }

        }



        private void ActualizarGrilla()
        {
            NE_Escribanos escribano = new NE_Escribanos();
            DataTable tabla = new DataTable();
            tabla = escribano.RecuperarTodos();
            CargarGrilla(tabla);
        }


        private void CargarGrilla(DataTable tabla)
        {
            gdr_Escribanos.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                gdr_Escribanos.Rows.Add();
                gdr_Escribanos.Rows[i].Cells["Nombre"].Value = tabla.Rows[i]["Nombre"].ToString();
                gdr_Escribanos.Rows[i].Cells["Apellido"].Value = tabla.Rows[i]["Apellido"].ToString();
                gdr_Escribanos.Rows[i].Cells["Matricula"].Value = tabla.Rows[i]["Matricula"].ToString();
            }
        }

        private void chk_Filtro_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Filtro.Checked)
            {
                grp_Filtro.Enabled = true;
                grp_Filtro2.Enabled = true;
                btn_Filtrar.Enabled = true;



            }
            else
            {
                ActualizarGrilla();
                grp_Filtro.Enabled = false;
                grp_Filtro2.Enabled = false;
                btn_Filtrar.Enabled = false;
            }
        }

        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            if ((rdNombre.Checked == false || rd_Apellido.Checked == false || rd_Matricula.Checked == false) && txt_PatronFiltro.Text == "")
            {
                MessageBox.Show("Debe seleccionar alguna opción de filtrado", "Importate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            NE_Escribanos escribano = new NE_Escribanos();

            string patron = txt_PatronFiltro.Text;

            string columna = RecuperarColumnaFiltro();

            DataTable tabla = new DataTable();

            tabla = escribano.Recuperar_x_Patron(patron , columna);
            
            CargarGrilla(tabla);

        }

        private string RecuperarColumnaFiltro()
        {
            if (rdNombre.Checked == true) { return "Nombre"; }
            else 
            {
                if (rd_Apellido.Checked == true) { return "Apellido"; }
                
                else { return "Matricula"; }
                
            }
        
        }

        private void gdr_Escribanos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Matricula = gdr_Escribanos.CurrentRow.Cells["Matricula"].Value.ToString();

           
            Frm_Info_Escribano informar = new Frm_Info_Escribano();
            informar.Matricula = this.Matricula;
            informar.ShowDialog();
            ActualizarGrilla();
            Matricula = "";

        }
    }
}
