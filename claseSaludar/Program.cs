using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace claseSaludar
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona alumnoTajamar = new Persona();
            alumnoTajamar.Nombre = "Sandra";
            DateTime fechaNac = new DateTime(1985, 3, 29);
            alumnoTajamar.FechaNacimiento = fechaNac;
            alumnoTajamar.Saludar();

            PersonaInglesa alumnoBritish = new PersonaInglesa();
            alumnoBritish.Nombre = "Fiorella";
            DateTime fechaNacI = new DateTime(1988, 4, 01);
            alumnoBritish.FechaNacimiento = fechaNacI;
            alumnoBritish.Saludar();
            alumnoBritish.TomarTe();

            PersonaItaliana alumnoLiceo = new PersonaItaliana();
            alumnoLiceo.Nombre = "Claudia";
            DateTime fechaNacIt = new DateTime(1981,10,11);
            alumnoLiceo.FechaNacimiento = fechaNacIt;
            alumnoLiceo.Saludar();


            Console.ReadKey();        
        }
        
    }
    
}
