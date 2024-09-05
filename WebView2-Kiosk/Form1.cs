using Microsoft.Web.WebView2.Core;
using System.Diagnostics;
using Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

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

        }


        private void WebView2_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            if (cadenaRecibidaFinal.Length > 0)
            {
                // Desuscribirse del evento NavigationStarting para que se ejecute solo una vez
                ContenedorWebView2.NavigationStarting -= WebView2_NavigationStarting;
                try
                {
                    string extension = DeterminarTipoArchivo();
                    if (extension == "PDF")
                    {
                        PrintURL();
                    }
                    else if (extension == "DOCX")
                    {
                        PrintWordFile();
                    }
                    else if (extension == "XLSX")
                    {
                        PrintExcelFile();
                    }
                    else
                    {
                        throw new Exception("Error, no hay extensión en el archivo");
                        System.Environment.Exit(1);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al determinar el tipo de archivo: {ex.Message}");
                }
            }

        }

        private string DeterminarTipoArchivo()
        {
            try
            {

                // Obtener la extensión del archivo
                string extension = Path.GetExtension(path: cadenaRecibidaFinal).ToLowerInvariant();

                // Extensión conocida
                if (extension == ".pdf" || extension == ".xlsx" || extension == ".docx")
                {
                    return extension.ToUpper().TrimStart('.');
                }

                return "Tipo de archivo desconocido";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al determinar el tipo de archivo: {ex.Message}");
                return "Error";
            }
        }

        private void Imprimir_Click_1(object sender, EventArgs e)
        {
            string directorioActual = Directory.GetCurrentDirectory();
            cadenaRecibidaFinal = directorioActual+"/PRODUBANCO-04-09-2024.docx";
            PrintWordFile();
        }



        private void Imprimir_Click_2(object sender, EventArgs e)
        {
            string directorioActual = Directory.GetCurrentDirectory();
            cadenaRecibidaFinal = directorioActual + "/CREDITO-04-09-2024.xlsx";
            PrintExcelFile();
        }

        // Método para imprimir en modo silencioso
        private async void PrintURL()
        {
            // Obtén la instancia de CoreWebView2
            var coreWebView2 = ContenedorWebView2.CoreWebView2;
            coreWebView2.Navigate(cadenaRecibidaFinal);
            // Suscríbete al evento NavigationCompleted
            coreWebView2.NavigationCompleted += async (sender, args) =>
            {
                if (args.IsSuccess)
                {
                    try
                    {
                        // Configura las opciones de impresión
                        var printSettings = coreWebView2.Environment.CreatePrintSettings();
                        printSettings.ShouldPrintBackgrounds = true;

                        // Imprime en modo silencioso
                        await coreWebView2.PrintAsync(printSettings);
                        System.Environment.Exit(1);
                    }
                    catch (Exception ex)
                    {
                        // Maneja errores de impresión
                        MessageBox.Show($"Error al imprimir: {ex.Message}");
                    }
                }
            };
        }

        private void PrintWordFile()
        {
            // Crear una instancia de Word
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();

            // Abrir el documento
            Document doc = wordApp.Documents.Open(cadenaRecibidaFinal);

            // Configurar opciones de impresión (opcional)
            // Ejemplo: Imprimir 2 copias
            doc.PrintOut();

            // Cerrar Word
            wordApp.Quit();
            System.Environment.Exit(1);
        }

        private void PrintExcelFile()
        {
            // Crear una instancia de Excel
            Excel.Application excelApp = new Excel.Application();
            // Abrir el documento
            Excel._Workbook oWB = excelApp.Workbooks.Open(cadenaRecibidaFinal);
            Excel._Worksheet oSheet = (Excel._Worksheet)oWB.ActiveSheet;

            // Configurar opciones de impresión (opcional) No puedo activar esto porque no tengo una impresora de verdad
            // oSheet.PageSetup.Zoom = false;
            // oSheet.PageSetup.FitToPagesWide = 1;
            // oSheet.PageSetup.FitToPagesTall = 0;
            //oSheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;
            //oSheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;

            // Ejemplo: Imprimir 2 copias
            oSheet.PrintOut();

            // Cerrar Word
            excelApp.Quit();
            System.Environment.Exit(1);
        }

        private void ImprimirWebView_Click(object sender, EventArgs e)
        {
            string directorioActual = Directory.GetCurrentDirectory();
            cadenaRecibidaFinal = "file:///"+directorioActual + "/ejemplo_003.pdf";
            PrintURL();
        }
    }
}
