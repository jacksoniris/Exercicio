
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

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
            options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()));
            options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));


            base.OnConfiguring(options);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ExercicioDbContext).Assembly);
        }


    }
}

