using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamKakaoTalk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(btnLogin.Text == "로그인")
            {
                FormKakaoLogin form = new FormKakaoLogin();
                if(form.ShowDialog() == DialogResult.OK)
                {
                    btnLogin.Text = "로그아웃";
                }
            }
        }
    }
}
