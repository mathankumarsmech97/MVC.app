using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        public string Gender { get; set; }

        public string Dateofbirth { get; set; }

        public string YearJoin { get; set; }

        List<Student> Students { get; set; }
    }
}