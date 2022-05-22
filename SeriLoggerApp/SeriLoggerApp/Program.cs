using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace SeriLoggerApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			IConfigurationRoot configuration = new ConfigurationBuilder()
												  .AddJsonFile("appsettings.json")
												  .Build();
			Log.Logger = new LoggerConfiguration()
							.ReadFrom
							.Configuration(configuration)
							.CreateLogger();
			try
			{
				Log.Information("Application Start Up");
				CreateHostBuilder(args).Build().Run();
			}
			catch(Exception ex)
			{
				Log.Fatal(ex, "The application failed to start correctly.");
			}
			finally
			{
				Log.CloseAndFlush();
			}
		}

		public static IHostBuilder CreateHostBuilder(string[] args)
		{
			return Host.CreateDefaultBuilder(args)
				        .UseSerilog()
						.ConfigureWebHostDefaults(webBuilder =>
						{
							webBuilder.UseStartup<Startup>();
						});
		}
	}
}
