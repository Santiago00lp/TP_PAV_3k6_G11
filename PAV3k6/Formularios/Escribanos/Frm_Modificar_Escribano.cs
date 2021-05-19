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
    public partial class Frm_Modificar_Escribano : Form
    {

        public string Matricula { get; set; }

        public Frm_Modificar_Escribano()
        {
            InitializeComponent();
        }

        private void Frm_Modificar_Escribano_Load(object sender, EventArgs e)
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
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();

            if (Tratamiento.Validar(this.groupBox1.Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                NE_Escribanos escribano = new NE_Escribanos()
                {
                    Pp_Matricula = txt_Matricula.Text           //posible matricula nueva
                    ,
                    Pp_Nombre = txt_Nombre.Text
                    ,
                    Pp_Apellido = txt_Apellido.Text
                    ,
                    Pp_Tipo_Doc = cmb_TipoDoc.SelectedValue.ToString()
                    ,
                    Pp_Documento = txt_NroDoc.Text
                    
                };

                if ( validarCarga( escribano ) )
                {
                    escribano.Modificar(this.Matricula);                  //Como es posible que se cambie la matricula (PK), se pasara como parametro la matricula que figura en la tabla.. ya que el objeto escribano contiene la nueva
                    MessageBox.Show("Se cambiaron los datos correctamente");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("La matricula ingresada ya existe, No se realizaron cambios");
                }

                
            }
            else
            {
                return;
            }

        }


        private Boolean validarCarga( NE_Escribanos escribano)
        {

            DataTable tabla = new DataTable();
            tabla = escribano.Recuperar_x_Matricula(escribano.Pp_Matricula);

            if (Matricula != escribano.Pp_Matricula && tabla.Rows.Count == 1 )
            {
                return false;
            }



            return true;
        }


    }
}
