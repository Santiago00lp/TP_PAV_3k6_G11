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
    class NE_Escribanos
    {
        public string Pp_Matricula { get; set; }
        public string Pp_Nombre { get; set; }
        public string Pp_Apellido { get; set; }
        public string Pp_Documento { get; set; }
        public string Pp_Tipo_Doc { get; set; }




        BE_Acceso_Datos _BD = new BE_Acceso_Datos();


        public DataTable RecuperarTodos()
        {
            string sql = @"SELECT e.*, d.Nombre_tipo_documento as n_doc "
                          + " FROM escribanos e join tipo_documento d "
                          + " on e.idDocumento = d.Id_tipo_documento ";
            return _BD.Consulta(sql);
        }

        public void Insertar(Control.ControlCollection controles)
        {
            TratamientosEspeciales tratamiento = new TratamientosEspeciales();
            _BD.Insertar(tratamiento.CostructorInsert("escribanos", controles));

        }

        public DataTable Recuperar_x_Matricula(string Matricula)
        {
            string sql = "SELECT * FROM escribanos WHERE Matricula =" + Matricula;
            return _BD.Consulta(sql);
        }

        public void Modificar(string matriculaVieja)
        {
            string sqlModificar = @"UPDATE escribanos SET "
                         + " Matricula = " + Pp_Matricula
                         + ", Nombre = '" + Pp_Nombre + "'"
                         + ", Apellido = '" + Pp_Apellido + "'"
                         + ", Documento = '" + Pp_Documento + "'"
                         + ", IdDocumento = '" + Pp_Tipo_Doc + "'"
                         + " WHERE Matricula = " + matriculaVieja;
            _BD.Modificar(sqlModificar);
        }


        public void Borrar()
        {
            string sqlDelete = "DELETE FROM escribanos WHERE Matricula=" + Pp_Matricula;
            _BD.Borrar(sqlDelete);
        }

        public void Borrar(string Matricula)
        {
            string sqlDelete = "DELETE FROM escribanos WHERE Matricula=" + Matricula;
            _BD.Borrar(sqlDelete);
        }

        public DataTable Recuperar_x_Patron(string patron, string columna)
        {
            string sql = @"SELECT e.*, d.Nombre_tipo_documento as n_doc "
                          + " FROM escribanos e join tipo_documento d "
                          + " on e.idDocumento = d.Id_tipo_documento "
                          + " WHERE e." + columna + " like '%" + patron.Trim() + "%'";



            return _BD.Consulta(sql);
        }


    }
}
