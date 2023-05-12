using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritmos.Algoritmos
{
    public class PesquisaEmLargura
    {        
        public static string PesquisaLargura(Dictionary<string, string[]> listQueue,string nome)
        {
            var pesquisaFila = new Queue<string>(listQueue[nome]);// adicionando todos os nomes na fila.
            var pesquisados= new List<string>();//criando uma nova lista para adicionar os nomes já pesquisados.

            // retirando um nome da fila para a pesquisa
            while (pesquisaFila.Any())
            {
                var pessoa = pesquisaFila.Dequeue();
                if (!pesquisados.Contains(pessoa))
                {
                    if (PessoaVendedora(pessoa))
                    {
                        return $"{pessoa}: é vendedora de Manga!";
                    }
                    else
                    {
                        pesquisaFila=new Queue<string>(pesquisaFila.Concat(listQueue[pessoa]));
                        pesquisados.Add(pessoa);
                    }
                }
            }
           
            return "Nenhuma pessoa é vendedora de manga!";
        }
        private static bool PessoaVendedora(string name)
        {
            return name.EndsWith("n");
        }
    }
}
