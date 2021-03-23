using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Assignment5.Models
{
    public class SeedData
    {
        //Data taken from the table that we were given
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookStoreDBContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookStoreDBContext>();
            //Checks to see if a migration already exists
            if (context.Database.GetPendingMigrations().Any())
            {
              context.Database.Migrate();
            }
            //If one does not we input this data into the table
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFirstName = "Victor",
                        AuthorLastName = "Hugo",
                        Publisher = "Signet",
                        ISBN = 978 - 0451419439,
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95,
                    },
                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirstName = "Doris",
                        AuthorMiddleName = "Kearns",
                        AuthorLastName = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = 978 - 0743270755,
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58,
                    },
                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirstName = "Alice",
                        AuthorLastName = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = 978 - 0553384611,
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54,
                    },
                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFirstName = "Ronald",
                        AuthorMiddleName = "C.",
                        AuthorLastName = "White",
                        Publisher = "Random House",
                        ISBN = 978 - 0812981254,
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61,
                    },
                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFirstName = "Laura",
                        AuthorLastName = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = 978 - 0812974492,
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33,
                    },
                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirstName = "Michael",
                        AuthorLastName = "Crichton",
                        Publisher = "Vintage",
                        ISBN = 978 - 0804171281,
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95,
                    },
                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFirstName = "Cal",
                        AuthorLastName = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = 978 - 1455586691,
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99,
                    },
                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthorFirstName = "Michael",
                        AuthorLastName = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = 978 - 1455523023,
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66,
                    },
                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFirstName = "Richard",
                        AuthorLastName = "Branson",
                        Publisher = "Portfolio",
                        ISBN = 978 - 1591847984,
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16,
                    },
                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFirstName = "John",
                        AuthorLastName = "Grisham",
                        Publisher = "Bantam",
                        ISBN = 978 - 0553393613,
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03,
                    },
                    new Book
                    {
                        Title = "Les Miserables 2nd",
                        AuthorFirstName = "Victor2",
                        AuthorLastName = "Hugo",
                        Publisher = "Signet",
                        ISBN = 978 - 0451419439,
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95,
                    },
                    new Book
                    {
                        Title = "Team of Rivals2",
                        AuthorFirstName = "Doris2",
                        AuthorMiddleName = "Kearns",
                        AuthorLastName = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = 978 - 0743270755,
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58,
                    },
                    new Book
                    {
                        Title = "The Snowball2",
                        AuthorFirstName = "Alice2",
                        AuthorLastName = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = 978 - 0553384611,
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54,
                    },
                    new Book
                    {
                        Title = "American Ulysses2",
                        AuthorFirstName = "Ronald2",
                        AuthorMiddleName = "C.",
                        AuthorLastName = "White",
                        Publisher = "Random House",
                        ISBN = 978 - 0812981254,
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61,
                    },
                    new Book
                    {
                        Title = "Unbroken2",
                        AuthorFirstName = "Laura2",
                        AuthorLastName = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = 978 - 0812974492,
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33,
                    },
                    new Book
                    {
                        Title = "The Great Train Robbery2",
                        AuthorFirstName = "Michael2",
                        AuthorLastName = "Crichton",
                        Publisher = "Vintage",
                        ISBN = 978 - 0804171281,
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95,
                    },
                    new Book
                    {
                        Title = "Deep Work2",
                        AuthorFirstName = "Cal2",
                        AuthorLastName = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = 978 - 1455586691,
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99,
                    },
                    new Book
                    {
                        Title = "It's Your Ship2",
                        AuthorFirstName = "Michael2",
                        AuthorLastName = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = 978 - 1455523023,
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66,
                    },
                    new Book
                    {
                        Title = "The Virgin Way2",
                        AuthorFirstName = "Richard2",
                        AuthorLastName = "Branson",
                        Publisher = "Portfolio",
                        ISBN = 978 - 1591847984,
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16,
                    },
                    new Book
                    {
                        Title = "Sycamore Row2",
                        AuthorFirstName = "John2",
                        AuthorLastName = "Grisham",
                        Publisher = "Bantam",
                        ISBN = 978 - 0553393613,
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03,
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}