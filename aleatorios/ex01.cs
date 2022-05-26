using System;
class Program {
	public static void Main (string[] args) {

		Console.WriteLine("valor:");
		int s1, s2;
			
		int x = int.Parse(Console.ReadLine());
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		s1 = 0;
		s2 = 0;
		
		if (a > b && a > x) {
			s1 += a;
		}
		if (b > x && b > a) {
			s1 += b;
		}
		if (x > a && x > b) {
			s1 += x;
		}
		if (a < b && a < x) {
			s2 += a;
		}
		if (b < x && b < a) {
			s2 += b;
		}
		if (x < a && x < b) {
			s2 += x;
		}
			
		Console.WriteLine(s1 + s2);
		
	}
}