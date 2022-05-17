using System;
class Program {
	public static void Main() {
		
		double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());

		double a = (x * 3.5);
		double b = (y * 7.5);
        
    double med = (a + b) / 11;
    Console.WriteLine($"MEDIA = {med:0.00000}");
	}
}