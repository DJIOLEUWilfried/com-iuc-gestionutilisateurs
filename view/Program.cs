using com_iuc_gestionutilisateurs.Controlleur;
using com_iuc_gestionutilisateurs.Repository;
using com_iuc_gestionutilisateurs.Repository.Interface;
using com_iuc_gestionutilisateurs.Service;
using com_iuc_gestionutilisateurs.Service.Interface;
using com_iuc_gestionutilisateurs.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace com_iuc_gestionutilisateurs.view
{
    public class Program
    {
       

        static void Main(string[] args)
        {

            var repo = new UserRepositoryImpl();

            var service = new UserServiceImpl(repo);

            var controller = new UserController(service);

            var view = new UserView(controller);



            

            view.Menu();
        }


    }


}

