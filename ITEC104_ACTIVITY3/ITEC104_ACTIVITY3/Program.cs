/*
 * Created by SharpDevelop.
 * User: Jacqueline Vertudez
 * Date: 10/13/2022
 * Time: 10:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ITEC104_ACTIVITY3
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[]names = new string[4];
			
			names[0] = "0";
			names[1] = "vertudez@gmail.com";
			names[2] = "jeraldvertudez";
			names[3] = "jvr44";
			
			Console.WriteLine("Index: " + names[0]);
			Console.WriteLine("Email: "+ names[1]);
			Console.WriteLine("Username: " + names[2]);
			Console.WriteLine("Password: " + names[3]);
			
			Console.ReadLine();
			
				
		}
	}
}