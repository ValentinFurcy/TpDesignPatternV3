using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contracts
{
    public interface IEmployeService
    {
        public Employe CreateEmploye(int id, string nom, string prenom, double salaire);
        public List<Employe> GetEmploye();
        public Employe SelectEmployeByID(int id);
    }
}
