using Entities;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository
{
    public class EmployeRepository : IEmployeRepository 
    {
        public Employe CreateEmploye(int id, string nom, string prenom, double salaire)
        {
            Employe employe = new Employe(id, nom, prenom, salaire);

            LocalStorage.Instance.employes.Add(employe);

            return employe;
        }

        public List<Employe> GetEmploye()
        {
            return LocalStorage.Instance.employes;
            
        }

        public Employe SelectEmployeByID(int id)
        {
            return LocalStorage.Instance.employes.FirstOrDefault(e => e.ID == id);

        }

    }
}
