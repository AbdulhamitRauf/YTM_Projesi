namespace DVLD.Login.Forget_Password
{
	partial class frmAssignPassword
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
			this.label7 = new System.Windows.Forms.Label();
			this.txtbxPassword = new System.Windows.Forms.TextBox();
			this.txtbxConiformPassword = new System.Windows.Forms.TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnEnter = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(235, 36);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(238, 31);
			this.label7.TabIndex = 140;
			this.label7.Text = "Assign Password";
			// 
			// txtbxPassword
			// 
			this.txtbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtbxPassword.Location = new System.Drawing.Point(190, 140);
			this.txtbxPassword.Multiline = true;
			this.txtbxPassword.Name = "txtbxPassword";
			this.txtbxPassword.Size = new System.Drawing.Size(360, 32);
			this.txtbxPassword.TabIndex = 138;
			// 
			// txtbxConiformPassword
			// 
			this.txtbxConiformPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtbxConiformPassword.Location = new System.Drawing.Point(190, 208);
			this.txtbxConiformPassword.Multiline = true;
			this.txtbxConiformPassword.Name = "txtbxConiformPassword";
			this.txtbxConiformPassword.Size = new System.Drawing.Size(360, 32);
			this.txtbxConiformPassword.TabIndex = 142;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::DVLD.Properties.Resources.Password_32;
			this.pictureBox2.Location = new System.Drawing.Point(133, 208);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(39, 32);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 143;
			this.pictureBox2.TabStop = false;
			// 
			// btnEnter
			// 
			this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEnter.Image = global::DVLD.Properties.Resources.Next_32;
			this.btnEnter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEnter.Location = new System.Drawing.Point(449, 272);
			this.btnEnter.Name = "btnEnter";
			this.btnEnter.Size = new System.Drawing.Size(101, 40);
			this.btnEnter.TabIndex = 141;
			this.btnEnter.Text = "Enter";
			this.btnEnter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEnter.UseVisualStyleBackColor = true;
			this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::DVLD.Properties.Resources.Password_32;
			this.pictureBox1.Location = new System.Drawing.Point(133, 140);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(39, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 139;
			this.pictureBox1.TabStop = false;
			// 
			// btnClose
			// 
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(333, 272);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(101, 40);
			this.btnClose.TabIndex = 141;
			this.btnClose.Text = "Close";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmAssignPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(682, 362);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.txtbxConiformPassword);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnEnter);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtbxPassword);
			this.Name = "frmAssignPassword";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AssignPassword";
			this.Load += new System.EventHandler(this.AssignPassword_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnEnter;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtbxPassword;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox txtbxConiformPassword;
		private System.Windows.Forms.Button btnClose;
	}
}