using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingAdoNetHelper
{
    [Table("Books")]
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(40)]
        public string Author { get; set; }

        [StringLength(150)]
        public string Description { get; set; }

        public decimal Price { get; set; }
    }

    public class DatabaseContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DatabaseContext()
        {
            Database.SetInitializer(new MyDatabaseInitializer());
        }
    }

    public class MyDatabaseInitializer : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            GenerateSampleData(context);
        }

        public static void GenerateSampleData(DatabaseContext context)
        {
            for (int i = 0; i < 50; i++)
            {
                context.Books.Add(new Book()
                {
                    Name = FakeData.NameData.GetCompanyName(),
                    Author = FakeData.NameData.GetFullName(),
                    Description = FakeData.TextData.GetAlphabetical(50),
                    Price = FakeData.NumberData.GetNumber(10, 50)
                });
            }

            context.SaveChanges();
        }
    }
}
