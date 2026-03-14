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
			// Apply blue / white / yellow color scheme
			this.BackColor = Color.White;
			pnlBackground.BackColor = Color.FromArgb(230, 230, 245, 255); // pale blue background with slight transparency
			// Button base color (blue) and text (white)
			btnGenerate.BackColor = Color.FromArgb(30, 120, 215);
			btnGenerate.ForeColor = Color.White;
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
			// Use blue for passing, warm yellow for failing (matches design palette)
			lblResult.ForeColor = average >= 75.00 ? Color.FromArgb(30, 120, 215) : Color.FromArgb(255, 180, 0);
			}
			else
			{
				MessageBox.Show("Please enter valid numeric grades for all subjects.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnGenerate_MouseEnter(object sender, EventArgs e)
		{
			// Hover: highlight with yellow accent
			btnGenerate.BackColor = Color.FromArgb(255, 215, 64);
			btnGenerate.ForeColor = Color.Black;
		}

		private void btnGenerate_MouseLeave(object sender, EventArgs e)
		{
			// Revert to base blue
			btnGenerate.BackColor = Color.FromArgb(30, 120, 215);
			btnGenerate.ForeColor = Color.White;
		}
	}
}