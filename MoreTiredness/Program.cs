using System;
using System.Collections.Generic;

namespace MoreTiredness
{
    class Program
    {
        static void Main(string[] args)
        {
            // for directed graph
            DijkGraph graph = new DijkGraph(5);
            graph.AddEdge(0, 1, 10);
            graph.AddEdge(0, 3, 7);
            graph.AddEdge(1, 3, 8);
            graph.AddEdge(1, 2, 5);
            graph.AddEdge(1, 4, 2);
            graph.AddEdge(2, 4, 8);
            graph.AddEdge(3, 4, 6);
            //graph.AddEdge(0, 1, 4);
            //graph.AddEdge(0, 2, 3);
            //graph.AddEdge(1, 2, 1);
            //graph.AddEdge(1, 3, 2);
            //graph.AddEdge(2, 3, 4);
            //graph.AddEdge(3, 4, 2);
            //graph.AddEdge(4, 5, 6);
            graph.ShortPath(0);

        }
    }
}
