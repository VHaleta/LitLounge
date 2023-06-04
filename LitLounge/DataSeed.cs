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
                    Name = "Rifujin Na Magonote"
                },
                new Author()
                {
//                    Id = 3,
                    Name = "M. John Harrison"
                },
                new Author()
                {
//                    Id = 4,
                    Name = "David Grann"
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
                    Name = "Seven Seas Entertainment"
                },
                new PublishingHouse()
                {
//                    Id = 4,
                    Name = "Profile"
                },
                new PublishingHouse()
                {
//                    Id = 5,
                    Name = "Author Solutions Inc"
                },
                new PublishingHouse()
                {
//                    Id = 6,
                    Name = "Simon & Schuster UK"
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
                    Name = "Graphic Novels"
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
                },
                new Book()
                {
                    Isbn = "9781685796365",
                    Name = "Mushoku Tensei: Jobless Reincarnation (Light Novel) Vol. 22",
                    Pages = 380,
                    CategoryId = 4,
                    AuthorId = 2,
                    PublishingHouseId = 3,
                    PublishingYear = 2023,
                    Description = "The reveal of the Man-God's longest-hidden disciple has Rudeus rushing to gather strong allies. Luckily, the Immortal Demon King Atofe fits the bill! Rudeus's team arrives on the Demon Continent she governs, but negotiations are anything but smooth sailing-not only does Atofe have a few screws loose, but listening is far from her strong suit. How will the party handle this Demon King's devil-may-care demeanor?"
                },
                new Book()
                {
                    Isbn = "9781648272608",
                    Name = "Mushoku Tensei: Jobless Reincarnation (Light Novel) Vol. 12",
                    Pages = 320,
                    CategoryId = 4,
                    AuthorId = 2,
                    PublishingHouseId = 3,
                    PublishingYear = 2021,
                    Description = "Rudeus and Paul must descend into the deadly depths of a Teleportation Labyrinth to rescue Zenith. The father-son duo makes short work of deadly beasts and ancient magical traps, but it's the terrible truth at the Labyrinth's heart that proves the greatest threat of all. What happens when all hope is shattered beyond recall?"
                },
                new Book()
                {
                    Isbn = "9780099285823",
                    Name = "Experience",
                    Pages = 401,
                    CategoryId = 2,
                    AuthorId = 1,
                    PublishingHouseId = 1,
                    PublishingYear = 2001,
                    Description = "In this remarkable work of autobiography, the son of the great comic novelist Kingsley Amis explores his relationship with his father and writes about the various crises of Kingsley's life, including the final one of his death.\r\n\r\nAmis also reflects on the life and legacy of his cousin, Lucy Partington, who disappeared without trace in 1973 and was exhumed twenty years later from the basement of Frederick West, one of Britain's most prolific serial murderers."
                },
                new Book()
                {
                    Isbn = "9781800812970",
                    Name = "Wish I Was Here",
                    Pages = 224,
                    CategoryId = 2,
                    AuthorId = 3,
                    PublishingHouseId = 4,
                    PublishingYear = 2023,
                    Description = "In this remarkable work of autobiography, the son of the great comic novelist Kingsley Amis explores his relationship with his father and writes about the various crises of Kingsley's life, including the final one of his death.\r\n\r\nAmis also reflects on the life and legacy of his cousin, Lucy Partington, who disappeared without trace in 1973 and was exhumed twenty years later from the basement of Frederick West, one of Britain's most prolific serial murderers."
                },
                new Book()
                {
                    Isbn = "9781450026338",
                    Name = "The Penance Walk",
                    Pages = 270,
                    CategoryId = 2,
                    AuthorId = 3,
                    PublishingHouseId = 5,
                    PublishingYear = 2010,
                    Description = "A true story From a stern Irish and English upbringing, nine year old John was placed in a Roman Catholic Boarding School in England in the early years of the Second World War. The heavy discipline meted out by the Catholic Teaching Order of Priests, who ran St Michael's College and the viciousness practiced by the older boys was almost unbearable. He was soon befriended by one of the priests, his Form's English Master. He did not realize that the attention he was receiving, was due to the priest's physical attraction towards him, but was pleased to have the attention of a sensitive father figure, as his own father had died before the war. When invited to stay during a summer school holiday at the Order's Novitiate College housed in a rambling Elizabethan country mansion, the relationship came to a climax when the sexual advances by the priest increased and became intolerable. The boy's mindset now believed that he was committing a series of mortal sins and was scared that he'd be damned to Hell for eternity. He felt a strong urge to go to Confession, but whom could he trust? With a stoicism developed during those early days at St Michael's, he was determined to stop the sexual part of their relationship and eventually taught the priest a lesson he would never forget. Concerning the title The Penance Walk was an exposed paved rose garden in front of the school, where boys were sent in all weathers to memorize a lesson they had failed to do correctly, until it was recited word perfect."
                },
                new Book()
                {
                    Isbn = "9781471183676",
                    Name = "The Wager A Tale of Shipwreck, Mutiny and Murder",
                    Pages = 352,
                    CategoryId = 3,
                    AuthorId = 4,
                    PublishingHouseId = 6,
                    PublishingYear = 2023,
                    Description = "On 28th January 1742, a ramshackle vessel of patched-together wood and cloth washed up on the coast of Brazil. Inside were thirty emaciated men, barely alive, and they had an extraordinary tale to tell. They were survivors of His Majesty's ship the Wager, a British vessel that had left England in 1740 on a secret mission during an imperial war with Spain. While chasing a Spanish treasure-filled galleon, the Wager was wrecked on a desolate island off the coast of Patagonia. The crew, marooned for months and facing starvation, built the flimsy craft and sailed for more than a hundred days, traversing 2,500 miles of storm-wracked seas. They were greeted as heroes."
                },
                new Book()
                {
                    Isbn = "9780857209030",
                    Name = "Killers of the Flower Moon",
                    Pages = 339,
                    CategoryId = 3,
                    AuthorId = 4,
                    PublishingHouseId = 6,
                    PublishingYear = 2018,
                    Description = "WINNER OF THE EDGAR AWARD FOR BEST FACT CRIME\r\nSHORTLISTED FOR THE ANDREW CARNEGIE MEDAL FOR EXCELLENCE IN NON-FICTION\r\nSHORTLISTED FOR THE CWA ALCS GOLD DAGGER FOR NON-FICTION\r\n**SOON TO BE A MAJOR MOTION PICTURE DIRECTED BY MARTIN SCORSESE STARRING LEONARDO DICAPRIO AND ROBERT DE NIRO**"
                }
                );
            context.SaveChanges();
        }
    }
}
