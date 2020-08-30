using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitTail
{
    public partial class Home : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        private Home()
        {
            InitializeComponent();
        }

        #region private variable
        /// <summary>マウス位置</summary>
        private Point mousePoint;
        #endregion

        #region private method
        /// <summary>
        /// フォームロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void home_Load(object sender, EventArgs e)
        {
            TitleBar.MouseDown += new MouseEventHandler(home_MouseDown);
            TitleBar.MouseMove += new MouseEventHandler(home_MouseMove);
            Logo.MouseDown += new MouseEventHandler(home_MouseDown);
            Logo.MouseMove += new MouseEventHandler(home_MouseMove);
        }

        /// <summary>
        /// マウスが押された時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void home_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                mousePoint = new Point(e.X, e.Y);
            }
        }

        /// <summary>
        /// マウスが動いた時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void home_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }

        /// <summary>
        /// ✕ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// ホームウィンドウ表示直後
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Home_Shown(object sender, EventArgs e)
        {
            // トークンの確認
            if (!TweetInfo.GetInstance().CheckTokens())
            {
                TweetInfo.GetInstance().AuthorizeApplication();
                OauthForm.GetInstance().Show();
                this.Enabled = false;
            }
        }
        #endregion


        #region singleton
        private static Home _theInstance = new Home();
        public static Home GetInstance() => _theInstance;
        #endregion

        /// <summary>
        /// ツイートボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonTweet_Click(object sender, EventArgs e)
        {
            TweetInfo.GetInstance().Tweet(TextBoxTweet.Text);
        }

        private void EnabledTimer_Tick(object sender, EventArgs e)
        {
            if (TextBoxTweet.Text == "")
            {
                ButtonTweet.Enabled = false;
            }
            else
            {
                ButtonTweet.Enabled = true;
            }
        }
    }
}
