using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextoEstatico
{
    class Matematicas
    {
        public const double PI = 3.14159;
        //variable estatica, significa que se puede tener acceso a ella solo a travez de la clase 
        //el const lo hace static y no se permite cambiar su contenido y/o valor 
        public static double sumar(double sumando1, double sumando2) //con el static, no es necesario instanciar la clase 
        {
            return sumando1 + sumando2;
        }

        public static double areaCirculo(double radio)
        //double es el tipo de dato que va regresar 

        {
            return (radio * radio) * PI;
        }


    }
}
