using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitializerLesson
{
    public class Student
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public double AverageMark { get; set; }

        public Student()
        {
            Id = Guid.NewGuid();
        }
    }
}
