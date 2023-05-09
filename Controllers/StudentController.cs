using Microsoft.AspNetCore.Mvc;
using SchoolWebsite.Models;

namespace SchoolWebsite.Controllers
{
    public class StudentController : Controller
    {

        List<Student> students = new List<Student>()
        {
            new Student()
            {
                Id = 1,
                Name = "Ali",
                Surname = "Taghizada",
                Point = 98.4,
                GroupName = "AB201",
                Image = "https://img.freepik.com/free-photo/man-is-happy-smiling-with-his-" +
                "eyes_114579-13387.jpg?w=900&t=st=1683643458~exp=1683644058~hmac=2fd355560" +
                "4e45e6be96c4be8843921a915322cb6eb5c65998ec0f26a708f21c8"
            },
            new Student()
            {
                Id = 2,
                Name = "Hakim",
                Surname = "Habibli",
                Point = 78.4,
                GroupName = "AB201",
                Image = "https://img.freepik.com/free-photo/waist-up-shot-cheerful-brunet-" +
                "guy-keeps-hand-rim-spectacles-wears-casual-t-shirt-round-spectacles-being" +
                "-good-mood-poses-against-vivid-yellow-background-happy-emotions-concept_2" +
                "73609-59008.jpg?w=900&t=st=1683642904~exp=1683643504~hmac=d078df790190b0c" +
                "2b8073332fc00558251dfa190df1aa53b123ee3dbd295e80d"

            },
            new Student()
            {
                Id = 3,
                Name = "Pehman",
                Surname = "Huseynov",
                Point = 65.3,
                GroupName = "AP208",
                Image = "https://img.freepik.com/free-photo/people-lifestyle-succes" +
                "s-and-confidence-concept-cheerful-attractive-young-caucasian-male-w" +
                "earing-formal-stylish-clothes-posing-isolated-with-confident-broad-s" +
                "mile_343059-4595.jpg?w=900&t=st=1683638853~exp=1683639453~hmac=176fd" +
                "0f3a844819c4a41105b5188250273ce6dcde6a334499ed64928e62962e7"
            },
            new Student()
            {
                Id = 4,
                Name = "Huseyn",
                Surname = "Shahmuradov",
                Point = 86.4,
                GroupName = "BB205",
                Image = "https://img.freepik.com/free-photo/handsome-charismatic-adult-b" +
                "lond-man-with-perfect-white-smile-introduce-new-product-pointing-finger" +
                "-upper-left-corner-demonstrate-banner-advertisement-standing-yellow-bac" +
                "kground_1258-59619.jpg?w=900&t=st=1683643114~exp=1683643714~hmac=f49c3b" +
                "6fb1a5e78fb119a1718ea88e3eb07422baf43f239cec9475e4581690b5"
            },
            new Student()
            {
                Id = 5,
                Name = "Hikmet",
                Surname = "Mekhraliyev",
                Point = 98.4,
                GroupName = "BB205",
                Image = "https://img.freepik.com/free-photo/young-hispanic-man-standin" +
                "g-yellow-background-with-happy-cool-smile-face-lucky-person_839833-85" +
                "87.jpg?w=900&t=st=1683643485~exp=1683644085~hmac=ec050ed1eb358b3e0624" +
                "875976d4a0aba9201a9ff572600eee79ec04c7dcc737"
            },
            new Student()
            {
                Id = 6,
                Name = "Xalid",
                Surname = "Tagiyev",
                Point = 95.3,
                GroupName = "AP208",
                Image = "https://img.freepik.com/free-photo/smiling-caucasian-young-guy-wearing" +
                "-pink-shirt-isolated-orange-background_141793-38612.jpg?w=900&t=st=1683643520~" +
                "exp=1683644120~hmac=1aecda744e09d885658c097d7fbecd0315b4417c4a5f9d86f86755989c" +
                "30e8ad"
            }
        };
        public IActionResult Index()
        {

            return View(students);
        }
    }
}
