using System;
using System.Runtime.InteropServices;

namespace GnuCashDotNetLibrary
{
	
	public class CLibraryAPI
	{
		[DllImport("GnuCashCLibrary.dll", EntryPoint = "lifeUniverseAndEverything", CallingConvention = CallingConvention.Cdecl)]
		public static extern int LifeUniverseAndEverything();

		[DllImport("GnuCashCLibrary.dll", EntryPoint = "addTwoNumbers", CallingConvention = CallingConvention.Cdecl)]
		public static extern int AddTwoNumbers(int a, int b);
	}
}
