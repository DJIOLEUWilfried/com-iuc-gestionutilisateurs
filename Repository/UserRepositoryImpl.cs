using com_iuc_gestionutilisateurs.Model;
using com_iuc_gestionutilisateurs.Repository.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_iuc_gestionutilisateurs.Repository
{


    /// <summary>
    /// 
    /// Cette classe UserRepositoryImpl implémente l'interface IUserRepository, 
    /// elle contient les methodes suivantes : Create, Update, GetAll, GetUsersById et DeleteUser.
    /// 
    /// </summary>
    public class UserRepositoryImpl : IUserRepository
    {

        private List<Users> DB = new List<Users>();


        public Users Create(Users users)
        {
            DB.Add(users);
            return users;
        }


        public Users Update(Users users)
        {
           //  throw new NotImplementedException();

            var newUser = DB.Find(u => u.Id == users.Id);

            if (newUser != null)
            {
                newUser.FirstName = users.FirstName;
                newUser.LastName = users.LastName;
                newUser.Email = users.Email;

                return newUser;
            }


            return newUser;
        }

        

        public List<Users> GetAll()
        {
            return DB;
        }


        public Users GetUsersById(long id)
        {
            return DB.Find(u => u.Id == id);
        }



        public bool DeleteUser(long id)
        {
            Users? users = DB.Find(u => u.Id == id);

            if ( users != null )
            {
                DB.Remove(users);
                return true;
            }

            return false;
        }




    }
}
