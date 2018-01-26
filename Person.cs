using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    class Person
    {

        public string TelCislo
        {
            get; set;
        }

        public string Meno
        {
            get;set;
        }

        public string Priezvisko
        {
            get;set;
        }

        public Person(string tel, string meno, string priezvisko)
        {
            this.TelCislo = tel;
            this.Meno = meno;
            this.Priezvisko = priezvisko;
        }

        public Person()
        {

        }
            
    }
       

}
