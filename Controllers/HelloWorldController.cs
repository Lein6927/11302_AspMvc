using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
	public class HelloWorldController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		// GET: /HelloWorld/
		/*
		public string Index()
		{
			return "This is my default action...";
			
		}*/
		// 
		// GET: /HelloWorld/Welcome/ 

		public IActionResult Welcome(string name, int numTimes = 1)
		{
			ViewData["Message"] = "Hello !" +" "+ name;
			ViewData["NumTimes"] = numTimes;

			
			return View();
		}

		/*
		public string Welcome(string name,int numTimes=1)
		{
			return HtmlEncoder.Default.Encode($"Hello{name},Numtimes is{numTimes}");
			//呼叫 https://localhost:7180/HelloWorld/Welcome/?name=LKK&numTimes=3
		}
		*/
	}
}
