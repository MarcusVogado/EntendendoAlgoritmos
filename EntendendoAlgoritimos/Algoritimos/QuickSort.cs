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
            var meio= list.Count() / 2;// pegando o elemento central como pivô
            var pivo= list.FirstOrDefault(meio);//passando o elemento central por FirstiOrDefault para descobrir o elemento central da tabela.
            var menor = list.Skip(1).Where(i => i <= pivo); // ordenando os números menores que o pivô
            var maior = list.Skip(1).Where(i => i > pivo);//ordenando os números maiores que o pivô
            return QuickSor(menor).Union(new List<int> { pivo }).Union(QuickSor(maior));// unindo a lista de menor, pivô e maior.
        }
    }
}
