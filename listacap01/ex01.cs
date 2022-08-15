using system;

class Program {
	public static void main () {

		Console.WriteLine("digite seu nome:");

		string nome = Console.ReadLine();

		Console.WriteLine($"Olá, {nome}, tudo bem!");
	}
}