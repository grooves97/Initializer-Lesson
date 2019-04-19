using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitializerLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DataContext())
            {
                context.Students.Add(new Student
                {
                    FullName = "Абрахам Линкольн",
                    AverageMark = 12
                });
                context.SaveChanges();
                var result = context.Students.ToList();
            }
        }
    }
}
