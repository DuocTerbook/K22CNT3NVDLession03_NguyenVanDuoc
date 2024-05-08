using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NVD_lession03.Controllers
{
    public class NVDStudentController : Controller
    {
        // GET: NVDstudent
        public ActionResult Index()
        {
            //Dữ liệu từ ViewData
            ViewData["msg"] = "ViewData = Nguyễn Văn Được";
            ViewData["time"] = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy tt");
            return View();
        }
        public ActionResult StudentList()
        {
            //Sử dụng ViewBag
            //Lưu trữ giá trị đơn
            ViewBag.titleName = "Danh sách học viên - Nguyễn Văn Được";
            //giá trị của một tập hợp
            string[] names = { "Trần Bình", "Xuân Tiến", "Thanh Thảo", "Đinh Hương" };
            ViewBag.list = names;
            //giá trị là một đối tượng
            var obj = new 
            {
                ID = 100,
                Name = "Duoc Duoc",
                Age = 20
            };
            ViewBag.student = obj;
            return View();
        }
        public ActionResult Insert()
        {
            return View("AddStudent");
        }
    }
}