using Medsoft_სატესტო_პროგრამა.DataAccess;
using Medsoft_სატესტო_პროგრამა.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Medsoft_სატესტო_პროგრამა
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			var serviceCollection = new ServiceCollection();
			ConfigureServices(serviceCollection);

			var serviceProvider = serviceCollection.BuildServiceProvider();

			ApplicationConfiguration.Initialize();

			var mainForm = serviceProvider.GetRequiredService<Home>();
			Application.Run(mainForm);
		}

		private static void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<PatientAppDbContext>(options =>
				options.UseSqlServer("Server=BPC;Database=MedsoftDb;Trusted_Connection=True;TrustServerCertificate=True"));
			services.AddScoped<IHomeService, HomeService>();
			services.AddSingleton<Home>();
		}
	}
}