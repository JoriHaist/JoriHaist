using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papkata3
{
   //
   class clsGraph
    {
        //
        private int Vertices;
        //
        private List<Int32>[] adj;
        
        //
        public clsGraph(int v)
        {

            Vertices = v;
            adj = new List<Int32>[v];
            //
            for (int i = 0; i < v; i++)
            {
                adj[i] = new List<Int32>();
            }
        }

        //
        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
        }
    }
}
