using Microsoft.EntityFrameworkCore;
using SimpleBookCatalog.Domain.Entities;

namespace SimpleBookCatalog.Infrastructure.Context
{
    public class SimpleBookCatalogDbContext : DbContext
    {
        public SimpleBookCatalogDbContext(DbContextOptions<SimpleBookCatalogDbContext> options) : base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }

        // if we do not want to use data annotations in entities, we can use this (fluent api way of things)
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Book>().Property(e => e.Title).IsRequired().HasMaxLength(100);
        //}
    }
}
