using System;
class Program {
	public static void Main() {
		
		Console.WriteLine("Digite a primeira nota");
		double x = double.Parse(Console.ReadLine());
		Console.WriteLine("Digite a segunda nota");
    double y = double.Parse(Console.ReadLine());

		double a = (x * 3.5);
		double b = (y * 7.5);
        
    double med = (a + b) / 11;
    Console.WriteLine($"MEDIA = {med:0.00000}");
	}
}