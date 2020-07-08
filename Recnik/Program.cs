using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recnik
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> Imenik = new Dictionary<string, string>();
			do
			{
				Console.WriteLine("Unesite ime: ");
				string ime = Console.ReadLine();
				Console.WriteLine("Unesite telefon: ");
				string tel = Console.ReadLine();

				// Ne, NOT ili !
				//
				//   A    |  !A
				//------------------
				//   T    |   F
				//   F    |   T

				if (!Imenik.ContainsKey(ime))
				{
					Imenik.Add(ime, tel);
				}

				foreach(string kljuc in Imenik.Keys)
				{
					Console.WriteLine($"{kljuc} ---- {Imenik[kljuc]}");
				}

			} while (true);
		}
	}
}
