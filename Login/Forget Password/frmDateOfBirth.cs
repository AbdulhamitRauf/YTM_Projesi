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
	public partial class frmDateOfBirth : Form
	{
		int _PersonID = -1;

		public frmDateOfBirth()
		{
			InitializeComponent();
		}

		public frmDateOfBirth(int PersonID)
		{
			InitializeComponent();
			_PersonID = PersonID;
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnEnter_Click(object sender, EventArgs e)
		{
			if (clsPerson.IsDateOfBirthExist(dtpDateOfBirth.Value))
			{
				frmAssignPassword AssignPassword = new frmAssignPassword(_PersonID);

				AssignPassword.ShowDialog();
			}
			else
			{
				MessageBox.Show("The Date Of Birth Dones't Exist", "Wrong Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
			}
		}
	}
}
