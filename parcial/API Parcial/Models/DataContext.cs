using System.Data.Entity;

namespace API_Parcial.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<API_Parcial.Models.Product> Products { get; set; }
    }
}