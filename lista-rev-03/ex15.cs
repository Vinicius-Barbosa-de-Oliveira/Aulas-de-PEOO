using System; 

class Program {
	public static void Main (string[] args) {

		Console.WriteLine("Digite sua Frase:");

		string x = Console.ReadLine();

		int s1 = x.IndexOf(' ');

		//int s2 = s1 - 1;
		while (s1 != -1){
			Console.Write(s1);
			x = x.Substring(s1 + 1);
			s1 = x.IndexOf(' ');
		}
	}
}