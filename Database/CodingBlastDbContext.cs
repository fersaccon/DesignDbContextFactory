using BOL;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class CodingBlastDbContext: IdentityDbContext<AppUser>
    {
        public CodingBlastDbContext(DbContextOptions<CodingBlastDbContext> options)
            : base(options)
        {

        }

        public DbSet<Admins> Admins { get; set; }
    }
}
