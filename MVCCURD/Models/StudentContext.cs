using Microsoft.EntityFrameworkCore;

namespace MVCCURD.Models

{
    public class StudentContext:DbContext

    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) 
        {

        }

        public DbSet<Student> tbl_Student {  get; set; }
        public DbSet<Department> tbl_Departments { get; set; }
    }
}
