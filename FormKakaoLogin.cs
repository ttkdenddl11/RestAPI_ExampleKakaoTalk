using Newtonsoft.Json.Linq;
using RestSharp;
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
    public partial class FormKakaoLogin : Form
    {
        public FormKakaoLogin()
        {
            InitializeComponent();
            webViewKakaoLogin.Source = new Uri(DefineKakao.LOGIN_URL);
            //webBrowserKakaoLogin.Navigate(DefineKakao.LOGIN_URL);
        }

        // 로그인 창 웹이 완료 되면 실행
        private void webViewKakaoLogin_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            //REDIRECT_URL로 카카오 서버로부터 인가 코드를 받아옴
            string code = getCode();

            // 인가 코드를 성공적으로 받았으면
            if (code != "")
            {
                DefineKakao.USER_CODE = code;
                DefineKakao.ACCESS_TOKEN = getToken();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        // 인가코드 받아오기
        public string getCode()
        {
            // url 상태 REDIRECT_URL?code=abc123def456  (예시)
            // string url = webViewKakaoLogin.Url.ToString();   webbrowser 사용시
            string url = webViewKakaoLogin.Source.ToString();

            string code = url.Substring(url.IndexOf("=") + 1);

            // 로그인 웹 url과 인가받은 코드를 redirect_url과 비교 (잘 들어갔는지)
            if (url.CompareTo(DefineKakao.REDIRECT_URL + "?code=" + code) == 0)
            {
                return code;
            }
            else
            {
                return "";
            }

        }

        // 토큰 받아오기
        public string getToken()
        {
            // restsharp 라이브러리에서 사용하는 restful 요청 라이브러리
            RestClient client = new RestClient(DefineKakao.HOST_OAUTH_URL);
            // 토큰을 받기 위한 엔드포인트 주소! 와 post방식으로 토큰을 요청 왜? 토큰받기 위해 필요한
            // 일부 데이터들을 전송해야하니까! (조회나 받기 위한 요청은 Get)
            RestRequest request = new RestRequest("/oauth/token", Method.Post);
            request.AddParameter("grant_type", "authorization_code"); // 필수 파라미터 추가
            request.AddParameter("client_id", DefineKakao.API_KEY);
            request.AddParameter("redirect_uri", DefineKakao.REDIRECT_URL);
            request.AddParameter("code", DefineKakao.USER_CODE);

            RestResponse result = client.Execute(request);
            // Newtonsoft.Json.Linq 라이브러리를 이용해서 json 으로 파싱
            JObject json = JObject.Parse(result.Content);

            return json["access_token"].ToString();
        }
    }
}

