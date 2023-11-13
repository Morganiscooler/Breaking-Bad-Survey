namespace Survey_FINAL
{
    partial class Failed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Failed));
            sadsponge = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)sadsponge).BeginInit();
            SuspendLayout();
            // 
            // sadsponge
            // 
            sadsponge.Image = Properties.Resources.sad_spongebob;
            sadsponge.Location = new Point(297, 134);
            sadsponge.MaximumSize = new Size(816, 606);
            sadsponge.Name = "sadsponge";
            sadsponge.Size = new Size(200, 200);
            sadsponge.TabIndex = 0;
            sadsponge.TabStop = false;
            sadsponge.Click += sadsponge_Click;
            // 
            // Failed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 567);
            Controls.Add(sadsponge);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 606);
            MinimumSize = new Size(816, 606);
            Name = "Failed";
            Text = "Disqualified";
            Load += Failed_Load;
            ((System.ComponentModel.ISupportInitialize)sadsponge).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox sadsponge;
    }
}