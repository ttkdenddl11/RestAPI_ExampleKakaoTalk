using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            else
            {
                RestClient client = new RestClient(DefineKakao.HOST_API_URL);

                RestRequest request = new RestRequest("/v1/user/unlink", Method.Post);
                request.AddHeader("Authorization", "bearer " + DefineKakao.ACCESS_TOKEN);

                if(client.Execute(request).IsSuccessful)
                {
                    btnLogin.Text = "로그인";
                }
            }
        }

        // WebBroswer 컨트롤 이용할시 IE11 버전 문제 때문에 사용하는 FUNC 
        // WebView2 사용할거라 안썼음.
        private void SetIE11KeyforWebBrowserControl(string appName)
        {
            RegistryKey Regkey = null;
            try
            {
                // For 64 bit machine
                if (Environment.Is64BitOperatingSystem)
                    Regkey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\Wow6432Node\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                else  //For 32 bit machine
                    Regkey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);

                // If the path is not correct or
                // if the user haven't priviledges to access the registry
                if (Regkey == null)
                {
                    MessageBox.Show("Application Settings Failed - Address Not found");
                    return;
                }

                string FindAppkey = Convert.ToString(Regkey.GetValue(appName));

                // IE11 버전이 이미 설정이 되어있다면 넘어갑니다.
                if (FindAppkey == "11001")
                {
                    Regkey.Close();
                    return;
                }

                //키가 다른 값으로 존재한다면, 11001(10진수)로 설정합니다.
                if (string.IsNullOrEmpty(FindAppkey))
                    Regkey.SetValue(appName, unchecked((int)0x2AF9), RegistryValueKind.DWord);

                FindAppkey = Convert.ToString(Regkey.GetValue(appName));

                if (FindAppkey == "11001")
                    MessageBox.Show("IE11 적용이 완료됐습니다.");
                else
                    MessageBox.Show("IE11 적용이 실패했습니다, 키 값: " + FindAppkey);
            }
            catch (Exception ex)
            {
                MessageBox.Show("IE11 적용이 실패했습니다.");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Regkey != null)
                    Regkey.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var appName = Process.GetCurrentProcess().ProcessName + ".exe";
            //SetIE11KeyforWebBrowserControl(appName);
        }

        private void rdoCustom_CheckedChanged(object sender, EventArgs e)
        {
            tboxCustom.Enabled = true;
        }

        private void rdoTemplete_CheckedChanged(object sender, EventArgs e)
        {
            tboxCustom.Enabled = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(rdoCustom.Checked)
            {
                if(tboxCustom.Text == "")
                {
                    MessageBox.Show("메시지를 제대로 입력해주세요.");
                } 
                else
                {
                    sendToMeCustom(tboxCustom.Text);
                }
            }
            else
            {
                sendToMeTemplete();
            }
        }
        private void sendToMeCustom(string message)
        {
            //Json 구성
            JObject send = new JObject();
            JObject link = new JObject();
            send.Add("object_type", "text");
            send.Add("text", message);
            link.Add("web_url", "https://developers.kakao.com");
            link.Add("mobile_web_url", "https://developers.kakao.com");
            send.Add("link", link);
            send.Add("button_title", "바로 확인");
            string send_str = send.ToString();

            // 요청
            RestClient client = new RestClient(DefineKakao.HOST_API_URL);
            RestRequest request = new RestRequest("/v2/api/talk/memo/default/send", Method.Post);
            //request.AddHeader("Content-Type", "application/x-www-form-urlencoded;charset=utf-8");
            request.AddHeader("Authorization", "Bearer " + DefineKakao.ACCESS_TOKEN);
            request.AddParameter("template_object", send_str);

            if (client.Execute(request).IsSuccessful)
            {
                MessageBox.Show("메시지 전송 성공!");
            }
            else
            {
                MessageBox.Show("메시지 전송 실패!");
            }
        }
        private void sendToMeTemplete()
        {
            var client = new RestClient(DefineKakao.HOST_API_URL);

            var request = new RestRequest("/v2/api/talk/memo/send", Method.Post);
            request.AddHeader("Authorization", "bearer " + DefineKakao.ACCESS_TOKEN);
            request.AddParameter("template_id", DefineKakao.TEMPLATE_ID);

            if (client.Execute(request).IsSuccessful)
                MessageBox.Show("메시지 보내기 성공");
            else
                MessageBox.Show("메시지 보내기 실패");
        }
    }
}
