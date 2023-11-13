using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// using System.Windows.Forms.Integration; // WindowsFormsIntegration.dll

namespace Survey_FINAL
{
    public partial class Form5 : Form
    {

        public Form5()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void radio1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Visible = radio1.Checked;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Visible = radio2.Checked;
        }


        private void nextButton_Click(object sender, EventArgs e)
        {
            if (this.radio1.Checked) // change the name of the variable (radio1)
            {

                string downloadsFolder = @"C:\Users\tiger\Downloads";
                var mp4File = Path.Combine(AppContext.BaseDirectory, "finger.mp4");
               // Replace with the actual file name
               // executes ---------------------------------------------------------------------------------->>
               
                var psi = new ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = mp4File;
                Process.Start(psi);
                
                this.Hide();
                this.Close();


            }
            else if (this.radio2.Checked)
            {

                string downloadsFolder2 = @"C:\Users\tiger\Downloads";
                var mp4File2 = Path.Combine(AppContext.BaseDirectory, "He cant keep getting away with this.mp4");
                // Replace with the actual file name
                // executes ---------------------------------------------------------------------------------->>

                var psi2 = new ProcessStartInfo();

                psi2.UseShellExecute = true;

                psi2.FileName = mp4File2;

                var process = Process.Start(psi2);
              
               

                this.Hide();
                this.Close();

                // then ---------------------------------------------------------------------------------->>
                Failed failed = new Failed();
                failed.Show();
                MessageBox.Show("Unfortunately you are not qualified for this survey :(");               
               
                failed.Hide();
                failed.Close();

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
