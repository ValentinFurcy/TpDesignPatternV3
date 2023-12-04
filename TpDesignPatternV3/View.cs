// See https://aka.ms/new-console-template for more information

using static System.Console;
using Views;
using Controllers;
using Entities;
using Unity;
using Business;
using Repository;
using Business.Contracts;
using Repository.Contracts;
void Tp()
{
    // Créer le container Unity
    IUnityContainer unitycontainer = new UnityContainer();
    // Lie les implémentations aux interfaces correspondantes
    unitycontainer.RegisterType<IEmployeService, EmployeService>();
    unitycontainer.RegisterType<IEmployeRepository, EmployeRepository>();

    EmployeController employeController = unitycontainer.Resolve<EmployeController>();

    int Menu()
    {
        WriteLine("Quelle action ?");
        WriteLine("1 - Créer un employé");
        WriteLine("2 - Afficher tout les employés");
        WriteLine("3 - Afficher un employé");
        WriteLine("0 - Quitter");

        int choix = ConsoleHelper.GetInputInt("Saisir la valeur du choix de l'action ");
        return choix;
    }

    int choix = 4;

    while (choix != 0)
    {
        choix = Menu();

        switch (choix)
        {
            case 0:
                break;

            case 1:
                int id = ConsoleHelper.GetInputInt("Saisir ID");
                string nom = ConsoleHelper.GetInputString("Saisir le nom");
                string prenom = ConsoleHelper.GetInputString("Saisir le prénom");
                double salaire = ConsoleHelper.GetInputDouble("Saisir le salaire");
           
                try
                {
                    employeController.CreateEmploye(id, nom, prenom, salaire);
                }
                catch (Exception ex) 
                {
                   WriteLine($"Erreur: {ex.Message}");
                }
    
                break;

            case 2:
                var GetEmploye = employeController.GetEmploye();
                foreach (var emp in GetEmploye)
                {
                    WriteLine(emp);
                }
                
                break;

            case 3:
                int idEmploye = ConsoleHelper.GetInputInt("Saisir l'ID de l'employe");
                var employe = employeController.SelectEmployeByID(idEmploye);


                if (employe != null)
                {
                    WriteLine(employe);
                }
                else
                {
                    WriteLine("Aucun employé avec cet ID");

                }
                break;

            default:
                WriteLine("Ce choix n'existe pas !");
                break;
        }
    }





}

Tp();