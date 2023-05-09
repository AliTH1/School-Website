using Microsoft.AspNetCore.Mvc;
using SchoolWebsite.Models;

namespace SchoolWebsite.Controllers
{
    public class TeacherController : Controller
    {
        List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher()
            {
                Id = 1,
                Name = "Zahid",
                Surname = "Memmedov",
                Subject = "C#"
            },
            new Teacher()
            {
                Id = 2,
                Name = "Narmin",
                Surname = "Shivakhanova",
                Subject = "C#"
            },
            new Teacher()
            {
                Id = 3,
                Name = "Murad",
                Surname = "Hesenzade",
                Subject = "JavaScript"
            },
            new Teacher()
            {
                Id = 4,
                Name = "Huseyn",
                Surname = "Humbetov",
                Subject = "Node.js"
            }
        };
        public IActionResult Index()
        {

            return View();
        }
    }
}
