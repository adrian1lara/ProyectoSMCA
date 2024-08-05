using AplicacionWindows_ESCUELA;
using SYSMCA_GUI;
using TestWindows_WCF_Matriculas;
using TestWindows_WCF_SistemaMatricula;

namespace Windows_Tes
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MDIPrincipal());
        }
    }
}