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
                var min = list.Min();
                list.Remove(min);
                minList.AddLast(min);

                var max = list.Max();
                list.Remove(max);
                maxList.AddFirst(max);
            }

            return minList.Union(maxList);
        }

    }
}
