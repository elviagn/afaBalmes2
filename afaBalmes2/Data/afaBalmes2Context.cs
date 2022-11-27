using afaBalmes2.Models;
using Microsoft.EntityFrameworkCore;

namespace afaBalmes2.Data
{

    public class afaBalmes2Context : DbContext
    {
        public afaBalmes2Context(DbContextOptions<afaBalmes2Context> options)
            : base(options)
        {
        }

        public DbSet<afaBalmes2.Models.User> User { get; set; } = default!;
    }
}
