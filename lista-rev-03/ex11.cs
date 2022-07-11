using System; 

class Program {
	public static void Main (string[] args) {

		Console.WriteLine("Digite a nome e o numero");
		string v = Console.ReadLine();
		int s1 = 0;

		foreach (char d in v){
			switch(d){
				case '1': s1 += 1; break;
				case '2': s1 += 2; break;
				case '3': s1 += 3; break;
				case '4': s1 += 4; break;
				case '5': s1 += 5; break;
				case '6': s1 += 6; break;
				case '7': s1 += 7; break;
				case '8': s1 += 8; break;
				case '9': s1 += 9; break;	
			}
		}
		Console.WriteLine(s1);
	}
}