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
            this.mediaPanel.Location = new System.Drawing.Point(18, 49);
            this.mediaPanel.Name = "mediaPanel";
            this.mediaPanel.Size = new System.Drawing.Size(646, 394);
            this.mediaPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 473);
            this.Controls.Add(this.mediaPanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.mediaPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPushPanel mediaPanel;
    }
}