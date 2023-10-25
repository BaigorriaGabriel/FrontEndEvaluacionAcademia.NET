using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FrontEndEvaluacionAcademia.NET.Controllers
{
	public class UsersController : Controller
	{
		[Authorize]
		public IActionResult Users()
		{
			return View();
		}
	}
}
