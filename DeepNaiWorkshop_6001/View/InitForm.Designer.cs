using System.Drawing;

namespace DeepNaiWorkshop_6001.View
{
    partial class InitForm
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
            CCWin.SkinControl.Animation animation1 = new CCWin.SkinControl.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitForm));
            this.loadingPanel = new CCWin.SkinControl.SkinPanel();
            this.loadingAnimator = new CCWin.SkinControl.SkinAnimator(this.components);
            this.initControl21 = new DeepNaiWorkshop_6001.View.InitControl2();
            this.initControl11 = new DeepNaiWorkshop_6001.View.InitControl1();
            this.loadingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadingPanel
            // 
            this.loadingPanel.BackColor = System.Drawing.Color.Black;
            this.loadingPanel.Controls.Add(this.initControl21);
            this.loadingPanel.Controls.Add(this.initControl11);
            this.loadingPanel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.loadingAnimator.SetDecoration(this.loadingPanel, CCWin.SkinControl.DecorationType.None);
            this.loadingPanel.DownBack = null;
            this.loadingPanel.Location = new System.Drawing.Point(4, 31);
            this.loadingPanel.MouseBack = null;
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.NormlBack = null;
            this.loadingPanel.Size = new System.Drawing.Size(628, 330);
            this.loadingPanel.TabIndex = 0;
            // 
            // loadingAnimator
            // 
            this.loadingAnimator.AnimationType = CCWin.SkinControl.AnimationType.Transparent;
            this.loadingAnimator.Cursor = null;
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
            this.loadingAnimator.DefaultAnimation = animation1;
            // 
            // initControl21
            // 
            this.initControl21.BackColor = System.Drawing.Color.Transparent;
            this.loadingAnimator.SetDecoration(this.initControl21, CCWin.SkinControl.DecorationType.None);
            this.initControl21.Location = new System.Drawing.Point(164, 75);
            this.initControl21.Name = "initControl21";
            this.initControl21.Size = new System.Drawing.Size(300, 180);
            this.initControl21.TabIndex = 1;
            this.initControl21.Visible = false;
            // 
            // initControl11
            // 
            this.initControl11.BackColor = System.Drawing.Color.Transparent;
            this.loadingAnimator.SetDecoration(this.initControl11, CCWin.SkinControl.DecorationType.None);
            this.initControl11.Location = new System.Drawing.Point(164, 75);
            this.initControl11.Name = "initControl11";
            this.initControl11.Size = new System.Drawing.Size(300, 180);
            this.initControl11.TabIndex = 0;
            this.initControl11.Visible = false;
            // 
            // InitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.BackToColor = false;
            this.ClientSize = new System.Drawing.Size(639, 370);
            this.ControlBoxActive = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.ControlBoxDeactive = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.ControlBoxOffset = new System.Drawing.Point(6, 8);
            this.ControlBoxSpace = 5;
            this.Controls.Add(this.loadingPanel);
            this.loadingAnimator.SetDecoration(this, CCWin.SkinControl.DecorationType.None);
            this.EffectBack = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ICoOffset = new System.Drawing.Point(8, 3);
            this.MaximumSize = new System.Drawing.Size(639, 370);
            this.MinimumSize = new System.Drawing.Size(639, 370);
            this.Name = "InitForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.TitleColor = System.Drawing.Color.IndianRed;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InitForm_FormClosing);
            this.Load += new System.EventHandler(this.InitForm_Load);
            this.Shown += new System.EventHandler(this.InitForm_Shown);
            this.loadingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel loadingPanel;
        private CCWin.SkinControl.SkinAnimator loadingAnimator;
        private InitControl2 initControl21;
        private InitControl1 initControl11;
    }
}