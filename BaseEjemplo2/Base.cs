using Microsoft.Web.WebView2.Core;
using System.Diagnostics;
using System.Xml;

namespace BaseEjemplo2
{
    public partial class Base : Form
    {
        private String msg;
        public Base()
        {
            InitializeComponent();
        }

        async void Form1_LoadAsync(object sender, EventArgs e)
        {
            Console.WriteLine("Esto se lee por aca");
            await webView21.EnsureCoreWebView2Async();
            webView21.CoreWebView2.Settings.IsWebMessageEnabled = true;
            webView21.CoreWebView2.WebMessageReceived += MessageReceived;
        }

        void MessageReceived(Object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            msg = args.TryGetWebMessageAsString();
            textBox1.Text = msg;
            Process.Start("C:\\Users\\xavie\\source\\repos\\WebView2-Kiosk\\bin\\Debug\\net8.0-windows\\WebView2-Kiosk.exe \"" + msg + "\"");
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
