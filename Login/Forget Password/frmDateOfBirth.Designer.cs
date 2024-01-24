namespace DVLD.Login.Forget_Password
{
	partial class frmDateOfBirth
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
			this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnEnter = new System.Windows.Forms.Button();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(213, 30);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(184, 31);
			this.label7.TabIndex = 137;
			this.label7.Text = "Date Of Birth";
			// 
			// dtpDateOfBirth
			// 
			this.dtpDateOfBirth.CustomFormat = "dd/M/yyyy";
			this.dtpDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateOfBirth.Location = new System.Drawing.Point(219, 123);
			this.dtpDateOfBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dtpDateOfBirth.Name = "dtpDateOfBirth";
			this.dtpDateOfBirth.Size = new System.Drawing.Size(221, 34);
			this.dtpDateOfBirth.TabIndex = 138;
			this.dtpDateOfBirth.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
			// 
			// btnClose
			// 
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = global::DVLD.Properties.Resources.cross_32;
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(202, 198);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(110, 40);
			this.btnClose.TabIndex = 141;
			this.btnClose.Text = "Close";
			this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnEnter
			// 
			this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEnter.Image = global::DVLD.Properties.Resources.Next_32;
			this.btnEnter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEnter.Location = new System.Drawing.Point(330, 198);
			this.btnEnter.Name = "btnEnter";
			this.btnEnter.Size = new System.Drawing.Size(110, 40);
			this.btnEnter.TabIndex = 141;
			this.btnEnter.Text = "Check";
			this.btnEnter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEnter.UseVisualStyleBackColor = true;
			this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::DVLD.Properties.Resources.Calendar_32;
			this.pictureBox4.Location = new System.Drawing.Point(167, 123);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(42, 34);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 140;
			this.pictureBox4.TabStop = false;
			// 
			// frmDateOfBirth
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(592, 276);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnEnter);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.dtpDateOfBirth);
			this.Controls.Add(this.label7);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "frmDateOfBirth";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
		private System.Windows.Forms.Button btnEnter;
		private System.Windows.Forms.Button btnClose;
	}
}