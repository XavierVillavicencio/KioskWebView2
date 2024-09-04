namespace WebView2_Kiosk
{
    class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string cadenaRecibida;
            if (args.Length == 0){
                cadenaRecibida = "file:///C:/Users/xavie/Downloads/ejemplos_archivos/ejemplo_003.pdf";
            } else {
                cadenaRecibida = args[0];
            }
            Application.Run(new Form1(cadenaRecibida));
        }

    }
}