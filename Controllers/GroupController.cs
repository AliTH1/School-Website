using Microsoft.AspNetCore.Mvc;
using SchoolWebsite.Models;

namespace SchoolWebsite.Controllers
{
    public class GroupController : Controller
    {
        public List<Group> groups = new List<Group>()
        {
            new Group()
            {
                Id = 1,
                GroupName = "AB201",
                Description = "Group AB201 is learning C# programming"
            },

            new Group()
            {
                Id = 2,
                GroupName = "AP208",
                Description = "The AP 208 group is a preparation group before the start of the main classes."
            },

            new Group()
            {
                Id = 3,
                GroupName = "BB205",
                Description = "This group is learning Full Stack programming. The basics of the network are also studied"
            }
        };
        public IActionResult Index()
        {
            return View(groups);
        }
    }
}
