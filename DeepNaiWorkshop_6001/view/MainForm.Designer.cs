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
            this.mediaPanel = new CCWin.SkinControl.SkinPushPanel();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // mediaPanel
            // 
            this.mediaPanel.BackColor = System.Drawing.Color.Black;
            this.mediaPanel.Location = new System.Drawing.Point(7, 31);
            this.mediaPanel.Name = "mediaPanel";
            this.mediaPanel.Size = new System.Drawing.Size(657, 412);
            this.mediaPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(672, 473);
            this.ControlBoxActive = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.ControlBoxDeactive = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.ControlBoxSpace = 5;
            this.Controls.Add(this.mediaPanel);
            this.EffectBack = System.Drawing.Color.Transparent;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.mediaPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPushPanel mediaPanel;
    }
}