using System.Web;
using System.Data.Entity;

namespace CheapGames.Models.Repository
{
    public class EFDbContext : DbContext
    {
        public EFDbContext()
            : base(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + HttpContext.Current.Server.MapPath("~/App_Data/CheapGames.mdf")
                    + ";Integrated Security=True")
        {  }

        public DbSet<Game> Games { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}