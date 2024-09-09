using Medsoft_სატესტო_პროგრამა.Models.Dbos;
using Microsoft.EntityFrameworkCore;

namespace Medsoft_სატესტო_პროგრამა.DataAccess;

public partial class PatientAppDbContext : DbContext
{
	public PatientAppDbContext()
	{
	}

	public PatientAppDbContext(DbContextOptions<PatientAppDbContext> options)
		: base(options)
	{
	}

	public virtual DbSet<Gender> Genders { get; set; }

	public virtual DbSet<Patient> Patients { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		if (!optionsBuilder.IsConfigured)
		{
			optionsBuilder.UseSqlServer("Server=BPC;Database=MedsoftDb;Trusted_Connection=True;TrustServerCertificate=True");
		}
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Gender>(entity =>
		{
			entity.ToTable("gender");

			entity.Property(e => e.GenderId).HasColumnName("genderID");
			entity.Property(e => e.GenderName)
				.HasMaxLength(30)
				.HasColumnName("gender_name");

			entity.HasData(
				new Gender
				{
					GenderId = 1,
					GenderName = "მამრობითი",
				},
				new Gender
				{
					GenderId = 2,
					GenderName = "მდედრობითი",
				}
				);
		});

		modelBuilder.Entity<Patient>(entity =>
		{
			entity.ToTable("patient");

			entity.Property(e => e.Id).HasColumnName("ID");
			entity.Property(e => e.Address)
				.HasMaxLength(500)
				.IsUnicode(false)
				.HasColumnName("address");
			entity.Property(e => e.Email)
				.HasMaxLength(255)
				.IsUnicode(false)
				.HasColumnName("email");
			entity.Property(e => e.FullName)
				.HasMaxLength(200)
				.HasColumnName("full_name");
			entity.Property(e => e.GenderId).HasColumnName("genderID");
			entity.Property(e => e.PatientId)
				.HasMaxLength(255)
				.IsUnicode(false)
				.HasColumnName("patient_id");
			entity.Property(e => e.Phone)
				.HasMaxLength(50)
				.IsUnicode(false)
				.HasColumnName("phone");

			entity.HasOne(d => d.Gender).WithMany(p => p.Patients)
				.HasForeignKey(d => d.GenderId)
				.OnDelete(DeleteBehavior.ClientSetNull)
				.HasConstraintName("FK_patient_gender");

			entity.HasData(
				new Patient
				{
					Id = 1,
					FullName = "ლუკა არჯევანიძე",
					Dob = new DateOnly(1987, 1, 21),
					GenderId = 1,
					Phone = "599123456",
					Address = "22/24 Ioane Shavteli St",
					PatientId = "3157747508",
					Email = "luka123@gmail.com",
				},
				new Patient
				{
					Id = 2,
					FullName = "ქეთი ბოკერია",
					Dob = new DateOnly(1992, 11, 4),
					GenderId = 2,
					Phone = "598654321",
					Address = "7 Apolon Kutateladze Street",
					PatientId = "0509342681",
					Email = "qeti321@gmail.com",
				},
				new Patient
				{
					Id = 3,
					FullName = "ლექსო გოგიჩაძე",
					Dob = new DateOnly(1998, 12, 17),
					GenderId = 1,
					Phone = "577162534",
					Address = "36 Giorgi Maruashvili St",
					PatientId = "6006784558",
					Email = "leqsogogichadze1998@gmail.com",
				},
				new Patient
				{
					Id = 4,
					FullName = "რევაზ თოდრაძე",
					Dob = new DateOnly(2006, 4, 29),
					GenderId = 1,
					Phone = "555112233",
					Address = "23a/23b Grigol Robakidze Ave",
					PatientId = "4562856692",
					Email = "hakim@gmail.com",
				},
				new Patient
				{
					Id = 5,
					FullName = "გიორგი ისაკაძე",
					Dob = new DateOnly(1989, 5, 20),
					GenderId = 1,
					Phone = "599181818",
					Address = "32 Kiketi Street",
					PatientId = "4846641520",
					Email = "bcglobal@gmail.com",
				},
				new Patient
				{
					Id = 6,
					FullName = "ლევან მახათაძე",
					Dob = new DateOnly(2002, 3, 3),
					GenderId = 1,
					Phone = "595471298",
					Address = "6 Somkheti St",
					PatientId = "123123",
					Email = "hahiss@gmail.com",
				},
				new Patient
				{
					Id = 7,
					FullName = "ანა კუპრაძე",
					Dob = new DateOnly(1993, 10, 9),
					GenderId = 2,
					Phone = "595876492",
					Address = "47a Vazha Pshavela Ave",
					PatientId = "9144403714",
					Email = "user14215@gmail.com",
				},
				new Patient
				{
					Id = 8,
					FullName = "მარიამ ყაზარაშვილი",
					Dob = new DateOnly(1997, 7, 5),
					GenderId = 2,
					Phone = "571422312",
					Address = "27 Vakhtang Chikovani St",
					PatientId = "2453063596",
					Email = "mariammariam@gmail.com",
				}
				);
		});

		OnModelCreatingPartial(modelBuilder);
	}

	partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
