using DonateToday.Data;
using DonateToday.Models;
using Microsoft.AspNetCore.Mvc;

namespace DonateToday.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDBContext _db;
        public StudentController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Categories()
        {
            //รูปแบบที่ 1 Type Interence ได้รับความนิยม
            var s1 = new Student();
            s1.Id = 1;
            s1.Email = "kan@gmail.com";
            s1.Password = "1234567890";

            //รูปแบบที่ 2 ใช้ฟังก์ชั่น new()
            Student s2 = new();
            s2.Id = 2;
            s2.Email = "Kanlaya@gmail.com";
            s2.Password = "255674";

            //รูปแบบที่ 3 คำสั่ง
            Student s3 = new Student();
            s3.Id = 3;
            s3.Email = "Yuwadee@gmail.com";
            s3.Password = "4789765685+";

            //การส่งข้อมูลหลายรายการ
            List<Student> allStudent = new List<Student>();
            allStudent.Add(s1);
            allStudent.Add(s2);
            allStudent.Add(s3);

            return View(allStudent);
        }
        public ActionResult CrisisRelief() {
            return View();
        }
        public ActionResult SocialImpactFund()
        {
            return View();
        }
        public ActionResult SupporterSpace()
        {
            return View();
        }
        // GET METHOD
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SignIn(Student obj)
        {
            _db.Students.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Categories");
        }


    }
}
