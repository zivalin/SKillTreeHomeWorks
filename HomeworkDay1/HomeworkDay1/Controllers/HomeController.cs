using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeworkDay1.Models.ViewModels;
using HomeworkDay1.Models;

namespace HomeworkDay1.Controllers
{
    public class HomeController : Controller
    {
        private SkillTreeHomeworkEntities db = new SkillTreeHomeworkEntities();
        public ActionResult Index()
        {
            
            return View();
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
      
        [ChildActionOnly]
        public ActionResult ShowGridData()
        {
            var dbs = db.AccountBook.Select(v =>
             new
             {
                 SR = v.Id.ToString(),
                 ChangType = v.Categoryyy == 1 ? "支出" : "收入",
                 ChangDate = v.Dateee,
                 Money = v.Amounttt
             });

            List<MoneyViewModel> listDatas = new List<MoneyViewModel>();
            foreach (var row in dbs)
            {
                listDatas.Add(
                    new MoneyViewModel
                    {
                        SR = row.SR,
                        ChangType = row.ChangType,
                        ChangDate = row.ChangDate,
                        Money = row.Money
                    });
            } 
            return View(listDatas);
        }
    }
}