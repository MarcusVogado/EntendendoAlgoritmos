using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritimos.Algoritimos
{
    public class Pesquisa_Binaria
    {
        public static int? PesquisaBinariaInt(IList<int> list, int item)
        {
            var resultado = -1;
            var baixa = 0;
            var alta = list.Count() - 1; // baixo e alta acompanham a parte da lista que estamos buscando, utilizamos(-1) pois o count retorna o valor sem a posição 0 da lista 
            while (baixa <= alta) // enquanto não chegar a um único elemento
            {
                var meio = (baixa + alta) / 2;//verificamos o elemento central
                var chute = list[meio];                            //
                if (chute == item)
                    resultado = chute;  //onde achamos o item
                if (chute > item)
                {
                    alta = meio - 1; // se o chute[meio da lista] for mais alto que o item
                }
                else
                {
                    baixa = meio + 1;// se o chute[meio da lista] for mais baixo que o item
                }
            }
            return resultado;
        }    
        public static string? PesquisaBinariastring(List<string> list,string item)
        {
            int index = 0;
            list.Sort(); //Ordenando a Lista, sem ordenar sempre o resultado será null.
            index= list.BinarySearch(item);// Achando o item
            if (index != 0)
            {
                foreach (var nome in list)
                {
                    Console.WriteLine(nome);
                }
                return index.ToString();
            }
            else
            {
                return null;
            }
        } 
    }   
}
