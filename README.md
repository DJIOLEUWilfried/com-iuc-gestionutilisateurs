📖 Description
gestionutilisateurs est une application console en C# natif développée from scratch pour la gestion des utilisateurs(CRUD) avec stockage temporaire des données en mémoire via une collection List<T>.
Elle illustre une architecture en couches (Controller, Service, Repository, Model, Exception, View) sans framework externe, avec une séparation claire des responsabilités.
Ce projet a été réalisé dans un cadre académique dans le but de pratiquer l’architecture propre, la gestion des données et les bonnes pratiques de développement.

Ce dernier met l’accent sur :

La Programmation Orientée Objet (POO)

La manipulation des collections

La séparation de la logique métier

Le traçage des opérations avec System.Diagnostics.Trace


🏗️ Architecture
L’application est organisée en plusieurs couches :

com-iuc-gestionutilisateurs
 ├── Dépendances
 ├── Controleur
 │    └── UserController.cs
 ├── Exception
 │    ├── UserNotFoundException.cs
 │    └── ValidationException.cs
 ├── Model
 │    └── Users.cs
 ├── Repository
 │    ├── Interface
 │    │    └── IUserRepository.cs
 │    └── UserRepositoryImpl.cs
 ├── Service
 │    ├── Interface
 │    │    └── IUserService.cs
 │    └── UserServiceImpl.cs
 ├── view
 │    ├── Program.cs
 │    └── UserView.cs
 ├── .gitattributes
 └── .gitignore

📌 Description des dossiers
Model : Représentation des entités du domaine (Users).

Repository : Gestion de la persistance en mémoire (UserRepository).

Service : Logique métier et validation (UserService).

Controllers : Point d’entrée pour orchestrer les opérations (UserController).

Exception : Gestion des erreurs personnalisées (UserNotFoundException, ValidationException).

Views : Interface console interactive (UserView).

Program.cs : Point d’entrée principal.



🚀 Fonctionnalités

✅ Création d’un utilisateur

✅ Modification d’un utilisateur

✅ Recherche d’un utilisateur par son identification

✅ Affichage de la liste des utilisateurs

✅ Suppression d’un utilisateur

✅ Validation des données

✅ Gestion des exceptions

✅ Traçage des opérations avec Trace


🖥️ Exemple d’utilisation
Code
System.Console.WriteLine("\n--- GESTION DES UTILISATEURS ---");

System.Console.WriteLine("\n 1. Créer un utilisateur");
System.Console.WriteLine("\n 2. Lister les utilisateurs");
System.Console.WriteLine("\n 3. Chercher un utilisateur par son identifiant");
System.Console.WriteLine("\n 4. Modifier un utilisateur");
System.Console.WriteLine("\n 5. Supprimer un utilisateur");

System.Console.WriteLine("\n 0. Quitter");
System.Console.Write("\n Choix: ");

1

 -- Création d'un utilisateur --
Nom: DJIOLEU
Prenom: Wilfried
Email: djioleuwilfried@mail.com
     Utilisateur ' Wilfried ' créer avec succès.



🛠️ Technologies utilisées

Langage : C#

Framework : .NET 8

Type d’application : Console

Stockage : Collection List<Users> (In-Memory)

Debug & Monitoring : System.Diagnostics.Trace

IDE : Visual Studio 2022


⚙️ Installation et exécution
1️⃣ Cloner le projet
git clone https://github.com/DJIOLEUWilfried/com-iuc-gestionutilisateurs.git

2️⃣ Ouvrir avec Visual Studio 2022

Ouvrir le fichier .sln

Restaurer les packages NuGet si nécessaire


🔐 Bonnes pratiques appliquées

Séparation des responsabilités (SRP)

Architecture en couches

Validation des données

Documentation

Utilisation de Git pour le versionnement


📌 Limites actuelles

❌ Pas de persistance des données

❌ Pas d’authentification

❌ Pas de gestion avancée des erreurs 



📈 Améliorations futures

🔹 Intégration d'une base de données postgreSQL

🔹 Implémentation de la validation avancée

🔹 Gestion avancée des erreurs 

🔹 Traçage des opérations avec Logger

🔹 Authentification JWT

🔹 Tests unitaires



👨‍💻 Auteur

Wilfried DJIOLEU
Développeur Backend C# / .NET - Java & Spring Boot
📍 Douala, Cameroun

