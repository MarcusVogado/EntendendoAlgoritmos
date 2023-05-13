
using EntendendoAlgoritimos.Algoritmos;
using EntendendoAlgoritmos.Algoritmos;
using System.Reflection.Metadata;
using System.Text;

public class Program
{   //Dijkstra inicio
    private const double _infinity = double.PositiveInfinity;
    private static Dictionary<string, Dictionary<string, double>> _graph = new Dictionary<string, Dictionary<string, double>>();
    private static List<string> _processed = new List<string>();//dijkstra final
    public static void Main(string[] args)
    {
        #region PESQUISA BINARIA
        //Pesquisando por Número do índice
        Console.WriteLine("Pesquisando por Numero do índice");
        List<int> minhaLista_Int = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        Console.WriteLine(Pesquisa_Binaria.PesquisaBinariaInt(minhaLista_Int, 14));
        //Pesquisando por String, Email e etc.
        Console.WriteLine("Pesquisando por String, Email e etc.");
        List<string> minhaListaString = new List<string>() { "Marcus", "Silmara", "Alberto", "Alfredo" };
        Console.WriteLine("O Índice é :" + Pesquisa_Binaria.PesquisaBinariastring(minhaListaString, "Marcus"));
        Console.WriteLine("_____________________________");
        #endregion

        #region ORDENAÇÃO POR SELEÇÃO
        Console.WriteLine("ORDENAÇÃO POR SELEÇÃO");
        var numbers = new int[] { 4, 5, 1, 3, 10, 9, 6, 8, 7, 2 };
        var sortedArr = OrdenacaoPorSelecao.SelectionSort(numbers);
        Console.WriteLine(string.Join(',', sortedArr));
        Console.WriteLine("_____________________");
        #endregion

        #region RECURSÃO
        // Toda função recursiva tem que ter o caso-Base-onde a função deve parar. e o caso- recursivo-onde a função chama ela mesma (cuidado com loop infinito)
        #region CAUCULAR FATORIAL
        Console.WriteLine("CAUCULAR FATORIAL");
        var fatorial = Recursao.CaucularFat(5);
        Console.WriteLine(fatorial);
        Console.WriteLine("COMPRIMENTAR");
        Recursao.Comprimentar("Marcus Vogado");
        #endregion
        #endregion

        #region QUICKSORT
        Console.WriteLine("QUICKSORT");
        var arr = new[] { 10, 5, 2, 3, 11, 15, 16, 17, 20, 26, 4, 12 };
        Console.WriteLine(string.Join(", ", QuickSort.QuickSor(arr)));
        #endregion

        #region TABELAS HASH
        Console.WriteLine("TABELAS HASH");
        //Função Hash é uma função na qual você insere um string e depois disso, a função retorna um número
        var produto = "Barbeador";
        var resultado = TabelaHash.Hash(produto);
        Console.WriteLine(resultado);

        var votacao = TabelaHash.Votacao("antônio");
        Console.WriteLine(votacao);

        #endregion

        #region PESQUISA EM LARGURA
        //Criando meu GRAFO com Nome, Meus vizinhos em um array
        Dictionary<string, string[]> _grafico = new Dictionary<string, string[]>();
        //Por ser uma árvore temos que ter conexões entre os itens e que eles existam em nossa arvore
        _grafico.Add("eu", new[] { "Junior", "Alberto", "Francisco" });
        _grafico.Add("Alberto", new[] { "João", "Vitor","Francisco" });
        _grafico.Add("Francisco", new[] { "Vitor","Junior"});
        _grafico.Add("Junior", new[] { "Crislan" });
        _grafico.Add("Vitor", Array.Empty<string>());
        _grafico.Add("Tomas", Array.Empty<string>());
        _grafico.Add("João", Array.Empty<string>());
        _grafico.Add("Crislan", Array.Empty<string>());

        var resultVendedor = PesquisaEmLargura.PesquisaLargura(_grafico, "Alberto");
        Console.WriteLine(resultVendedor);

        #endregion

        #region ALGORITMO DE DIJKSTRA        
          
   
        _graph.Add("start", new Dictionary<string, double>());
        _graph["start"].Add("a", 6.0);
        _graph["start"].Add("b", 2.0);

        _graph.Add("a", new Dictionary<string, double>());
        _graph["a"].Add("fin", 1.0);

        _graph.Add("b", new Dictionary<string, double>());
        _graph["b"].Add("a", 3.0);
        _graph["b"].Add("fin", 5.0);

        _graph.Add("fin", new Dictionary<string, double>());

        var costs = new Dictionary<string, double>();
        costs.Add("a", 6.0);
        costs.Add("b", 2.0);
        costs.Add("fin", _infinity);

        var parents = new Dictionary<string, string>();
        parents.Add("a", "start");
        parents.Add("b", "start");
        parents.Add("fin", null);

        var node = FindLowestCostNode(costs);
        while (node != null)
        {
            var cost = costs[node];
            var neighbors = _graph[node];
            foreach (var n in neighbors.Keys)
            {
                var new_cost = cost + neighbors[n];
                if (costs[n] > new_cost)
                {
                    costs[n] = new_cost;
                    parents[n] = node;
                }
            }
            _processed.Add(node);
            node = FindLowestCostNode(costs);
        }
        Console.WriteLine(string.Join(", ", costs));

        static string FindLowestCostNode(Dictionary<string, double> costs)
        {
            var lowestCost = double.PositiveInfinity;
            string lowestCostNode = null;
            foreach (var node in costs)
            {
                var cost = node.Value;
                if (cost < lowestCost && !_processed.Contains(node.Key))
                {
                    lowestCost = cost;
                    lowestCostNode = node.Key;
                }
            }
            return lowestCostNode;
        }
    }

   
    #endregion
}

