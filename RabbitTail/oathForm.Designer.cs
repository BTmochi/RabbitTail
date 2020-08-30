namespace RabbitTail
{
    partial class OauthForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_oath = new System.Windows.Forms.Label();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Label_PinCode = new System.Windows.Forms.Label();
            this.Button_oath = new System.Windows.Forms.Button();
            this.TextPinCode = new System.Windows.Forms.TextBox();
            this.TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_oath
            // 
            this.Label_oath.AutoSize = true;
            this.Label_oath.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label_oath.ForeColor = System.Drawing.Color.Silver;
            this.Label_oath.Location = new System.Drawing.Point(10, 9);
            this.Label_oath.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Label_oath.Name = "Label_oath";
            this.Label_oath.Size = new System.Drawing.Size(95, 19);
            this.Label_oath.TabIndex = 1;
            this.Label_oath.Text = "OAth認証";
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TitleBar.Controls.Add(this.CloseButton);
            this.TitleBar.Controls.Add(this.Label_oath);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(227, 35);
            this.TitleBar.TabIndex = 2;
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
            this.CloseButton.Location = new System.Drawing.Point(188, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(38, 35);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "✕";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Label_PinCode
            // 
            this.Label_PinCode.AutoSize = true;
            this.Label_PinCode.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Label_PinCode.ForeColor = System.Drawing.Color.Silver;
            this.Label_PinCode.Location = new System.Drawing.Point(10, 73);
            this.Label_PinCode.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Label_PinCode.Name = "Label_PinCode";
            this.Label_PinCode.Size = new System.Drawing.Size(74, 16);
            this.Label_PinCode.TabIndex = 3;
            this.Label_PinCode.Text = "PINコード";
            // 
            // Button_oath
            // 
            this.Button_oath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Button_oath.FlatAppearance.BorderSize = 0;
            this.Button_oath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_oath.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button_oath.ForeColor = System.Drawing.Color.White;
            this.Button_oath.Location = new System.Drawing.Point(144, 118);
            this.Button_oath.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Button_oath.Name = "Button_oath";
            this.Button_oath.Size = new System.Drawing.Size(67, 25);
            this.Button_oath.TabIndex = 0;
            this.Button_oath.Text = "認証";
            this.Button_oath.UseVisualStyleBackColor = false;
            this.Button_oath.Click += new System.EventHandler(this.Button_oath_Click);
            // 
            // TextPinCode
            // 
            this.TextPinCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.TextPinCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextPinCode.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextPinCode.ForeColor = System.Drawing.Color.White;
            this.TextPinCode.Location = new System.Drawing.Point(88, 73);
            this.TextPinCode.Name = "TextPinCode";
            this.TextPinCode.Size = new System.Drawing.Size(123, 16);
            this.TextPinCode.TabIndex = 4;
            // 
            // OauthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(227, 154);
            this.Controls.Add(this.TextPinCode);
            this.Controls.Add(this.Label_PinCode);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.Button_oath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "OauthForm";
            this.Load += new System.EventHandler(this.OauthForm_Load);
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_oath;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label Label_PinCode;
        private System.Windows.Forms.Button Button_oath;
        private System.Windows.Forms.TextBox TextPinCode;
    }
}

