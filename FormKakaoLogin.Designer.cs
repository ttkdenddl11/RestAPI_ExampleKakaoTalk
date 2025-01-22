
namespace ExamKakaoTalk
{
    partial class FormKakaoLogin
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
            this.webViewKakaoLogin = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webViewKakaoLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // webViewKakaoLogin
            // 
            this.webViewKakaoLogin.AllowExternalDrop = true;
            this.webViewKakaoLogin.CreationProperties = null;
            this.webViewKakaoLogin.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewKakaoLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webViewKakaoLogin.Location = new System.Drawing.Point(0, 0);
            this.webViewKakaoLogin.Name = "webViewKakaoLogin";
            this.webViewKakaoLogin.Size = new System.Drawing.Size(450, 450);
            this.webViewKakaoLogin.TabIndex = 0;
            this.webViewKakaoLogin.ZoomFactor = 1D;
            this.webViewKakaoLogin.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.webViewKakaoLogin_NavigationCompleted);
            // 
            // FormKakaoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.webViewKakaoLogin);
            this.Name = "FormKakaoLogin";
            this.Text = "FormKakaoLogin";
            ((System.ComponentModel.ISupportInitialize)(this.webViewKakaoLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webViewKakaoLogin;
    }
}