using System;
using System.Collections.Generic;

public class Program {
  	public static void Main (string[] args)
  	{
		Random rd = new Random();

        int rand_num = rd.Next(0,100);

		if(rand_num > 49)
		{
			Console.WriteLine("Hint: The Number Is Above 50");
		} else
		{
			Console.WriteLine("Hint: The Number Is Below 50");
		}

		string answer = Console.ReadLine();

		if(Convert.ToInt32(answer) == rand_num)
		{
			Console.WriteLine("Congrats! You Got It Right!");
		} else
		{
			Console.WriteLine("Dang, You Failed.");
		}
  	}
}

