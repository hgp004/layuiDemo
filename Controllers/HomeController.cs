using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace layuiDemo.Controllers
{
    public class Truck
    {
        public int id { get; set; }
        public string code { get; set; }
        public string gps { get; set; }
    }
    public class HomeController : Controller
    {
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
        public ActionResult GetContent()
        {
            return PartialView() ;
        }
        [HttpGet]
        public ActionResult GetData(int iPage,int iPageSize,string filter,int? id)
        {
            List<Truck> lTruck = new List<Truck>();
            lTruck.Add(new Truck() {  code="aa", gps="aagsp",id=0});
            lTruck.Add(new Truck() { code = "aa1", gps = "aagsp1", id = 1 });
            lTruck.Add(new Truck() { code = "aa2", gps = "aagsp2", id = 2 });
            lTruck.Add(new Truck() { code = "aa3", gps = "aagsp3", id = 3});
            lTruck.Add(new Truck() { code = "aa4", gps = "aagsp4", id = 4 });
            lTruck.Add(new Truck() { code = "aa5", gps = "aagsp5", id = 5 });
            lTruck.Add(new Truck() { code = "aa6", gps = "aagsp6", id = 6 });
            if (id != null)
            {
                lTruck = lTruck.Where(a => a.id == id.Value).ToList();
            }
            return Json(new { code=0,msg="", count=1000,data=lTruck },JsonRequestBehavior.AllowGet);
        }
    }
}