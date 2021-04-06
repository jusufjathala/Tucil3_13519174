using System;
using System.Collections.Generic;
using System.Text;

namespace Tucil3
{
    class Node
	{
		private int _v;
		private int _x;
		private int _y;
		public Node(int v, int x, int y)
		{
			this._v = v;
			this._x = x;
			this._y = y;
		}

		public int V()
		{
			return _v;
		}

		public int X()
		{
			return _x;
		}

		public int Y()
		{
			return _y;
		}

		public double EuclideanDistance(Node w)
		{
			int x = this._x - w.X();
			int y = this._y - w.Y();
			return Math.Sqrt((x * x) + (y * y));
		}
	}
}
