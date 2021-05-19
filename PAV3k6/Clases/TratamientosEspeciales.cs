using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV3k6.Clases;
using System.Data;

namespace PAV3k6.Clases
{
    class TratamientosEspeciales   
    {
        public enum Resultado { correcto, error }

        public Resultado Validar(Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBoxHeredado")
                {
                    if (((TextBoxHeredado)item).Text == "")
                    {
                        MessageBox.Show(((TextBoxHeredado)item).Pp_MensajeError);
                        ((TextBoxHeredado)item).Focus();
                        return Resultado.error;
                    }
                }
                if (item.GetType().Name == "ComboBoxHeredada")
                {
                    if (((ComboBoxHeredada)item).SelectedIndex == -1)
                    {
                        MessageBox.Show(((ComboBoxHeredada)item).Pp_MensajeError);
                        ((ComboBoxHeredada)item).Focus();
                        return Resultado.error;
                    }
                }
                if (item.GetType().Name == "MaskedTextBoxHeredado")
                {
                    if (((MaskedTextBoxHeredado)item).Pp_MaskxDefecto == ((MaskedTextBoxHeredado)item).Text)
                    {
                        MessageBox.Show(((MaskedTextBoxHeredado)item).Pp_MensajeError);
                        ((MaskedTextBoxHeredado)item).Focus();
                        return Resultado.error;
                    }
                }
            }
            return Resultado.correcto;
        }

        public string CostructorInsert(string NombreTabla, Control.ControlCollection controles)
        {
            string sql = "INSERT INTO " + NombreTabla + " (";                                               //<--- Esto realiza un insert a cualquier tabla... se generaliza
            string columna = "";
            string tipoDatoColumna = "";
            string valorColumna = "";
            string paqueteColumnas = "";
            string paqueteValores = "";
            DataTable Estructura = new DataTable();

            Estructura = BuscarEstructuraTabla(NombreTabla);

            for (int i = 0; i < Estructura.Columns.Count; i++)
            {
                columna = Estructura.Columns[i].Caption;                    //<---- Nombre de la columna 
                tipoDatoColumna = Estructura.Columns[i].DataType.Name;          //<---- Devuelve el tipo de dato de la columna 
                valorColumna = BuscarColumnaEnControles(columna, controles);        //<---- valor de la columna a insertar 
                if (valorColumna != string.Empty)
                {
                    valorColumna = FormatearDato(valorColumna, tipoDatoColumna);      //<----- Les agrega el formato para que sea apto en una consulta sql... esto dependiendo si es int, string, etc

                    if (paqueteColumnas == "")
                    {
                        paqueteColumnas = columna;                      //<----- Es el nombre de las columnas de la BD
                        paqueteValores = valorColumna;                         //<---- Es el valor de las propiedades del txtBox o el CMbBox
                    }
                    else
                    {
                        paqueteColumnas += ", " + columna;
                        paqueteValores += ", " + valorColumna;
                    }
                }
            }

            sql += paqueteColumnas + ") VALUES (" + paqueteValores + ")";             //Se integra el paquete de columna y el de valores a la sentencia sql definitiva     
            //MessageBox.Show(sql);
            return sql;
        }
        private DataTable BuscarEstructuraTabla(string NombreTabla)
        {
            BE_Acceso_Datos _BD = new BE_Acceso_Datos();
            return _BD.Consulta("SELECT TOP 1 * FROM " + NombreTabla);           //Me devuelve 1 solo registro de la tabla... el 1ro --> Me sirve para saber las columnas y el tipo de datos 
        }
        private string BuscarColumnaEnControles(string campo, Control.ControlCollection controles)      //<--- Me devuelve El valor del txt o cmb que tenga en Pp_NombreCampo = nombre de columna (campo)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBoxHeredado")
                {
                    if (((TextBoxHeredado)item).Pp_NombreCampo == campo)
                    {
                        return ((TextBoxHeredado)item).Text;
                    }
                }
                if (item.GetType().Name == "ComboBoxHeredada")
                {
                    if (((ComboBoxHeredada)item).Pp_NombreCampo == campo)
                    {
                        return ((ComboBoxHeredada)item).SelectedValue.ToString();
                    }
                }

                if (item.GetType().Name == "MaskedTextBoxHeredado")
                {
                    if (((MaskedTextBoxHeredado)item).Pp_NombreCampo == campo)
                    {
                        return ((MaskedTextBoxHeredado)item).Text;
                    }
                }


            }
            return "";

        }

        private string FormatearDato(string valorColumna, string tipoDatoColumna)          //Se adapta el valor de la columna dependiendo del tipo de dato
        {
            switch (tipoDatoColumna)
            {
                case "String":
                    return "'" + valorColumna + "'";
                case "Int16":
                case "Int32":
                case "Int64":
                    return valorColumna;
                default:
                    return valorColumna;
            }
        }
    }
}
