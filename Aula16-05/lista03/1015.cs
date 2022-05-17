using System;
class Program {
	public static void Main() {

		string[] x = Console.ReadLine().split(' ');
		string[] s = Console.ReadLine().split(' ');
		double a1 = double.Parse(x[0]);
		double b1 = double.Parse(s[0]);
		double a2 = double.Parse(x[1]);
		double b2 = double.Parse(s[1]);

		double cal1 = (a1 - a2) * (a1 - a2);
		double cal2 = (b1 - b2) * (b1 - b2);
		double result = cal1 + cal2;
	}
}