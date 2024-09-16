using Microsoft.Web.WebView2.Core;

namespace BaseEjemplo2
{
    partial class Base
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            button1 = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 21);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 0;
            label1.Text = "Texto recibido de webview";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(531, 23);
            textBox1.TabIndex = 1;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(39, 76);
            webView21.Name = "webView21";
            webView21.Size = new Size(501, 352);
            webView21.Source = new Uri("http://localhost:4200/", UriKind.Absolute);
            webView21.TabIndex = 2;
            webView21.ZoomFactor = 1D;
            // 
            // button1
            // 
            button1.Location = new Point(600, 21);
            button1.Name = "button1";
            button1.Size = new Size(110, 59);
            button1.TabIndex = 3;
            button1.Text = "Enviar a Impresión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(578, 112);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // Base
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(webView21);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Base";
            Text = "Form1";
            Load += Form1_LoadAsync;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button button1;
        private ComboBox comboBox1;
    }

    public class Opcion
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name; // Esto permite mostrar solo el nombre en el ComboBox
        }
    }
}
