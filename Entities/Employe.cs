using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entities
{
    public class Employe
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public double Salaire { get; set; }

        public Employe(int id, string nom, string prenom, double salaire)
        {
            this.ID = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Salaire = salaire;
        }

        public override string ToString()
        {
            return $"Employe : ID {ID} , Nom : {Nom}, Prenom : {Prenom}, Salaire : {Salaire} "; ;
        }

    }
}
