using System;

class Program {
	public static void Main() {
		
		Console.WriteLine("figite dois valores separados por virgula:");

		string[] v = Console.ReadLine().Split(',');

		int i = int.Parse(v[0]);
		int k = int.Parse(v[1]);

		Console.WriteLine(Soma(i, k));
	}
	public static int Soma(int inicio, int fim) {
		
		int l = 0;
		int s1 = 0;

		while (l != fim){

			s1 += inicio;
			inicio += 1;
			l += 1;
			
		}
		return s1;
		
	}
}