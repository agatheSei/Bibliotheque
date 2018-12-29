using BibliothekV1.Domain.DataModel;
using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace BibliothekV1.Domain
{
    public class BibliothequeContext : DbContext, IBibliothequeContext
    {
        private DbContextOptions dbContextOptions;

        public BibliothequeContext()
        {
        }

        public BibliothequeContext(DbContextOptions dbContextOptions)
        {
            this.dbContextOptions = dbContextOptions;
        }

        public DbSet<AuthorModel> Authors { get; set; }
        public DbSet<BookModel> Books { get; set; }
        public DbSet<CityModel> Cities { get; set; }
        public DbSet<CountryModel> Countries { get; set; }
        public DbSet<DistrictModel> Districts { get; set; }
        public DbSet<EditionModel> Editions { get; set; }
        public DbSet<LangageModel> Langages { get; set; }
        public DbSet<TypeModel> Types { get; set; }
        public DbSet<UserInformationModel> UserInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorModel>().ToTable("Author");
            modelBuilder.Entity<BookModel>().ToTable("Book");
            modelBuilder.Entity<CityModel>().ToTable("City");
            modelBuilder.Entity<CountryModel>().ToTable("Country");
            modelBuilder.Entity<DistrictModel>().ToTable("District");
            modelBuilder.Entity<EditionModel>().ToTable("Edition");
            modelBuilder.Entity<AuthorModel>().ToTable("Author");
            modelBuilder.Entity<LangageModel>().ToTable("Langage");
            modelBuilder.Entity<TypeModel>().ToTable("Type");
            modelBuilder.Entity<UserInformationModel>().ToTable("UserInformation");

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-7SLCGT2;Initial Catalog=BibliothequeApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }
    }
}