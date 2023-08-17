using Microsoft.EntityFrameworkCore;
using ToDo.Models;

namespace ToDo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<TodoModel> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("TrustServerCertificate=True; Persist Security Info=False;Integrated Security=true;Initial Catalog=ToDo;server=DESKTOP-3PVVSJJ\\SERVERSQL");


        }

    }
}
