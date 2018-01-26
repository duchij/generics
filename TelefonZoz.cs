using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    class TelefonZoz
    {

        Dictionary<string, Person> zoznam = new Dictionary<string, Person>();

       

        public void AddPerson(Person person)
        {

           
            try
            {
                zoznam.Add(person.TelCislo, person);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Pozor uz je tam {0}",ex.ToString());
            }
        }

        public bool find(string telCislo, out Person person)
        {
            return zoznam.TryGetValue(telCislo, out person);
        }


    }
}
