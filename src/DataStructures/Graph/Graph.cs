using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph
{

    public class Graph
    {
        //declare a dictionary with... 
        //int keys: vertices
        //list values: edges
        public Dictionary<int, List<int>> matrix;
        public int V; //vertices
        public int E; //edges

        //create a v-vertex graph with no edges
        public Graph()
        {
            matrix = new Dictionary<int, List<int>>();
            V = 0;
            E = 0;
        }

        public void addVertice(int v)
        {
            //don't check to see if already exists cus not a simple graph
            matrix.Add(v, new List<int>()); //empty list with no edges
            V++;
        }

        //add edge v-w to this graph
        public void addEdge(int v, int w)
        {
            //if v and or w does not exist, add them
            if (!matrix.ContainsKey(v))
            {
                matrix.Add(v, new List<int>());
                V++;
            }
            if (!matrix.ContainsKey(w))
            {
                matrix.Add(w, new List<int>());
                V++;
            }

            //add w to v's list
            matrix[v].Add(w);

            //add v to w's list
            matrix[w].Add(v);

            //increment edges
            E++;
        }

        //return how many vertexes are incident
        public int Degree(int v)
        {
            if (!matrix.ContainsKey(v)) return -1; //vertex does not exist

            return matrix[v].Count;
        }

        //return the degrees of the vertex that has the max amount of degrees
        public int MaxDegree()
        {
            if (V == 0) return 0; //no vertices

            int max = 0;
            foreach (var vertex in matrix.Keys)
            {
                int degree = Degree(vertex);
                if (degree > max) max = degree; //set new max
            }

            return max;
        }

        public float AverageDegree() 
        {
            if (V == 0) return 0; //no vertices

            float avg = 0;
            foreach (var v in matrix.Keys) avg += Degree(v);
            return avg = avg / V; 

        }

        //count occurances where a vertex is on it's own adjacency list
        public int NumberOfSelfLoops() 
        {
            int count = 0;
            foreach (var v in matrix.Keys)
            {
                if (matrix[v] != null && matrix[v].Contains(v)) count++;
            }
            return count;
        }
    }
}
