using com_iuc_gestionutilisateurs.Controlleur;
using com_iuc_gestionutilisateurs.Exception;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_iuc_gestionutilisateurs.view
{
    public class UserView
    {



        private readonly UserController _controller;


        public UserView(UserController controller)
        {
            _controller = controller;
        }


        int id;
        string nom, prenom, email;
        string message;


        public void Menu()
        {

            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out)); 
            Trace.AutoFlush = true;


            Trace.WriteLine("Application démarrée.");

            while (true)
            {
                System.Console.WriteLine("\n--- GESTION DES UTILISATEURS ---");

                System.Console.WriteLine("\n 1. Créer un utilisateur");
                System.Console.WriteLine("\n 2. Lister les utilisateurs");
                System.Console.WriteLine("\n 3. Chercher un utilisateur par son identifiant");
                System.Console.WriteLine("\n 4. Modifier un utilisateur");
                System.Console.WriteLine("\n 5. Supprimer un utilisateur");

                System.Console.WriteLine("\n 0. Quitter");
                System.Console.Write("\n Choix: ");

               

                var choix = System.Console.ReadLine();

                switch (choix)
                {


                    case "1":

                        Trace.WriteLine($"\n -- Création d'un utilisateur -- \n");


                        System.Console.Write("Nom: ");
                        nom = System.Console.ReadLine();

                        System.Console.Write("Prenom: ");
                        prenom = System.Console.ReadLine();

                        System.Console.Write("Email: ");
                        email = System.Console.ReadLine();


                        try
                        {

                            message = _controller.Create(nom, prenom, email) != null ? $"\n Utilisateur ' {prenom} ' créer avec succès" 
                                                                                     : "Echec de création de cet utilisateur";

                            Trace.WriteLine(message);

                        }
                        catch (ValidationException ex)
                        {
                            Trace.WriteLine($"\n Erreur : {ex.Message}");
                        }

                        Vider();
                        break;

                    case "2":

                        Trace.WriteLine($"\n -- Liste des utilisateurs --   \n");

                        _controller.GetAll();

                        break;

                    case "3":

                        Trace.WriteLine($"\n -- Cherche d'un utilisateur par son identifiant -- \n");
                     

                        try
                        {
                            System.Console.Write("Id: ");
                            id = int.Parse(System.Console.ReadLine());


                            System.Console.WriteLine(_controller.GetUsersById(id));

                        }
                        
                        catch (ValidationException ex)
                        {
                            Trace.WriteLine($"\n Erreur : {ex.Message}");
                        }
                        catch (UserNotFoundException ex)
                        {
                            Trace.WriteLine($"\n Erreur : {ex.Message}");
                        }
                        catch (System.Exception ex)
                        {
                            Trace.WriteLine($"\n Erreur : {ex.Message}");
                        }


                        Vider();
                        break;

                    case "4":

                        Trace.WriteLine($"\n -- Modification d'un utilisateur -- \n");
        
                        try
                        {

                            System.Console.Write("Id: ");
                            id = int.Parse(System.Console.ReadLine());


                            System.Console.Write("Nom: ");
                            nom = System.Console.ReadLine();

                            System.Console.Write("Prenom: ");
                            prenom = System.Console.ReadLine();

                            System.Console.Write("Email: ");
                            email = System.Console.ReadLine();


                            message = _controller.Update(nom, prenom, email, id) != null ? $"\n Utilisateur avec id ' {id} ' modifier avec succès"
                                                                                     : "Echec de modification de cet utilisateur";

                            Trace.WriteLine(message);

                        }
                        catch (ValidationException ex)
                        {
                            Trace.WriteLine($"\n Erreur : {ex.Message}");
                        }
                        catch (UserNotFoundException ex)
                        {
                            Trace.WriteLine($"\n Erreur : {ex.Message}");
                        }
                        catch (System.Exception ex)
                        {
                            Trace.WriteLine($"\n Erreur : {ex.Message}");
                        }

                        Vider();
                        break;

                    case "5":

                   
                        Trace.WriteLine($"\n -- Suppresion d'un utilisateur -- \n");

                        try
                        {

                            System.Console.Write("Id: ");
                            id = int.Parse(System.Console.ReadLine());

                            message = _controller.DeleteUser(id) ? $"\n Utilisateur avec id ' {id} ' supprimer avec succès"
                                                                                     : "Echec de suppression de cet utilisateur";

                            Trace.WriteLine(message);

                        }
                        catch (ValidationException ex)
                        {
                            Trace.WriteLine($"\n Erreur : {ex.Message}");
                        }
                        catch (UserNotFoundException ex)
                        {
                            Trace.WriteLine($"\n Erreur : {ex.Message}");
                        }
                        catch (System.Exception ex)
                        {
                            Trace.WriteLine($"\n Erreur : {ex.Message}");
                        }

                        Vider();
                        break;


                    case "0":
                        return;
                }
            }




        }



        public void Vider()
        {
            id = 0;
            nom = "";
            prenom = "";
            email = "";
        }







    }


}






