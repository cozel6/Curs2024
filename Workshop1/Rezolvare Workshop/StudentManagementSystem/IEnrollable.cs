using StudentManagementSystem.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public interface IEnrollable
    {
        void Enroll(Student student);
    }
}
