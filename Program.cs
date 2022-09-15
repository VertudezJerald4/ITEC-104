/*
 * Created by SharpDevelop.
 * User: Jacqueline Vertudez
 * Date: 9/15/2022
 * Time: 1:19 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace EngagingActivity_Struct
{
	public class ProgramStruct
	{
		struct Employee
		{
			public string firstname;
			public string lastname;
			public int age;
			public string completed;
		}
		public static void Main(string[]args){
			
			Employee employee1;
			
			Console.WriteLine("First Name?");
			employee1.firstname = Console.ReadLine();
			
			Console.WriteLine("Last Name:?");
			employee1.lastname = Console.ReadLine();
			
			Console.WriteLine("Age?");
			employee1.age =int.Parse (Console.ReadLine());
			
			Console.WriteLine("Training Completed? ");
			employee1.completed = Console.ReadLine();
			
			Console.WriteLine("You Entered");
			Console.WriteLine("Firstname: "+employee1.firstname);
			Console.WriteLine("Lastname: "+employee1.lastname);	
			Console.WriteLine("Age:"+employee1.age);
			Console.WriteLine("Completed Training? "+employee1.completed);
			
			Console.ReadLine();
		
		}
	}
}