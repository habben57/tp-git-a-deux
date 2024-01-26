using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src
{
    public class PeopleContainer
    {
        public List<Person> personnes;
        
        public PeopleContainer(List<Person> _personnes)//constructeur avec parametre
        {
            this.personnes = _personnes;
        }

        public List<string> SortbyLastName(List<string> _nom)//methode de tri par nom alphabetiqie
        {
            _nom.Sort();
            return _nom;
        }

        public List<string> SortbyFirstName(List<string> _prenom)//methode de tri par prenom alphabetiqie
        {
            _prenom.Sort();
            return _prenom;
        }
    }
}