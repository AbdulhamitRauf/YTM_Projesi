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
	public partial class frmAssignPassword : Form
	{
		int _PersonID = -1;
		public frmAssignPassword()
		{
			InitializeComponent();
		}

		public frmAssignPassword(int PersonID)
		{
			InitializeComponent();
			_PersonID = PersonID;
		}

		private void AssignPassword_Load(object sender, EventArgs e)
		{

		}

		private void btnEnter_Click(object sender, EventArgs e)
		{
			if(txtbxPassword.Text.Trim() == txtbxConiformPassword.Text.Trim())
			{
				if(clsUser.UpdatePassword(txtbxPassword.Text, _PersonID))
				{
					MessageBox.Show("Your password updated successfully.", "Wrong Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Faild to updated password", "Wrong Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("The Passwords don't match.", "Wrong Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
