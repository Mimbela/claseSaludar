using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseSaludar
{
    public class PersonaItaliana:Persona
    {
        public new void Saludar()
        {
            Console.WriteLine("Ciao {0} e io ho {1} anni ",
            Nombre, CalcularEdad(FechaNacimiento).ToString());
        }
    }
}
