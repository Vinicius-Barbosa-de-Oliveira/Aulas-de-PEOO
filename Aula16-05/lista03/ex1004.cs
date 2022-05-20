using System;
class Program {
	public static void Main () {
		
		Console.WriteLine("Digite o valor");	
    int x = int.Parse(Console.ReadLine());
		Console.WriteLine("Digite o valor");
    int y = int.Parse(Console.ReadLine());
    
    int prod = (x * y);
    Console.WriteLine($"PROD = {prod}");

	}
}