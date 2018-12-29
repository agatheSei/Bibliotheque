using BibliothekV1.Application;
using BibliothekV1.Application.ViewModel;
using BibliothekV1.Domain;
using Microsoft.AspNetCore.Mvc;

namespace BibliothekV1.Controllers
{
    public class UserController:Controller
    {
        private BibliothequeContext db = new BibliothequeContext();
        private readonly ICreateAccount _createAccount;

        public UserController(ICreateAccount createAccount)
        {
            _createAccount = createAccount;
        }

        public ActionResult Index()
        {
            return View("_CreateAnAccount",new UserViewModel());
        }

        public bool CreateAnAccount(UserViewModel user)
        {
            var result =_createAccount.Execute(user);
            return result;
        }

        public void VerifyAccount(int userId)
        {

        }

        public void GetSettingsUser(int userId)
        {

        }

        public void UpdateAccount(UserViewModel user)
        {

        }

        public void RetrieveForgottenPassword(int userId)
        {

        }

        public void DeleteAccount(int userId)
        {

        }
    }    
}