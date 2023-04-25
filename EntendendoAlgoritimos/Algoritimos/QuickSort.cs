using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritimos.Algoritimos
{
    public class QuickSort
    {
        public static IEnumerable<int>QuickSor(IEnumerable<int> list)
        {
            if (list.Count() <= 1) return list;//verificando se a lista contem menos de 2 elementos
            var pivot = list.First();// pegando o primeiro elemento como pivô
            var menor = list.Skip(1).Where(i => i <= pivot); // ordenando os números menores que o pivô
            var maior = list.Skip(1).Where(i => i > pivot);//ordenando os números maiores que o pivô
            return QuickSor(menor).Union(new List<int> { pivot }).Union(QuickSor(maior));// unindo a lista de menor, pivô e maior.
        }
    }
}
