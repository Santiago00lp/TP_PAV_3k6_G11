﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV3k6.Formularios;
using PAV3k6.Formularios.Escribanos;
using PAV3k6.Formularios.Tipo_Moneda;


namespace PAV3k6
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_ABM_Escribano());
        }
    }
}
