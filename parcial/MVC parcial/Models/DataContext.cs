using System.Data.Entity;

namespace MVC_parcial.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<MVC_parcial.Models.Product> Products { get; set; }
    }
}