using Microsoft.Web.WebView2.Core;

namespace WebView2_Kiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Asegúrate de tener la referencia a Microsoft.Web.WebView2.Core


        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ContenedorWebView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ImprimirExcel = new Button();
            Imprimir = new Button();
            ImprimirWebView = new Button();
            ((System.ComponentModel.ISupportInitialize)ContenedorWebView2).BeginInit();
            SuspendLayout();
            // 
            // ContenedorWebView2
            // 
            ContenedorWebView2.AllowExternalDrop = true;
            ContenedorWebView2.BackgroundImageLayout = ImageLayout.None;
            ContenedorWebView2.CreationProperties = null;
            ContenedorWebView2.DefaultBackgroundColor = Color.White;
            ContenedorWebView2.Location = new Point(30, 37);
            ContenedorWebView2.Name = "ContenedorWebView2";
            ContenedorWebView2.Size = new Size(280, 268);
            ContenedorWebView2.Source = new Uri("file:///C:/Users/xavie/Downloads/ejemplos_archivos/ejempl_001.pdf", UriKind.Absolute);
            ContenedorWebView2.TabIndex = 2;
            ContenedorWebView2.ZoomFactor = 1D;
            // 
            // ImprimirExcel
            // 
            ImprimirExcel.Location = new Point(336, 87);
            ImprimirExcel.Name = "ImprimirExcel";
            ImprimirExcel.Size = new Size(75, 48);
            ImprimirExcel.TabIndex = 4;
            ImprimirExcel.Text = "Imprimir Excel";
            ImprimirExcel.UseVisualStyleBackColor = true;
            ImprimirExcel.Click += Imprimir_Click_2;
            // 
            // Imprimir
            // 
            Imprimir.Location = new Point(336, 37);
            Imprimir.Name = "Imprimir";
            Imprimir.Size = new Size(75, 44);
            Imprimir.TabIndex = 3;
            Imprimir.Text = "Imprimir Word";
            Imprimir.UseVisualStyleBackColor = true;
            Imprimir.Click += Imprimir_Click_1;
            // 
            // ImprimirWebView
            // 
            ImprimirWebView.Location = new Point(336, 141);
            ImprimirWebView.Name = "ImprimirWebView";
            ImprimirWebView.Size = new Size(75, 48);
            ImprimirWebView.TabIndex = 5;
            ImprimirWebView.Text = "Imprimir PDF";
            ImprimirWebView.UseVisualStyleBackColor = true;
            ImprimirWebView.Click += ImprimirWebView_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 327);
            Controls.Add(ImprimirWebView);
            Controls.Add(Imprimir);
            Controls.Add(ImprimirExcel);
            Controls.Add(ContenedorWebView2);
            Name = "Form1";
            Text = "WebView Impresión Silenciosa";
            Load += Form1_LoadAsync;
            ((System.ComponentModel.ISupportInitialize)ContenedorWebView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public System.Drawing.Printing.PrintDocument printDocument1;
        private Microsoft.Web.WebView2.WinForms.WebView2 ContenedorWebView2;
        private Button ImprimirExcel;
        private Button Imprimir;
        private Button ImprimirWebView;
    }
}
