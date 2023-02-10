namespace Projekt
{
    partial class formDomu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.casovac = new System.Windows.Forms.Timer(this.components);
            this.labelHodiny = new System.Windows.Forms.Label();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // casovac
            // 
            this.casovac.Interval = 1000;
            this.casovac.Tick += new System.EventHandler(this.casovac_Tick);
            // 
            // labelHodiny
            // 
            this.labelHodiny.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHodiny.ForeColor = System.Drawing.Color.White;
            this.labelHodiny.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelHodiny.Location = new System.Drawing.Point(327, 9);
            this.labelHodiny.Name = "labelHodiny";
            this.labelHodiny.Size = new System.Drawing.Size(378, 33);
            this.labelHodiny.TabIndex = 1;
            this.labelHodiny.Text = "Načítám...";
            this.labelHodiny.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(12, 92);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(693, 334);
            this.webView21.TabIndex = 2;
            this.webView21.ZoomFactor = 1D;
            // 
            // formDomu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(717, 438);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.labelHodiny);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formDomu";
            this.Text = "formDomu";
            this.Load += new System.EventHandler(this.formDomu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer casovac;
        private Label labelHodiny;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}