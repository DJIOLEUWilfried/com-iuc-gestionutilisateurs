using com_iuc_gestionutilisateurs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_iuc_gestionutilisateurs.Service.Interface
{

    /// <summary>
    /// 
    /// Cette interface IUserService declare les methodes de service pour la gestion des utilisateurs, 
    /// elle contient les methodes suivantes : Create, Update, GetAll, GetUsersById et DeleteUser.  
    /// 
    /// </summary>
    public interface IUserService
    {

        /// <summary>
        ///  
        /// La methode Create pour créer un utilisateur et prend en parametre un utilisateur
        ///  
        /// </summary>
        /// <param name="users"> Un utilisateur </param>
        Users Create(Users users);


        /// <summary>
        /// 
        /// La methode Update pour modifier un utilisateur et prend en parametre un utilisateur(dont son identifiant et ses nouvelles données)
        /// 
        /// </summary>
        /// <param name="users"> Un utilisateur </param>
        Users Update(Users users);


        /// <summary>
        /// 
        /// La methode GetAll pour récupèrer tous les utilisateurs.
        /// 
        /// </summary>
        /// <returns> La liste des utilisateurs </returns>
        List<Users> GetAll();


        /// <summary>
        /// 
        /// La methode GetUsersById pour rechercher un utilisateur a partir de son identifiant, elle
        /// prend en parametre l'identifiant de cet utilisateur
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Users </returns>
        Users GetUsersById(long id);



        /// <summary>
        /// 
        /// La methode DeleteUser pour supprimer un utilisateur a partir de son identifiant, elle
        /// prend en parametre l'identifiant de cet utilisateur
        /// 
        /// </summary>
        /// <param name="id"> </param>
        bool DeleteUser(long id);


    }


}
