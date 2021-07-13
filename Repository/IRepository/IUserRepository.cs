using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using animaliasAPI.Models;

namespace animaliasAPI.Repository.IRepository
{
    interface IUserRepository
    {
       
            List<User> GetUsers();
        
    }
}
