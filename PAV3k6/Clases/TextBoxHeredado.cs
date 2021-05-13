using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace PAV3k6.Clases
{
    class TextBoxHeredado : TextBox
    {

        public string Pp_NombreTabla { get; set; }

        public string Pp_NombreCampo { get; set; }

        public bool Pp_Validable { get; set; }

        public string Pp_MensajeError { get; set; }

    }
}