using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey_FINAL
{
    public partial class Page2Form : Form
    {

        public Page2Form()
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
            label1.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            label2.Visible = radio1.Checked;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            label3.Visible = radio2.Checked;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radio1.Checked) // change the name of the variable (radio1)
            {

                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();

            }
            else if (radio2.Checked)
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
    }
}
