using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace f1project.webui.Identity
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        IConfiguration _configuration;
        public ApplicationContext(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("MsSqlConnection"));
            base.OnConfiguring(optionsBuilder);
        }
        // public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        // {
            
        // }
    }

}