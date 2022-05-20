using System;
class Program{
	public static void Main(string[] args){
		
		Console.WriteLine("Digite os numeros de tomadas:");
		string[] x = Console.ReadLine().Split(' ');

		int t1 = int.Parse(x[0]);
		int t2 = int.Parse(x[1]);
		int t3 = int.Parse(x[2]);
		int t4 = int.Parse(x[3]);

		int result = (t1 + t2 + t3 + t4) - 3;
		Console.WriteLine(result);
	}
}