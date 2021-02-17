using CleanBlog.Entity;
using Microsoft.EntityFrameworkCore;

namespace CleanBlog.Data
{
    public class HomeContext : DbContext
    {
        public HomeContext(DbContextOptions<HomeContext> options) : base(options) { }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        protected void OnModelCreate(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasKey(pdb => pdb.PostID);
            modelBuilder.Entity<Post>().Property(pdb => pdb.Title).IsRequired();
            modelBuilder.Entity<Post>().Property(pdb => pdb.Description).IsRequired();
            modelBuilder.Entity<Post>().Property(pdb => pdb.AuthorID).IsRequired();
            modelBuilder.Entity<Post>().Property(pdb => pdb.AuthorName).IsRequired();
            modelBuilder.Entity<Post>().Property(pdb => pdb.AuthorSurname).IsRequired();

            modelBuilder.Entity<Author>().HasKey(adb => adb.AuthorID);
            modelBuilder.Entity<Author>().Property(adb => adb.AuthorName).IsRequired();
            modelBuilder.Entity<Author>().Property(adb => adb.AuthorSurname).IsRequired();

            modelBuilder.Entity<Contact>().HasKey(ct => ct.ContactID);
            modelBuilder.Entity<Contact>().Property(ct => ct.ContactName).IsRequired();
            modelBuilder.Entity<Contact>().Property(ct => ct.ContactMail).IsRequired();
            modelBuilder.Entity<Contact>().Property(ct => ct.ContactPhone).IsRequired();
            modelBuilder.Entity<Contact>().Property(ct => ct.ContactMessage).IsRequired();


            modelBuilder.Entity<Author>()
            .HasData(new Author
            {
                AuthorID = 1,
                AuthorName = "Mina",
                AuthorSurname = "Turgut"
            });

            modelBuilder.Entity<Author>()
           .HasData(new Author
           {
               AuthorID = 1,
               AuthorName = "Sevim",
               AuthorSurname = "Gür"
           });


            modelBuilder.Entity<Post>()
            .HasData(new Post
            {
                PostID = 1,
                Title = "Başarılı Post",
                Description = "Başarılı Post metnidir",
                AuthorID = 1,
                AuthorName = "Mina",
                AuthorSurname = "Turgut"

            });

            modelBuilder.Entity<Post>()
           .HasData(new Post
           {
               PostID = 1,
               Title = "Başarılı Post 2 ",
               Description = "Başarılı Post 2 metnidir",
               AuthorID = 1,
               AuthorName = "Sevim",
               AuthorSurname = "Gür"

           });

            modelBuilder.Entity<Contact>()
                .HasData(new Contact
                {
                    ContactID = 1,
                    ContactName = "Hanife",
                    ContactMail = "hanife@hotmail.com",
                    ContactPhone = "5554443322",
                    ContactMessage = "Oldu mu?"
                });
            modelBuilder.Entity<Contact>()
               .HasData(new Contact
               {
                   ContactID = 2,
                   ContactName = "Selen",
                   ContactMail = "selen@hotmail.com",
                   ContactPhone = "5554443311",
                   ContactMessage = "Deneme 2"
               });


        }
    }
}
