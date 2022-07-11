using System; 

class Program {
	public static void Main (string[] args) {

		Console.WriteLine("Digite a frase:");

		string[] v = Console.ReadLine().Split();

		int s1 = v.Length;
		Console.WriteLine(s1);
	}
}