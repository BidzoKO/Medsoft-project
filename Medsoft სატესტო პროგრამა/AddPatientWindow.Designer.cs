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
			NameField = new TextBox();
			MobileField = new TextBox();
			PatientIdField = new TextBox();
			EmailField = new TextBox();
			GenderField = new ComboBox();
			NameLabel = new Label();
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
			NameErrorText = new Label();
			PhoneErrorText = new Label();
			AddressErrorText = new Label();
			UserIdErrorText = new Label();
			EmailErrorText = new Label();
			SuspendLayout();
			// 
			// AddressField
			// 
			AddressField.Location = new Point(168, 215);
			AddressField.MaxLength = 30;
			AddressField.Name = "AddressField";
			AddressField.Size = new Size(137, 23);
			AddressField.TabIndex = 0;
			// 
			// NameField
			// 
			NameField.Location = new Point(168, 95);
			NameField.Name = "NameField";
			NameField.Size = new Size(329, 23);
			NameField.TabIndex = 0;
			// 
			// MobileField
			// 
			MobileField.Location = new Point(168, 156);
			MobileField.Name = "MobileField";
			MobileField.Size = new Size(137, 23);
			MobileField.TabIndex = 0;
			// 
			// PatientIdField
			// 
			PatientIdField.Location = new Point(168, 274);
			PatientIdField.Name = "PatientIdField";
			PatientIdField.Size = new Size(137, 23);
			PatientIdField.TabIndex = 0;
			// 
			// EmailField
			// 
			EmailField.Location = new Point(168, 338);
			EmailField.Name = "EmailField";
			EmailField.Size = new Size(137, 23);
			EmailField.TabIndex = 0;
			// 
			// GenderField
			// 
			GenderField.DropDownStyle = ComboBoxStyle.DropDownList;
			GenderField.FormattingEnabled = true;
			GenderField.Items.AddRange(new object[] { "მამრობითი", "მდედრობითი" });
			GenderField.Location = new Point(406, 341);
			GenderField.Name = "GenderField";
			GenderField.Size = new Size(112, 23);
			GenderField.TabIndex = 1;
			// 
			// NameLabel
			// 
			NameLabel.AutoSize = true;
			NameLabel.Location = new Point(71, 98);
			NameLabel.Name = "NameLabel";
			NameLabel.Size = new Size(91, 15);
			NameLabel.TabIndex = 2;
			NameLabel.Text = "სახელი გვარი";
			// 
			// PhoneLabel
			// 
			PhoneLabel.AutoSize = true;
			PhoneLabel.Location = new Point(86, 159);
			PhoneLabel.Name = "PhoneLabel";
			PhoneLabel.Size = new Size(76, 15);
			PhoneLabel.TabIndex = 2;
			PhoneLabel.Text = "მობილური";
			// 
			// AdressLabel
			// 
			AdressLabel.AutoSize = true;
			AdressLabel.Location = new Point(88, 218);
			AdressLabel.Name = "AdressLabel";
			AdressLabel.Size = new Size(74, 15);
			AdressLabel.TabIndex = 2;
			AdressLabel.Text = "მისამართი";
			// 
			// UserIdLabel
			// 
			UserIdLabel.AutoSize = true;
			UserIdLabel.Location = new Point(61, 277);
			UserIdLabel.Name = "UserIdLabel";
			UserIdLabel.Size = new Size(101, 15);
			UserIdLabel.TabIndex = 2;
			UserIdLabel.Text = "პირადი ნომერი";
			// 
			// EmailLabel
			// 
			EmailLabel.AutoSize = true;
			EmailLabel.Location = new Point(115, 341);
			EmailLabel.Name = "EmailLabel";
			EmailLabel.Size = new Size(47, 15);
			EmailLabel.TabIndex = 2;
			EmailLabel.Text = "მეილი";
			// 
			// DobLabel
			// 
			DobLabel.AutoSize = true;
			DobLabel.Location = new Point(317, 218);
			DobLabel.Name = "DobLabel";
			DobLabel.Size = new Size(83, 15);
			DobLabel.TabIndex = 2;
			DobLabel.Text = "დაბ თარიღი";
			// 
			// GenderLabel
			// 
			GenderLabel.AutoSize = true;
			GenderLabel.Location = new Point(360, 344);
			GenderLabel.Name = "GenderLabel";
			GenderLabel.Size = new Size(40, 15);
			GenderLabel.TabIndex = 2;
			GenderLabel.Text = "სქესი";
			// 
			// BirthdayField
			// 
			BirthdayField.Format = DateTimePickerFormat.Short;
			BirthdayField.Location = new Point(406, 215);
			BirthdayField.Name = "BirthdayField";
			BirthdayField.Size = new Size(112, 23);
			BirthdayField.TabIndex = 3;
			// 
			// NewPatientHeader
			// 
			NewPatientHeader.AutoSize = true;
			NewPatientHeader.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			NewPatientHeader.Location = new Point(219, 40);
			NewPatientHeader.Name = "NewPatientHeader";
			NewPatientHeader.Size = new Size(185, 20);
			NewPatientHeader.TabIndex = 2;
			NewPatientHeader.Text = "პაციენტის ინფორმაცია";
			// 
			// ConfirmBtn
			// 
			ConfirmBtn.BackColor = Color.DarkGreen;
			ConfirmBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			ConfirmBtn.ForeColor = SystemColors.Control;
			ConfirmBtn.Location = new Point(168, 412);
			ConfirmBtn.Name = "ConfirmBtn";
			ConfirmBtn.Size = new Size(125, 32);
			ConfirmBtn.TabIndex = 4;
			ConfirmBtn.Text = "დადასტურება";
			ConfirmBtn.UseVisualStyleBackColor = false;
			ConfirmBtn.Click += ConfirmBtn_Click;
			// 
			// CancelBtn
			// 
			CancelBtn.BackColor = Color.DarkRed;
			CancelBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			CancelBtn.ForeColor = SystemColors.Control;
			CancelBtn.Location = new Point(341, 412);
			CancelBtn.Name = "CancelBtn";
			CancelBtn.Size = new Size(111, 32);
			CancelBtn.TabIndex = 4;
			CancelBtn.Text = "დაბრუნება";
			CancelBtn.UseVisualStyleBackColor = false;
			CancelBtn.Click += CancelBtn_Click;
			// 
			// NameErrorText
			// 
			NameErrorText.AutoSize = true;
			NameErrorText.Font = new Font("Segoe UI", 8.25F);
			NameErrorText.ForeColor = Color.Red;
			NameErrorText.Location = new Point(168, 121);
			NameErrorText.Name = "NameErrorText";
			NameErrorText.Size = new Size(109, 13);
			NameErrorText.TabIndex = 5;
			NameErrorText.Text = "სახელში შეცდომა";
			NameErrorText.Visible = false;
			// 
			// PhoneErrorText
			// 
			PhoneErrorText.AutoSize = true;
			PhoneErrorText.Font = new Font("Segoe UI", 8.25F);
			PhoneErrorText.ForeColor = Color.Red;
			PhoneErrorText.Location = new Point(168, 182);
			PhoneErrorText.Name = "PhoneErrorText";
			PhoneErrorText.Size = new Size(129, 13);
			PhoneErrorText.TabIndex = 5;
			PhoneErrorText.Text = "მობილურში შეცდომა";
			PhoneErrorText.Visible = false;
			// 
			// AddressErrorText
			// 
			AddressErrorText.AutoSize = true;
			AddressErrorText.Font = new Font("Segoe UI", 8.25F);
			AddressErrorText.ForeColor = Color.Red;
			AddressErrorText.Location = new Point(168, 241);
			AddressErrorText.Name = "AddressErrorText";
			AddressErrorText.Size = new Size(126, 13);
			AddressErrorText.TabIndex = 5;
			AddressErrorText.Text = "მისამართში შეცდომა";
			AddressErrorText.Visible = false;
			// 
			// UserIdErrorText
			// 
			UserIdErrorText.AutoSize = true;
			UserIdErrorText.Font = new Font("Segoe UI", 8.25F);
			UserIdErrorText.ForeColor = Color.Red;
			UserIdErrorText.Location = new Point(168, 300);
			UserIdErrorText.Name = "UserIdErrorText";
			UserIdErrorText.Size = new Size(146, 13);
			UserIdErrorText.TabIndex = 5;
			UserIdErrorText.Text = "პირად ნომერში შეცდომა";
			UserIdErrorText.Visible = false;
			// 
			// EmailErrorText
			// 
			EmailErrorText.AutoSize = true;
			EmailErrorText.Font = new Font("Segoe UI", 8.25F);
			EmailErrorText.ForeColor = Color.Red;
			EmailErrorText.Location = new Point(168, 364);
			EmailErrorText.Name = "EmailErrorText";
			EmailErrorText.Size = new Size(104, 13);
			EmailErrorText.TabIndex = 5;
			EmailErrorText.Text = "მეილში შეცდომა";
			EmailErrorText.Visible = false;
			// 
			// AddPatientWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(584, 505);
			Controls.Add(EmailErrorText);
			Controls.Add(UserIdErrorText);
			Controls.Add(AddressErrorText);
			Controls.Add(PhoneErrorText);
			Controls.Add(NameErrorText);
			Controls.Add(CancelBtn);
			Controls.Add(ConfirmBtn);
			Controls.Add(BirthdayField);
			Controls.Add(GenderLabel);
			Controls.Add(EmailLabel);
			Controls.Add(DobLabel);
			Controls.Add(UserIdLabel);
			Controls.Add(AdressLabel);
			Controls.Add(PhoneLabel);
			Controls.Add(NewPatientHeader);
			Controls.Add(NameLabel);
			Controls.Add(GenderField);
			Controls.Add(EmailField);
			Controls.Add(PatientIdField);
			Controls.Add(MobileField);
			Controls.Add(NameField);
			Controls.Add(AddressField);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Name = "AddPatientWindow";
			Text = "AddPatientWindow";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox AddressField;
		private TextBox NameField;
		private TextBox MobileField;
		private TextBox PatientIdField;
		private TextBox EmailField;
		private ComboBox GenderField;
		private Label NameLabel;
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
		private Label NameErrorText;
		private Label PhoneErrorText;
		private Label AddressErrorText;
		private Label UserIdErrorText;
		private Label EmailErrorText;
	}
}