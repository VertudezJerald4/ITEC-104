using System;
using System.Collections.Generic;
using System.Linq;

namespace ITEC_104_VERTUDEZ_ACTIVITY5
{
	class Program
	{
		public static void Main(string[] args)
		{
			List<int> mylist = new List<int> {10, 20, 35 , 65, 53, 48 , 5, 1};
			 
			List<int> Result = mylist.Where(x => x % 10 != 5).ToList();
			foreach(var element in Result)
			{
				Console.WriteLine(element + "");
			}
			Console.ReadLine();
		}
	}
}