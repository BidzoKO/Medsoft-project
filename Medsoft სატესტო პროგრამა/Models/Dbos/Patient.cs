namespace Medsoft_სატესტო_პროგრამა.Models.Dbos;

public partial class Patient
{
	public int Id { get; set; }

	public string FullName { get; set; } = null!;

	public DateOnly Dob { get; set; }

	public int GenderId { get; set; }

	public string? Phone { get; set; }

	public string Address { get; set; } = null!;

	public string? PatientId { get; set; }

	public string? Email { get; set; }

	public virtual Gender Gender { get; set; } = null!;
}
