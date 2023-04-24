using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritimos.Algoritimos
{
    public class OrdenacaoPorSelecao
    {
       public static int[] SelectionSort(int[] array)
            => SelectionSort(new LinkedList<int>(array)).ToArray();

       public static IEnumerable<int> SelectionSort(LinkedList<int> list)
        {
            var minList = new LinkedList<int>();
            var maxList = new LinkedList<int>();

            while (list.Count != 0)
            {
                var min = list.Min();//acha o menor valor de um array/lista  
                list.Remove(min);//remove esse valor do array/lista original
                minList.AddLast(min);//adiciona esse valor a lista Minima com o utilizando o termo Last adicionando ao ultimo índice do array

                var max = list.Max();//acha o maior valor de um array/lista
                list.Remove(max);//remove esse valor do array/lista original
                maxList.AddFirst(max);//adiciona esse valor a lista maxima utilizando o termo First adicionando na primeira posição do índice
            }

            return minList.Union(maxList);// unindo as 2 Listas MIN E MAX  Utilizando o Namespace LindekList
        }

    }
}
