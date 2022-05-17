using System;
class Program {
	public static void Main () {
		
    double x = double.Parse(Console.ReadLine());
        
    const double pi = 3.14159;
        
    double form = (4.0/3.0) * pi * (x * x * x);
        
    Console.WriteLine($"VOLUME = {form:0.000}");
	}
}