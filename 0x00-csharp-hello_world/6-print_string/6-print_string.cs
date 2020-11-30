using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
		Console.Write("{0}{0}{0}" + "\n", str);
        Console.WriteLine(str.Substring(0,9));
        }
}