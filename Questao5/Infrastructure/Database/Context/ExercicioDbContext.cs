
using Microsoft.EntityFrameworkCore;

namespace Questao5.Infrastructure.Database.Context
{
    public class ExercicioDbContext : DbContext
    {
       
        protected readonly IConfiguration Configuration;

        public ExercicioDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
        }


    }
}

