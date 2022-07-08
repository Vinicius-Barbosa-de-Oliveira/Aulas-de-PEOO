using System; 

class Program {
	public static void Main (string[] args) {

		Console.WriteLine("Coloque a frase:");
		string x = Console.ReadLine();

		int s1;

    s1 = x.IndexOf(' ');
		while (s1 != -1) {
			x = x.Substring(s1 + 1);
			Console.WriteLine(x);
			s1 = x.IndexOf(' ');
		}
  	//Console.WriteLine(x.Substring(s1));
	}
}