
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
            this.webBrowserKakaoLogin = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserKakaoLogin
            // 
            this.webBrowserKakaoLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserKakaoLogin.Location = new System.Drawing.Point(0, 0);
            this.webBrowserKakaoLogin.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserKakaoLogin.Name = "webBrowserKakaoLogin";
            this.webBrowserKakaoLogin.Size = new System.Drawing.Size(450, 450);
            this.webBrowserKakaoLogin.TabIndex = 0;
            this.webBrowserKakaoLogin.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowserKakaoLogin_DocumentCompleted);
            // 
            // FormKakaoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.webBrowserKakaoLogin);
            this.Name = "FormKakaoLogin";
            this.Text = "FormKakaoLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserKakaoLogin;
    }
}