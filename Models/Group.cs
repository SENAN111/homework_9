using Encapsilation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsilation.Models
{
    internal class Group
    {
        private string no;
        private int student_limit;
        private Student[] students;


        public void Setstudent_limit(int student_limit)
        {
            if (student_limit >= 5 && student_limit <= 18)

            {
                student_limit = student_limit;
            }
        }
        public int Getstudent_limit()
        {
            return student_limit;
        }
        public void Add(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            Students[students.Length - 1] = student;
        }

    }
}
