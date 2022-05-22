using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SeriLoggerApp.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{
			_logger.LogInformation("You requested the index page");
			try
			{
				for (int i = 1; i < 10; i++)
				{
					if (i == 6)
					{
						throw new Exception("No not 6");
					}
					else
					{
						_logger.LogInformation("The number is {Anything}", i);
					}
				}
			}
			catch(Exception e)
			{
				_logger.LogError(e, "We got the error");
			}
			
		}
	}
}
