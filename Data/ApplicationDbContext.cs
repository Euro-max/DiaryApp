using Microsoft.EntityFrameworkCore;
using DiaryApp.Models;

namespace DiaryApp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet <DiaryItems> DiaryItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DiaryItems>().HasData(
                new DiaryItems
                {
                    Id = 1,
                    Title="Went Hiking with Joe",
                    Content="Noice",
                    Created=DateTime.Now,
                },
                 new DiaryItems
                 {
                     Id = 2,
                     Title = "Went Hiking wh Joe",
                     Content = "Noce",
                     Created = DateTime.Now,
                 },
                  new DiaryItems
                  {
                      Id = 3,
                      Title = "C#",
                      Content = "Noce",
                      Created = DateTime.Now,
                  }

                );
        }
    }
}
