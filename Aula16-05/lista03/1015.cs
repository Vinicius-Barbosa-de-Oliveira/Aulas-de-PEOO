using System;
class Program {
	public static void Main(string[] args) {
		
		Console.WriteLine("Digite os primeiros valores");
		string[] p = Console.ReadLine().Split(' ');
		Console.WriteLine("Digite os segundos valores");
		string[] s = Console.ReadLine().Split(' ');

		double x1 = double.Parse(p[0]);
		double y1 = double.Parse(s[0]);
		double x2 = double.Parse(p[1]);
		double y2 = double.Parse(s[1]);


		double cal1 = Math.Pow((x1 - y1), 2);
		double cal2 = Math.Pow((x2 - y2), 2);
		double result = Math.Sqrt(cal1 + cal2);
		
		Console.WriteLine($"{result:0.0000}");
	}
}