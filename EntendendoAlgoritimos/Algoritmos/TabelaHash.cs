using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EntendendoAlgoritimos.Algoritmos
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

        public static string Votacao(string nome)
        {
            var nameNormalize = nome.ToUpper();
            var listNormalize = new List<string>();
            var eleitores = new List<string> { "Marcus", "Antônio", "Silmara", "José" };
            
            foreach (var eleitor in eleitores)
            {
                var eleitorNormalize = eleitor.ToUpper();
                listNormalize.Add(eleitorNormalize);
            }
            var votaram = listNormalize.Contains(nameNormalize);
            if (votaram is false)
            {
                eleitores.Add(nome);
                return nome + ": Está apto para votar";
            }
            else
            {
                return "Não permitido esse eleitor já registrou o seu Voto";
            }
        }
    }
}
