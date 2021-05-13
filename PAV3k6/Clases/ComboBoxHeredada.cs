using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace PAV3k6.Clases
{
    class ComboBoxHeredada : ComboBox
    {
        public string Pp_Pk { get; set; }
        public string Pp_descripcion { get; set; }
        public string Pp_tabla_origen { get; set; }

        /// <summary>
        /// Nombre de la tabla en la que actuará el dato ante un comando de insert
        /// </summary>
        public string Pp_NombreTabla { get; set; }
        /// <summary>
        /// Nombre del campo en el actuará el dato dentro de la tabla
        /// </summary>
        public string Pp_NombreCampo { get; set; }

        public bool Pp_Conseleccion { get; set; }
        public bool Pp_Validable { get; set; }
        public string Pp_MensajeError { get; set; }


        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public void CargarCombo(string sql)
        {
            ///string sql = "SELECT " + Pp_Pk + ", " + Pp_descripcion + " FROM " + Pp_tabla_origen;
            this.DisplayMember = Pp_descripcion;
            this.ValueMember = Pp_Pk;
            this.DataSource = _BD.Consulta(sql);
        }

        public void CargarCombo()
        {
            string sql = "SELECT " + Pp_Pk + ", " + Pp_descripcion + " FROM " + Pp_tabla_origen;
            this.DisplayMember = Pp_descripcion;
            this.ValueMember = Pp_Pk;
            this.DataSource = _BD.Consulta(sql);
            if (this.Pp_Conseleccion == true)
            {
                this.SelectedIndex = 0;
            }
            else
            {
                this.SelectedIndex = -1;
            }
        }

    }
}
