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

    }
}