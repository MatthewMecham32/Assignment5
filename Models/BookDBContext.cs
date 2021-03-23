using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment5.Models;
using System.Configuration;

namespace Assignment5.Models
{


    public class BookStoreDBContext : DbContext
    {

        public BookStoreDBContext(DbContextOptions<BookStoreDBContext>options):base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
    
        
}
