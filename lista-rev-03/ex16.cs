using System; 

class Program {
	public static void Main (string[] args) {

		Console.WriteLine("Digite a Frase");

		string i = Console.ReadLine();
		string v = i.ToLower();

		int s1 = 0;
		int s2 = 0;
		int s3 = 0;
		int s4 = 0;
		int s5 = 0;
		int s6 = 0;
		
		Console.WriteLine(v);

		foreach (char x in v) {
			switch (x){
				case 'a': s1 += 1; break;
				case 'e': s2 += 1; break;
				case 'i': s3 += 1; break;
				case 'o': s4 += 1; break;
				case 'u': s5 += 1; break;
				default: s6 += 1; break;
			}
		}
		Console.WriteLine($"A - {s1}");
		Console.WriteLine($"E - {s2}");
		Console.WriteLine($"I - {s3}");
		Console.WriteLine($"O - {s4}");
		Console.WriteLine($"U - {s5}");
		Console.WriteLine($"Consoantes - {s6}");
	}
}