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
    public partial class OauthForm : Form
    {
        private OauthForm()
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
        private void OauthForm_Load(object sender, EventArgs e)
        {
            TitleBar.MouseDown += new MouseEventHandler(OauthForm_MouseDown);
            TitleBar.MouseMove += new MouseEventHandler(OauthForm_MouseMove);
            Label_oath.MouseDown += new MouseEventHandler(OauthForm_MouseDown);
            Label_oath.MouseMove += new MouseEventHandler(OauthForm_MouseMove);
        }

        /// <summary>
        /// マウスが押された時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OauthForm_MouseDown(object sender, MouseEventArgs e)
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
        private void OauthForm_MouseMove(object sender, MouseEventArgs e)
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
            Home.GetInstance().Close();
        }

        /// <summary>
        /// 認証ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_oath_Click(object sender, EventArgs e)
        {
            if (TweetInfo.GetInstance().GetTokens(TextPinCode.Text))
            {
                this.Close();
                Home.GetInstance().Enabled = true;
            }
            else
            {
                MessageBox.Show("認証に失敗しました。");
            }
        }
        #endregion

        #region singleton
        private static OauthForm _theInstance = new OauthForm();
        public static OauthForm GetInstance() => _theInstance;
        #endregion
    }
}
