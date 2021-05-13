using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV3k6.Clases
{
    class MaskedTextBoxHeredado : MaskedTextBox
    {
        public string Pp_NombreTabla { get; set; }

        public string Pp_NombreCampo { get; set; }

        public bool Pp_Validable { get; set; }

        public string Pp_MensajeError { get; set; }

        public string Pp_MaskxDefecto { get; set; }
    }
}