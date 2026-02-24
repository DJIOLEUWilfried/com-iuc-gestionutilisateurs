using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace com_iuc_gestionutilisateurs.Model
{

    /// <summary>
    /// 
    /// Cette classe Users est notre model de données pour les utilisateurs, elle contient les attributs suivants : Id, FirstName, LastName et Email.
    /// 
    /// </summary>
    public class Users
    {


        // Attributs privés de notre model Users
        private long _Id ;
        private string _FirstName;
        private string _LastName;
        private string _Email;


        /// <summary>
        /// 
        ///  Redéfinition de la methode ToString pour afficher les infos de l'utilisateur
        ///  
        /// </summary>
        /// <returns> L'identifiant, le nom, le prenom et l'email </returns>
        public override string ToString()
        {
            return $"Id : {_Id} \n Nom : {_FirstName} \n Prenom : {_LastName}  \n Email : {_Email}" ;
        }



        // Getteurs et Setteurs
        public long Id { get { return _Id; } set { _Id = value; } }

        public string FirstName { get { return _FirstName; } set { _FirstName = value; } }

        public string LastName { get { return _LastName; } set { _LastName = value; } }

        public string Email { get { return _Email; } set { _Email = value; } }



    }


}
