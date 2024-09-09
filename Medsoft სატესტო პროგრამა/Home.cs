using Medsoft_სატესტო_პროგრამა.Models.Dtos;
using Medsoft_სატესტო_პროგრამა.Services;

namespace Medsoft_სატესტო_პროგრამა
{
	public partial class Home : Form
	{
		private readonly IPatientService _patientService;

		private AddPatientWindow patientForm;

		public Home(IPatientService patientService)
		{
			_patientService = patientService;

			InitializeComponent();
			InitialData();
			this.Load += new EventHandler(Home_Load);
			PatientTable.MouseClick += new MouseEventHandler(PatientTable_MouseClick);
			this.Click += new EventHandler(Form_MouseDown);
		}

		private void ClearTableSelection()
		{
			PatientTable.ClearSelection();
			PatientTable.CurrentCell = null;
		}

		private void Form_MouseDown(object sender, EventArgs e)
		{
			ClearTableSelection();
		}

		private void PatientTable_MouseClick(object sender, MouseEventArgs e)
		{
			DataGridView.HitTestInfo hitTestInfo = PatientTable.HitTest(e.X, e.Y);

			if (hitTestInfo.Type == DataGridViewHitTestType.None)
			{
				ClearTableSelection();
			}
		}

		private async void InitialData()
		{
			var patientList = await _patientService.GetAll();

			PatientTable.DataSource = patientList;
		}

		protected void OnCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (e.RowIndex == -1 && e.ColumnIndex > -1)
			{
				e.Handled = true;
				using (Brush b = new SolidBrush(Color.DimGray))
				{
					e.Graphics.FillRectangle(b, e.CellBounds);
				}
				e.PaintContent(e.ClipBounds);
			}
		}

		private void Home_Load(object sender, EventArgs e)
		{
			PatientTable.CellPainting += new DataGridViewCellPaintingEventHandler(OnCellPainting);
			PatientTable.ClearSelection();
		}

		private void Add_Click(object sender, EventArgs e)
		{
			if (patientForm == null || patientForm.IsDisposed)
			{
				patientForm = new AddPatientWindow(_patientService);
			}
			patientForm.ShowDialog();

			InitialData();
		}

		private void Edit_Click(object sender, EventArgs e)
		{
			if (patientForm == null || patientForm.IsDisposed)
			{
				patientForm = new AddPatientWindow(_patientService);

				var selectedPatient = (PatientDto)PatientTable.SelectedRows[0].DataBoundItem;

				patientForm.patient = selectedPatient;
			}

			patientForm.ShowDialog();

			InitialData();
		}

		private async void Delete_Click(object sender, EventArgs e)
		{
			DialogResult result = new DialogResult();

			if (PatientTable.CurrentRow is not null)
			{
				result = MessageBox.Show("ნივთის წაშლა?",
							  "Confirm Delete",
							  MessageBoxButtons.YesNo,
							  MessageBoxIcon.Warning);
			}

			if (result is DialogResult.Yes)
			{
				var idValue = (int)PatientTable.CurrentRow!.Cells["ID"].Value;

				await _patientService.Delete(idValue);
			}

			InitialData();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
