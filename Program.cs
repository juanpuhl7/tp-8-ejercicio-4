/*4) Guardar en un arreglo la cantidad de días que tiene cada mes del año (año no bisiesto) y
luego pedir al usuario que ingrese un mes (1=enero 12=diciembre) y según dicho valor mostrar
por pantalla los días de dicho mes.*/


using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int []diasMeses= {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string []mesesNombre= {"Enero", "Febrero", "Marzo","Abril", "Mayo", "Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};
            int mes=0;

            Console.WriteLine("IGRESE DE (1 Enero... 12 Diciembre)");
           mes= Convert.ToInt32(Console.ReadLine());

           mes=mes-1;
           Console.WriteLine("Usted eligio: " + mesesNombre[mes] + " Tiene " + diasMeses[mes] + " dias.");

        }
    }
}
