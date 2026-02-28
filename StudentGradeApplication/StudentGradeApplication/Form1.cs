using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Student_Grade_Application
{
    public partial class frmStudentGradeProgram : Form
    {
        public frmStudentGradeProgram()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlBackground.BackColor = Color.FromArgb(200, 15, 30, 22);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the student's name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (double.TryParse(txtEnglish.Text, out double english) &&
                double.TryParse(txtMath.Text, out double math) &&
                double.TryParse(txtScience.Text, out double science) &&
                double.TryParse(txtFilipino.Text, out double filipino) &&
                double.TryParse(txtHistory.Text, out double history))
            {
                double average = (english + math + science + filipino + history) / 5;
                string status = average >= 75.00 ? "passed" : "failed";

                lblResult.Text = $"The student {status}.\nThe general average of {txtName.Text} is {average:F2}.";
                lblResult.ForeColor = average >= 75.00 ? Color.FromArgb(160, 240, 160) : Color.FromArgb(255, 140, 140);
            }
            else
            {
                MessageBox.Show("Please enter valid numeric grades for all subjects.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGenerate_MouseEnter(object sender, EventArgs e)
        {
            btnGenerate.BackColor = Color.FromArgb(60, 120, 85);
        }

        private void btnGenerate_MouseLeave(object sender, EventArgs e)
        {
            btnGenerate.BackColor = Color.FromArgb(45, 90, 65);
        }
    }
}