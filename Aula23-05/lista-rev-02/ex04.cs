using System;
class Program {
	public static void Main (string[] args) {

		Console.WriteLine("Adicione o primeiro horario em hh:mm");
		string[] x = Console.ReadLine().Split(':');
		Console.WriteLine("Adicione o segundo horario em hh:mm");
		string[] y = Console.ReadLine().Split(':');

		int s1 = int.Parse(x[0]);
		int s2 = int.Parse(x[2]);
		int s3 = int.Parse(y[0]);
		int s4 = int.Parse(y[1]);

		var tempo = new TimeSpan(s1, s2, 00);
		var novohorario = new TimeSpan(s3, s4, 00);

		var result = tempo + novohorario;

		Console.WriteLine(result);
	}
}