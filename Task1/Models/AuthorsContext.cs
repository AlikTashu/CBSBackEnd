using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Task1.Models
{
    public class AuthorsContext : DbContext
    {
        public AuthorsContext()
            : base("AuthorDb")
        {
            
        }       

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

    }
}