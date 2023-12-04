using Entities;
using Microsoft.VisualBasic;
using Repository;
using Repository.Contracts;
using Business.Contracts;


namespace Business
{
    public class EmployeService : IEmployeService
    {
        IEmployeRepository EmployeRepository { get; }
        public EmployeService(IEmployeRepository employeRepository)
        {
            EmployeRepository = employeRepository;
        }

        public Employe CreateEmploye(int id, string nom, string prenom, double salaire)
        {
            if (id != null && nom != null && prenom != null && salaire > 0)
            {
               return EmployeRepository.CreateEmploye(id, nom, prenom, salaire);
               
            }
            else
            {
                string erreur = "";

                if(id == null || nom == null || prenom == null) 
                { 
                    erreur = " ID non renseigné"; 
                }
                else if (salaire <= 0)
                {
                    erreur = " IL FAUT PAYER LES GENS !!!";
                }

                throw new Exception(erreur);
            }


        }

        public List<Employe> GetEmploye() 
        {
            var employe = EmployeRepository.GetEmploye();

            if (employe != null)
            {
                return employe;
            }
            else
            {
                return null;
            }
        }

        public Employe SelectEmployeByID(int id)
        {

            var employe = EmployeRepository.SelectEmployeByID(id);

            if (employe != null)
            {
                return employe;
            }
            else
            {
                return null;
            }
        }
    }
}
