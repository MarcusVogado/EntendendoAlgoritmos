using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritmos.Algoritmos
{
    public class AlgoritmoDeDijkstra
    {
        public static string FindLowestCostNode(Dictionary<string, double> costs, List<string> _processed)
        {
            var lowestCost = double.PositiveInfinity;
            string lowestCostNode = null!;
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
}
