using System; 

class Program {
	public static void Main (string[] args) {

		Console.WriteLine("digite os 4 valores separados por virgula");
		string[] v = Console.ReadLine().Split(",");
		int soma = 0;

		foreach (string x in v) {
			switch (x) {
				case "1": soma += 1; break;
				case "2": soma += 2; break;
				case "3": soma += 3; break;
				case "4": soma += 4; break;
				case "5": soma += 5; break;
				case "6": soma += 6; break;
				case "7": soma += 7; break;
				case "8": soma += 8; break;
				case "9": soma += 9; break;	
			}
		}
		Console.WriteLine($"Soma = {soma}");
	}
}