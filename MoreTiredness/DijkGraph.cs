using System;
using System.Collections.Generic;
using System.Text;

namespace MoreTiredness
{
    class DijkGraph
    {
        int vertice;
        int[,] list;
        public DijkGraph(int vertice)
        {
            this.vertice = vertice;
            list = new int[vertice, vertice];
        }
        public void AddEdge(int source, int destination, int weight)
        {
            list[source,destination] = weight;
        }
        int MininimumDistance(int [] dist, bool [] isIncluded)
        {
            int min = int.MaxValue;
            int mindIndex = 0;
            for (int i = 0; i < vertice; i++)
            {
                if(isIncluded[i] == false && min > dist[i])
                {
                    min = dist[i];
                    mindIndex = i;
                }

            }
            return mindIndex;
        }
       public void ShortPath(int source)
        {
            int[] dist = new int[vertice]; // holds distance of current path
            bool[] isIncluded = new bool[vertice]; // checks if its included in the shortest path

            // initializong the distances to infinity and included as false
            for (int i = 0; i < vertice; i++)
            {
                dist[i] = int.MaxValue;
                
            }
            // initial distance
            dist[source] = 0; // of course you suppose be zero na
            // now finding the shortest path 
            for (int v = 0; v < vertice ; v++)
            {
                // getting the minimum node from node not yet processed
                int u = MininimumDistance(dist, isIncluded);
                isIncluded[u] = true; // mark the vertex as included
                // update 
                for (int node = 0; node < vertice; node++)
                {
                    // check the edges between U and node
                    if (list[u, node] > 0)
                    {
                        // check if node is already included and dist value is infinity
                        if (isIncluded[node] == false && list[u, node] != int.MaxValue)
                        {
                            // update the dist value if its not in set
                            if (dist[u] + list[u, node] < dist[node])
                            {
                                // update
                                dist[node] = dist[u] + list[u, node];
                            }
                        }
                    }
                }
            }
            PrintShow(source,dist);
        }
        void PrintShow(int source,int [] n)
        {
           // Console.Write(" distance from vertex  ");
            for (int i = 0; i < vertice; i++)
            {
                Console.WriteLine("Source node " + source + " To vertex " + i + " is "+ n[i]);
            }
        } 
    }
}
