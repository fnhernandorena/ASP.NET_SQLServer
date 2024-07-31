using ASP.NET_SQLServer.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_SQLServer.Context
{
    public class AppDataBaseContext: DbContext
    {
        public AppDataBaseContext(DbContextOptions<AppDataBaseContext> options): base(options)
        {
            
        }

        public DbSet<Student> Students {  get; set; }
    }
}
