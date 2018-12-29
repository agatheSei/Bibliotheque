using BibliothekV1.Application.ViewModel;
using BibliothekV1.Domain;
using BibliothekV1.Domain.DataModel;
using System;
using System.Data.Linq;
namespace BibliothekV1.Application
{    
    public class CreateAccount:ICreateAccount
    {
        private BibliothequeContext db = new BibliothequeContext();
        //Convert the VM to the DataModel

        public bool Execute(UserViewModel userInfo)
        {
            var cityId = 0;
            if (userInfo.CityId != 0)
            {
                cityId = userInfo.CityId;
            }
            else
                cityId = FindOrCreateCityId(userInfo.City);
            var e = new UserInformationModel();
            var newUser = new UserInformationModel() {
                Active = false,
                BirthDate = userInfo.BirthDate,
                CityId = cityId,
                CreateDate = DateTime.Now.ToShortDateString(),
                Email = userInfo.Email,
                FirstName = userInfo.FirstName,
                LastName = userInfo.LastName,
                NbVoting = 0,
                Password = userInfo.Password,
                Pseudo = userInfo.Pseudo                
            };

            db.UserInfos.Add(newUser);
            db.SaveChanges();

            return true;
        }

        private int FindOrCreateCityId(string cityName)
        {
            //Create or find CityId
            return 1;
        }
    }
}