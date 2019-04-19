using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitializerLesson
{
    public class DataInitializercs : DropCreateDatabaseAlways<DataContext>
    {
        private List<Student> students;

        public DataInitializercs()
        {
            students = new List<Student>
            {
                new Student
                {
                    FullName="Иван Иванов",
                    AverageMark= 11
                },
                new Student
                {
                    FullName = "Петр Петров",
                    AverageMark = 7
                },
                new Student
                {
                    FullName = "Дмитрий Дмитриев",
                    AverageMark = 9.5
                }
            };
        }

        protected override void Seed(DataContext context)
        {
            context.Students.AddRange(students);
            base.Seed(context);
        }
    }
}
