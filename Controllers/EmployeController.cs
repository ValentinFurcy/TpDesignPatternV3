using Entities;
using Repository;
using Business;
using Business.Contracts;
using static System.Console;
using Repository.Contracts;

namespace Controllers
{
    public class EmployeController
    {
        IEmployeService EmployeBusiness { get; }
        public EmployeController(IEmployeService employeBusiness)
        {
            EmployeBusiness = employeBusiness;
        }
        public Employe CreateEmploye(int id, string nom, string prenom, double salaire)
        {

            return EmployeBusiness.CreateEmploye(id, nom, prenom, salaire);

        }

        public List<Employe> GetEmploye()
        {
            return EmployeBusiness.GetEmploye();
        }
        public Employe SelectEmployeByID(int id)
        {

            return EmployeBusiness.SelectEmployeByID(id);

        }
    }
}
