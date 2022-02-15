using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class LineComp
    {
		public static void CompareLines()
		{
			int x1, x2, y1, y2, p1, p2, q1, q2;
			double dis1, dis2;
			x1 = 1; y1 = 1; x2 = 4; y2 = 6;
			p1 = 1; q1 = 1; p2 = 4; q2 = 4;
			dis1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
			dis2 = Math.Sqrt((p2 - p1) * (p2 - p1) + (q2 - q1) * (q2 - q1));
			Console.WriteLine("Length of line one of coordinates" + "(" + x1 + "," + y1 + ")," + "(" + x2 + "," + y2 + ") is equal to " + dis1);
			Console.WriteLine("Length of line two of coordinates" + "(" + p1 + "," + q1 + ")," + "(" + p2 + "," + q2 + ") is equal to " + dis2);
			if (dis1 == dis2)
			{
				Console.WriteLine("Both lines are equal");
			}
			else if (dis1 > dis2)
			{
				Console.WriteLine("Line one is greater then line two");
			}
			else
			{
				Console.WriteLine("Line one is smaller then line two");
			}


		}
	}
}
