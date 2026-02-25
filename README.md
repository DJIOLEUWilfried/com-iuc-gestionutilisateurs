# 📌 gestionutilisateurs

## 📖 Description

**gestionutilisateurs** est une application console C# développée from scratch permettant la gestion des utilisateurs (CRUD) avec stockage temporaire en mémoire via une collection `List<Users>`.

Cette application repose sur une architecture en couches sans framework externe, favorisant une séparation claire des responsabilités.

Projet académique réalisé pour renforcer la maîtrise de l’architecture logicielle, de la gestion des données et des bonnes pratiques de développement.

---

## 🎯 Objectifs pédagogiques

- ✔️ Programmation Orientée Objet (POO)
- ✔️ Manipulation des collections
- ✔️ Séparation de la logique métier
- ✔️ Gestion des exceptions personnalisées
- ✔️ Traçage des opérations avec `System.Diagnostics.Trace`

---

## 🏗️ Architecture

```text
com-iuc-gestionutilisateurs
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
 ├── View
 │    ├── Program.cs
 │    └── UserView.cs
 ├── .gitattributes
 └── .gitignore
```

---

## 📂 Description des dossiers

| Dossier     | Rôle |
|------------|------|
| Model      | Représentation des entités (`Users`) |
| Repository | Gestion de la persistance en mémoire |
| Service    | Logique métier et validation |
| Controleur | Orchestration des opérations |
| Exception  | Gestion des erreurs personnalisées |
| View       | Interface console |
| Program.cs | Point d’entrée principal |

---

## 🚀 Fonctionnalités

- ✅ Création d’un utilisateur
- ✅ Modification d’un utilisateur
- ✅ Recherche d’un utilisateur par identifiant
- ✅ Affichage de la liste des utilisateurs
- ✅ Suppression d’un utilisateur
- ✅ Validation des données
- ✅ Gestion des exceptions
- ✅ Traçage des opérations avec Trace

---

## 🖥️ Exemple d’utilisation

```csharp
Console.WriteLine("\n--- GESTION DES UTILISATEURS ---");

Console.WriteLine("\n 1. Créer un utilisateur");
Console.WriteLine("\n 2. Lister les utilisateurs");
Console.WriteLine("\n 3. Chercher un utilisateur par son identifiant");
Console.WriteLine("\n 4. Modifier un utilisateur");
Console.WriteLine("\n 5. Supprimer un utilisateur");

Console.WriteLine("\n 0. Quitter");
Console.Write("\n Choix: ");
```

### Exemple d’exécution

```text
1

-- Création d'un utilisateur --
Nom: DJIOLEU
Prenom: Wilfried
Email: djioleuwilfried@mail.com

Utilisateur 'Wilfried' créé avec succès.
```

---

## 🛠️ Technologies utilisées

- Langage : C#
- Framework : .NET 8
- Type : Application Console
- Stockage : List<Users> (In-Memory)
- Debug : System.Diagnostics.Trace
- IDE : Visual Studio 2022

---

## ⚙️ Installation

```bash
git clone https://github.com/DJIOLEUWilfried/com-iuc-gestionutilisateurs.git
```

Ouvrir le projet dans Visual Studio puis exécuter.

---

## 🔐 Bonnes pratiques

- ✔️ Respect du principe SRP
- ✔️ Architecture en couches
- ✔️ Validation des données
- ✔️ Exceptions personnalisées
- ✔️ Versionnement Git

---

## ⚠️ Limites

- ❌ Pas de base de données
- ❌ Pas d’authentification
- ❌ Pas de tests unitaires

---

## 📈 Améliorations futures

- 🔹 Intégration PostgreSQL
- 🔹 Logger structuré
- 🔹 Authentification JWT
- 🔹 Tests unitaires
- 🔹 Migration vers API REST ASP.NET Core

---

## 👨‍💻 Auteur

**Wilfried DJIOLEU**  
Développeur Backend C# / .NET & Java Spring Boot  
Douala, Cameroun
