using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Operaciones{
        
        //Ing no se como hacer paera que el usuario ingrese el radio, no se que hice mal, 
        //solo corre con datos fijos
        public double AreaCirculo (double radio){
            Console.WriteLine("Escriba el radio");
            Console.ReadLine();
            return Math.PI * Math.Pow(radio, 2);
        }
        public double LongitudCirculo (double radio){
             return 2 * Math.PI * radio;
        }
        public double VolumenEsfera (double radio){
            return (4.0 / 3.0) * Math.PI * Math.Pow(radio, 3);
        }
    }
}
