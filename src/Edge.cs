using System;
using System.Collections.Generic;
using System.Text;

namespace Tucil3
{
    class Edge
	{
		private Node _v;
		private Node _w;
		private double _weight;
		public Edge(Node v, Node w)
		{
			this._v = v;
			this._w = w;
			int x = v.X() - w.X();
			int y = v.Y() - w.Y();
			this._weight = Math.Sqrt((x * x) + (y * y));
		}

		public double Weight()
		{
			return _weight;
		}

		public Node Source()
		{
			return _v;
		}

		public Node Target(Node vertex)
		{
			if (vertex == _v)
				return _w;
			else if (vertex == _w)
				return _v;
			else
				throw new Exception("Error");
		}
	}
}
