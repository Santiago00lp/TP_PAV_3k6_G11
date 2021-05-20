using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PAV3k6.Clases;
using System.Windows.Forms;

namespace PAV3k6.Negocio
{
    class NE_Tipo_Moneda
    {

        public string Pp_Porcentaje_comision { get; set; }
        public string Pp_Nombre { get; set; }





        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT *"
                          + " FROM tipo_moneda ";
            return _BD.Consulta(sql);
        }


        public void Insertar(Control.ControlCollection controles)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            _BD.Insertar(tratamiento.CostructorInsert("tipo_moneda", controles));

        }

        public DataTable Recuperar_x_IdMoneda(string id_moneda)
        {
            string sql = "SELECT * FROM tipo_moneda WHERE id_moneda =" + id_moneda;
            return _BD.Consulta(sql);
        }

        public void Modificar(string id_moneda)
        {
            string sqlModificar = @"UPDATE tipo_moneda SET "
                         + " nombre = '" + Pp_Nombre + "'"
                         + ", porcentaje_comision = '" + Pp_Porcentaje_comision + "'"       //Aqui se guarda un tipo de dato Float como string, pero funciona igual
                         + " WHERE id_moneda = " + id_moneda;
            _BD.Modificar(sqlModificar);
        }

        public void Borrar(string id_moneda)
        {
            string sqlDelete = "DELETE FROM tipo_moneda WHERE id_moneda=" + id_moneda;
            _BD.Borrar(sqlDelete);
        }
    }
}
