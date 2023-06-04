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
                    Name = "Martin Amis"
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
                    Name = "Random House"
                },
                new PublishingHouse() {
//                    Id = 2,
                    Name = "Everyman"
                },
                new PublishingHouse() {
//                    Id = 3,
                    Name = "Publishing House 3"
                }
                );
            context.SaveChanges();
            context.Categories.AddRange(
                new Category()
                {
//                    Id = 1,
                    Name = "Fantasy"
                },
                new Category()
                {
//                    Id = 2,
                    Name = "Biography"
                },
                new Category()
                {
//                    Id = 3,
                    Name = "History"
                },
                new Category()
                {
//                    Id = 4,
                    Name = "Art and Design"
                }
                );
            context.SaveChanges();
            context.Books.AddRange(
                new Book()
                {
                    Isbn = "9780099461883",
                    Name = "Money",
                    Pages = 394,
                    CategoryId = 1,
                    AuthorId = 1,
                    PublishingHouseId = 1,
                    PublishingYear = 2005,
                    Description = "Rolling between London and New York he closes movie deals and spends feverishly, all the while grabbing everything he can to sate his massive appetites: alcohol, tobacco, pills, pornography and mountains of junk food.\r\n\r\nBut John's excesses haven't gone unnoted. Menaced by a phone stalker, his high-wire, hoggish lifestyle is about to bring him face-to-face with the secret of his success."
                },
                new Book()
                {
                    Isbn = "9780099455424",
                    Name = "The Rachel Papers",
                    Pages = 219,
                    CategoryId = 1,
                    AuthorId = 1,
                    PublishingHouseId = 1,
                    PublishingYear = 2003,
                    Description = "Precociously intelligent, mercilessly manipulative and highly sexed, Charles devotes the last of his teenage years to bedding girls and evading the half-arsed overtures of his distant parents. That is, until, he meets the aloof, wildly unattainable, Rachel.\r\n\r\nAs Charles's twentieth birthday - and the Oxford entrance exams - loom, his plans for seducing Rachel will draw him into a private collection of obsessional notes and observations: the eponymous 'Rachel Papers'."
                },
                new Book()
                {
                    Isbn = "9781841593623",
                    Name = "London Fields - Everyman's Library",
                    Pages = 509,
                    CategoryId = 1,
                    AuthorId = 1,
                    PublishingHouseId = 2,
                    PublishingYear = 2014,
                    Description = "London Fields is a brilliant, funny and multi-layered novel. It is a book in which the narrator, Samson Young, enters the Black Cross, a thoroughly undesirable public house, and finds the main players of his drama assembled, just waiting to begin. It's a gift of a story from real life...all Samson has to do is write it as it happens."
                });
            context.SaveChanges();
        }
    }
}
