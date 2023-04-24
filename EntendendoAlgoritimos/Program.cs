//          Pesquisa_Binaria
using EntendendoAlgoritimos.Algoritimos;
using System.Text;

public class Program
{ 
    public static void Main(string[] args)
    {
        #region PESQUISA BINARIA
        //Pesquisando por Número do índice
        Console.WriteLine("Pesquisando por Numero do índice");
        List<int> minhaLista_Int = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13,14 };        
        Console.WriteLine(Pesquisa_Binaria.PesquisaBinariaInt(minhaLista_Int, 6));
        //Pesquisando por String, Email e etc.
        Console.WriteLine("Pesquisando por String, Email e etc.");
        List<string> minhaListaString = new List<string>() {"Marcus", "Silmara", "Alberto", "Alfredo" };
        Console.WriteLine("O Índice é :" + Pesquisa_Binaria.PesquisaBinariastring(minhaListaString, "Marcus"));
        Console.WriteLine("_____________________________");
        #endregion


        #region ORDENAÇÃO POR SELEÇÃO
        Console.WriteLine("ORDENAÇÃO POR SELEÇÃO");
        var numbers = new int[] { 4, 5, 1, 3, 10, 9, 6, 8, 7, 2 };
        var sortedArr =OrdenacaoPorSelecao.SelectionSort(numbers);
        Console.WriteLine(string.Join(',', sortedArr));
        Console.WriteLine("_____________________");
        #endregion

        #region RECURSÃO
        // Toda função recursiva tem que ter o caso-Base-onde a função deve parar. e o caso- recursivo-onde a função chama ela mesma (cuidado com loop infinito)
        #region CAUCULAR FATORIAL
        Console.WriteLine("CAUCULAR FATORIAL");
        var fatorial=Recursao.CaucularFat(5);
        Console.WriteLine(fatorial);
        Console.WriteLine("COMPRIMENTAR");
        Recursao.Comprimentar("Marcus Vogado");

        #endregion
        #endregion
    }
}
