using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace bt_tuan3.Models
{
    public partial class BookManager : DbContext
    {
        public BookManager()
            : base("name=BookManager")
        {
        }

        public virtual DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);
        }
    }
}
