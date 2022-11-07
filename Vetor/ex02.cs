using System;

class Program {
	public static void Main () {
		int[] vetor = {10, 4, 6, 3, 8, 12, 15, 20}
		Console.WriteLine(array.IndexOf(vetor, 8));
		foreach (int i in vetor) {
			Console.WriteLine(i);
			
			for (int i = 7; i >= 0; i--)
				Console.WriteLine(i + " " + vetor[i]);

			for (int i = 0; i < vetor.Length; i += 2)
				Console.WriteLine(i + " " + vetor[i]);
		}
	}
}