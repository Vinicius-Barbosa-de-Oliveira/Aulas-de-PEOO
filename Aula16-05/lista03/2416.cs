using System;
class Program{
	public static void Main(string[] args){

		Console.WriteLine("Digite os valores:");
		string[] s = Console.ReadLine().Split(' ');
		int c = int.Parse(s[0]);
		int n = int.Parse(s[1]);

		int result = c % n;

		Console.WriteLine(result);
	}
}