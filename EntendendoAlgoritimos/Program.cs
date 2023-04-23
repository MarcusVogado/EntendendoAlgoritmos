//          Pesquisa_Binaria
using EntendendoAlgoritimos.Algoritimos;
using System.Text;

public class Program
{ 
    public static void Main(string[] args)
    {
                           //PESQUISA BINARIA
        
        List<int> minhaLista_Int = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13,14 };        
        Console.WriteLine(Pesquisa_Binaria.PesquisaBinariaInt(minhaLista_Int, 6));

        List<string> minhaListaString = new List<string>() {"Marcus", "Silmara", "Alberto", "Alfredo" };
        Console.WriteLine("O Índice é :" + Pesquisa_Binaria.PesquisaBinariastring(minhaListaString, "Marcus"));
        
    }
}
