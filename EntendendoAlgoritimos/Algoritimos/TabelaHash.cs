using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritimos.Algoritimos
{
    public class TabelaHash
    {
        public static string Hash(string nomeProduto)
        {
            var produtos = new Dictionary<string, decimal>();
            produtos.Add("Barbeador", 19.5m);
            produtos.Add("Tesoura", 15.8m);
            produtos.Add("Bola", 9.99m);

            var produto = produtos.Where(a => a.Key == nomeProduto);
            foreach (var item in produto)
            {
                return $"{item.Key}: {item.Value}";
            }

            return "Objeto Não encontrado";
        }
    }
}
