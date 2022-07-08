using System; 

class Program {
	public static void Main (string[] args) {

		int a = 1;
		int b = 0;
		while (a <= 30) {
			Console.WriteLine(a);
			b += a;
			a++;
			Console.WriteLine(a);
			b += a;
			a++;
			Console.WriteLine(a);
			b += a;
			Console.WriteLine(b);
			a++;
			b = 0;
		}
	}
}