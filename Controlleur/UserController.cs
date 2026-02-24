using com_iuc_gestionutilisateurs.Exception;
using com_iuc_gestionutilisateurs.Model;
using com_iuc_gestionutilisateurs.Repository.Interface;
using com_iuc_gestionutilisateurs.Service;
using com_iuc_gestionutilisateurs.Service.Interface;
using com_iuc_gestionutilisateurs.view;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_iuc_gestionutilisateurs.Controlleur
{

    /// <summary>
    /// 
    /// Cette classe UserController est responsable de la logique métier de notre application, elle reçoit les données de la part de la vue, 
    /// les traite et utilise les méthodes de l'interface IUserService pour effectuer les opérations nécessaires sur les données des utilisateurs.
    /// 
    /// </summary>
    public class UserController
    {

        private readonly IUserService _userService ;


        /// <summary>
        /// 
        /// Initialisation de l'interface IUserService pour pouvoir utiliser les methodes de cette interface
        /// 
        /// </summary>
        /// <param name="userService"></param>
        public UserController(UserServiceImpl userService ) 
        {
            _userService = userService;
        }


        public Users Create(string firstName, string lastName, string email)
        {

            Users users = new Users();

            // Verifications des donnees recues
            if (string.IsNullOrEmpty(firstName)) { throw new ValidationException("Veuillez entrer le nom svp."); }
            else if (string.IsNullOrEmpty(lastName)) { throw new ValidationException("Veuillez entrer le prenom svp."); }
            else if (string.IsNullOrEmpty(email)) { throw new ValidationException("Veuillez entrer l'email svp.");  }
            else if (!email.Contains("@") && !email.Contains(".")) { throw new ValidationException("Veuillez entrer le format correct de l'email svp.");  }


            users.Id = _userService.GetAll().Count + 1;  
            users.FirstName = firstName;
            users.LastName = lastName;
            users.Email = email;

            

            return _userService.Create(users);

        }


        public Users Update(string firstName, string lastName, string email, long id)
        {

            // Recuperons cet utilisateur dans notre Liste
            Users users = _userService.GetUsersById(id);

            if (id < 1) { throw new ValidationException("Veuillez entrer l'identifiant svp, il doit être un nombre entier et suppérieur à 0."); }

            // Verifions si cet utilisateur existe d'abord dans notre Liste
            else if (users == null) { throw new UserNotFoundException($"Utilisateur avec Id {id} introuvable."); }


            // Verifications des donnees recues
            else if (string.IsNullOrEmpty(firstName)) { throw new ValidationException("Veuillez entrer le nom svp."); }
            else if (string.IsNullOrEmpty(lastName)) { throw new ValidationException("Veuillez entrer le prenom svp."); }
            else if (string.IsNullOrEmpty(email)) { throw new ValidationException("Veuillez entrer l'email svp."); }
            else if (!email.Contains("@") && !email.Contains(".")) { throw new ValidationException("Veuillez entrer le format correct de l'email svp."); }

            users.FirstName = firstName;
            users.LastName = lastName;
            users.Email = email;

            users.Id = id;


            return _userService.Update(users);
        }



        public void GetAll()
        {
            if (_userService.GetAll().Count < 1) { Trace.WriteLine("La liste est vide.");  }

            foreach (Users user in _userService.GetAll())
            {
                Console.WriteLine(user.ToString());
            }

        }



        public Users? GetUsersById(long id)
        {
            Users users = _userService.GetUsersById(id);

            if (id < 1) { throw new ValidationException("Veuillez entrer l'identifiant svp, il doit être un nombre entier et suppérieur à 0."); }
            else if (users == null) { throw new UserNotFoundException($"Utilisateur avec Id {id} introuvable."); }

            return users;
        }



        public bool DeleteUser(long id)
        {

            // Recuperons cet utilisateur dans notre Liste
            Users users = _userService.GetUsersById(id);

            if (id < 1) { throw new ValidationException("Veuillez entrer l'identifiant svp, il doit être un nombre entier et suppérieur à 0."); }

            // Verifions si cet utilisateur existe d'abord dans notre Liste
            else if (users == null) { throw new UserNotFoundException($"Utilisateur avec Id {id} introuvable."); }


            return _userService.DeleteUser(id);
        }



    }


}
