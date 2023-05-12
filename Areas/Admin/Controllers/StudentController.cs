using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolWebsite.DAL;
using SchoolWebsite.Models;

namespace SchoolWebsite.Areas.Admin.Controllers
{
    public class StudentController : Controller
    {

        private readonly AppDbContext _appDbContext;
        public StudentController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        [Area("Admin")]
        public async Task<IActionResult> Index()
        {
            ICollection<Student> students = await _appDbContext.Students
                .Include(s => s.Groups)
                .ToListAsync();
            return View(students);
        }

        [Area("Admin")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Area("Admin")]
        [HttpPost]
        public async Task<IActionResult> Create(string name)
        {
            Student student = new Student();
            student.Name = name;
            await _appDbContext.Students.AddAsync(student);
            return RedirectToAction(nameof(Index));
        }
    }
}
