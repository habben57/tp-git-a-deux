using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src
{
   public class Person
    {
        public string nom;
        public string prenom;
    

    public Person(string _nom, string _prenom)//constructeur avec parametre
    {
        this.nom = _nom;
        this.prenom = _prenom;
    }

     //Fonction de comparaison de deux personnes
    /*public bool Comparer(Person other)
    {
        if(other.prenom.ToUpper().Equals(this.prenom.ToUpper()) && other.nom.ToUpper().Equals(this.nom.ToUpper()))
        {
            return true;
        }
        return false;
    } */
    
    }
}
