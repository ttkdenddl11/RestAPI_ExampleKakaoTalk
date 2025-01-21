using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamKakaoTalk
{
    class DefineKakao
    {
        //사용자 인증키
        public const string API_KEY = "849426144aaae95829e1aaba3e86636f";  

        // 메시지 템플릿 아이디
        public const string TEMPLATE_ID = "116587";
        // 사용자 에플리케이션 아이디
        public const string USER_ID = "1190775";
        // Redirect URL
        public const string REDIRECT_URL = "https://blog.naver.com/ttkdenddl11/oauth";

        //Login Request URL: https://kauth.kakao.com/oauth/authorize?response_type=code&client_id={REST_API_KEY}&redirect_uri={REDIRECT_URI}
        public const string LOGIN_URL = "https://kauth.kakao.com/oauth/authorize?response_type=code&client_id=" + API_KEY + "&redirect_uri=" + REDIRECT_URL;

        public const string HOST_OAUTH_URL = "https://kauth.kakao.com";
        public const string HOST_API_URL = "https://kapi.kakao.com";

        public static string USER_CODE;
        public static string ACCESS_TOKEN;

    }
}
