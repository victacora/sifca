using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.Caching;
using SIFCA_DAL;

namespace SIFCA
{

    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>

        public static ObjectCache Cache = MemoryCache.Default;

        public static SIFCA_CONTEXT ContextData = new SIFCA_CONTEXT();

        [STAThread]
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-CO");//en-US, es-CO
            AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal_Form());
        }
    }
}
