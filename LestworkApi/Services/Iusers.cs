using LestworkApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LestworkApi.Services
{
    interface Iusers
    {
        void Inscription(ApplicationUser user);

        void AllUsers();

        string DeleteUser( int IdUser);

        string UpdateUser(int IdUser);


    }
}
