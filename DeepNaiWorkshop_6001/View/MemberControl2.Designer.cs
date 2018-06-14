namespace DeepNaiWorkshop_6001.View
{
    partial class MemberControl2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberControl2));
            this.accountPanel = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPage1 = new CCWin.SkinControl.SkinTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginPageRememberMe = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginPagePassword = new CCWin.SkinControl.SkinTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginButton = new CCWin.SkinControl.SkinButton();
            this.loginPageUserName = new CCWin.SkinControl.SkinTextBox();
            this.skinTabPage2 = new CCWin.SkinControl.SkinTabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.registPageEmail = new CCWin.SkinControl.SkinTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.registPagePassword = new CCWin.SkinControl.SkinTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.registPageUserName = new CCWin.SkinControl.SkinTextBox();
            this.skinTabPage3 = new CCWin.SkinControl.SkinTabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rechargePageRec = new CCWin.SkinControl.SkinTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rechargePageCard = new CCWin.SkinControl.SkinTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.rechargePageUserName = new CCWin.SkinControl.SkinTextBox();
            this.registerTip = new System.Windows.Forms.Label();
            this.rechargeTip = new System.Windows.Forms.Label();
            this.accountPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.skinTabControl1.SuspendLayout();
            this.skinTabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.skinTabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.skinTabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountPanel
            // 
            this.accountPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accountPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.accountPanel.Controls.Add(this.linkLabel1);
            this.accountPanel.Controls.Add(this.groupBox2);
            this.accountPanel.Location = new System.Drawing.Point(0, 0);
            this.accountPanel.Name = "accountPanel";
            this.accountPanel.Size = new System.Drawing.Size(317, 293);
            this.accountPanel.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.LightSteelBlue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.IndianRed;
            this.linkLabel1.Location = new System.Drawing.Point(19, 272);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(221, 12);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "做任务领取充值卡？点我了解一下！！！";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.groupBox2.Controls.Add(this.skinTabControl1);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox2.ForeColor = System.Drawing.Color.IndianRed;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 247);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "会员操作";
            // 
            // skinTabControl1
            // 
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Controls.Add(this.skinTabPage1);
            this.skinTabControl1.Controls.Add(this.skinTabPage2);
            this.skinTabControl1.Controls.Add(this.skinTabPage3);
            this.skinTabControl1.HeadBack = null;
            this.skinTabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl1.ItemSize = new System.Drawing.Size(70, 36);
            this.skinTabControl1.Location = new System.Drawing.Point(6, 22);
            this.skinTabControl1.Name = "skinTabControl1";
            this.skinTabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowDown")));
            this.skinTabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowHover")));
            this.skinTabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseHover")));
            this.skinTabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseNormal")));
            this.skinTabControl1.PageDown = null;
            this.skinTabControl1.PageDownTxtColor = System.Drawing.Color.WhiteSmoke;
            this.skinTabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageHover")));
            this.skinTabControl1.PageHoverTxtColor = System.Drawing.Color.Maroon;
            this.skinTabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl1.PageNorml = null;
            this.skinTabControl1.PageNormlTxtColor = System.Drawing.Color.IndianRed;
            this.skinTabControl1.SelectedIndex = 0;
            this.skinTabControl1.Size = new System.Drawing.Size(281, 219);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl1.TabIndex = 0;
            // 
            // skinTabPage1
            // 
            this.skinTabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.skinTabPage1.Controls.Add(this.groupBox1);
            this.skinTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTabPage1.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage1.Name = "skinTabPage1";
            this.skinTabPage1.Size = new System.Drawing.Size(281, 183);
            this.skinTabPage1.TabIndex = 0;
            this.skinTabPage1.TabItemImage = null;
            this.skinTabPage1.Text = "登录";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginPageRememberMe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.loginPagePassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.loginButton);
            this.groupBox1.Controls.Add(this.loginPageUserName);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // loginPageRememberMe
            // 
            this.loginPageRememberMe.AutoSize = true;
            this.loginPageRememberMe.Location = new System.Drawing.Point(65, 136);
            this.loginPageRememberMe.Name = "loginPageRememberMe";
            this.loginPageRememberMe.Size = new System.Drawing.Size(68, 17);
            this.loginPageRememberMe.TabIndex = 16;
            this.loginPageRememberMe.Text = "记住我";
            this.loginPageRememberMe.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "密  码：";
            // 
            // loginPagePassword
            // 
            this.loginPagePassword.BackColor = System.Drawing.Color.Transparent;
            this.loginPagePassword.DownBack = null;
            this.loginPagePassword.Icon = null;
            this.loginPagePassword.IconIsButton = false;
            this.loginPagePassword.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.loginPagePassword.IsPasswordChat = '*';
            this.loginPagePassword.IsSystemPasswordChar = false;
            this.loginPagePassword.Lines = new string[0];
            this.loginPagePassword.Location = new System.Drawing.Point(102, 72);
            this.loginPagePassword.Margin = new System.Windows.Forms.Padding(0);
            this.loginPagePassword.MaxLength = 20;
            this.loginPagePassword.MinimumSize = new System.Drawing.Size(28, 28);
            this.loginPagePassword.MouseBack = null;
            this.loginPagePassword.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.loginPagePassword.Multiline = true;
            this.loginPagePassword.Name = "loginPagePassword";
            this.loginPagePassword.NormlBack = null;
            this.loginPagePassword.Padding = new System.Windows.Forms.Padding(5);
            this.loginPagePassword.ReadOnly = false;
            this.loginPagePassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.loginPagePassword.Size = new System.Drawing.Size(141, 29);
            // 
            // 
            // 
            this.loginPagePassword.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginPagePassword.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPagePassword.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.loginPagePassword.SkinTxt.ForeColor = System.Drawing.Color.Gray;
            this.loginPagePassword.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.loginPagePassword.SkinTxt.MaxLength = 20;
            this.loginPagePassword.SkinTxt.Multiline = true;
            this.loginPagePassword.SkinTxt.Name = "BaseText";
            this.loginPagePassword.SkinTxt.PasswordChar = '*';
            this.loginPagePassword.SkinTxt.Size = new System.Drawing.Size(131, 19);
            this.loginPagePassword.SkinTxt.TabIndex = 0;
            this.loginPagePassword.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.loginPagePassword.SkinTxt.WaterText = "";
            this.loginPagePassword.TabIndex = 14;
            this.loginPagePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.loginPagePassword.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.loginPagePassword.WaterText = "";
            this.loginPagePassword.WordWrap = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "用户名：";
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
            this.loginButton.Location = new System.Drawing.Point(190, 129);
            this.loginButton.MouseBack = null;
            this.loginButton.MouseBaseColor = System.Drawing.Color.Black;
            this.loginButton.Name = "loginButton";
            this.loginButton.NormlBack = null;
            this.loginButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.loginButton.Size = new System.Drawing.Size(53, 29);
            this.loginButton.TabIndex = 12;
            this.loginButton.Text = "登录";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginPageUserName
            // 
            this.loginPageUserName.BackColor = System.Drawing.Color.Transparent;
            this.loginPageUserName.DownBack = null;
            this.loginPageUserName.Icon = null;
            this.loginPageUserName.IconIsButton = false;
            this.loginPageUserName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.loginPageUserName.IsPasswordChat = '\0';
            this.loginPageUserName.IsSystemPasswordChar = false;
            this.loginPageUserName.Lines = new string[0];
            this.loginPageUserName.Location = new System.Drawing.Point(102, 26);
            this.loginPageUserName.Margin = new System.Windows.Forms.Padding(0);
            this.loginPageUserName.MaxLength = 20;
            this.loginPageUserName.MinimumSize = new System.Drawing.Size(28, 28);
            this.loginPageUserName.MouseBack = null;
            this.loginPageUserName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.loginPageUserName.Multiline = true;
            this.loginPageUserName.Name = "loginPageUserName";
            this.loginPageUserName.NormlBack = null;
            this.loginPageUserName.Padding = new System.Windows.Forms.Padding(5);
            this.loginPageUserName.ReadOnly = false;
            this.loginPageUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.loginPageUserName.Size = new System.Drawing.Size(141, 29);
            // 
            // 
            // 
            this.loginPageUserName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginPageUserName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPageUserName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.loginPageUserName.SkinTxt.ForeColor = System.Drawing.Color.Gray;
            this.loginPageUserName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.loginPageUserName.SkinTxt.MaxLength = 20;
            this.loginPageUserName.SkinTxt.Multiline = true;
            this.loginPageUserName.SkinTxt.Name = "BaseText";
            this.loginPageUserName.SkinTxt.Size = new System.Drawing.Size(131, 19);
            this.loginPageUserName.SkinTxt.TabIndex = 0;
            this.loginPageUserName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.loginPageUserName.SkinTxt.WaterText = "";
            this.loginPageUserName.TabIndex = 11;
            this.loginPageUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.loginPageUserName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.loginPageUserName.WaterText = "";
            this.loginPageUserName.WordWrap = true;
            // 
            // skinTabPage2
            // 
            this.skinTabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.skinTabPage2.Controls.Add(this.groupBox3);
            this.skinTabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage2.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTabPage2.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage2.Name = "skinTabPage2";
            this.skinTabPage2.Size = new System.Drawing.Size(281, 183);
            this.skinTabPage2.TabIndex = 1;
            this.skinTabPage2.TabItemImage = null;
            this.skinTabPage2.Text = "注册";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.registerTip);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.registPageEmail);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.registPagePassword);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.skinButton1);
            this.groupBox3.Controls.Add(this.registPageUserName);
            this.groupBox3.Location = new System.Drawing.Point(3, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 183);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "邮箱地址：";
            // 
            // registPageEmail
            // 
            this.registPageEmail.BackColor = System.Drawing.Color.Transparent;
            this.registPageEmail.DownBack = null;
            this.registPageEmail.Icon = null;
            this.registPageEmail.IconIsButton = false;
            this.registPageEmail.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.registPageEmail.IsPasswordChat = '\0';
            this.registPageEmail.IsSystemPasswordChar = false;
            this.registPageEmail.Lines = new string[0];
            this.registPageEmail.Location = new System.Drawing.Point(102, 107);
            this.registPageEmail.Margin = new System.Windows.Forms.Padding(0);
            this.registPageEmail.MaxLength = 40;
            this.registPageEmail.MinimumSize = new System.Drawing.Size(28, 28);
            this.registPageEmail.MouseBack = null;
            this.registPageEmail.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.registPageEmail.Multiline = true;
            this.registPageEmail.Name = "registPageEmail";
            this.registPageEmail.NormlBack = null;
            this.registPageEmail.Padding = new System.Windows.Forms.Padding(5);
            this.registPageEmail.ReadOnly = false;
            this.registPageEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.registPageEmail.Size = new System.Drawing.Size(141, 29);
            // 
            // 
            // 
            this.registPageEmail.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registPageEmail.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registPageEmail.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.registPageEmail.SkinTxt.ForeColor = System.Drawing.Color.Gray;
            this.registPageEmail.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.registPageEmail.SkinTxt.MaxLength = 40;
            this.registPageEmail.SkinTxt.Multiline = true;
            this.registPageEmail.SkinTxt.Name = "BaseText";
            this.registPageEmail.SkinTxt.Size = new System.Drawing.Size(131, 19);
            this.registPageEmail.SkinTxt.TabIndex = 0;
            this.registPageEmail.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.registPageEmail.SkinTxt.WaterText = "";
            this.registPageEmail.TabIndex = 16;
            this.registPageEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.registPageEmail.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.registPageEmail.WaterText = "";
            this.registPageEmail.WordWrap = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "密  码：";
            // 
            // registPagePassword
            // 
            this.registPagePassword.BackColor = System.Drawing.Color.Transparent;
            this.registPagePassword.DownBack = null;
            this.registPagePassword.Icon = null;
            this.registPagePassword.IconIsButton = false;
            this.registPagePassword.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.registPagePassword.IsPasswordChat = '*';
            this.registPagePassword.IsSystemPasswordChar = false;
            this.registPagePassword.Lines = new string[0];
            this.registPagePassword.Location = new System.Drawing.Point(102, 64);
            this.registPagePassword.Margin = new System.Windows.Forms.Padding(0);
            this.registPagePassword.MaxLength = 20;
            this.registPagePassword.MinimumSize = new System.Drawing.Size(28, 28);
            this.registPagePassword.MouseBack = null;
            this.registPagePassword.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.registPagePassword.Multiline = true;
            this.registPagePassword.Name = "registPagePassword";
            this.registPagePassword.NormlBack = null;
            this.registPagePassword.Padding = new System.Windows.Forms.Padding(5);
            this.registPagePassword.ReadOnly = false;
            this.registPagePassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.registPagePassword.Size = new System.Drawing.Size(141, 29);
            // 
            // 
            // 
            this.registPagePassword.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registPagePassword.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registPagePassword.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.registPagePassword.SkinTxt.ForeColor = System.Drawing.Color.Gray;
            this.registPagePassword.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.registPagePassword.SkinTxt.MaxLength = 20;
            this.registPagePassword.SkinTxt.Multiline = true;
            this.registPagePassword.SkinTxt.Name = "BaseText";
            this.registPagePassword.SkinTxt.PasswordChar = '*';
            this.registPagePassword.SkinTxt.Size = new System.Drawing.Size(131, 19);
            this.registPagePassword.SkinTxt.TabIndex = 0;
            this.registPagePassword.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.registPagePassword.SkinTxt.WaterText = "";
            this.registPagePassword.TabIndex = 14;
            this.registPagePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.registPagePassword.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.registPagePassword.WaterText = "";
            this.registPagePassword.WordWrap = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "用户名：";
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.skinButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(10)))));
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.skinButton1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton1.ForeColor = System.Drawing.Color.IndianRed;
            this.skinButton1.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton1.IsDrawGlass = false;
            this.skinButton1.Location = new System.Drawing.Point(190, 142);
            this.skinButton1.MouseBack = null;
            this.skinButton1.MouseBaseColor = System.Drawing.Color.Black;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton1.Size = new System.Drawing.Size(53, 29);
            this.skinButton1.TabIndex = 12;
            this.skinButton1.Text = "注册";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // registPageUserName
            // 
            this.registPageUserName.BackColor = System.Drawing.Color.Transparent;
            this.registPageUserName.DownBack = null;
            this.registPageUserName.Icon = null;
            this.registPageUserName.IconIsButton = false;
            this.registPageUserName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.registPageUserName.IsPasswordChat = '\0';
            this.registPageUserName.IsSystemPasswordChar = false;
            this.registPageUserName.Lines = new string[0];
            this.registPageUserName.Location = new System.Drawing.Point(102, 24);
            this.registPageUserName.Margin = new System.Windows.Forms.Padding(0);
            this.registPageUserName.MaxLength = 20;
            this.registPageUserName.MinimumSize = new System.Drawing.Size(28, 28);
            this.registPageUserName.MouseBack = null;
            this.registPageUserName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.registPageUserName.Multiline = true;
            this.registPageUserName.Name = "registPageUserName";
            this.registPageUserName.NormlBack = null;
            this.registPageUserName.Padding = new System.Windows.Forms.Padding(5);
            this.registPageUserName.ReadOnly = false;
            this.registPageUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.registPageUserName.Size = new System.Drawing.Size(141, 29);
            // 
            // 
            // 
            this.registPageUserName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registPageUserName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registPageUserName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.registPageUserName.SkinTxt.ForeColor = System.Drawing.Color.Gray;
            this.registPageUserName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.registPageUserName.SkinTxt.MaxLength = 20;
            this.registPageUserName.SkinTxt.Multiline = true;
            this.registPageUserName.SkinTxt.Name = "BaseText";
            this.registPageUserName.SkinTxt.Size = new System.Drawing.Size(131, 19);
            this.registPageUserName.SkinTxt.TabIndex = 0;
            this.registPageUserName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.registPageUserName.SkinTxt.WaterText = "";
            this.registPageUserName.TabIndex = 11;
            this.registPageUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.registPageUserName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.registPageUserName.WaterText = "";
            this.registPageUserName.WordWrap = true;
            // 
            // skinTabPage3
            // 
            this.skinTabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.skinTabPage3.Controls.Add(this.groupBox4);
            this.skinTabPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage3.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTabPage3.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage3.Name = "skinTabPage3";
            this.skinTabPage3.Size = new System.Drawing.Size(281, 183);
            this.skinTabPage3.TabIndex = 2;
            this.skinTabPage3.TabItemImage = null;
            this.skinTabPage3.Text = "充值";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rechargeTip);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.rechargePageRec);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.rechargePageCard);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.skinButton2);
            this.groupBox4.Controls.Add(this.rechargePageUserName);
            this.groupBox4.Location = new System.Drawing.Point(3, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(275, 183);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "推荐人：";
            // 
            // rechargePageRec
            // 
            this.rechargePageRec.BackColor = System.Drawing.Color.Transparent;
            this.rechargePageRec.DownBack = null;
            this.rechargePageRec.Icon = null;
            this.rechargePageRec.IconIsButton = false;
            this.rechargePageRec.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.rechargePageRec.IsPasswordChat = '\0';
            this.rechargePageRec.IsSystemPasswordChar = false;
            this.rechargePageRec.Lines = new string[0];
            this.rechargePageRec.Location = new System.Drawing.Point(102, 106);
            this.rechargePageRec.Margin = new System.Windows.Forms.Padding(0);
            this.rechargePageRec.MaxLength = 20;
            this.rechargePageRec.MinimumSize = new System.Drawing.Size(28, 28);
            this.rechargePageRec.MouseBack = null;
            this.rechargePageRec.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.rechargePageRec.Multiline = true;
            this.rechargePageRec.Name = "rechargePageRec";
            this.rechargePageRec.NormlBack = null;
            this.rechargePageRec.Padding = new System.Windows.Forms.Padding(5);
            this.rechargePageRec.ReadOnly = false;
            this.rechargePageRec.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rechargePageRec.Size = new System.Drawing.Size(141, 29);
            // 
            // 
            // 
            this.rechargePageRec.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rechargePageRec.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rechargePageRec.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.rechargePageRec.SkinTxt.ForeColor = System.Drawing.Color.Gray;
            this.rechargePageRec.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.rechargePageRec.SkinTxt.MaxLength = 20;
            this.rechargePageRec.SkinTxt.Multiline = true;
            this.rechargePageRec.SkinTxt.Name = "BaseText";
            this.rechargePageRec.SkinTxt.Size = new System.Drawing.Size(131, 19);
            this.rechargePageRec.SkinTxt.TabIndex = 0;
            this.rechargePageRec.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.rechargePageRec.SkinTxt.WaterText = "";
            this.rechargePageRec.TabIndex = 16;
            this.rechargePageRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.rechargePageRec.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.rechargePageRec.WaterText = "";
            this.rechargePageRec.WordWrap = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "充值卡密：";
            // 
            // rechargePageCard
            // 
            this.rechargePageCard.BackColor = System.Drawing.Color.Transparent;
            this.rechargePageCard.DownBack = null;
            this.rechargePageCard.Icon = null;
            this.rechargePageCard.IconIsButton = false;
            this.rechargePageCard.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.rechargePageCard.IsPasswordChat = '\0';
            this.rechargePageCard.IsSystemPasswordChar = false;
            this.rechargePageCard.Lines = new string[0];
            this.rechargePageCard.Location = new System.Drawing.Point(102, 64);
            this.rechargePageCard.Margin = new System.Windows.Forms.Padding(0);
            this.rechargePageCard.MaxLength = 80;
            this.rechargePageCard.MinimumSize = new System.Drawing.Size(28, 28);
            this.rechargePageCard.MouseBack = null;
            this.rechargePageCard.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.rechargePageCard.Multiline = true;
            this.rechargePageCard.Name = "rechargePageCard";
            this.rechargePageCard.NormlBack = null;
            this.rechargePageCard.Padding = new System.Windows.Forms.Padding(5);
            this.rechargePageCard.ReadOnly = false;
            this.rechargePageCard.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rechargePageCard.Size = new System.Drawing.Size(141, 29);
            // 
            // 
            // 
            this.rechargePageCard.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rechargePageCard.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rechargePageCard.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.rechargePageCard.SkinTxt.ForeColor = System.Drawing.Color.Gray;
            this.rechargePageCard.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.rechargePageCard.SkinTxt.MaxLength = 80;
            this.rechargePageCard.SkinTxt.Multiline = true;
            this.rechargePageCard.SkinTxt.Name = "BaseText";
            this.rechargePageCard.SkinTxt.Size = new System.Drawing.Size(131, 19);
            this.rechargePageCard.SkinTxt.TabIndex = 0;
            this.rechargePageCard.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.rechargePageCard.SkinTxt.WaterText = "";
            this.rechargePageCard.TabIndex = 14;
            this.rechargePageCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.rechargePageCard.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.rechargePageCard.WaterText = "";
            this.rechargePageCard.WordWrap = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "用户名：";
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
            this.skinButton2.Location = new System.Drawing.Point(190, 142);
            this.skinButton2.MouseBack = null;
            this.skinButton2.MouseBaseColor = System.Drawing.Color.Black;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton2.Size = new System.Drawing.Size(53, 29);
            this.skinButton2.TabIndex = 12;
            this.skinButton2.Text = "充值";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // rechargePageUserName
            // 
            this.rechargePageUserName.BackColor = System.Drawing.Color.Transparent;
            this.rechargePageUserName.DownBack = null;
            this.rechargePageUserName.Icon = null;
            this.rechargePageUserName.IconIsButton = false;
            this.rechargePageUserName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.rechargePageUserName.IsPasswordChat = '\0';
            this.rechargePageUserName.IsSystemPasswordChar = false;
            this.rechargePageUserName.Lines = new string[0];
            this.rechargePageUserName.Location = new System.Drawing.Point(102, 24);
            this.rechargePageUserName.Margin = new System.Windows.Forms.Padding(0);
            this.rechargePageUserName.MaxLength = 20;
            this.rechargePageUserName.MinimumSize = new System.Drawing.Size(28, 28);
            this.rechargePageUserName.MouseBack = null;
            this.rechargePageUserName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.rechargePageUserName.Multiline = true;
            this.rechargePageUserName.Name = "rechargePageUserName";
            this.rechargePageUserName.NormlBack = null;
            this.rechargePageUserName.Padding = new System.Windows.Forms.Padding(5);
            this.rechargePageUserName.ReadOnly = false;
            this.rechargePageUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.rechargePageUserName.Size = new System.Drawing.Size(141, 29);
            // 
            // 
            // 
            this.rechargePageUserName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rechargePageUserName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rechargePageUserName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.rechargePageUserName.SkinTxt.ForeColor = System.Drawing.Color.Gray;
            this.rechargePageUserName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.rechargePageUserName.SkinTxt.MaxLength = 20;
            this.rechargePageUserName.SkinTxt.Multiline = true;
            this.rechargePageUserName.SkinTxt.Name = "BaseText";
            this.rechargePageUserName.SkinTxt.Size = new System.Drawing.Size(131, 19);
            this.rechargePageUserName.SkinTxt.TabIndex = 0;
            this.rechargePageUserName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.rechargePageUserName.SkinTxt.WaterText = "";
            this.rechargePageUserName.TabIndex = 11;
            this.rechargePageUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.rechargePageUserName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.rechargePageUserName.WaterText = "";
            this.rechargePageUserName.WordWrap = true;
            // 
            // registerTip
            // 
            this.registerTip.AutoSize = true;
            this.registerTip.ForeColor = System.Drawing.Color.Gold;
            this.registerTip.Location = new System.Drawing.Point(21, 150);
            this.registerTip.Name = "registerTip";
            this.registerTip.Size = new System.Drawing.Size(21, 13);
            this.registerTip.TabIndex = 18;
            this.registerTip.Text = "无";
            this.registerTip.Visible = false;
            // 
            // rechargeTip
            // 
            this.rechargeTip.AutoSize = true;
            this.rechargeTip.ForeColor = System.Drawing.Color.Gold;
            this.rechargeTip.Location = new System.Drawing.Point(21, 150);
            this.rechargeTip.Name = "rechargeTip";
            this.rechargeTip.Size = new System.Drawing.Size(21, 13);
            this.rechargeTip.TabIndex = 19;
            this.rechargeTip.Text = "无";
            this.rechargeTip.Visible = false;
            // 
            // MemberControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.accountPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MemberControl2";
            this.Size = new System.Drawing.Size(317, 293);
            this.accountPanel.ResumeLayout(false);
            this.accountPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.skinTabControl1.ResumeLayout(false);
            this.skinTabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.skinTabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.skinTabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel accountPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private CCWin.SkinControl.SkinTabControl skinTabControl1;
        private CCWin.SkinControl.SkinTabPage skinTabPage1;
        private CCWin.SkinControl.SkinTabPage skinTabPage2;
        private CCWin.SkinControl.SkinTabPage skinTabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox loginPageRememberMe;
        private System.Windows.Forms.Label label2;
        private CCWin.SkinControl.SkinTextBox loginPagePassword;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinButton loginButton;
        private CCWin.SkinControl.SkinTextBox loginPageUserName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private CCWin.SkinControl.SkinTextBox registPageEmail;
        private System.Windows.Forms.Label label3;
        private CCWin.SkinControl.SkinTextBox registPagePassword;
        private System.Windows.Forms.Label label4;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinTextBox registPageUserName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private CCWin.SkinControl.SkinTextBox rechargePageRec;
        private System.Windows.Forms.Label label7;
        private CCWin.SkinControl.SkinTextBox rechargePageCard;
        private System.Windows.Forms.Label label8;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinTextBox rechargePageUserName;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label registerTip;
        private System.Windows.Forms.Label rechargeTip;
    }
}
