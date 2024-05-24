using Microsoft.EntityFrameworkCore;
using TFRegisterLoginJWT.Data.Models;

namespace TFRegisterLoginJWT.Data
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

		public DbSet<User> Users { get; set; }
    }
}
