using System.Data.Entity;

namespace DataAccessLayer
{
    public class EmpContext:DbContext
    {
        public EmpContext():base("name=EmpDB")
        {
        }
        public DbSet<Model.Employee> Employees { get; set; }
    }
}
