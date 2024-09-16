using Microsoft.Web.WebView2.Core;
using System.Diagnostics;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaseEjemplo2
{
    public partial class Base : Form
    {
        private String msg;
        public Base()
        {
            InitializeComponent();
            
            webView21.CoreWebView2InitializationCompleted += Form1_LoadAsync;
            // Asignar el evento Click al botón
            comboBox1.SelectedIndexChanged += new EventHandler(comboBox_Click);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Opcion[] opciones = new Opcion[]
            {
                new Opcion { Id = "0", Name = "Maggie Meyer" },
                new Opcion { Id = "SNGL", Name = "Post-Compra" },
                new Opcion { Id = "MULT", Name = "Pre-compra" },
                new Opcion { Id = "OFF", Name = "Desactivado" },
                new Opcion { Id = "All", Name = "Todos" }
            };

            comboBox1.Items.AddRange(opciones);
            // Seleccionar el último item
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = comboBox1.Items.Count - 1; // Selecciona el último elemento
            }
        }

        async void Form1_LoadAsync(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();
            webView21.CoreWebView2.Settings.IsWebMessageEnabled = true;
            webView21.CoreWebView2.WebMessageReceived += MessageReceived;            
        }

        private void comboBox_Click(object sender, EventArgs e)
        {
            Opcion opcionSeleccionada = (Opcion)comboBox1.SelectedItem;
            MessageBox.Show($"Has seleccionado: {opcionSeleccionada.Name} con ID: {opcionSeleccionada.Id}");
        }

        void MessageReceived(Object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            textBox1.Text = "Cargando...";
            string mimeType = args.WebMessageAsJson;
            //webView21.CoreWebView2.PostWebMessageAsString("true");
            //var data = JsonSerializer.Deserialize<string>(args.WebMessageAsJson);
            // string msg = args.TryGetWebMessageAsString();
            textBox1.Text = mimeType;
            //Process.Start("C:\\Users\\xavie\\source\\repos\\WebView2-Kiosk\\bin\\Debug\\net8.0-windows\\WebView2-Kiosk.exe \"" + msg + "\"");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\xavie\\source\\repos\\WebView2-Kiosk\\bin\\Debug\\net8.0-windows\\WebView2-Kiosk.exe \"" + msg + "\"");
        }
    }
}
