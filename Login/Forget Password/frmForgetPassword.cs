using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Buisness;


namespace DVLD.Login.Forget_Password
{
	public partial class frmForgetPassword : Form
	{

		int PersonID = -1;
		public frmForgetPassword()
		{
			InitializeComponent();
		}

		private void frmAssignEmail_Load(object sender, EventArgs e)
		{

		}

		private void btnEnter_Click(object sender, EventArgs e)
		{
			PersonID = clsPerson.IsEmailExist(txtbxEmail.Text);

			if (PersonID != -1)
			{
				frmDateOfBirth DateOfBirth = new frmDateOfBirth(PersonID);

				DateOfBirth.ShowDialog();
			}
			else
			{
				MessageBox.Show("Your Email doesn't Exist", "Wrong Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
			}
		}
	}
}
