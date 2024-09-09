using Medsoft_სატესტო_პროგრამა.Models.Dtos;

namespace Medsoft_სატესტო_პროგრამა.Services
{
	public interface IPatientService
	{
		public Task<List<PatientDto>> GetAll();
		public Task Delete(int patientId);
		public Task Add(PatientDto newPatient);
		public Task Edit(PatientDto EditedPatient, int id);
	}
}
