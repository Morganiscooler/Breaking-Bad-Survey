using System;
using System.Windows.Forms;

namespace Survey_FINAL
{
    public partial class Page1 : Form
    {
        public Page1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            label1.Visible = false;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            label2.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            label3.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e) // Next button
        {
            if (radioButton1.Checked)
            {
                Page2Form page2form = new Page2Form(); // displays in a new window
                page2form.Show();
                this.Hide();

            }
            else if (radioButton2.Checked)
            {

                Failed form3 = new Failed(); // displays in a new window
                form3.Show();
                this.Hide();
                MessageBox.Show("Unfortunately you are not qualified for this survey :(");
                form3.Close();
            }
            else
            {
                string message = "Please choose an option.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                DialogResult result;

                result = MessageBox.Show(message); // warning label

            }
        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}