using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolWebsite.DAL;
using SchoolWebsite.Models;

namespace SchoolWebsite.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public StudentController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IActionResult> Index()
        {
            ICollection<Student> students = await _appDbContext.Students
                .Include(s => s.Groups).ToListAsync();
            return View(students);
        }
    }
}
