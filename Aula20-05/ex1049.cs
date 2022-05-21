using System;
class Program{
	public static void Main () {

		Concole.WriteLine("digite as caracteristicas");
		string c1 = Console.ReadLine();
		string c2 = Console.ReadLine();
		string c3 = Console.ReadLine();

		if (c1 == vertebrado) {
			if (c2 == ave) {
				if (c3 == carnivoro) Console.WriteLine("aguia");
				if (c3 == onivoro) Console.WriteLine("Pomba");
			}
			if (c2 == mamifero) {
				if (c3 == onivoro) Console.WriteLine("homem");
				if (c3 == herbivoro) Console.WriteLine("vaca");
			}
		}
		if (c2 == invertebrado) {
			if (c2 == inseto) {
				if (c3 == hematofago) Console.WriteLine("pulga");
				if (c3 == herbivoro) Consoel.WriteLine("lagarta");
			}
			if (c2 == anelideo) {
				if (c3 == hematofago) Console.WriteLine("sanguessuga");
				if (c3 == onivoro) Console.WriteLine("minhoca");
			}
		}
	}
}