using SchoolWebsite.Controllers;

namespace SchoolWebsite.Models
{
    public class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Point { get; set; }
        public int GroupId { get; set; }
        public Group Groups { get; set; }
        public string Image { get; set; }
        //public int GroupId { get; set; }

    }
}
