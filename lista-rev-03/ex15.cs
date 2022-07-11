using System; 

class Program {
	public static void Main (string[] args) {

		Console.WriteLine("Digite a Frase:");
		string v = Console .ReadLine();

		int s2 = 0;
		int s1 = v.IndexOf(' ');

		while (s1 != -1){
			s2 += 1;
			v = v.Substring(s1 + 1);
		}
		Console.WriteLine(s2);
		s2 = 0;
		s1 = v.IndexOf(' ');
	}
}