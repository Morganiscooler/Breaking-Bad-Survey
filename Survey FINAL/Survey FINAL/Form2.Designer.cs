namespace Survey_FINAL
{
    partial class Page2Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page2Form));
            label1 = new Label();
            radio1 = new RadioButton();
            radio2 = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(415, 40);
            label1.TabIndex = 1;
            label1.Text = "Are you a chemistry teacher?";
            label1.Click += label1_Click;
            // 
            // radio1
            // 
            radio1.AutoSize = true;
            radio1.Location = new Point(24, 78);
            radio1.Name = "radio1";
            radio1.Size = new Size(180, 19);
            radio1.TabIndex = 2;
            radio1.Text = "Yes, I am a chemistry teacher.";
            radio1.UseVisualStyleBackColor = true;
            radio1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radio2
            // 
            radio2.AutoSize = true;
            radio2.Location = new Point(24, 108);
            radio2.Name = "radio2";
            radio2.Size = new Size(200, 19);
            radio2.TabIndex = 3;
            radio2.Text = "No, I am not a chemistry teacher.";
            radio2.UseVisualStyleBackColor = true;
            radio2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(2, 6);
            label2.Name = "label2";
            label2.Size = new Size(179, 17);
            label2.TabIndex = 4;
            label2.Text = "Yes, I am a chemistry teacher.";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(2, 38);
            label3.Name = "label3";
            label3.Size = new Size(201, 17);
            label3.TabIndex = 5;
            label3.Text = "No, I am not a chemistry teacher.";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(24, 152);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(24, 198);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(382, 302);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Enabled = false;
            panel2.Location = new Point(42, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 63);
            panel2.TabIndex = 10;
            panel2.Visible = false;
            // 
            // Page2Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 567);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(radio2);
            Controls.Add(radio1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(816, 606);
            MinimumSize = new Size(816, 606);
            Name = "Page2Form";
            Text = "Survey";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radio1;
        private RadioButton radio2;
        private Label label2;
        private Label label3;
        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
    }
}