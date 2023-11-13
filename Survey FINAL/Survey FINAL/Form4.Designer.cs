namespace Survey_FINAL
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label1 = new Label();
            radio1 = new RadioButton();
            radio2 = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            nextButton = new Button();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(370, 40);
            label1.TabIndex = 2;
            label1.Text = "Do you have lung cancer?";
            label1.Click += label1_Click;
            // 
            // radio1
            // 
            radio1.AutoSize = true;
            radio1.Location = new Point(24, 78);
            radio1.Name = "radio1";
            radio1.Size = new Size(147, 19);
            radio1.TabIndex = 3;
            radio1.Text = "Yes, I have lung cancer.";
            radio1.UseVisualStyleBackColor = true;
            radio1.CheckedChanged += radio1_CheckedChanged;
            // 
            // radio2
            // 
            radio2.AutoSize = true;
            radio2.Location = new Point(24, 108);
            radio2.Name = "radio2";
            radio2.Size = new Size(184, 19);
            radio2.TabIndex = 4;
            radio2.Text = "No, I do not have lung cancer.";
            radio2.UseVisualStyleBackColor = true;
            radio2.CheckedChanged += radio2_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 2);
            label2.Name = "label2";
            label2.Size = new Size(142, 17);
            label2.TabIndex = 5;
            label2.Text = "Yes, I have lung cancer.";
            label2.Visible = false;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 34);
            label3.Name = "label3";
            label3.Size = new Size(184, 17);
            label3.TabIndex = 6;
            label3.Text = "No, I do not have lung cancer.";
            label3.Visible = false;
            label3.Click += label3_Click;
            // 
            // nextButton
            // 
            nextButton.BackColor = SystemColors.InactiveCaption;
            nextButton.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nextButton.Location = new Point(24, 152);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(75, 23);
            nextButton.TabIndex = 9;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(24, 198);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(382, 302);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Enabled = false;
            panel1.Location = new Point(44, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 59);
            panel1.TabIndex = 11;
            panel1.Visible = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 567);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(nextButton);
            Controls.Add(radio2);
            Controls.Add(radio1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 606);
            MinimumSize = new Size(816, 606);
            Name = "Form4";
            Text = "Survey";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radio1;
        private RadioButton radio2;
        private Label label2;
        private Label label3;
        private Button nextButton;
        private PictureBox pictureBox2;
        private Panel panel1;
    }
}