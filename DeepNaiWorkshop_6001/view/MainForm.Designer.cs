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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            CCWin.SkinControl.Animation animation1 = new CCWin.SkinControl.Animation();
            this.mediaPanel = new CCWin.SkinControl.SkinPushPanel();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.accountButton = new CCWin.SkinControl.SkinButton();
            this.movieButton = new CCWin.SkinControl.SkinButton();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.animator = new CCWin.SkinControl.SkinAnimator(this.components);
            this.moviePanel = new System.Windows.Forms.Panel();
            this.accountPanel = new System.Windows.Forms.Panel();
            this.skinPushPanel1 = new CCWin.SkinControl.SkinPushPanel();
            this.pushPanelItem1 = new CCWin.SkinControl.PushPanelItem();
            this.pushPanelItem2 = new CCWin.SkinControl.PushPanelItem();
            this.pushPanelItem3 = new CCWin.SkinControl.PushPanelItem();
            this.pushPanelItem4 = new CCWin.SkinControl.PushPanelItem();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPanel)).BeginInit();
            this.skinPanel1.SuspendLayout();
            this.moviePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPushPanel1)).BeginInit();
            this.skinPushPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mediaPanel
            // 
            this.mediaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mediaPanel.BackColor = System.Drawing.Color.Black;
            this.mediaPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mediaPanel.BackgroundImage")));
            this.mediaPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.animator.SetDecoration(this.mediaPanel, CCWin.SkinControl.DecorationType.None);
            this.mediaPanel.Location = new System.Drawing.Point(4, 34);
            this.mediaPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mediaPanel.Name = "mediaPanel";
            this.mediaPanel.Radius = 2;
            this.mediaPanel.RoundStyle = CCWin.SkinClass.RoundStyle.None;
            this.mediaPanel.Size = new System.Drawing.Size(792, 501);
            this.mediaPanel.TabIndex = 1;
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.skinPanel1.Controls.Add(this.accountButton);
            this.skinPanel1.Controls.Add(this.movieButton);
            this.skinPanel1.Controls.Add(this.skinButton1);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.animator.SetDecoration(this.skinPanel1, CCWin.SkinControl.DecorationType.None);
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(4, 535);
            this.skinPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(792, 61);
            this.skinPanel1.TabIndex = 2;
            // 
            // accountButton
            // 
            this.accountButton.BackColor = System.Drawing.Color.Transparent;
            this.accountButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.accountButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(10)))));
            this.accountButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.animator.SetDecoration(this.accountButton, CCWin.SkinControl.DecorationType.None);
            this.accountButton.DownBack = null;
            this.accountButton.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.accountButton.GlowColor = System.Drawing.Color.Transparent;
            this.accountButton.Location = new System.Drawing.Point(30, 16);
            this.accountButton.MouseBack = null;
            this.accountButton.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(100)))));
            this.accountButton.Name = "accountButton";
            this.accountButton.NormlBack = null;
            this.accountButton.Size = new System.Drawing.Size(75, 23);
            this.accountButton.TabIndex = 2;
            this.accountButton.Text = "账号信息";
            this.accountButton.UseVisualStyleBackColor = false;
            this.accountButton.Click += new System.EventHandler(this.accountButton_Click);
            // 
            // movieButton
            // 
            this.movieButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.movieButton.BackColor = System.Drawing.Color.Transparent;
            this.movieButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.movieButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(10)))));
            this.movieButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.animator.SetDecoration(this.movieButton, CCWin.SkinControl.DecorationType.None);
            this.movieButton.DownBack = null;
            this.movieButton.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.movieButton.GlowColor = System.Drawing.Color.Transparent;
            this.movieButton.Location = new System.Drawing.Point(686, 19);
            this.movieButton.MouseBack = null;
            this.movieButton.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(100)))));
            this.movieButton.Name = "movieButton";
            this.movieButton.NormlBack = null;
            this.movieButton.Size = new System.Drawing.Size(75, 23);
            this.movieButton.TabIndex = 1;
            this.movieButton.Text = "资源列表";
            this.movieButton.UseVisualStyleBackColor = false;
            this.movieButton.Click += new System.EventHandler(this.movieButton_Click);
            // 
            // skinButton1
            // 
            this.skinButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.animator.SetDecoration(this.skinButton1, CCWin.SkinControl.DecorationType.None);
            this.skinButton1.DownBack = null;
            this.skinButton1.GlowColor = System.Drawing.Color.Transparent;
            this.skinButton1.Location = new System.Drawing.Point(282, 13);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(75, 29);
            this.skinButton1.TabIndex = 0;
            this.skinButton1.Text = "播放";
            this.skinButton1.UseVisualStyleBackColor = false;
            // 
            // animator
            // 
            this.animator.AnimationType = CCWin.SkinControl.AnimationType.Transparent;
            this.animator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.animator.DefaultAnimation = animation1;
            // 
            // moviePanel
            // 
            this.moviePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moviePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.moviePanel.Controls.Add(this.skinPushPanel1);
            this.animator.SetDecoration(this.moviePanel, CCWin.SkinControl.DecorationType.None);
            this.moviePanel.Location = new System.Drawing.Point(525, 34);
            this.moviePanel.Name = "moviePanel";
            this.moviePanel.Size = new System.Drawing.Size(271, 501);
            this.moviePanel.TabIndex = 0;
            this.moviePanel.Visible = false;
            // 
            // accountPanel
            // 
            this.accountPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.accountPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(65)))));
            this.animator.SetDecoration(this.accountPanel, CCWin.SkinControl.DecorationType.None);
            this.accountPanel.Location = new System.Drawing.Point(5, 348);
            this.accountPanel.Name = "accountPanel";
            this.accountPanel.Size = new System.Drawing.Size(317, 185);
            this.accountPanel.TabIndex = 0;
            this.accountPanel.Visible = false;
            // 
            // skinPushPanel1
            // 
            this.animator.SetDecoration(this.skinPushPanel1, CCWin.SkinControl.DecorationType.None);
            this.skinPushPanel1.Items.AddRange(new CCWin.SkinControl.PushPanelItem[] {
            this.pushPanelItem1,
            this.pushPanelItem2,
            this.pushPanelItem3,
            this.pushPanelItem4});
            this.skinPushPanel1.Location = new System.Drawing.Point(3, 4);
            this.skinPushPanel1.Name = "skinPushPanel1";
            this.skinPushPanel1.Size = new System.Drawing.Size(264, 118);
            this.skinPushPanel1.TabIndex = 1;
            // 
            // pushPanelItem1
            // 
            this.pushPanelItem1.Border = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pushPanelItem1.CaptionBackHover = System.Drawing.Color.Black;
            this.pushPanelItem1.CaptionBackNormal = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pushPanelItem1.CaptionBackPressed = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pushPanelItem1.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 10F);
            this.pushPanelItem1.CaptionFore = System.Drawing.Color.White;
            this.pushPanelItem1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.pushPanelItem1, CCWin.SkinControl.DecorationType.None);
            this.pushPanelItem1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pushPanelItem1.Name = "pushPanelItem1";
            this.pushPanelItem1.Radius = 2;
            this.pushPanelItem1.Text = "在线视频";
            // 
            // pushPanelItem2
            // 
            this.pushPanelItem2.Border = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.pushPanelItem2.CaptionBackHover = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.pushPanelItem2.CaptionBackNormal = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.pushPanelItem2.CaptionBackPressed = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.pushPanelItem2.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.pushPanelItem2.CaptionFore = System.Drawing.Color.Black;
            this.animator.SetDecoration(this.pushPanelItem2, CCWin.SkinControl.DecorationType.None);
            this.pushPanelItem2.Name = "pushPanelItem2";
            this.pushPanelItem2.Text = "pushPanelItem2";
            // 
            // pushPanelItem3
            // 
            this.pushPanelItem3.Border = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.pushPanelItem3.CaptionBackHover = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.pushPanelItem3.CaptionBackNormal = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.pushPanelItem3.CaptionBackPressed = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.pushPanelItem3.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.pushPanelItem3.CaptionFore = System.Drawing.Color.Black;
            this.animator.SetDecoration(this.pushPanelItem3, CCWin.SkinControl.DecorationType.None);
            this.pushPanelItem3.Name = "pushPanelItem3";
            this.pushPanelItem3.Text = "pushPanelItem3";
            // 
            // pushPanelItem4
            // 
            this.pushPanelItem4.Border = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.pushPanelItem4.CaptionBackHover = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.pushPanelItem4.CaptionBackNormal = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(218)))), ((int)(((byte)(255)))));
            this.pushPanelItem4.CaptionBackPressed = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.pushPanelItem4.CaptionFont = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.pushPanelItem4.CaptionFore = System.Drawing.Color.Black;
            this.animator.SetDecoration(this.pushPanelItem4, CCWin.SkinControl.DecorationType.None);
            this.pushPanelItem4.Name = "pushPanelItem4";
            this.pushPanelItem4.Text = "pushPanelItem4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.BackToColor = false;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBoxActive = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(88)))));
            this.ControlBoxDeactive = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.ControlBoxOffset = new System.Drawing.Point(6, 8);
            this.ControlBoxSpace = 5;
            this.Controls.Add(this.accountPanel);
            this.Controls.Add(this.moviePanel);
            this.Controls.Add(this.skinPanel1);
            this.Controls.Add(this.mediaPanel);
            this.animator.SetDecoration(this, CCWin.SkinControl.DecorationType.None);
            this.EffectBack = System.Drawing.Color.Transparent;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.mediaPanel)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.moviePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinPushPanel1)).EndInit();
            this.skinPushPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPushPanel mediaPanel;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton movieButton;
        private CCWin.SkinControl.SkinAnimator animator;
        private System.Windows.Forms.Panel moviePanel;
        private System.Windows.Forms.Panel accountPanel;
        private CCWin.SkinControl.SkinButton accountButton;
        private CCWin.SkinControl.SkinPushPanel skinPushPanel1;
        private CCWin.SkinControl.PushPanelItem pushPanelItem1;
        private CCWin.SkinControl.PushPanelItem pushPanelItem2;
        private CCWin.SkinControl.PushPanelItem pushPanelItem3;
        private CCWin.SkinControl.PushPanelItem pushPanelItem4;
    }
}