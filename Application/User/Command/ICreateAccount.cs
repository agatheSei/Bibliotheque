using BibliothekV1.Application.ViewModel;

namespace BibliothekV1.Application
{
    public interface ICreateAccount
    {
        bool Execute(UserViewModel userInfo);
    }
}
