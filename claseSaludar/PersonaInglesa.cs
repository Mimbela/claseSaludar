using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseSaludar
{
    public class PersonaInglesa:Persona
    {
        public new void Saludar()
        {
            Console.WriteLine("Hi, im {0} and iam {1} years old", Nombre ,
                CalcularEdad(FechaNacimiento).ToString());
        }
        public void TomarTe()
        {
            Console.WriteLine("Estoy tomando té");
            //Console.ReadKey();
        }
    }
}
