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
    public partial class Frm_Baja_TipoMoneda : Form
    {

        public string id_moneda { get; set; }

        public Frm_Baja_TipoMoneda()
        {
            InitializeComponent();
        }

        private void Frm_Baja_TipoMoneda_Load(object sender, EventArgs e)
        {
            NE_Tipo_Moneda moneda = new NE_Tipo_Moneda();
            MostrarDatos(moneda.Recuperar_x_IdMoneda(id_moneda));
        }

        private void MostrarDatos(DataTable tabla)                                                 //<---- Se puede automatizar.. similar a como se hizo el Select
        {
            txt_Nombre.Text = tabla.Rows[0]["nombre"].ToString();
            string porcentaje_tabla = tabla.Rows[0]["porcentaje_comision"].ToString();
            txt_Porcentaje.Text = TransformarPorcentaje(porcentaje_tabla);
            
        }


        private string TransformarPorcentaje(string porcentaje)
        {

            var miCadena = porcentaje.ToCharArray();

            string parteEntera = "";
            string parteDecimal = "";
            bool pasoComa = false;

            foreach (var i in miCadena)
            {

                if (i == ',')
                {
                    pasoComa = true;
                    continue;
                }

                if (pasoComa)
                {
                    parteDecimal += i;
                }
                else
                {
                    parteEntera += i;
                }


            }


            if (parteEntera.Length == 1)
            {
                parteEntera = "00" + parteEntera;
            }
            if (parteEntera.Length == 2)
            {
                parteEntera = "0" + parteEntera;
            }

            if (parteDecimal.Length == 1)
            {
                parteDecimal = parteDecimal + "0";
            }
            if (pasoComa == false)
            {
                parteDecimal = "00";
            }


            return parteEntera + "," + parteDecimal;



        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            NE_Tipo_Moneda moneda = new NE_Tipo_Moneda();
            moneda.Borrar(this.id_moneda);
            MessageBox.Show("El Borrado ha sido exitoso");
            this.Close();

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
