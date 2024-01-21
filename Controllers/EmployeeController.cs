using Day2Training.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day2Training.Controllers
{
	public class EmployeeController : Controller
	{
		public List<Employee> employees = new List<Employee>()
		{
			new Employee() { Id = 1, Name = "John", Age = 23 },
			new Employee() { Id = 2, Name = "Jane", Age = 24 },
			new Employee() { Id = 3, Name = "Jack", Age = 25 },
			new Employee() { Id = 4, Name = "Jill", Age = 26 }
		};


		public IActionResult Index()
		{
			ViewBag.Message = "EmloyeeList";
			ViewBag.EployeesCount = employees.Count();
			ViewBag.employees = employees;
			return View();
		}

		public IActionResult Index2()
		{
			TempData["Message"] = "EmloyeeList";
			TempData["EployeesCount"] = employees.Count();
			TempData["employees"] = employees;
			return View();
		}
	}
}
