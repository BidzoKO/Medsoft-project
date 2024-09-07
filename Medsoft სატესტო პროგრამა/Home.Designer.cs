using System.Windows.Forms;

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
			PatientNames = new DataGridViewTextBoxColumn();
			Dob = new DataGridViewTextBoxColumn();
			Gender = new DataGridViewTextBoxColumn();
			Phone = new DataGridViewTextBoxColumn();
			Address = new DataGridViewTextBoxColumn();
			PersonId = new DataGridViewTextBoxColumn();
			EMail = new DataGridViewTextBoxColumn();
			AddButton = new Button();
			EditButton = new Button();
			DeleteButton = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			((System.ComponentModel.ISupportInitialize)PatientTable).BeginInit();
			SuspendLayout();
			// 
			// PatientTable
			// 
			PatientTable.AllowUserToAddRows = false;
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
			PatientTable.Columns.AddRange(new DataGridViewColumn[] { ID, PatientNames, Dob, Gender, Phone, Address, PersonId, EMail });
			PatientTable.EnableHeadersVisualStyles = false;
			PatientTable.GridColor = SystemColors.ActiveCaptionText;
			PatientTable.Location = new Point(24, 28);
			PatientTable.Margin = new Padding(0);
			PatientTable.MultiSelect = false;
			PatientTable.Name = "PatientTable";
			PatientTable.ReadOnly = true;
			PatientTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			PatientTable.RowHeadersVisible = false;
			dataGridViewCellStyle3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			PatientTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
			PatientTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			PatientTable.Size = new Size(1280, 500);
			PatientTable.TabIndex = 1;
			// 
			// ID
			// 
			ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			ID.DataPropertyName = "ID";
			ID.HeaderText = "ID";
			ID.Name = "ID";
			ID.ReadOnly = true;
			ID.Width = 53;
			// 
			// PatientNames
			// 
			PatientNames.DataPropertyName = "PatientName";
			PatientNames.HeaderText = "პაციენტის სახელი";
			PatientNames.Name = "PatientNames";
			PatientNames.ReadOnly = true;
			PatientNames.Width = 205;
			// 
			// Dob
			// 
			Dob.DataPropertyName = "Dob";
			Dob.HeaderText = "დაბ თარიღი";
			Dob.Name = "Dob";
			Dob.ReadOnly = true;
			Dob.Width = 147;
			// 
			// Gender
			// 
			Gender.DataPropertyName = "Gender";
			Gender.HeaderText = "სქესი";
			Gender.Name = "Gender";
			Gender.ReadOnly = true;
			Gender.Width = 85;
			// 
			// Phone
			// 
			Phone.DataPropertyName = "Phone";
			Phone.HeaderText = "მობ ნომერი";
			Phone.Name = "Phone";
			Phone.ReadOnly = true;
			Phone.Width = 139;
			// 
			// Address
			// 
			Address.DataPropertyName = "Address";
			Address.HeaderText = "მისამართი";
			Address.Name = "Address";
			Address.ReadOnly = true;
			Address.Width = 134;
			// 
			// PersonId
			// 
			PersonId.DataPropertyName = "PersonId";
			PersonId.HeaderText = "პირადი ნომერი";
			PersonId.Name = "PersonId";
			PersonId.ReadOnly = true;
			PersonId.Width = 176;
			// 
			// EMail
			// 
			EMail.DataPropertyName = "Email";
			EMail.HeaderText = "მეილი";
			EMail.Name = "EMail";
			EMail.ReadOnly = true;
			EMail.Width = 94;
			// 
			// AddButton
			// 
			AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			AddButton.Location = new Point(1117, 699);
			AddButton.Name = "AddButton";
			AddButton.Size = new Size(98, 40);
			AddButton.TabIndex = 2;
			AddButton.Text = "დამატება";
			AddButton.UseVisualStyleBackColor = true;
			AddButton.Click += Add_Click;
			// 
			// EditButton
			// 
			EditButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			EditButton.ImageAlign = ContentAlignment.MiddleLeft;
			EditButton.Location = new Point(1117, 604);
			EditButton.Name = "EditButton";
			EditButton.Size = new Size(98, 43);
			EditButton.TabIndex = 3;
			EditButton.Text = "რედაქტირება";
			EditButton.UseVisualStyleBackColor = true;
			EditButton.Click += Edit_Click;
			// 
			// DeleteButton
			// 
			DeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			DeleteButton.Location = new Point(1117, 653);
			DeleteButton.Name = "DeleteButton";
			DeleteButton.Size = new Size(98, 40);
			DeleteButton.TabIndex = 4;
			DeleteButton.Text = "წაშლა";
			DeleteButton.UseVisualStyleBackColor = true;
			DeleteButton.Click += Delete_Click;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label1.AutoSize = true;
			label1.Image = Properties.Resources.Delete;
			label1.Location = new Point(1221, 653);
			label1.MinimumSize = new Size(40, 40);
			label1.Name = "label1";
			label1.Size = new Size(40, 40);
			label1.TabIndex = 5;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label2.AutoSize = true;
			label2.Image = Properties.Resources.Add;
			label2.Location = new Point(1221, 699);
			label2.MinimumSize = new Size(40, 40);
			label2.Name = "label2";
			label2.Size = new Size(40, 40);
			label2.TabIndex = 5;
			label2.Click += label2_Click;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			label3.AutoSize = true;
			label3.Image = Properties.Resources.Edit;
			label3.Location = new Point(1221, 604);
			label3.MinimumSize = new Size(40, 40);
			label3.Name = "label3";
			label3.Size = new Size(40, 40);
			label3.TabIndex = 5;
			// 
			// Home
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1330, 791);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(DeleteButton);
			Controls.Add(EditButton);
			Controls.Add(AddButton);
			Controls.Add(PatientTable);
			Name = "Home";
			Text = "მთავარი";
			Load += Home_Load;
			((System.ComponentModel.ISupportInitialize)PatientTable).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView PatientTable;
		private Button AddButton;
		private Button EditButton;
		private Button DeleteButton;
		private DataGridViewTextBoxColumn PatientName;
		private Label label1;
		private Label label2;
		private Label label3;
		private DataGridViewTextBoxColumn ID;
		private DataGridViewTextBoxColumn PatientNames;
		private DataGridViewTextBoxColumn Dob;
		private DataGridViewTextBoxColumn Gender;
		private DataGridViewTextBoxColumn Phone;
		private DataGridViewTextBoxColumn Address;
		private DataGridViewTextBoxColumn PersonId;
		private DataGridViewTextBoxColumn EMail;
	}
}
