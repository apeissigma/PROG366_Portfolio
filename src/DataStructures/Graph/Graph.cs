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
        }

        public void addVertice(int v)
        {
            //don't check to see if already exists cus not a simple graph
            matrix.Add(v, null);
        }

        //add edge v-w to this graph
        public void addEdge(int v, int w)
        {
            //if v and or w does not exist, add them
            if (!matrix.ContainsKey(v))
            {
                matrix.Add(v, null);
                V++;
            }
            if (!matrix.ContainsKey(w))
            {
                matrix.Add(w, null);
                V++;
            }

            //add w to v's list
            //if v does not have a list, create
            if (matrix[v] == null) matrix[v] = new List<int>();
            matrix[v].Add(w);
            E++;

            //add v to w's list
            if (matrix[w] == null) matrix[w] = new List<int>();
            matrix[w].Add(v);
            E++;
        }

        //return how many vertexes are incident
        //how many connections the vertexes
        public int Degree(int v)
        {
            return matrix[v].Count;
        }

        //return the degrees of the vertex with the max
        //amount of degrees
        //public int MaxDegree() { }

        //public float AverageDegree() {}

        //public int NumberOfSelfLoops() {}
    }
}
