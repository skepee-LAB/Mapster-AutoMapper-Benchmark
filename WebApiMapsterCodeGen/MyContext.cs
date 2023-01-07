using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiMapsterCodeGen.Domains;

namespace WebApiMapsterCodeGen
{
    public class MyContext: DbContext
    {
        public DbSet<Portfolio> portfolio { get; set; }

        public MyContext(DbContextOptions<MyContext> options): base(options)
        {}

    }
}
