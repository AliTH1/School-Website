using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolWebsite.DAL;
using SchoolWebsite.Models;

namespace SchoolWebsite.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public TeacherController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            List<Teacher> teachers = await _appDbContext.Teachers.ToListAsync();
            return View(teachers);
        }
    }
}
