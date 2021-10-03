using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadenas
{
    class Cadena
    {
        private string Frase;

        public void Operacion()
        {
            Console.Write("Ingrese la frase: ");
            Frase = Console.ReadLine();

            int i = Frase.Length;
            int j = 0;

            while (j < i)
            {
                Frase = Frase.Replace(" ", "\n");
                Console.Write(Frase[j]);
                j++;
            }
            Console.Write("\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cadena n = new Cadena();
            n.Operacion();
        }
    }
}
