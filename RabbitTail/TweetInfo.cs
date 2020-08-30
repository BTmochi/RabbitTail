using CoreTweet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static CoreTweet.OAuth;

namespace RabbitTail
{
    class TweetInfo
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        private TweetInfo()
        {
        }

        #region private variable
        private OAuthSession session = null;
        private Tokens tokens = null;
        private const string API_KEY = "XNpnSRtsPmkSJ4fmCeAwiJRjJ";
        private const string API_KEY_SECRET = "MgDeiChRSoEbaIimYIv721dpxK2GJ4PZcJ0W5iyCDxP6npMbHe";
        #endregion

        #region private method

        #endregion

        #region public method
        /// <summary>
        /// トークンの保存有無確認
        /// </summary>
        /// <returns>true:保存済み/false:保存なし</returns>
        public bool CheckTokens()
        {
            bool result = false;

            tokens = Properties.Settings.Default.tokens;
            if (tokens != null)
            {
                result = true;
            }
            
            return result;
        }

        /// <summary>
        /// アプリ認証
        /// </summary>
        public void AuthorizeApplication()
        {
            session = Authorize(API_KEY, API_KEY_SECRET);
            Process.Start(session.AuthorizeUri.AbsoluteUri);
        }

        /// <summary>
        /// トークン取得
        /// </summary>
        /// <param name="_pinCode"></param>
        /// <returns>true:成功/false:失敗</returns>
        public bool GetTokens(string _pinCode)
        {
            bool result = false;
            if (Regex.IsMatch(_pinCode, @"^\d+$"))
            {
                tokens = OAuth.GetTokens(session, _pinCode);
                result = true;
            }
            return result;
        }

        public void Tweet(string _text)
        {
            tokens.Statuses.Update(status => _text);
        }
        #endregion

        #region singleton
        private static TweetInfo _theInstance = new TweetInfo();
        public static TweetInfo GetInstance() => _theInstance;
        #endregion
    }
}
