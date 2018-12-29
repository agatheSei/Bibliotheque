using BibliothekV1.Application.ViewModel;
using BibliothekV1.Domain;



namespace BibliothequeApp.Controllers
{
    public class BookController
    {
        private BibliothequeContext db = new BibliothequeContext();

        public void AddBook(BookViewModel book)
        {
            
        }

        public void UpdateBook(BookViewModel book)
        {

        }

        public void DeleteBook(int bookId) { }

        public void GetAllBooks(int userId) {
            //un service ou un dossier bibiotheque?
        }

        public void GetInfoBook(int BookId) { }
    }
}