using System;
using System.Collections.Generic;
using System.Text;

namespace Tucil3
{
    class WeightedGraph
	{
		private int _v;
		private int _e;
		private List<Edge>[] _adj;
		public WeightedGraph(int V)
		{
			this._v = V;
			this._e = 0;
			this._adj = new List<Edge>[V];
			for (int i = 0; i < this._adj.Length; i++)
				this._adj[i] = new List<Edge>();
		}

		public int V()
		{
			return _v;
		}

		public int E()
		{
			return _e;
		}

		public void AddEdge(Edge e)
		{
			Node v = e.Source();
			Node w = e.Target(v);
			this._adj[v.V()].Add(e);
			this._adj[w.V()].Add(e);
			this._e++;
		}

		public List<Edge> getAdjacency(int v)
		{
			return this._adj[v];
		}
	}
}
