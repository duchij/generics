using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            TelefonZoz telefonZoz = new TelefonZoz();

            telefonZoz.AddPerson(new Person("123", "Palo", "Mrkvicka"));
            telefonZoz.AddPerson(new Person("345", "Jozko", "Maly"));
            telefonZoz.AddPerson(new Person("567", "Peter", "Hruby"));

            telefonZoz.AddPerson(new Person("567", "Peter", "Hruby"));


            Person pr = new Person();

            bool res = telefonZoz.find("5", out pr);

            if (res)
            {
                Console.WriteLine("Tel: {0}, Meno: {1}, Priezvisko: {2}", pr.TelCislo, pr.Meno, pr.Priezvisko);
            }
            else
            {
                Console.WriteLine("Nie je tam");
            }

            GenericSmallStack<string> test = new GenericSmallStack<string>();
            /* test.Push("halo");
             test.Push("to je");
             test.Push("svet");*/
            test.Pop();

            
         




            Console.ReadKey();


            // tz.

        }
    }
}
