namespace Medsoft_სატესტო_პროგრამა
{
	partial class AddPatientWindow
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
			AddressField = new TextBox();
			FirstNameField = new TextBox();
			MobileField = new TextBox();
			LastNameField = new TextBox();
			PatientIdField = new TextBox();
			EmailField = new TextBox();
			GenderField = new ComboBox();
			FirstNameLabel = new Label();
			LastNameLabel = new Label();
			PhoneLabel = new Label();
			AdressLabel = new Label();
			UserIdLabel = new Label();
			EmailLabel = new Label();
			DobLabel = new Label();
			GenderLabel = new Label();
			BirthdayField = new DateTimePicker();
			NewPatientHeader = new Label();
			ConfirmBtn = new Button();
			CancelBtn = new Button();
			SuspendLayout();
			// 
			// AddressField
			// 
			AddressField.Location = new Point(168, 269);
			AddressField.MaxLength = 20;
			AddressField.Name = "AddressField";
			AddressField.Size = new Size(137, 23);
			AddressField.TabIndex = 0;
			// 
			// FirstNameField
			// 
			FirstNameField.Location = new Point(168, 95);
			FirstNameField.Name = "FirstNameField";
			FirstNameField.Size = new Size(232, 23);
			FirstNameField.TabIndex = 0;
			AddressField.MaxLength = 30;
			// 
			// MobileField
			// 
			MobileField.Location = new Point(168, 210);
			MobileField.Name = "MobileField";
			MobileField.Size = new Size(137, 23);
			MobileField.TabIndex = 0;
			AddressField.MaxLength = 20;
			// 
			// LastNameField
			// 
			LastNameField.Location = new Point(168, 153);
			LastNameField.Name = "LastNameField";
			LastNameField.Size = new Size(232, 23);
			LastNameField.TabIndex = 0;
			AddressField.MaxLength = 50;
			// 
			// PatientIdField
			// 
			PatientIdField.Location = new Point(168, 328);
			PatientIdField.Name = "PatientIdField";
			PatientIdField.Size = new Size(137, 23);
			PatientIdField.TabIndex = 0;
			AddressField.MaxLength = 20;
			// 
			// EmailField
			// 
			EmailField.Location = new Point(168, 392);
			EmailField.Name = "EmailField";
			EmailField.Size = new Size(137, 23);
			EmailField.TabIndex = 0;
			AddressField.MaxLength = 30;
			// 
			// GenderField
			// 
			GenderField.DropDownStyle = ComboBoxStyle.DropDownList;
			GenderField.FormattingEnabled = true;
			GenderField.Items.AddRange(new object[] { "კაცი", "ქალი" });
			GenderField.Location = new Point(406, 395);
			GenderField.Name = "GenderField";
			GenderField.Size = new Size(91, 23);
			GenderField.TabIndex = 1;
			GenderField.SelectedIndexChanged += GenderField_SelectedIndexChanged;
			// 
			// FirstNameLabel
			// 
			FirstNameLabel.AutoSize = true;
			FirstNameLabel.Location = new Point(109, 98);
			FirstNameLabel.Name = "FirstNameLabel";
			FirstNameLabel.Size = new Size(53, 15);
			FirstNameLabel.TabIndex = 2;
			FirstNameLabel.Text = "სახელი";
			// 
			// LastNameLabel
			// 
			LastNameLabel.AutoSize = true;
			LastNameLabel.Location = new Point(120, 156);
			LastNameLabel.Name = "LastNameLabel";
			LastNameLabel.Size = new Size(42, 15);
			LastNameLabel.TabIndex = 2;
			LastNameLabel.Text = "გვარი";
			// 
			// PhoneLabel
			// 
			PhoneLabel.AutoSize = true;
			PhoneLabel.Location = new Point(86, 213);
			PhoneLabel.Name = "PhoneLabel";
			PhoneLabel.Size = new Size(76, 15);
			PhoneLabel.TabIndex = 2;
			PhoneLabel.Text = "მობილური";
			// 
			// AdressLabel
			// 
			AdressLabel.AutoSize = true;
			AdressLabel.Location = new Point(88, 272);
			AdressLabel.Name = "AdressLabel";
			AdressLabel.Size = new Size(74, 15);
			AdressLabel.TabIndex = 2;
			AdressLabel.Text = "მისამართი";
			// 
			// UserIdLabel
			// 
			UserIdLabel.AutoSize = true;
			UserIdLabel.Location = new Point(61, 331);
			UserIdLabel.Name = "UserIdLabel";
			UserIdLabel.Size = new Size(101, 15);
			UserIdLabel.TabIndex = 2;
			UserIdLabel.Text = "პირადი ნომერი";
			// 
			// EmailLabel
			// 
			EmailLabel.AutoSize = true;
			EmailLabel.Location = new Point(115, 395);
			EmailLabel.Name = "EmailLabel";
			EmailLabel.Size = new Size(47, 15);
			EmailLabel.TabIndex = 2;
			EmailLabel.Text = "მეილი";
			// 
			// DobLabel
			// 
			DobLabel.AutoSize = true;
			DobLabel.Location = new Point(317, 272);
			DobLabel.Name = "DobLabel";
			DobLabel.Size = new Size(83, 15);
			DobLabel.TabIndex = 2;
			DobLabel.Text = "დაბ თარიღი";
			// 
			// GenderLabel
			// 
			GenderLabel.AutoSize = true;
			GenderLabel.Location = new Point(360, 398);
			GenderLabel.Name = "GenderLabel";
			GenderLabel.Size = new Size(40, 15);
			GenderLabel.TabIndex = 2;
			GenderLabel.Text = "სქესი";
			// 
			// BirthdayField
			// 
			BirthdayField.Format = DateTimePickerFormat.Short;
			BirthdayField.Location = new Point(406, 269);
			BirthdayField.Name = "BirthdayField";
			BirthdayField.Size = new Size(91, 23);
			BirthdayField.TabIndex = 3;
			// 
			// NewPatientHeader
			// 
			NewPatientHeader.AutoSize = true;
			NewPatientHeader.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			NewPatientHeader.Location = new Point(219, 40);
			NewPatientHeader.Name = "NewPatientHeader";
			NewPatientHeader.Size = new Size(131, 20);
			NewPatientHeader.TabIndex = 2;
			NewPatientHeader.Text = "ახალი პაციენტი";
			// 
			// ConfirmBtn
			// 
			ConfirmBtn.BackColor = Color.DarkGreen;
			ConfirmBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			ConfirmBtn.ForeColor = SystemColors.Control;
			ConfirmBtn.Location = new Point(168, 466);
			ConfirmBtn.Name = "ConfirmBtn";
			ConfirmBtn.Size = new Size(125, 32);
			ConfirmBtn.TabIndex = 4;
			ConfirmBtn.Text = "დადასტურება";
			ConfirmBtn.UseVisualStyleBackColor = false;
			// 
			// CancelBtn
			// 
			CancelBtn.BackColor = Color.DarkRed;
			CancelBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			CancelBtn.ForeColor = SystemColors.Control;
			CancelBtn.Location = new Point(341, 466);
			CancelBtn.Name = "CancelBtn";
			CancelBtn.Size = new Size(111, 32);
			CancelBtn.TabIndex = 4;
			CancelBtn.Text = "დაბრუნება";
			CancelBtn.UseVisualStyleBackColor = false;
			// 
			// AddPatientWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(584, 561);
			Controls.Add(CancelBtn);
			Controls.Add(ConfirmBtn);
			Controls.Add(BirthdayField);
			Controls.Add(GenderLabel);
			Controls.Add(EmailLabel);
			Controls.Add(DobLabel);
			Controls.Add(UserIdLabel);
			Controls.Add(AdressLabel);
			Controls.Add(PhoneLabel);
			Controls.Add(LastNameLabel);
			Controls.Add(NewPatientHeader);
			Controls.Add(FirstNameLabel);
			Controls.Add(GenderField);
			Controls.Add(EmailField);
			Controls.Add(PatientIdField);
			Controls.Add(LastNameField);
			Controls.Add(MobileField);
			Controls.Add(FirstNameField);
			Controls.Add(AddressField);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "AddPatientWindow";
			Text = "AddPatientWindow";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox AddressField;
		private TextBox FirstNameField;
		private TextBox MobileField;
		private TextBox LastNameField;
		private TextBox PatientIdField;
		private TextBox EmailField;
		private ComboBox GenderField;
		private Label FirstNameLabel;
		private Label LastNameLabel;
		private Label PhoneLabel;
		private Label AdressLabel;
		private Label UserIdLabel;
		private Label EmailLabel;
		private Label DobLabel;
		private Label GenderLabel;
		private DateTimePicker BirthdayField;
		private Label NewPatientHeader;
		private Button ConfirmBtn;
		private Button CancelBtn;
	}
}