using Medsoft_სატესტო_პროგრამა.Models.Dtos;

namespace Medsoft_სატესტო_პროგრამა
{
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
			InitialData();
			this.Load += new EventHandler(Home_Load);
			this.MouseDown += new MouseEventHandler(Form_MouseDown);
		}

		private void Form_MouseDown(object sender, MouseEventArgs e)
		{
			if (ActiveControl != PatientTable)
			{
				PatientTable.ClearSelection();
			}
		}

		private void InitialData()
		{
			var listOfPatients = new List<PatientDto>()
			{
				new PatientDto()
				{
					ID = 1,
					PatientName = "Test",
					Dob = new DateOnly(1998, 10, 26),
					Gender = "male",
					Phone = "",
					Address = "",
					PersonId = 1,
					EMail = "",
				},
				new PatientDto()
				{
					ID = 1,
					PatientName = "Test",
					Dob = new DateOnly(1998, 10, 26),
					Gender = "male",
					Phone = "",
					Address = "",
					PersonId = 1,
					EMail = "",
				},
				new PatientDto()
				{
					ID = 1,
					PatientName = "Test",
					Dob = new DateOnly(1998, 10, 26),
					Gender = "male",
					Phone = "",
					Address = "",
					PersonId = 1,
					EMail = "",
				},
				new PatientDto()
				{
					ID = 1,
					PatientName = "Test",
					Dob = new DateOnly(1998, 10, 26),
					Gender = "male",
					Phone = "",
					Address = "",
					PersonId = 1,
					EMail = "",
				},

			};

			foreach (var patient in listOfPatients)
			{
				DtoToGridMapper(patient);
			}
		}

		private void DtoToGridMapper(PatientDto patient)
		{
			PatientTable.Rows.Add(
					patient.ID,
					patient.PatientName,
					patient.Dob,
					patient.Gender,
					patient.Phone,
					patient.Address,
					patient.PersonId,
					patient.EMail
				);
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

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}
	}
}
