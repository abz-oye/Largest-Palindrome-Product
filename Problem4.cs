using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    
    static void Main(String[] args) {
        int x, y;
		string product="" , res="";

		for (x = 100; x <= 999; x++)
		{
			for (y = 100; y <= 999; y++)
			{
				product = Convert.ToString(x*y);

				if (product == new String(product.Reverse().ToArray()))
				{
					Console.WriteLine("X=" + x + " Y=" + y );
					res = product;

					Console.WriteLine("Polindrome is: " + res);
				}

				else { continue; }
			}
		}
    }
}
