namespace DVLD.Login.Forget_Password
{
	partial class frmForgetPassword
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
			this.txtbxEmail = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnEnter = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtbxEmail
			// 
			this.txtbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtbxEmail.Location = new System.Drawing.Point(147, 137);
			this.txtbxEmail.Multiline = true;
			this.txtbxEmail.Name = "txtbxEmail";
			this.txtbxEmail.Size = new System.Drawing.Size(360, 32);
			this.txtbxEmail.TabIndex = 0;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(141, 28);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(348, 31);
			this.label7.TabIndex = 136;
			this.label7.Text = "Enter Your Email Address";
			// 
			// btnEnter
			// 
			this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEnter.Image = global::DVLD.Properties.Resources.Next_32;
			this.btnEnter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEnter.Location = new System.Drawing.Point(399, 200);
			this.btnEnter.Name = "btnEnter";
			this.btnEnter.Size = new System.Drawing.Size(108, 40);
			this.btnEnter.TabIndex = 137;
			this.btnEnter.Text = "Enter";
			this.btnEnter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEnter.UseVisualStyleBackColor = true;
			this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::DVLD.Properties.Resources.Email_32;
			this.pictureBox1.Location = new System.Drawing.Point(90, 137);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(39, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// frmForgetPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(615, 279);
			this.Controls.Add(this.btnEnter);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtbxEmail);
			this.Name = "frmForgetPassword";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Forget Password";
			this.Load += new System.EventHandler(this.frmAssignEmail_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtbxEmail;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnEnter;
	}
}