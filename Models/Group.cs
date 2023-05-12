﻿namespace SchoolWebsite.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public List<Student> Students { get; set; }
        public string Description { get; set; }
    }
}
