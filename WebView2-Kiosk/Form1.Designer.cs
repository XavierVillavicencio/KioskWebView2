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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ContenedorWebView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            Imprimir = new Button();
            ((System.ComponentModel.ISupportInitialize)ContenedorWebView2).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(454, 56);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(248, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(305, 54);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 1;
            label1.Text = "Es  una prueba";
            // 
            // ContenedorWebView2
            // 
            ContenedorWebView2.AllowExternalDrop = true;
            ContenedorWebView2.BackgroundImageLayout = ImageLayout.None;
            ContenedorWebView2.CreationProperties = null;
            ContenedorWebView2.DefaultBackgroundColor = Color.White;
            ContenedorWebView2.Location = new Point(274, 100);
            ContenedorWebView2.Name = "ContenedorWebView2";
            ContenedorWebView2.Size = new Size(377, 795);
            ContenedorWebView2.Source = new Uri("file:///C:/Users/xavie/Downloads/ejemplos_archivos/ejempl_001.pdf", UriKind.Absolute);
            ContenedorWebView2.TabIndex = 2;
            ContenedorWebView2.ZoomFactor = 1D;
            // 
            // Imprimir
            // 
            Imprimir.Location = new Point(774, 56);
            Imprimir.Name = "Imprimir";
            Imprimir.Size = new Size(75, 23);
            Imprimir.TabIndex = 3;
            Imprimir.Text = "Imprimir";
            Imprimir.UseVisualStyleBackColor = true;
            Imprimir.Click += Imprimir_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 534);
            Controls.Add(Imprimir);
            Controls.Add(ContenedorWebView2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_LoadAsync;
            ((System.ComponentModel.ISupportInitialize)ContenedorWebView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        public System.Drawing.Printing.PrintDocument printDocument1;
        private Microsoft.Web.WebView2.WinForms.WebView2 ContenedorWebView2;
        private Button Imprimir;
    }
}
