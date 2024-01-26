using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src
{
    public class PeopleContainer
    {
        private List<Person> personnes;
        
        public PeopleContainer(List<Person> _personnes)//constructeur avec parametre
        {
            this.Personnes = _personnes;
        }

        public List<Person> Personnes { get => personnes; set => personnes = value; }
    }
}