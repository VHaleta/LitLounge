using LitLounge.Constants;
using LitLounge.Helpers;
using LitLounge.Models;

namespace LitLounge
{
    public class DataSeed
    {
        public static void Initialize (DataContext context)
        {
            if (context.Books.Any())
                return;
            context.Users.Add(
                new User() {
                    Email = "admin@gmail.com",
                    Password = Encrypter.Encrypt("admin"),
                    Role = UserRoleNames.Admin
                }
                );
            context.SaveChanges();
            context.Authors.AddRange(
                new Author()
                {
//                    Id = 1,
                    Name = "Author 1"
                },
                new Author()
                {
//                    Id = 2,
                    Name = "Author 2"
                },
                new Author()
                {
//                    Id = 3,
                    Name = "Author 3"
                }
                );
            context.SaveChanges();
            context.PublishingHouses.AddRange(
                new PublishingHouse() {
//                    Id = 1,
                    Name = "Publishing House 1" 
                },
                new PublishingHouse() {
//                    Id = 2,
                    Name = "Publishing House 2"
                },
                new PublishingHouse() {
//                    Id = 3,
                    Name = "Publishing House 3"
                }
                );
            context.SaveChanges();
            context.Genres.AddRange(
                new Genre()
                {
//                    Id = 1,
                    Name = "Fantasy"
                },
                new Genre()
                {
//                    Id = 2,
                    Name = "Adventure"
                },
                new Genre()
                {
//                    Id = 3,
                    Name = "Romance"
                },
                new Genre()
                {
//                    Id = 4,
                    Name = "Horror"
                },
                new Genre()
                {
//                    Id = 5,
                    Name = "Mystery"
                },
                new Genre()
                {
//                    Id = 6,
                    Name = "Science Fiction"
                }
                );
            context.SaveChanges();
            context.Books.AddRange(
                new Book()
                {
                    Isbn = "978-3-16-148410-0",
                    Name = "Book Name 1",
                    Pages = 320,
                    GenreId = 1,
                    AuthorId = 2,
                    PublishingHouseId = 1,
                    PublishingYear = 2014,
                    Description = "Some description of cool book. Very cool book."
                },
                new Book()
                {
                    Isbn = "978-5-16-148210-0",
                    Name = "Book Name 2",
                    Pages = 150,
                    GenreId = 2,
                    AuthorId = 1,
                    PublishingHouseId = 1,
                    PublishingYear = 2016,
                    Description = "Some description of cool book. Very cool book."
                },
                new Book()
                {
                    Isbn = "978-3-16-148440-0",
                    Name = "Book Name 3",
                    Pages = 100,
                    GenreId = 1,
                    AuthorId = 3,
                    PublishingHouseId = 2,
                    PublishingYear = 2000,
                    Description = "Some description of cool book. Very cool book."
                },
                new Book()
                {
                    Isbn = "978-3-16-448410-3",
                    Name = "Book Name 4",
                    Pages = 243,
                    GenreId = 4,
                    AuthorId = 3,
                    PublishingHouseId = 3,
                    PublishingYear = 2019,
                    Description = "Some description of cool book. Very cool book."
                },
                new Book()
                {
                    Isbn = "978-8-96-148410-0",
                    Name = "Book Name 5",
                    Pages = 370,
                    GenreId = 5,
                    AuthorId = 2,
                    PublishingHouseId = 3,
                    PublishingYear = 2014,
                    Description = "Some description of cool book. Very cool book."
                },
                new Book()
                {
                    Isbn = "978-3-16-149910-0",
                    Name = "Book Name 6",
                    Pages = 535,
                    GenreId = 2,
                    AuthorId = 2,
                    PublishingHouseId = 1,
                    PublishingYear = 2013,
                    Description = "Some description of cool book. Very cool book."
                }
                );
            context.SaveChanges();
        }
    }
}
