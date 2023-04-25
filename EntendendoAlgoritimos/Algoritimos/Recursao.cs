using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritimos.Algoritimos
{
    public  class Recursao
    {
        public static int CaucularFat(int fatorial)
        {
           
            if(fatorial<=1)
            {
                return 1;
            }
            else
            {
                return fatorial * CaucularFat(fatorial-1); // chamando a função dentro da própria função passando o fatorial recebido -1 até chegar ao resultado;
            }
        }

        public static void Comprimentar(string name)
        {
            Console.WriteLine($"Olá, {name}!");
            Greet2(name);
            Console.WriteLine("Se preparando para dizer Tchau...");
            Bye();
        }

        private static void Greet2(string name)
        {
            Console.WriteLine($"Como você está?, {name}?");
        }

        private static void Bye()
        {
            Console.WriteLine("OK, tchau...");
        }
        private static void CountagemRegressiva(int i)
        {
            Console.WriteLine(i);

            //caso-base 
            if (i <= 0) return;

            // caso recursivo - quando a função chama a si mesma
            CountagemRegressiva(i - 1);
        }

    }
}
