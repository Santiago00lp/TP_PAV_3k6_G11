﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using PAV3k6.Negocio;

namespace PAV3k6.Formularios
{
    public partial class Frm_AMB_Propiedades : Form
    {
        DataTable tabla = new DataTable();
        NE_Propiedades propiedad = new NE_Propiedades();

        public string designacionCatastral { get; set; }

        public Frm_AMB_Propiedades()
        {
            InitializeComponent();
        }

        private void CargarGrilla(DataTable tabla)
        {
            grid_propiedades.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_propiedades.Rows.Add();
                grid_propiedades.Rows[i].Cells[0].Value = tabla.Rows[i]["designacion_catastral"].ToString();
                grid_propiedades.Rows[i].Cells[1].Value = tabla.Rows[i]["calle"].ToString();
                grid_propiedades.Rows[i].Cells[2].Value = tabla.Rows[i]["numero"].ToString();
                grid_propiedades.Rows[i].Cells[3].Value = tabla.Rows[i]["piso"].ToString();
                grid_propiedades.Rows[i].Cells[4].Value = tabla.Rows[i]["departamento"].ToString();
                grid_propiedades.Rows[i].Cells[5].Value = tabla.Rows[i]["barrio"].ToString();
                grid_propiedades.Rows[i].Cells[6].Value = tabla.Rows[i]["tipo"].ToString();
            }
        }

        private void Frm_AMB_Propiedades_Load(object sender, EventArgs e)
        {
            tabla = propiedad.RecuperarTodos();
            CargarGrilla(tabla);

            designacionCatastral = grid_propiedades.CurrentRow.Cells["designacion_catastral"].Value.ToString();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (Txt_Designacion_Catastral.Text == "")
            {
                MessageBox.Show("Ingrese una designacion catastral para la busqueda.");
                return;
            }
            else
            {
                tabla = propiedad.RecuperarDesignacion(Txt_Designacion_Catastral.Text.ToString());
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se ha encontrado propiedad con esa designacion catastral.");
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
            FRM_Alta_Propiedades alta = new FRM_Alta_Propiedades();
            alta.ShowDialog();

            tabla = propiedad.RecuperarTodos();
            CargarGrilla(tabla);

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Frm_Borrar_Propiedades borrar = new Frm_Borrar_Propiedades();
            borrar.designacionCatastral = designacionCatastral;
            borrar.ShowDialog();

            tabla = propiedad.RecuperarTodos();
            CargarGrilla(tabla);
        }

        private void grid_propiedades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            designacionCatastral = grid_propiedades.CurrentRow.Cells["designacion_catastral"].Value.ToString();
        }

        private void BTN_Modificacion_Click(object sender, EventArgs e)
        {
            Frm_Modificar_Propiedades modificar = new Frm_Modificar_Propiedades();
            modificar.designacionCatastral = designacionCatastral;
            modificar.ShowDialog();

            tabla = propiedad.RecuperarTodos();
            CargarGrilla(tabla);

        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            tabla = propiedad.RecuperarTodos();
            CargarGrilla(tabla);
        }
    }
}
