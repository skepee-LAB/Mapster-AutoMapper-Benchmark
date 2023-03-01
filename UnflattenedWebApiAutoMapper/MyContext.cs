using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using WebApiAutoMapper.Dto;
using WebApiAutoMapper.Model;

namespace WebApiAutoMapper
{
    public class MyContext: DbContext
    {
        public DbSet<Portfolio> portfolio { get; set; }
        public DbSet<DateTimeProperties> dateTimeProperties { get; set; }
        public DbSet<IntProperties> intProperties { get; set; }
        public DbSet<DecimalProperties> decimalProperties { get; set; }
        public DbSet<StringProperties> stringProperties { get; set; }

        public MyContext(DbContextOptions<MyContext> options): base(options)
        {}

    }
}
