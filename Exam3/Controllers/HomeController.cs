using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exam3.Models;

namespace Exam3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            northwindEntities NorthwindDB = new northwindEntities();
            List<Order> AllOrders = NorthwindDB.Orders.ToList();

            ViewBag.Orders = AllOrders;

            return View();
        }

        public ActionResult AddNumbers(string Number1, string Number2)
        {
            int num1 = Int32.Parse(Number1);
            int num2 = Int32.Parse(Number2);
            ViewBag.result = num1 + num2;

            return View("Result");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}