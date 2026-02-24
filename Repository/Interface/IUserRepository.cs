using com_iuc_gestionutilisateurs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_iuc_gestionutilisateurs.Repository.Interface
{
    internal interface IUserRepository
    {

        
        Users Create(Users users);

        Users Update(Users users);

        List<Users> GetAll();

        Users GetUsersById(long id);

        bool DeleteUser(long id);


    }


}
