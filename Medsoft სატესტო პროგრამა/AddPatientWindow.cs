using Medsoft_სატესტო_პროგრამა.Models.Dtos;
using Medsoft_სატესტო_პროგრამა.Services;
using System.Text.RegularExpressions;

namespace Medsoft_სატესტო_პროგრამა
{
	public partial class AddPatientWindow : Form
	{
		public PatientDto? patient = null;

		private readonly IPatientService _patientService;

		public AddPatientWindow(IPatientService patientService)
		{
			_patientService = patientService;
			InitializeComponent();
			this.MaximizeBox = false;
			this.Load += new EventHandler(AddPatientWindow_Load);
			this.FormClosing += new FormClosingEventHandler(FormClose);
		}

		private void AddPatientWindow_Load(object sender, EventArgs e)
		{
			if (patient is not null)
			{
				NameField.Text = patient.PatientName;
				MobileField.Text = patient.Phone;
				AddressField.Text = patient.Address;
				PatientIdField.Text = patient.PersonId;
				EmailField.Text = patient.Email;
				GenderField.SelectedItem = patient.Gender;
				BirthdayField.Value = patient.Dob.ToDateTime(TimeOnly.MinValue);
			}
			else
			{
				GenderField.SelectedIndex = 0;
			}
		}

		private void CancelBtn_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("გამოსვლა?",
				"გამოსვლა?",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if (result == DialogResult.Yes)
			{
				this.Dispose();
			}
		}

		private void FormClose(object sender, FormClosingEventArgs e)
		{
			this.Dispose();
		}

		private async void ConfirmBtn_Click(object sender, EventArgs e)
		{
			try
			{
				var newPatient = new PatientDto();

				newPatient.Address = AddressField.Text;
				newPatient.PatientName = NameField.Text;
				newPatient.Gender = GenderField.Text;
				newPatient.Phone = MobileField.Text;
				newPatient.PersonId = PatientIdField.Text;
				newPatient.Dob = DateOnly.FromDateTime(BirthdayField.Value);
				newPatient.Email = EmailField.Text;

				if (VerifyData(newPatient) is false)
				{
					return;
				}

				if (patient is null)
				{
					await _patientService.Add(newPatient);
				}
				else
				{
					await _patientService.Edit(newPatient, patient.ID);
				}

				this.Dispose();
			}
			catch (ArgumentNullException ex)
			{
				this.Dispose();
			}
		}

		private bool VerifyData(PatientDto patient)
		{
			int errorCount = 0;

			if (!Regex.IsMatch(patient.PatientName, @"^\p{L}+\s\p{L}+$"))
			{
				NameErrorText.Visible = true;
				errorCount += 1;
			}
			else
			{
				NameErrorText.Visible = false;
			}

			if (patient.Phone is not null && !Regex.IsMatch(patient.Phone, @"^5\d{8}$"))
			{
				PhoneErrorText.Visible = true;
				errorCount += 1;
			}
			else
			{
				PhoneErrorText.Visible = false;
			}

			if (patient.Address is not null && !Regex.IsMatch(patient.Address, @"^[\w\s,\.]+$"))
			{
				AddressErrorText.Visible = true;
				errorCount += 1;
			}
			else
			{
				AddressErrorText.Visible = false;
			}

			if (patient.PersonId is not null && !Regex.IsMatch(patient.PersonId, @"^\d{10}$"))
			{
				UserIdErrorText.Visible = true;
				errorCount += 1;
			}
			else
			{
				UserIdErrorText.Visible = false;
			}

			if (patient.Email is not null && !Regex.IsMatch(patient.Email, @"^[\w\.-]+@[a-zA-Z\d\.-]+\.[a-zA-Z]{2,}$"))
			{
				EmailErrorText.Visible = true;
				errorCount += 1;
			}
			else
			{
				EmailErrorText.Visible = false;
			}

			if (errorCount > 0)
			{
				return false;
			}

			return true;
		}
	}
}
