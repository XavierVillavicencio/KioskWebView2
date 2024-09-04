using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.Diagnostics;
using Timer = System.Threading.Timer;

namespace WebView2_Kiosk
{
    public partial class Form1 : Form
    {
        public string cadenaRecibidaFinal;
        public Form1(string cadenaRecibida)
        {
            InitializeComponent();
            cadenaRecibidaFinal = cadenaRecibida;
        }


        private async void Form1_LoadAsync(object sender, EventArgs e)
        {
            //show MS Edge version -- also ensures that an exception will be raised if proper MS Edge version isn't installed
            Debug.WriteLine(CoreWebView2Environment.GetAvailableBrowserVersionString());
            // Inicializar WebView2 (si aún no lo has hecho)
            await ContenedorWebView2.EnsureCoreWebView2Async();
            // Suscribirse al evento NavigationStarting
            ContenedorWebView2.NavigationStarting += WebView2_NavigationStarting;

            // Navegar a la URL inicial
            if (cadenaRecibidaFinal.Length > 0)
            {
                ContenedorWebView2.Source = new Uri(cadenaRecibidaFinal);
            } else
            {
                MessageBox.Show("No se envío una URL");
            }
            
        }


        private void WebView2_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            PrintSilently();
            // Desuscribirse del evento NavigationStarting para que se ejecute solo una vez
            ContenedorWebView2.NavigationStarting -= WebView2_NavigationStarting;
        }

        private void Imprimir_Click_1(object sender, EventArgs e)
        {

            PrintSilently();
        }

        // Método para imprimir en modo silencioso
        private void PrintSilently()
        {
            // Obtén la instancia de CoreWebView2
            var coreWebView2 = ContenedorWebView2.CoreWebView2;

            // Configura las opciones de impresión
            var printSettings = coreWebView2.Environment.CreatePrintSettings();
            printSettings.ShouldPrintBackgrounds = true; // Ejemplo de configuración

            // Imprime en modo silencioso
            coreWebView2.PrintAsync(printSettings);
            // System.Environment.Exit(1);
        }
    }
}
