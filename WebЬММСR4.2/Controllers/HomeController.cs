using System.Data;
using Microsoft.AspNetCore.Mvc;
using WebЬММСR1.Models;


namespace WebЬММСR1.Controllers
{
	public class HomeController : Controller
	{
		private static PersonRepository db = new PersonRepository();
		public IActionResult Index()
		{
			int hour = DateTime.Now.Hour;
			ViewBag.Greeting = hour < 12 ? "Доброе утро" : "Добрый день";
			ViewData["Mes"] = "хорошего настроения";
			return View();
		}
	
        [HttpGet]
        public ViewResult InputData()
        {
            return View();
        }
        [HttpPost]
        public ViewResult InputData(Person p)
        {
            db.AddResponse(p);
            return View("Hello", p);
        }
		public ViewResult OutputData()
		{
			ViewBag.Pers = db.GetAllResponses;
			ViewBag.Count = db.NumberOfPerson;
			return View("ListPerson");
		}

	}
}
