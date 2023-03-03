using Microsoft.EntityFrameworkCore;
using WebApiAutoMapper.Model;

namespace WebApiAutoMapper
{
    public class MyContext: DbContext
    {
        public DbSet<portfolio> portfolio { get; set; }

        public MyContext(DbContextOptions<MyContext> options): base(options)
        {}

    }
}
