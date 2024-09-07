using Medsoft_სატესტო_პროგრამა.DataAccess;
using Medsoft_სატესტო_პროგრამა.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Medsoft_სატესტო_პროგრამა.Services
{
	public class HomeService : IHomeService
	{
		private readonly PatientAppDbContext _patientAppDbContext;

		public HomeService(PatientAppDbContext patientAppDbContext)
		{
			_patientAppDbContext = patientAppDbContext;
		}

		public async Task<List<PatientDto>> GetAll()
		{
			var patientDbList = await _patientAppDbContext.Patients.Include(c => c.Gender).ToListAsync();

			var patientDtoList = new List<PatientDto>();

			foreach (var patient in patientDbList)
			{
				patientDtoList.Add(new PatientDto()
				{
					ID = patient.Id,
					PatientName = patient.FullName,
					Dob = patient.Dob,
					Gender = patient.Gender.GenderName,
					Phone = patient.Phone ?? string.Empty,
					Address = patient.Address,
					PersonId = patient.PatientId ?? string.Empty,
					Email = patient.Email ?? string.Empty
				});
			}

			return patientDtoList;
		}

		public async Task Delete(int patientId)
		{
			var patient = await _patientAppDbContext.Patients.FirstOrDefaultAsync(c => c.Id == patientId);
			_patientAppDbContext.Patients.Remove(patient);
			await _patientAppDbContext.SaveChangesAsync();
		}
	}
}
