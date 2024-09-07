using Medsoft_სატესტო_პროგრამა.Models.Dtos;

namespace Medsoft_სატესტო_პროგრამა.Services
{
	public interface IHomeService
	{
		public Task<List<PatientDto>> GetAll();
		public Task Delete(int patientId);
	}
}
