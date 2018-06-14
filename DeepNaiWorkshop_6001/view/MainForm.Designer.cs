namespace DeepNaiWorkshop_6001.view
{
    partial class MainForm
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
            CCWin.SkinControl.Animation animation2 = new CCWin.SkinControl.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.animator = new CCWin.SkinControl.SkinAnimator(this.components);
            this.mediaPanel = new CCWin.SkinControl.SkinPanel();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            this.accountButton = new CCWin.SkinControl.SkinButton();
            this.moviePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPage2 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage1 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage3 = new CCWin.SkinControl.SkinTabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.recommendMovieList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.loginButton = new CCWin.SkinControl.SkinButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.memberControl = new DeepNaiWorkshop_6001.View.MemberControl2();
            this.mediaPanel.SuspendLayout();
            this.skinPanel2.SuspendLayout();
            this.moviePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.skinTabControl1.SuspendLayout();
            this.skinTabPage2.SuspendLayout();
            this.skinTabPage1.SuspendLayout();
            this.skinTabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // animator
            // 
            this.animator.AnimationType = CCWin.SkinControl.AnimationType.Transparent;
            this.animator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.animator.DefaultAnimation = animation2;
            // 
            // mediaPanel
            // 
            this.mediaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mediaPanel.BackColor = System.Drawing.Color.Black;
            this.mediaPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mediaPanel.BackgroundImage")));
            this.mediaPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mediaPanel.Controls.Add(this.memberControl);
            this.mediaPanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.animator.SetDecoration(this.mediaPanel, CCWin.SkinControl.DecorationType.None);
            this.mediaPanel.DownBack = null;
            this.mediaPanel.Location = new System.Drawing.Point(4, 34);
            this.mediaPanel.MouseBack = null;
            this.mediaPanel.Name = "mediaPanel";
            this.mediaPanel.NormlBack = null;
            this.mediaPanel.Size = new System.Drawing.Size(792, 501);
            this.mediaPanel.TabIndex = 0;
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.skinPanel2.Controls.Add(this.label4);
            this.skinPanel2.Controls.Add(this.skinButton3);
            this.skinPanel2.Controls.Add(this.accountButton);
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.animator.SetDecoration(this.skinPanel2, CCWin.SkinControl.DecorationType.None);
            this.skinPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinPanel2.DownBack = null;
            this.skinPanel2.Location = new System.Drawing.Point(4, 535);
            this.skinPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.skinPanel2.MouseBack = null;
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = null;
            this.skinPanel2.Size = new System.Drawing.Size(792, 61);
            this.skinPanel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.animator.SetDecoration(this.label4, CCWin.SkinControl.DecorationType.None);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(217, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "公告：请勿相信视频中出现的广告信息！！！";
            // 
            // skinButton3
            // 
            this.skinButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.skinButton3.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.animator.SetDecoration(this.skinButton3, CCWin.SkinControl.DecorationType.None);
            this.skinButton3.DownBack = null;
            this.skinButton3.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.skinButton3.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton3.ForeColor = System.Drawing.Color.IndianRed;
            this.skinButton3.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton3.IsDrawGlass = false;
            this.skinButton3.Location = new System.Drawing.Point(654, 15);
            this.skinButton3.MouseBack = null;
            this.skinButton3.MouseBaseColor = System.Drawing.Color.Black;
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = null;
            this.skinButton3.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton3.Size = new System.Drawing.Size(87, 29);
            this.skinButton3.TabIndex = 3;
            this.skinButton3.Text = "资源列表";
            this.skinButton3.UseVisualStyleBackColor = false;
            this.skinButton3.Click += new System.EventHandler(this.movieButton_Click);
            // 
            // accountButton
            // 
            this.accountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.accountButton.BaseColor = System.Drawing.Color.Transparent;
            this.accountButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.accountButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.animator.SetDecoration(this.accountButton, CCWin.SkinControl.DecorationType.None);
            this.accountButton.DownBack = null;
            this.accountButton.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.accountButton.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accountButton.ForeColor = System.Drawing.Color.IndianRed;
            this.accountButton.GlowColor = System.Drawing.Color.Transparent;
            this.accountButton.IsDrawGlass = false;
            this.accountButton.Location = new System.Drawing.Point(30, 15);
            this.accountButton.MouseBack = null;
            this.accountButton.MouseBaseColor = System.Drawing.Color.Black;
            this.accountButton.Name = "accountButton";
            this.accountButton.NormlBack = null;
            this.accountButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.accountButton.Size = new System.Drawing.Size(87, 29);
            this.accountButton.TabIndex = 2;
            this.accountButton.Text = "账号信息";
            this.accountButton.UseVisualStyleBackColor = false;
            this.accountButton.Click += new System.EventHandler(this.accountButton_Click);
            // 
            // moviePanel
            // 
            this.moviePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moviePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.moviePanel.Controls.Add(this.panel1);
            this.animator.SetDecoration(this.moviePanel, CCWin.SkinControl.DecorationType.None);
            this.moviePanel.Location = new System.Drawing.Point(471, 34);
            this.moviePanel.Name = "moviePanel";
            this.moviePanel.Size = new System.Drawing.Size(325, 501);
            this.moviePanel.TabIndex = 5;
            this.moviePanel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.skinTabControl1);
            this.animator.SetDecoration(this.panel1, CCWin.SkinControl.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(4, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 473);
            this.panel1.TabIndex = 0;
            // 
            // skinTabControl1
            // 
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Controls.Add(this.skinTabPage1);
            this.skinTabControl1.Controls.Add(this.skinTabPage2);
            this.skinTabControl1.Controls.Add(this.skinTabPage3);
            this.animator.SetDecoration(this.skinTabControl1, CCWin.SkinControl.DecorationType.None);
            this.skinTabControl1.HeadBack = null;
            this.skinTabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl1.ItemSize = new System.Drawing.Size(100, 36);
            this.skinTabControl1.Location = new System.Drawing.Point(3, 3);
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
            this.skinTabControl1.Size = new System.Drawing.Size(313, 467);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl1.TabIndex = 3;
            // 
            // skinTabPage2
            // 
            this.skinTabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.skinTabPage2.Controls.Add(this.groupBox1);
            this.skinTabPage2.Controls.Add(this.skinButton1);
            this.skinTabPage2.Controls.Add(this.textBox1);
            this.skinTabPage2.Controls.Add(this.label2);
            this.skinTabPage2.Controls.Add(this.comboBox1);
            this.skinTabPage2.Controls.Add(this.label1);
            this.skinTabPage2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.skinTabPage2, CCWin.SkinControl.DecorationType.None);
            this.skinTabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage2.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTabPage2.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage2.Name = "skinTabPage2";
            this.skinTabPage2.Size = new System.Drawing.Size(313, 431);
            this.skinTabPage2.TabIndex = 1;
            this.skinTabPage2.TabItemImage = null;
            this.skinTabPage2.Text = "各平台vip视频";
            // 
            // skinTabPage1
            // 
            this.skinTabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.skinTabPage1.Controls.Add(this.recommendMovieList);
            this.skinTabPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.skinTabPage1, CCWin.SkinControl.DecorationType.None);
            this.skinTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTabPage1.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage1.Name = "skinTabPage1";
            this.skinTabPage1.Size = new System.Drawing.Size(313, 431);
            this.skinTabPage1.TabIndex = 0;
            this.skinTabPage1.TabItemImage = null;
            this.skinTabPage1.Text = "推荐电影";
            // 
            // skinTabPage3
            // 
            this.skinTabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.skinTabPage3.Controls.Add(this.groupBox2);
            this.skinTabPage3.Controls.Add(this.groupBox3);
            this.skinTabPage3.Controls.Add(this.loginButton);
            this.skinTabPage3.Controls.Add(this.textBox2);
            this.skinTabPage3.Controls.Add(this.label3);
            this.skinTabPage3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.skinTabPage3, CCWin.SkinControl.DecorationType.None);
            this.skinTabPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage3.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTabPage3.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage3.Name = "skinTabPage3";
            this.skinTabPage3.Size = new System.Drawing.Size(313, 431);
            this.skinTabPage3.TabIndex = 2;
            this.skinTabPage3.TabItemImage = null;
            this.skinTabPage3.Text = "搜电影";
            // 
            // timer1
            // 
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.RecordMemberTime);
            // 
            // recommendMovieList
            // 
            this.animator.SetDecoration(this.recommendMovieList, CCWin.SkinControl.DecorationType.None);
            this.recommendMovieList.Location = new System.Drawing.Point(12, 13);
            this.recommendMovieList.Name = "recommendMovieList";
            this.recommendMovieList.Size = new System.Drawing.Size(284, 400);
            this.recommendMovieList.TabIndex = 1;
            this.recommendMovieList.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.animator.SetDecoration(this.label1, CCWin.SkinControl.DecorationType.None);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "步骤①解析源选择：";
            // 
            // comboBox1
            // 
            this.animator.SetDecoration(this.comboBox1, CCWin.SkinControl.DecorationType.None);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(157, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.animator.SetDecoration(this.label2, CCWin.SkinControl.DecorationType.None);
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "步骤②将各个平台的vip视频链接粘贴到此处：";
            // 
            // textBox1
            // 
            this.animator.SetDecoration(this.textBox1, CCWin.SkinControl.DecorationType.None);
            this.textBox1.Location = new System.Drawing.Point(12, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 22);
            this.textBox1.TabIndex = 17;
            // 
            // skinButton1
            // 
            this.skinButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.skinButton1.BaseColor = System.Drawing.Color.Transparent;
            this.skinButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.animator.SetDecoration(this.skinButton1, CCWin.SkinControl.DecorationType.None);
            this.skinButton1.DownBack = null;
            this.skinButton1.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.skinButton1.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton1.ForeColor = System.Drawing.Color.IndianRed;
            this.skinButton1.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton1.IsDrawGlass = false;
            this.skinButton1.Location = new System.Drawing.Point(183, 169);
            this.skinButton1.MouseBack = null;
            this.skinButton1.MouseBaseColor = System.Drawing.Color.Black;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton1.Size = new System.Drawing.Size(87, 29);
            this.skinButton1.TabIndex = 5;
            this.skinButton1.Text = "解析资源";
            this.skinButton1.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.animator.SetDecoration(this.groupBox1, CCWin.SkinControl.DecorationType.None);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(12, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 184);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息反馈：";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.animator.SetDecoration(this.listBox1, CCWin.SkinControl.DecorationType.None);
            this.listBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(262, 143);
            this.listBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.animator.SetDecoration(this.label3, CCWin.SkinControl.DecorationType.None);
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(22, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "电影名称：";
            // 
            // textBox2
            // 
            this.animator.SetDecoration(this.textBox2, CCWin.SkinControl.DecorationType.None);
            this.textBox2.Location = new System.Drawing.Point(25, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 22);
            this.textBox2.TabIndex = 16;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.loginButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(10)))));
            this.loginButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.animator.SetDecoration(this.loginButton, CCWin.SkinControl.DecorationType.None);
            this.loginButton.DownBack = null;
            this.loginButton.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.loginButton.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loginButton.ForeColor = System.Drawing.Color.IndianRed;
            this.loginButton.GlowColor = System.Drawing.Color.Transparent;
            this.loginButton.IsDrawGlass = false;
            this.loginButton.Location = new System.Drawing.Point(215, 60);
            this.loginButton.MouseBack = null;
            this.loginButton.MouseBaseColor = System.Drawing.Color.Black;
            this.loginButton.Name = "loginButton";
            this.loginButton.NormlBack = null;
            this.loginButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.loginButton.Size = new System.Drawing.Size(74, 29);
            this.loginButton.TabIndex = 20;
            this.loginButton.Text = "搜索电影";
            this.loginButton.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.animator.SetDecoration(this.groupBox3, CCWin.SkinControl.DecorationType.None);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Location = new System.Drawing.Point(15, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 123);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询到的结果：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox2);
            this.animator.SetDecoration(this.groupBox2, CCWin.SkinControl.DecorationType.None);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(15, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 184);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信息反馈：";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.animator.SetDecoration(this.listBox2, CCWin.SkinControl.DecorationType.None);
            this.listBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(6, 24);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(262, 143);
            this.listBox2.TabIndex = 0;
            // 
            // memberControl
            // 
            this.animator.SetDecoration(this.memberControl, CCWin.SkinControl.DecorationType.None);
            this.memberControl.Location = new System.Drawing.Point(0, 208);
            this.memberControl.Margin = new System.Windows.Forms.Padding(0);
            this.memberControl.Name = "memberControl";
            this.memberControl.Size = new System.Drawing.Size(317, 293);
            this.memberControl.TabIndex = 0;
            this.memberControl.Visible = false;
            this.memberControl.setFatherForm(this);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.BackToColor = false;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBoxActive = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.ControlBoxDeactive = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.ControlBoxOffset = new System.Drawing.Point(6, 8);
            this.ControlBoxSpace = 5;
            this.Controls.Add(this.moviePanel);
            this.Controls.Add(this.skinPanel2);
            this.Controls.Add(this.mediaPanel);
            this.animator.SetDecoration(this, CCWin.SkinControl.DecorationType.None);
            this.EffectBack = System.Drawing.Color.Transparent;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ICoOffset = new System.Drawing.Point(8, 3);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.TitleColor = System.Drawing.Color.IndianRed;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.mediaPanel.ResumeLayout(false);
            this.skinPanel2.ResumeLayout(false);
            this.skinPanel2.PerformLayout();
            this.moviePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.skinTabControl1.ResumeLayout(false);
            this.skinTabPage2.ResumeLayout(false);
            this.skinTabPage2.PerformLayout();
            this.skinTabPage1.ResumeLayout(false);
            this.skinTabPage3.ResumeLayout(false);
            this.skinTabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinAnimator animator;
        private System.Windows.Forms.Timer timer1;
        private CCWin.SkinControl.SkinPanel mediaPanel;
        private CCWin.SkinControl.SkinPanel skinPanel2;
        private System.Windows.Forms.Label label4;
        private CCWin.SkinControl.SkinButton skinButton3;
        private CCWin.SkinControl.SkinButton accountButton;
        private System.Windows.Forms.Panel moviePanel;
        private View.MemberControl2 memberControl;
        private System.Windows.Forms.Panel panel1;
        private CCWin.SkinControl.SkinTabControl skinTabControl1;
        private CCWin.SkinControl.SkinTabPage skinTabPage1;
        private CCWin.SkinControl.SkinTabPage skinTabPage2;
        private CCWin.SkinControl.SkinTabPage skinTabPage3;
        private System.Windows.Forms.ListView recommendMovieList;
        private System.Windows.Forms.GroupBox groupBox1;
        private CCWin.SkinControl.SkinButton skinButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private CCWin.SkinControl.SkinButton loginButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox2;
    }
}