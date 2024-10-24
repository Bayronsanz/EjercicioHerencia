using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Implementacion : Operaciones{
        double _radio;

        public Implementacion(double radio)
        {
            _radio = radio;
        }

        public void Imprimir()
        {

            double area = AreaCirculo(_radio);
            double longitud = LongitudCirculo(_radio);
            double volumen = VolumenEsfera(_radio);

            Console.WriteLine($"Área del círculo: {area}");
            Console.WriteLine($"Longitud de la circunferencia: {longitud}");
            Console.WriteLine($"Volumen de la esfera: {volumen}");
        }
    }
}
