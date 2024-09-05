namespace Medsoft_სატესტო_პროგრამა
{
	partial class Home
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			PatientTable = new DataGridView();
			ID = new DataGridViewTextBoxColumn();
			PatientName = new DataGridViewTextBoxColumn();
			Dob = new DataGridViewTextBoxColumn();
			Gender = new DataGridViewTextBoxColumn();
			Phone = new DataGridViewTextBoxColumn();
			Address = new DataGridViewTextBoxColumn();
			PersonId = new DataGridViewTextBoxColumn();
			EMail = new DataGridViewTextBoxColumn();
			AddButton = new Button();
			EditButton = new Button();
			DeleteButton = new Button();
			((System.ComponentModel.ISupportInitialize)PatientTable).BeginInit();
			SuspendLayout();
			// 
			// PatientTable
			// 
			dataGridViewCellStyle1.BackColor = Color.LightGray;
			dataGridViewCellStyle1.Font = new Font("Arial", 11F);
			dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = Color.White;
			PatientTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			PatientTable.Anchor = AnchorStyles.None;
			PatientTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			PatientTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			PatientTable.BackgroundColor = SystemColors.Control;
			PatientTable.BorderStyle = BorderStyle.None;
			PatientTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
			PatientTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.DimGray;
			dataGridViewCellStyle2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = Color.White;
			dataGridViewCellStyle2.SelectionBackColor = Color.DimGray;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			PatientTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			PatientTable.ColumnHeadersHeight = 35;
			PatientTable.Columns.AddRange(new DataGridViewColumn[] { ID, PatientName, Dob, Gender, Phone, Address, PersonId, EMail });
			PatientTable.EnableHeadersVisualStyles = false;
			PatientTable.GridColor = SystemColors.ActiveCaptionText;
			PatientTable.Location = new Point(66, 37);
			PatientTable.Margin = new Padding(0);
			PatientTable.Name = "PatientTable";
			PatientTable.ReadOnly = true;
			PatientTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			PatientTable.RowHeadersVisible = false;
			dataGridViewCellStyle3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			PatientTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
			PatientTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			PatientTable.Size = new Size(1160, 500);
			PatientTable.TabIndex = 1;
			PatientTable.CellContentClick += dataGridView1_CellContentClick;
			// 
			// ID
			// 
			ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			ID.HeaderText = "ID";
			ID.Name = "ID";
			ID.ReadOnly = true;
			ID.Width = 53;
			// 
			// PatientName
			// 
			PatientName.HeaderText = "პაციენტის გვარი სახელი";
			PatientName.Name = "PatientName";
			PatientName.ReadOnly = true;
			PatientName.Width = 265;
			// 
			// Dob
			// 
			Dob.HeaderText = "დაბ თარიღი";
			Dob.Name = "Dob";
			Dob.ReadOnly = true;
			Dob.Width = 147;
			// 
			// Gender
			// 
			Gender.HeaderText = "სქესი";
			Gender.Name = "Gender";
			Gender.ReadOnly = true;
			Gender.Width = 85;
			// 
			// Phone
			// 
			Phone.HeaderText = "მობ ნომერი";
			Phone.Name = "Phone";
			Phone.ReadOnly = true;
			Phone.Width = 139;
			// 
			// Address
			// 
			Address.HeaderText = "მისამართი";
			Address.Name = "Address";
			Address.ReadOnly = true;
			Address.Width = 134;
			// 
			// PersonId
			// 
			PersonId.HeaderText = "პირადი ნომერი";
			PersonId.Name = "PersonId";
			PersonId.ReadOnly = true;
			PersonId.Width = 176;
			// 
			// EMail
			// 
			EMail.HeaderText = "იმეილი";
			EMail.Name = "EMail";
			EMail.ReadOnly = true;
			EMail.Width = 105;
			// 
			// AddButton
			// 
			AddButton.Anchor = AnchorStyles.None;
			AddButton.Location = new Point(466, 575);
			AddButton.Name = "AddButton";
			AddButton.Size = new Size(102, 40);
			AddButton.TabIndex = 2;
			AddButton.Text = "დამატება";
			AddButton.UseVisualStyleBackColor = true;
			AddButton.Click += button1_Click;
			// 
			// EditButton
			// 
			EditButton.Anchor = AnchorStyles.None;
			EditButton.Location = new Point(600, 575);
			EditButton.Name = "EditButton";
			EditButton.Size = new Size(107, 40);
			EditButton.TabIndex = 3;
			EditButton.Text = "რედაქტირება";
			EditButton.UseVisualStyleBackColor = true;
			EditButton.Click += button2_Click;
			// 
			// DeleteButton
			// 
			DeleteButton.Anchor = AnchorStyles.None;
			DeleteButton.Location = new Point(726, 575);
			DeleteButton.Name = "DeleteButton";
			DeleteButton.Size = new Size(102, 40);
			DeleteButton.TabIndex = 4;
			DeleteButton.Text = "წაშლა";
			DeleteButton.UseVisualStyleBackColor = true;
			DeleteButton.Click += button3_Click;
			// 
			// Home
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1235, 777);
			Controls.Add(DeleteButton);
			Controls.Add(EditButton);
			Controls.Add(AddButton);
			Controls.Add(PatientTable);
			Name = "Home";
			Text = "მთავარი";
			Load += Home_Load;
			((System.ComponentModel.ISupportInitialize)PatientTable).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView PatientTable;
		private Button AddButton;
		private Button EditButton;
		private Button DeleteButton;
		private DataGridViewTextBoxColumn ID;
		private DataGridViewTextBoxColumn PatientName;
		private DataGridViewTextBoxColumn Dob;
		private DataGridViewTextBoxColumn Gender;
		private DataGridViewTextBoxColumn Phone;
		private DataGridViewTextBoxColumn Address;
		private DataGridViewTextBoxColumn PersonId;
		private DataGridViewTextBoxColumn EMail;
	}
}
