﻿
using EntendendoAlgoritimos.Algoritmos;
using EntendendoAlgoritmos.Algoritmos;
using System;
using System.Reflection.Metadata;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        #region CAP.1 PESQUISA BINARIA
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

        #region CAP.2 ORDENAÇÃO POR SELEÇÃO
        Console.WriteLine("ORDENAÇÃO POR SELEÇÃO");
        var numbers = new int[] { 4, 5, 1, 3, 10, 9, 6, 8, 7, 2 };
        var sortedArr = OrdenacaoPorSelecao.SelectionSort(numbers);
        Console.WriteLine(string.Join(',', sortedArr));
        Console.WriteLine("_____________________");
        #endregion

        #region CAP.3 RECURSÃO
        // Toda função recursiva tem que ter o caso-Base-onde a função deve parar. e o caso- recursivo-onde a função chama ela mesma (cuidado com loop infinito)
        #region CAUCULAR FATORIAL
        Console.WriteLine("CAUCULAR FATORIAL");
        var fatorial = Recursao.CaucularFat(5);
        Console.WriteLine(fatorial);
        Console.WriteLine("COMPRIMENTAR");
        Recursao.Comprimentar("Marcus Vogado");
        #endregion
        #endregion

        #region CAP.4 QUICKSORT
        Console.WriteLine("QUICKSORT");
        var arr = new[] { 10, 5, 2, 3, 11, 15, 16, 17, 20, 26, 4, 12 };
        Console.WriteLine(string.Join(", ", QuickSort.QuickSor(arr)));
        #endregion

        #region CAP.5 TABELAS HASH
        Console.WriteLine("TABELAS HASH");
        //Função Hash é uma função na qual você insere um string e depois disso, a função retorna um número
        var produto = "Barbeador";
        var resultado = TabelaHash.Hash(produto);
        Console.WriteLine(resultado);

        var votacao = TabelaHash.Votacao("antônio");
        Console.WriteLine(votacao);

        #endregion

        #region CAP.6 PESQUISA EM LARGURA
        //Criando meu GRAFO com Nome, Meus vizinhos em um array
        Dictionary<string, string[]> _grafico = new Dictionary<string, string[]>();
        //Por ser uma árvore temos que ter conexões entre os itens e que eles existam em nossa arvore
        _grafico.Add("eu", new[] { "Junior", "Alberto", "Francisco" });
        _grafico.Add("Alberto", new[] { "João", "Vitor", "Francisco" });
        _grafico.Add("Francisco", new[] { "Vitor", "Junior" });
        _grafico.Add("Junior", new[] { "Crislan" });
        _grafico.Add("Vitor", Array.Empty<string>());
        _grafico.Add("Tomas", Array.Empty<string>());
        _grafico.Add("João", Array.Empty<string>());
        _grafico.Add("Crislan", Array.Empty<string>());

        var resultVendedor = PesquisaEmLargura.PesquisaLargura(_grafico, "Alberto");
        Console.WriteLine(resultVendedor);

        #endregion

        #region CAP.7 ALGORITMO DE DIJKSTRA   
        //Algoritmo utilizado para verificar qual o caminho mais curto muito utilizado por GPS
        Dictionary<string, Dictionary<string, double>> _graph = new Dictionary<string, Dictionary<string, double>>();
        const double _infinity = double.PositiveInfinity;
        List<string> _processed = new List<string>();
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
        parents.Add("fin", null!);

        var node = AlgoritmoDeDijkstra.FindLowestCostNode(costs, _processed);
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
            node = AlgoritmoDeDijkstra.FindLowestCostNode(costs, _processed);
        }
        Console.WriteLine(string.Join(", ", costs));





        #endregion

        #region CAP.8 ALGORITMOS GULOSOS

        AlgoritmosGulosos.GulosoEstacoes();
        AlgoritmosGulosos.GulosoFrutas();
        #endregion

        #region CAP.9 PROGRAMAÇÃO DINÂMICA
        var array =ProgramacaoDinamica.Dinamica("hish", "fish");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0} ", array[i, j]);
            }   
            Console.WriteLine();
        }


        #endregion

        #region K-VIZINHOS MAIS PRÓXIMOS(K-NN)
        Console.WriteLine("K-VIZINHOS MAIS PRÓXIMOS(K-NN)");
        KVizinhos.Vizinhos();
		#endregion
	}
}


