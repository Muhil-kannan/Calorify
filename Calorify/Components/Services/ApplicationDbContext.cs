using Microsoft.EntityFrameworkCore;

namespace Calorify.Components.Services
{
    namespace Calorify.Data
    {

        public class ApplicationDbContext : Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }

            public DbSet<Foods> Foods { get; set; }
        }
    }

}
