using BasicStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kruskal
{
    public class Graf
    {
        int[] Parrent;
        public Edge[] Kruskal(int[][] g)
        {
            Parrent = new int[g.Length];
            for (int i = 0; i < Parrent.Length; i++) Parrent[i] = i;

            SingleArray<Edge> edges = new SingleArray<Edge>();
            while (edges.Size < g.Length - 1)
            {
                int v1 = 0, v2 = 0;
                int minWeight = int.MaxValue;
                for (int i = 0; i < g.Length; i++)
                    for (int j = 0; j < g[i].Length; j++)
                        if (g[i][j] != 0 && g[i][j] < minWeight)
                        {
                            v1 = i;
                            v2 = j;
                            minWeight = g[i][j];
                        }

                if (Find(v1) != Find(v2))
                {
                    edges.Add(new Edge(v1, v2), edges.Size);
                    Union(v1, v2);
                }
                g[v1][v2] = int.MaxValue;
                g[v2][v1] = int.MaxValue;
            }
            return edges.Array;
        }
        int Find(int a)
        {
            if (Parrent[a] == a) return a;
            return Find(Parrent[a]);
        }
        void Union(int x, int y)
        {
            int parX = Find(x);
            int parY = Find(y);
            Parrent[parX] = parY;
        }
    }
}
