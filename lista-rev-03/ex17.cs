using System; 

class Program {
	public static void Main (string[] args) {

		Console.WriteLine("escreva a frase:");

		string v = Console.ReadLine();
		string[] i = v.Split();
		
		int qtd = 0;

		foreach (string k in i){
			foreach (char x in k){
				switch (x){
					
					case 'a': qtd += 1; break;
					case 'e': qtd += 1; break;
					case 'i': qtd += 1; break;
					case 'o': qtd += 1; break;
					case 'u': qtd += 1; break;
				}
			}
			while (qtd > 0){
				Console.Write($" {k}");
				qtd--;
			}
		}
		
	}
}