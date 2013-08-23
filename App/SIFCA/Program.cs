using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.Caching;
using SIFCA_DAL;

namespace SIFCA
{
    public sealed class ContextProvider
    {
        private static readonly SIFCA_CONTEXT contextData = new SIFCA_CONTEXT();

        static ContextProvider() { }

        private ContextProvider() { }

        public static SIFCA_CONTEXT ContextData
        {
            get
            {
                return contextData;
            }
        }
    }

    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        
        public static ObjectCache cache = MemoryCache.Default;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal_Form());
        }
    }
}
