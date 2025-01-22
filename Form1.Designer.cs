
namespace ExamKakaoTalk
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.rdoCustom = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoTemplete = new System.Windows.Forms.RadioButton();
            this.tboxCustom = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(6, 20);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 54);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // rdoCustom
            // 
            this.rdoCustom.AutoSize = true;
            this.rdoCustom.Location = new System.Drawing.Point(87, 30);
            this.rdoCustom.Name = "rdoCustom";
            this.rdoCustom.Size = new System.Drawing.Size(99, 16);
            this.rdoCustom.TabIndex = 1;
            this.rdoCustom.TabStop = true;
            this.rdoCustom.Text = "커스텀 메시지";
            this.rdoCustom.UseVisualStyleBackColor = true;
            this.rdoCustom.CheckedChanged += new System.EventHandler(this.rdoCustom_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.tboxCustom);
            this.groupBox1.Controls.Add(this.rdoTemplete);
            this.groupBox1.Controls.Add(this.rdoCustom);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "나에게 메시지 보내기";
            // 
            // rdoTemplete
            // 
            this.rdoTemplete.AutoSize = true;
            this.rdoTemplete.Location = new System.Drawing.Point(87, 52);
            this.rdoTemplete.Name = "rdoTemplete";
            this.rdoTemplete.Size = new System.Drawing.Size(99, 16);
            this.rdoTemplete.TabIndex = 2;
            this.rdoTemplete.TabStop = true;
            this.rdoTemplete.Text = "템플릿 메시지";
            this.rdoTemplete.UseVisualStyleBackColor = true;
            this.rdoTemplete.CheckedChanged += new System.EventHandler(this.rdoTemplete_CheckedChanged);
            // 
            // tboxCustom
            // 
            this.tboxCustom.Location = new System.Drawing.Point(192, 28);
            this.tboxCustom.Name = "tboxCustom";
            this.tboxCustom.Size = new System.Drawing.Size(153, 21);
            this.tboxCustom.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(318, 55);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(57, 42);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "전송";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 114);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RadioButton rdoCustom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tboxCustom;
        private System.Windows.Forms.RadioButton rdoTemplete;
    }
}

