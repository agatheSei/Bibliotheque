using BibliothekV1.Domain.DataModel;
using Microsoft.EntityFrameworkCore;

namespace BibliothekV1.Domain
{
    public interface IBibliothequeContext
    {
        DbSet<AuthorModel> Authors { get; set; }
        DbSet<BookModel> Books { get; set; }
        DbSet<CityModel> Cities { get; set; }
        DbSet<CountryModel> Countries { get; set; }
        DbSet<DistrictModel> Districts { get; set; }
        DbSet<EditionModel> Editions { get; set; }
        DbSet<LangageModel> Langages { get; set; }
        DbSet<TypeModel> Types { get; set; }
        DbSet<UserInformationModel> UserInfos { get; set; }
    }
}