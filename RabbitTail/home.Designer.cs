namespace RabbitTail
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.SideMenu = new System.Windows.Forms.Panel();
            this.Button1 = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Panel();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TextBoxTweet = new System.Windows.Forms.RichTextBox();
            this.ButtonTweet = new System.Windows.Forms.Button();
            this.EnabledTimer = new System.Windows.Forms.Timer(this.components);
            this.SideMenu.SuspendLayout();
            this.TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SideMenu.Controls.Add(this.Button1);
            this.SideMenu.Controls.Add(this.Logo);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.Location = new System.Drawing.Point(0, 0);
            this.SideMenu.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(241, 744);
            this.SideMenu.TabIndex = 0;
            // 
            // Button1
            // 
            this.Button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button1.Location = new System.Drawing.Point(0, 82);
            this.Button1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(241, 60);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "button1";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(241, 82);
            this.Logo.TabIndex = 0;
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TitleBar.Controls.Add(this.CloseButton);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(241, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(1003, 30);
            this.TitleBar.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(965, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(38, 30);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "✕";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TextBoxTweet
            // 
            this.TextBoxTweet.Location = new System.Drawing.Point(843, 403);
            this.TextBoxTweet.Name = "TextBoxTweet";
            this.TextBoxTweet.Size = new System.Drawing.Size(352, 162);
            this.TextBoxTweet.TabIndex = 2;
            this.TextBoxTweet.Text = "";
            // 
            // ButtonTweet
            // 
            this.ButtonTweet.Enabled = false;
            this.ButtonTweet.Location = new System.Drawing.Point(1073, 614);
            this.ButtonTweet.Name = "ButtonTweet";
            this.ButtonTweet.Size = new System.Drawing.Size(122, 49);
            this.ButtonTweet.TabIndex = 3;
            this.ButtonTweet.Text = "button2";
            this.ButtonTweet.UseVisualStyleBackColor = true;
            this.ButtonTweet.Click += new System.EventHandler(this.ButtonTweet_Click);
            // 
            // EnabledTimer
            // 
            this.EnabledTimer.Enabled = true;
            this.EnabledTimer.Tick += new System.EventHandler(this.EnabledTimer_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1244, 744);
            this.Controls.Add(this.ButtonTweet);
            this.Controls.Add(this.TextBoxTweet);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.SideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Home";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.home_Load);
            this.Shown += new System.EventHandler(this.Home_Shown);
            this.SideMenu.ResumeLayout(false);
            this.TitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideMenu;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.RichTextBox TextBoxTweet;
        private System.Windows.Forms.Button ButtonTweet;
        private System.Windows.Forms.Timer EnabledTimer;
    }
}