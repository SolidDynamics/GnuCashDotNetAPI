using System;
using GnuCashDotNetLibrary;

namespace GnuCashCAPIConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Starting GnuCash DotNet API");
			try
			{
				CLibraryAPI CLibraryAPI = new CLibraryAPI();
				Console.WriteLine("Answer to meaning of life, universe and everything: " +
				                  CLibraryAPI.LifeUniverseAndEverything().ToString());

				int a = 7;
				int b = 6;
				Console.WriteLine($"{a} plus {b} = {CLibraryAPI.AddTwoNumbers(a,b)}");
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}


			Console.WriteLine("End of program");
			Console.ReadKey();
		}
	}
}
