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
            CCWin.SkinControl.Animation animation5 = new CCWin.SkinControl.Animation();
            this.mediaPanel = new CCWin.SkinControl.SkinPushPanel();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            this.accountButton = new CCWin.SkinControl.SkinButton();
            this.animator = new CCWin.SkinControl.SkinAnimator(this.components);
            this.moviePanel = new System.Windows.Forms.Panel();
            this.skinPushPanel1 = new CCWin.SkinControl.SkinPushPanel();
            this.pushPanelItem1 = new CCWin.SkinControl.PushPanelItem();
            this.memberControl = new DeepNaiWorkshop_6001.View.MemberControl();
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
            this.skinPanel1.Controls.Add(this.label4);
            this.skinPanel1.Controls.Add(this.skinButton3);
            this.skinPanel1.Controls.Add(this.accountButton);
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
            // animator
            // 
            this.animator.AnimationType = CCWin.SkinControl.AnimationType.Transparent;
            this.animator.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 1F;
            this.animator.DefaultAnimation = animation5;
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
            // skinPushPanel1
            // 
            this.animator.SetDecoration(this.skinPushPanel1, CCWin.SkinControl.DecorationType.None);
            this.skinPushPanel1.Items.AddRange(new CCWin.SkinControl.PushPanelItem[] {
            this.pushPanelItem1});
            this.skinPushPanel1.Location = new System.Drawing.Point(3, 4);
            this.skinPushPanel1.Name = "skinPushPanel1";
            this.skinPushPanel1.Size = new System.Drawing.Size(264, 403);
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
            // memberControl
            // 
            this.memberControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.animator.SetDecoration(this.memberControl, CCWin.SkinControl.DecorationType.None);
            this.memberControl.Location = new System.Drawing.Point(5, 240);
            this.memberControl.Margin = new System.Windows.Forms.Padding(0);
            this.memberControl.Name = "memberControl";
            this.memberControl.Size = new System.Drawing.Size(317, 293);
            this.memberControl.TabIndex = 2;
            this.memberControl.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.BackToColor = false;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBoxOffset = new System.Drawing.Point(6, 8);
            this.ControlBoxSpace = 5;
            this.Controls.Add(this.memberControl);
            this.Controls.Add(this.moviePanel);
            this.Controls.Add(this.skinPanel1);
            this.Controls.Add(this.mediaPanel);
            this.animator.SetDecoration(this, CCWin.SkinControl.DecorationType.None);
            this.EffectBack = System.Drawing.Color.Transparent;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ICoOffset = new System.Drawing.Point(8, 3);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "";
            this.TitleColor = System.Drawing.Color.IndianRed;
            ((System.ComponentModel.ISupportInitialize)(this.mediaPanel)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.moviePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinPushPanel1)).EndInit();
            this.skinPushPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPushPanel mediaPanel;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinAnimator animator;
        private System.Windows.Forms.Panel moviePanel;
        private CCWin.SkinControl.SkinButton accountButton;
        private CCWin.SkinControl.SkinPushPanel skinPushPanel1;
        private CCWin.SkinControl.PushPanelItem pushPanelItem1;
        private CCWin.SkinControl.SkinButton skinButton3;
        private System.Windows.Forms.Label label4;
        private View.MemberControl memberControl;
    }
}