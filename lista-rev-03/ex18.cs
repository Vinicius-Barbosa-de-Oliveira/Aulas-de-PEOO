using System; 

class Program {
	public static void Main (string[] args) {

		Console.WriteLine("digite os 4 valores separados por virgula");
		string[] x = Console.ReadLine().Split(",");

		int a1 = int.Parse(x[0]);
		int a2 = int.Parse(x[1]);
		int a3 = int.Parse(x[2]);
		int a4 = int.Parse(x[3]);
		int a5 = int.Parse(x[4]);
		
		Console.WriteLine(a1 + a2 + a3 + a4 + a5);
	}
}