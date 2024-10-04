using Microsoft.AspNetCore.Mvc;

namespace Task.PL.Areas.Dashboard.Controllers
{
	[Area("Dashboard")]
	public class CategoryController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
