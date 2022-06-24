using System;

class Program {
	public static void Main (string[] args) {

		Console.WriteLine("Digite seu nomme:");
		string nome = Console.ReadLine();
		string[] x = nome.ToLower().Split();

		Console.WriteLine(x[0]);		

		string r = "";
		string y = "";

		foreach (string s in x) {

			switch (s) {
				case "da": case "do": case "de": case "dos": case "das": case "e": r = r + s + " "; break;
				default:
					if (s != "")
					r = r + s.Substring(0, 1).ToUpper() + s.Substring(1) + " "; break;
			}
		}
		Console.WriteLine(r);
		foreach (string k in x) {

			//if (k != "")
			//	y = y + k.Substring(0, 1).ToUpper();	
			switch (k) {
				case "da": case "do": case "de": case "dos": case "das": case "e": y = y + k + " "; break;
				default:
					if (k != "")
					y = y + k.Substring(0, 1).ToUpper(); break;
			}
			
		}
		Console.WriteLine(y);
	}
}