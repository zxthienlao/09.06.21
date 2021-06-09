using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> sad = new List<int>();
			Random rnd = new Random();
			int a = rnd.Next(1, 100);
			int b = rnd.Next(1, 100);
			int c = rnd.Next(1, 100);
			int d = rnd.Next(1, 100);
			Console.WriteLine(a);
			Console.WriteLine(b);
			Console.WriteLine(c);
			Console.WriteLine(d);
			Console.WriteLine();
			sad.Add(a);
			sad.Add(b);
			sad.Add(c);
			sad.AddFront(d);
			sad.Print();
			Console.ReadKey();
		}
	}
}
