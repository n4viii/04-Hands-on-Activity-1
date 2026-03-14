using System;
using System.Windows.Forms;
using Student_Grade_Application;

namespace StudentGradeApplication
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Application.Run(new frmStudentGradeProgram());
		}
	}
}