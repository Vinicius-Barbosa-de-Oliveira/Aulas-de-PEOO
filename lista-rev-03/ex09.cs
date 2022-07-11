using System; 

class Program {
	public static void Main (string[] args) {

		Console.WriteLine("Digite uma Palavra");

		string p = Console.ReadLine();

		/*string v;
		
		v = p.Split('');*/
		
		int qtd = 0;
		int k = 1;

		foreach (char x in p) {
			qtd += 1;
		}
		while (k <= qtd){
			Console.WriteLine($"{k} {p}");
			k++;
		}
	}
}