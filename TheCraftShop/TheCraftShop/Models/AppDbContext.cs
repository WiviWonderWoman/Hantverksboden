using Microsoft.EntityFrameworkCore;

namespace TheCraftShop.Models
{
    //Intermediate between code and database
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //adding seeded data to in memory database
            this.Database.EnsureCreated();
        }
        public DbSet<Handicraft> Handicrafts { get; set; }
        public DbSet<CraftMethod> CraftMethods { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed crafting methods
            modelBuilder.Entity<CraftMethod>().HasData(new CraftMethod { CraftMethodId = 1, CraftMethodName = "Virkning" });
            modelBuilder.Entity<CraftMethod>().HasData(new CraftMethod { CraftMethodId = 2, CraftMethodName = "Macrame" });
            modelBuilder.Entity<CraftMethod>().HasData(new CraftMethod { CraftMethodId = 3, CraftMethodName = "Tecknat" });

            //seed handicrafts
            modelBuilder.Entity<Handicraft>().HasData(new Handicraft
            {
                HandicraftId = 1,
                Name = "AngryBirds set",
                Description = "Virkat set med 5 st fåglar och 4 st grisar, inspirerade av mobilspelet Angry birds.",
                Image = "AngryBirds.jpg",
                Price = 500,
                CraftMethodId = 1,
                IsNewItem = false
            });
            modelBuilder.Entity<Handicraft>().HasData(new Handicraft

            {
                HandicraftId = 2,
                Name = "Fluffy Duo",
                Description = "Virkat set med 2 st \"Fluffies\", inspirerade av mobilspelet Fluffy fall.",
                Image = "FluffyDuo.jpg",
                Price = 200,
                CraftMethodId = 1,
                IsNewItem = false
            });
            modelBuilder.Entity<Handicraft>().HasData(new Handicraft
            {
                HandicraftId = 3,
                Name = "Pokémon Duett",
                Description = "Virkat set med 2 st figurer, pokemonsen Jigglypuff & Igglybuff.",
                Image = "JigglyDuo.jpg",
                Price = 100,
                CraftMethodId = 1,
                IsNewItem = false
            });
            modelBuilder.Entity<Handicraft>().HasData(new Handicraft
            {
                HandicraftId = 4,
                Name = "Kattleksak",
                Description = "Virkad kattleksak, en mörkröd mus.",
                Image = "Mus.jpg",
                Price = 75,
                CraftMethodId = 1,
                IsNewItem = false
            });
            modelBuilder.Entity<Handicraft>().HasData(new Handicraft
            {
                HandicraftId = 5,
                Name = "Pokéballs",
                Description = "Virkat set med 3 st Pokéball. Vanlig, greateball och ultraball",
                Image = "Pokeballs.jpg",
                Price = 100,
                CraftMethodId = 1,
                IsNewItem = false
            });
            modelBuilder.Entity<Handicraft>().HasData(new Handicraft
            {
                HandicraftId = 6,
                Name = "Pika-ball",
                Description = "Virkat set med en Pokémon i Pokéball, Pikachu.",
                Image = "Pika_boll.jpg",
                Price = 150,
                CraftMethodId = 1,
                IsNewItem = false
            });
            modelBuilder.Entity<Handicraft>().HasData(new Handicraft
            {
                HandicraftId = 7,
                Name = "Brosch 1",
                Description = "Virkad brosch, vit anemon.",
                Image = "Blomma1.jpg",
                Price = 50,
                CraftMethodId = 1,
                IsNewItem = false
            });
            modelBuilder.Entity<Handicraft>().HasData(new Handicraft
            {
                HandicraftId = 8,
                Name = "Brosch 2",
                Description = "Virkad brosch, röd ros.",
                Image = "Blomma2.jpg",
                Price = 50,
                CraftMethodId = 1,
                IsNewItem = true
            });
            modelBuilder.Entity<Handicraft>().HasData(new Handicraft
            {
                HandicraftId = 9,
                Name = "Brosch 3",
                Description = "Virkad brosch, studentmössa.",
                Image = "Studentmössa.jpg",
                Price = 50,
                CraftMethodId = 1,
                IsNewItem = false
            });
            modelBuilder.Entity<Handicraft>().HasData(new Handicraft
            {
                HandicraftId = 10,
                Name = "Nyckelring",
                Description = "Macrame nyckelring, gran.",
                Image = "Nyckelring.jpg",
                Price = 50,
                CraftMethodId = 2,
                IsNewItem = false
            });
            modelBuilder.Entity<Handicraft>().HasData(new Handicraft
            {
                HandicraftId = 11,
                Name = "Hänge",
                Description = "Gran med silver pärlor att hänga i halsbandet.",
                Image = "Hänge.jpg",
                Price = 50,
                CraftMethodId = 2,
                IsNewItem = false
            });
            modelBuilder.Entity<Handicraft>().HasData(new Handicraft
            {
                HandicraftId = 12,
                Name = "Armband",
                Description = "Macrame armband.",
                Image = "Armband.jpg",
                Price = 75,
                CraftMethodId = 2,
                IsNewItem = false
            });
            modelBuilder.Entity<Handicraft>().HasData(new Handicraft
            {
                HandicraftId = 13,
                Name = "Öronhängen",
                Description = "Macrame öronhänge, gröna granar.",
                Image = "Öronhänge.jpg",
                Price = 75,
                CraftMethodId = 2,
                IsNewItem = true
            });

            modelBuilder.Entity<Handicraft>().HasData(new Handicraft
            {
                HandicraftId = 14,
                Name = "Solnedgång",
                Description = "Målning med akvarell, nedgående sol över havet.",
                Image = "Solnedgång.jpg",
                Price = 75,
                CraftMethodId = 3,
                IsNewItem = false
            });
            modelBuilder.Entity<Handicraft>().HasData(new Handicraft
            {
                HandicraftId = 15,
                Name = "Stranden",
                Description = "Akryl målning, vågor som slår mot en sandstrand.",
                Image = "Strand.jpg",
                Price = 75,
                CraftMethodId = 3,
                IsNewItem = false
            });
            modelBuilder.Entity<Handicraft>().HasData(new Handicraft
            {
                HandicraftId = 16,
                Name = "Träd",
                Description = "Blyertsteckning, färglagd med akvarell.",
                Image = "Träd.jpg",
                Price = 75,
                CraftMethodId = 3,
                IsNewItem = true
            });
            modelBuilder.Entity<Handicraft>().HasData(new Handicraft
            {
                HandicraftId = 17,
                Name = "ADHD-Hjärna",
                Description = "Teckning i tusch, hur det känns att ha adhd.",
                Image = "Hjärna.jpg",
                Price = 50,
                CraftMethodId = 3,
                IsNewItem = false
            });
        }
    }
}
