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
                Subject = "C#",
                Image = "https://www.w3schools.com/bootstrap5/img_avatar3.png"
            },
            new Teacher()
            {
                Id = 2,
                Name = "Narmin",
                Surname = "Shivakhanova",
                Subject = "C#",
                Image = "https://www.w3schools.com/bootstrap5/img_avatar5.png"
            },
            new Teacher()
            {
                Id = 3,
                Name = "Murad",
                Surname = "Hesenzade",
                Subject = "JavaScript",
                Image = "https://www.w3schools.com/bootstrap5/img_avatar1.png"
            },
            new Teacher()
            {
                Id = 4,
                Name = "Huseyn",
                Surname = "Humbetov",
                Subject = "Node.js",
                Image = "https://pixlok.com/wp-content/uploads/2022/02/Profile-Icon-SVG-09856789.png"
            },
            new Teacher()
            {
                Id = 5,
                Name = "Omer",
                Surname = "Mammadov",
                Subject = "HTML, CSS, JavaScript",
                Image = "https://www.w3schools.com/bootstrap5/img_avatar3.png"
            },
            new Teacher()
            {
                Id = 6,
                Name = "Vagif",
                Surname = "Aliyev",
                Subject = "Java",
                Image = "https://www.w3schools.com/bootstrap5/img_avatar1.png"
            }
        };
        public IActionResult Index()
        {

            return View(teachers);
        }
    }
}
