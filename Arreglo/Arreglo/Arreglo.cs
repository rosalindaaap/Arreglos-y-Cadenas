using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo
{
    class Arreglo
    {
        private int[] Valores;
        public void PedirDatos()
        {
            float suma = 0;
            float resultado;
            Console.Write("Ingrese el tamaño del arreglo: ");
            int i = Int32.Parse(Console.ReadLine());

            Valores = new int[i];
            int j = 0;
            while (j < i)
            {
                Console.Write("Ingrese el valor: ");
                Valores[j] = Int32.Parse(Console.ReadLine());
                suma = suma + Valores[j];
                j++;
            }
            resultado = suma / i;

            Console.Write("La media de los valores del arreglo es: " + resultado);
            Console.ReadKey();
        }
            
    }
    class Program
    {
        static void Main(string[] args)
        {
            Arreglo n = new Arreglo();
            n.PedirDatos();
            }
    }
}
