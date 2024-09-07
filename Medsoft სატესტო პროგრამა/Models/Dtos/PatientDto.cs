namespace Medsoft_სატესტო_პროგრამა.Models.Dtos
{
	public class PatientDto
	{
		public int ID { get; set; }
		public string PatientName { get; set; } = string.Empty;
		public DateOnly Dob { get; set; }
		public string Gender { get; set; } = string.Empty;
		public string Phone { get; set; } = string.Empty;
		public string Address { get; set; } = string.Empty;
		public string PersonId { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
	}
}
