namespace InitializerLesson
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
            Database.SetInitializer(new DataInitializercs());//Можно упростить
        }

        public DbSet<Student> Students { get; set; }


    }
}