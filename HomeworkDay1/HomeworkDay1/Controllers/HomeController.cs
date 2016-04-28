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
        [HttpPost]
        public ActionResult Index(MoneyViewModel  moneyData)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var accountBook = new AccountBook
            {
                Amounttt = Convert.ToInt32(moneyData.MNY),
                Categoryyy = moneyData.IO == "支出" ? 1 :0,
                Dateee = moneyData.CHDT, 
                Remarkkk = moneyData.RMK, 
                Id = Guid.NewGuid()
            };
            db.AccountBook.Add(accountBook);
            db.SaveChanges();
            return RedirectToAction("Index");
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
        // private int pageSize = 25;

        [ChildActionOnly]
        public ActionResult ShowGridData(int? pageCount)
        {
           // var pageNumber = pageCount ?? 1;

            var dbs = db.AccountBook.Select(v =>
             new
             {
                 SR = v.Id.ToString(),
                 ChangType = v.Categoryyy == 1 ? "支出" : "收入",
                 ChangDate = v.Dateee,
                 Money = v.Amounttt,
                 Remark = v.Remarkkk
             });

            List<MoneyViewModel> listDatas = new List<MoneyViewModel>();
            int i = 0;
            foreach (var row in dbs)
            {
                listDatas.Add(
                    new MoneyViewModel
                    {
                        SR = ++i,
                        IO = row.ChangType,
                        CHDT = row.ChangDate,
                        MNY = row.Money,
                        RMK = row.Remark
                        
                    });
            } 
            return View(listDatas);
        }
    }
}