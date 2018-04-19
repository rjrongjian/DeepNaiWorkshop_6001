namespace DeepNaiWorkshop_6001.View
{
    partial class MemberControl
    {
        public static int DefaultLocationX = 5;
        public static int DefaultLocationY = 240;
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberControl));
            this.accountPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
            this.memberType = new System.Windows.Forms.Label();
            this.expiredTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logoutButton = new CCWin.SkinControl.SkinButton();
            this.loginButton = new CCWin.SkinControl.SkinButton();
            this.memberCodeText = new CCWin.SkinControl.SkinTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.headerPictureBox = new CCWin.SkinControl.SkinPictureBox();
            this.accountPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Location = new System.Drawing.Point(0, 0);
            ((System.ComponentModel.ISupportInitialize)(this.headerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // accountPanel
            // 
            this.accountPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accountPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.accountPanel.Controls.Add(this.groupBox2);
            this.accountPanel.Controls.Add(this.memberType);
            this.accountPanel.Controls.Add(this.expiredTime);
            this.accountPanel.Controls.Add(this.groupBox1);
            this.accountPanel.Controls.Add(this.label2);
            this.accountPanel.Controls.Add(this.label1);
            this.accountPanel.Controls.Add(this.headerPictureBox);
            this.accountPanel.Location = new System.Drawing.Point(0, 0);
            this.accountPanel.Name = "accountPanel";
            this.accountPanel.Size = new System.Drawing.Size(317, 293);
            this.accountPanel.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.skinButton2);
            this.groupBox2.Controls.Add(this.skinTextBox1);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox2.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox2.Location = new System.Drawing.Point(17, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 101);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "获取会员码方式";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "或复制链接，粘贴到浏览器打开！";
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.skinButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(10)))));
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.skinButton2.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton2.ForeColor = System.Drawing.Color.IndianRed;
            this.skinButton2.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton2.IsDrawGlass = false;
            this.skinButton2.Location = new System.Drawing.Point(222, 64);
            this.skinButton2.MouseBack = null;
            this.skinButton2.MouseBaseColor = System.Drawing.Color.Black;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton2.Size = new System.Drawing.Size(58, 29);
            this.skinButton2.TabIndex = 5;
            this.skinButton2.Text = "去充值";
            this.skinButton2.UseVisualStyleBackColor = false;
            // 
            // skinTextBox1
            // 
            this.skinTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox1.DownBack = null;
            this.skinTextBox1.Icon = null;
            this.skinTextBox1.IconIsButton = false;
            this.skinTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.IsPasswordChat = '\0';
            this.skinTextBox1.IsSystemPasswordChar = false;
            this.skinTextBox1.Lines = new string[] {
        "skinTextBox1"};
            this.skinTextBox1.Location = new System.Drawing.Point(13, 19);
            this.skinTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox1.MaxLength = 32767;
            this.skinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox1.MouseBack = null;
            this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Multiline = false;
            this.skinTextBox1.Name = "skinTextBox1";
            this.skinTextBox1.NormlBack = null;
            this.skinTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox1.ReadOnly = false;
            this.skinTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox1.Size = new System.Drawing.Size(256, 28);
            // 
            // 
            // 
            this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox1.SkinTxt.Name = "BaseText";
            this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(246, 18);
            this.skinTextBox1.SkinTxt.TabIndex = 0;
            this.skinTextBox1.SkinTxt.Text = "skinTextBox1";
            this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.SkinTxt.WaterText = "";
            this.skinTextBox1.TabIndex = 0;
            this.skinTextBox1.Text = "skinTextBox1";
            this.skinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.WaterText = "";
            this.skinTextBox1.WordWrap = true;
            // 
            // memberType
            // 
            this.memberType.AutoSize = true;
            this.memberType.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.memberType.ForeColor = System.Drawing.Color.White;
            this.memberType.Location = new System.Drawing.Point(215, 14);
            this.memberType.Name = "memberType";
            this.memberType.Size = new System.Drawing.Size(72, 16);
            this.memberType.TabIndex = 5;
            this.memberType.Text = "普通会员";
            // 
            // expiredTime
            // 
            this.expiredTime.AutoSize = true;
            this.expiredTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.expiredTime.ForeColor = System.Drawing.Color.White;
            this.expiredTime.Location = new System.Drawing.Point(215, 44);
            this.expiredTime.Name = "expiredTime";
            this.expiredTime.Size = new System.Drawing.Size(88, 16);
            this.expiredTime.TabIndex = 4;
            this.expiredTime.Text = "2018-04-18";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logoutButton);
            this.groupBox1.Controls.Add(this.loginButton);
            this.groupBox1.Controls.Add(this.memberCodeText);
            this.groupBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Location = new System.Drawing.Point(125, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 95);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登录";
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Transparent;
            this.logoutButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.logoutButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(10)))));
            this.logoutButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.logoutButton.DownBack = null;
            this.logoutButton.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.logoutButton.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logoutButton.ForeColor = System.Drawing.Color.IndianRed;
            this.logoutButton.GlowColor = System.Drawing.Color.Transparent;
            this.logoutButton.IsDrawGlass = false;
            this.logoutButton.Location = new System.Drawing.Point(104, 57);
            this.logoutButton.MouseBack = null;
            this.logoutButton.MouseBaseColor = System.Drawing.Color.Black;
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.NormlBack = null;
            this.logoutButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.logoutButton.Size = new System.Drawing.Size(53, 29);
            this.logoutButton.TabIndex = 4;
            this.logoutButton.Text = "登出";
            this.logoutButton.UseVisualStyleBackColor = false;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.loginButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(10)))));
            this.loginButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.loginButton.DownBack = null;
            this.loginButton.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.loginButton.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginButton.ForeColor = System.Drawing.Color.IndianRed;
            this.loginButton.GlowColor = System.Drawing.Color.Transparent;
            this.loginButton.IsDrawGlass = false;
            this.loginButton.Location = new System.Drawing.Point(16, 57);
            this.loginButton.MouseBack = null;
            this.loginButton.MouseBaseColor = System.Drawing.Color.Black;
            this.loginButton.Name = "loginButton";
            this.loginButton.NormlBack = null;
            this.loginButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.loginButton.Size = new System.Drawing.Size(53, 29);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "登录";
            this.loginButton.UseVisualStyleBackColor = false;
            // 
            // memberCodeText
            // 
            this.memberCodeText.BackColor = System.Drawing.Color.Transparent;
            this.memberCodeText.DownBack = null;
            this.memberCodeText.Icon = null;
            this.memberCodeText.IconIsButton = false;
            this.memberCodeText.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.memberCodeText.IsPasswordChat = '\0';
            this.memberCodeText.IsSystemPasswordChar = false;
            this.memberCodeText.Lines = new string[] {
        "请输入会员码"};
            this.memberCodeText.Location = new System.Drawing.Point(16, 21);
            this.memberCodeText.Margin = new System.Windows.Forms.Padding(0);
            this.memberCodeText.MaxLength = 8;
            this.memberCodeText.MinimumSize = new System.Drawing.Size(28, 28);
            this.memberCodeText.MouseBack = null;
            this.memberCodeText.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.memberCodeText.Multiline = true;
            this.memberCodeText.Name = "memberCodeText";
            this.memberCodeText.NormlBack = null;
            this.memberCodeText.Padding = new System.Windows.Forms.Padding(5);
            this.memberCodeText.ReadOnly = false;
            this.memberCodeText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memberCodeText.Size = new System.Drawing.Size(141, 29);
            // 
            // 
            // 
            this.memberCodeText.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memberCodeText.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberCodeText.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.memberCodeText.SkinTxt.ForeColor = System.Drawing.Color.Gray;
            this.memberCodeText.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.memberCodeText.SkinTxt.MaxLength = 8;
            this.memberCodeText.SkinTxt.Multiline = true;
            this.memberCodeText.SkinTxt.Name = "BaseText";
            this.memberCodeText.SkinTxt.Size = new System.Drawing.Size(131, 19);
            this.memberCodeText.SkinTxt.TabIndex = 0;
            this.memberCodeText.SkinTxt.Text = "请输入会员码";
            this.memberCodeText.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.memberCodeText.SkinTxt.WaterText = "";
            this.memberCodeText.TabIndex = 0;
            this.memberCodeText.Text = "请输入会员码";
            this.memberCodeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.memberCodeText.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.memberCodeText.WaterText = "";
            this.memberCodeText.WordWrap = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(138, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "到期日：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "会员类型：";
            // 
            // headerPictureBox
            // 
            this.headerPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.headerPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("headerPictureBox.BackgroundImage")));
            this.headerPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("headerPictureBox.InitialImage")));
            this.headerPictureBox.Location = new System.Drawing.Point(12, 35);
            this.headerPictureBox.Name = "headerPictureBox";
            this.headerPictureBox.Size = new System.Drawing.Size(104, 103);
            this.headerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headerPictureBox.TabIndex = 0;
            this.headerPictureBox.TabStop = false;
            // 
            // MemberControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.accountPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MemberControl";
            this.Size = new System.Drawing.Size(317, 293);
            this.accountPanel.ResumeLayout(false);
            this.accountPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel accountPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinTextBox skinTextBox1;
        private System.Windows.Forms.Label memberType;
        private System.Windows.Forms.Label expiredTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private CCWin.SkinControl.SkinButton logoutButton;
        private CCWin.SkinControl.SkinButton loginButton;
        private CCWin.SkinControl.SkinTextBox memberCodeText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinPictureBox headerPictureBox;
    }
}
