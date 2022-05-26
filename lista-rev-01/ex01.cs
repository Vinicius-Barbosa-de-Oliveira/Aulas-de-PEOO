using System;
class Program {
	static void Main (string[] args) {
		int a, b; double c; string d;
		a = 7;
		b = 3;
		c = 4.0;
		d = "5";

		Console.WriteLine("a = {0}, b = {1}", a, b);
		Console.WriteLine("a + b =" + (a + b));
		Console.WriteLine("{0}{1}{0}{2}{0}{3}", a, b, c, d);
		Console.WriteLine("{0} / {1} = {2:0.00}", a + b, d, (a + b) / c);
		Console.WriteLine(a + b + (a + b)/ b + c);
	}
}