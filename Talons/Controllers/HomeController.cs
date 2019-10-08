using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Talons.Models;

namespace Talons.Controllers
{
    public class HomeController : Controller
    {
        private Models.TalonDBEntities1 db = new Models.TalonDBEntities1();
        public ActionResult Index()
        {
            var Items = db.Infs;
            return View();
        }

        public ActionResult MainPage(int item_id)
        {

            var Item = db.Infs.FirstOrDefault(x => x.Id == item_id);
            return View(Item);
        }


        public ActionResult About()
        {
            var Items = db.Infs;
            return View();
        }

        public ActionResult Ok()
        {
            var Items = db.Infs;
            return View();
            
        }
        

        public ActionResult Contact()
        {
            var Items = db.Infs;
            return View();
        }


        public ActionResult Registr()
        {
            var Items = db.Infs;
            return View();
        }


      


        [ChildActionOnly]
        public string FormOptions(int item_id = 0)
        {
            var Items = db.Doctors;
            string str = "";
            foreach (var item in Items)
            { if (item_id == item.Id)
                {
                    str += "<option value = " + item.Id + "selected>" + item.Speciality + "</option>";
                }
                else
                {
                    str += "<option value = " + item.Id + ">" + item.Speciality + "</option>";
                }
            } return str;


        }



        [HttpGet]
        public ActionResult Form(int item_id = 0)
        {
            ViewBag.Item = item_id;
            return PartialView();

        }


        [HttpPost]
        public string Ok(String Surname, string Name, string Secondname, string BirthDate, string Tel, string Email, int specialty)
            

        {
           Order order = new Order
            {
                Фамилия = Surname,
                Имя = Name,
                Отчество = Secondname,
                Дата_рождения = BirthDate,
               Телефон = Tel,
               Эмэйл = Email,
               Специальностьid = specialty,
               


           };
            db.Orders.Add(order);
            db.SaveChanges();

            return "" ;

        }

    }

}