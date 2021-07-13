using animaliasAPI.Models;
using animaliasAPI.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace animaliasAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        private appandroidContext db;

        public UserRepository(appandroidContext db)
        {
            this.db = db;
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();

            var usersSQl = from o in db.Users
                           orderby o.Name ascending
                           select o;
            if (db != null)
            { 

                        foreach (var r in usersSQl)
                    {
                        User user = new User();
                        user.Name = r.Name;
                        user.Mail = r.Mail;
                        user.Password = r.Password;
                        user.Pet = r.Pet;
                        user.Telephone = r.Telephone;
                        user.IdUser = r.IdUser;
                        user.IdBreed = r.IdBreed;
                        user.IdBrand = r.IdBrand;


                        users.Add(user);
                    }


                 return users;
             }
                return null;
        }
          
     }

}
    

