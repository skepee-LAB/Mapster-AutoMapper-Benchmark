using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiMapster.Model;

namespace WebApiMapster
{
    public class MyContext: DbContext
    {
        public DbSet<portfolio> portfolio { get; set; }


        public MyContext(DbContextOptions<MyContext> options): base(options)
        {}

    }
}
