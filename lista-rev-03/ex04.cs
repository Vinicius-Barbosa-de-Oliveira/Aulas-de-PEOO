using System; 

class Program {
	public static void Main (string[] args) {

		int a = 1;
		while (a <= 30) {
			if (a % 3 == 0) Console.WriteLine(-a);
			else Console.WriteLine(a);
			a++;
		}
	}
}