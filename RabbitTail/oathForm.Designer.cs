namespace RabbitTail
{
    partial class oauthForm
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
            this.button_oath = new System.Windows.Forms.Button();
            this.label_oath = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button_oath
            // 
            this.button_oath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.button_oath.FlatAppearance.BorderSize = 0;
            this.button_oath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_oath.ForeColor = System.Drawing.Color.Silver;
            this.button_oath.Location = new System.Drawing.Point(302, 306);
            this.button_oath.Name = "button_oath";
            this.button_oath.Size = new System.Drawing.Size(171, 60);
            this.button_oath.TabIndex = 0;
            this.button_oath.Text = "認証";
            this.button_oath.UseVisualStyleBackColor = false;
            // 
            // label_oath
            // 
            this.label_oath.AutoSize = true;
            this.label_oath.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_oath.ForeColor = System.Drawing.Color.Silver;
            this.label_oath.Location = new System.Drawing.Point(146, 180);
            this.label_oath.Name = "label_oath";
            this.label_oath.Size = new System.Drawing.Size(178, 37);
            this.label_oath.TabIndex = 1;
            this.label_oath.Text = "OAth認証";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(-2, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 85);
            this.panel1.TabIndex = 2;
            // 
            // oauthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(795, 644);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_oath);
            this.Controls.Add(this.button_oath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "oauthForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_oath;
        private System.Windows.Forms.Label label_oath;
        private System.Windows.Forms.Panel panel1;
    }
}

