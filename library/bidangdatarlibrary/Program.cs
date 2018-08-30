using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bidangdatar;

namespace bidangdatarlibrary
{
	class Program
	{
		static void Main(string[] args)
		{
			menghitung hitung = new menghitung();

			Console.WriteLine("---KELILING PERSEGI---");
			Console.WriteLine(hitung.persegi(5));
			Console.WriteLine("---LUAS PERSEGI---");
			Console.WriteLine(hitung.luasPersegi(5));
			Console.WriteLine("---KELILING PERSEGI PANJANG---");
			Console.WriteLine(hitung.persegipanjang(10, 5));
			Console.WriteLine("---LUAS PERSEGI PANJANG---");
			Console.WriteLine(hitung.LuasPersegipanjang(10, 5));
			Console.WriteLine("---LUAS SEGITIGA---");
			Console.WriteLine(hitung.luasSegitiga(2, 2));
			Console.ReadLine();
		}
	}
}
