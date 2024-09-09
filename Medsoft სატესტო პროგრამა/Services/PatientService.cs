using Medsoft_სატესტო_პროგრამა.DataAccess;
using Medsoft_სატესტო_პროგრამა.Models.Dbos;
using Medsoft_სატესტო_პროგრამა.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Medsoft_სატესტო_პროგრამა.Services
{
	public class PatientService : IPatientService
	{
		private readonly PatientAppDbContext _patientAppDbContext;

		public PatientService(PatientAppDbContext patientAppDbContext)
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

		public async Task Add(PatientDto newPatient)
		{
			var patientDbo = new Patient()
			{
				FullName = newPatient.PatientName,
				Dob = newPatient.Dob,
				GenderId = newPatient.Gender == "მამრობითი" ? 1 : 2,
				Phone = newPatient.Phone,
				Address = newPatient.Address,
				PatientId = newPatient.PersonId,
				Email = newPatient.Email
			};

			await _patientAppDbContext.Patients.AddAsync(patientDbo);
			await _patientAppDbContext.SaveChangesAsync();
		}

		public async Task Edit(PatientDto EditedPatient, int id)
		{
			var patientDbo = await _patientAppDbContext.Patients
				.FirstOrDefaultAsync(c => c.Id == id)
				?? throw new ArgumentNullException();

			patientDbo.FullName = EditedPatient.PatientName;
			patientDbo.Dob = EditedPatient.Dob;
			patientDbo.GenderId = EditedPatient.Gender == "მამრობითი" ? 1 : 2;
			patientDbo.Phone = EditedPatient.Phone;
			patientDbo.Address = EditedPatient.Address;
			patientDbo.PatientId = EditedPatient.PersonId;
			patientDbo.Email = EditedPatient.Email;

			await _patientAppDbContext.SaveChangesAsync();
		}
	}
}
