using com_iuc_gestionutilisateurs.Model;
using com_iuc_gestionutilisateurs.Repository;
using com_iuc_gestionutilisateurs.Repository.Interface;
using com_iuc_gestionutilisateurs.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_iuc_gestionutilisateurs.Service
{


    /// <summary>
    /// 
    /// Cette classe UserServiceImpl implémente l'interface IUserService, 
    /// elle contient les methodes suivantes : Create, Update, GetAll, GetUsersById et DeleteUser.
    /// 
    /// </summary>
    public class UserServiceImpl : IUserService
    {


        /// <summary>
        /// 
        /// Initialisation de l'interface IUserRepository pour pouvoir utiliser les methodes de cette interface
        /// dans les methodes de service de cette classe UserServiceImpl.
        /// 
        /// </summary>
        private readonly IUserRepository _userRepository = new UserRepositoryImpl();


        public UserServiceImpl(UserRepositoryImpl userRepository ) 
        {
            _userRepository = userRepository;
        }    

        public Users Create(Users users)
        {       
            return _userRepository.Create(users);
        }


        public Users Update(Users users)
        {
            return _userRepository.Update(users);
        }



        public List<Users> GetAll()
        {
            return _userRepository.GetAll();
        }


        public Users GetUsersById(long id)
        {
            return _userRepository.GetUsersById(id);
        }



        public bool DeleteUser(long id)
        {
            return _userRepository.DeleteUser(id);
        }


    }


}
