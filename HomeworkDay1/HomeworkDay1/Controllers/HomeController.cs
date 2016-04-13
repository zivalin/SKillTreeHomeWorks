using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeworkDay1.Models.ViewModels;

namespace HomeworkDay1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Random rnd = new Random();
            List<MoneyViewModel> listDatas = new List<MoneyViewModel>();

            for (int i = 0; i < 10; i++)
            {
                listDatas.Add(
                    new MoneyViewModel()
                    {
                        SR = i,
                        IO = (i / 2) == 1 ? "支出" : "收入",
                        CHDT = DateTime.Now.AddDays(rnd.Next(1, 10)),
                        MNY = rnd.Next(1, 10) * (i+1) * 100
                    }
                );
            }
            return View(listDatas);
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