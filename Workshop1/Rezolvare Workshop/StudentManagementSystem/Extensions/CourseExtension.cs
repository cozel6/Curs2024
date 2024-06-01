using StudentManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Extensions
{
    public static class CourseExtension
    {
        public static Course? FindByName(this List<Course> courses , Subject name)
        {
            return courses.FirstOrDefault(s => s.Name == name);
        }
    }
}
