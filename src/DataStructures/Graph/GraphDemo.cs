using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph
{
    public class GraphDemo
    {
        public GraphDemo()
        {
            Console.WriteLine("\n========== Graph Implementation ==========\n");
            Graph graph = new Graph();

            Console.WriteLine("Adding vertices [1, 2, 3, 4, 5]");
            graph.addVertice(1);
            graph.addVertice(2);
            graph.addVertice(3);
            graph.addVertice(4);
            graph.addVertice(5);
            Console.WriteLine($" > Graph has {graph.V} vertices and {graph.E} edges\n");

            Console.WriteLine("Adding edges [[1,2], [1,3], [3,4], [2,5], [5,5]]");
            graph.addEdge(1, 2);
            graph.addEdge(1, 3);
            graph.addEdge(3, 4);
            graph.addEdge(2, 5);
            graph.addEdge(5, 5);
            Console.WriteLine($" > Graph has {graph.V} vertices and {graph.E} edges\n");

            Console.WriteLine($" > Maximum degree in graph: {graph.MaxDegree()}");
            Console.WriteLine($" > Average degree in graph: {graph.AverageDegree()}");
            Console.WriteLine($" > Number of self-loops: {graph.NumberOfSelfLoops()}");
        }
    }
}
