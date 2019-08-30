using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContextoEstatico
{
    class Program
    {
        static void Main(string[] args) //las variables no tienen acceso a metodos estaticos 
        {
            
            double sumando1 = 10;
            double sumando2 = 20;
            double resultado = Matematicas.sumar(sumando1, sumando2);// se debe mandar llamar ala clase, ya que no existe ninguna variable
            //al llamar a la clase, esta se ejecuta 

            Console.WriteLine(sumando1.ToString() +"+" + sumando2.ToString() + "=" + resultado.ToString());

            double radio = 6.7;
            Console.WriteLine("radio: " + radio.ToString() + " area= " + Matematicas.areaCirculo(radio));//hacerlo mas dinamico, declarando antes la varibale a la que va ser igual el radio
            Console.WriteLine("radio: 5, area es = " + Matematicas.areaCirculo (4.7));
            // esta linea no sirve si se pone conts en la linea 11 de la clase "Matematicas.PI = 95.36;"
            //Nuevo valor de Pi en toda la aplicacion, a que solo hay un espacio de memoria para pi


            Console.Read();//siempre debe ir al final, si no no se ejecutara lo que quede debajo de el 
        }
    }
}
