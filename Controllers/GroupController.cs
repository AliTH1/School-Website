using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolWebsite.DAL;
using SchoolWebsite.Models;

namespace SchoolWebsite.Controllers
{
    public class GroupController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public GroupController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            List<Group> groups = await _appDbContext.Groups.ToListAsync();
            return View(groups);
        }
    }
}
