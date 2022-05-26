using System;
class Program {
	public static void Main (string[] args) {

		Console.WriteLine("Digite dez valores inteiros");

		string[] x = Console.ReadLine().Split();

		int s1 = int.Parse(x[0]);
		int s2 = int.Parse(x[1]);
		int s3 = int.Parse(x[2]);
		int s4 = int.Parse(x[3]);
		int s5 = int.Parse(x[4]);
		int s6 = int.Parse(x[5]);
		int s7 = int.Parse(x[6]);
		int s8 = int.Parse(x[7]);
		int s9 = int.Parse(x[8]);
		int s10 = int.Parse(x[9]);

		int maior = 0;

		if (s1 > s2) maior = s1;
		if (s2 > s3) maior = s2;
		if (s3 > s4) maior = s3;
		if (s4 > s5) maior = s4;
		if (s5 > s6) maior = s5;
		if (s6 > s7) maior = s6;
		if (s7 > s8) maior = s7;
		if (s8 > s9) maior = s8;
		if (s9 > s10) maior = s9;
		else {maior = s10;}
		Console.WriteLine("Maior valor = {0}", maior);

		int menor = 0;
		if (s10 > s9) menor = s9;
		else menor = s10;
		if (s9 > s8) menor = s8;
		if (s8 > s7) menor = s7;
		if (s7 > s6) menor = s6;
		if (s6 > s5) menor = s5;
		if (s5 > s4) menor = s4;
		if (s4 > s3) menor = s3;
		if (s3 > s2) menor = s2;
		if (s2 > s1) menor = s1;
		Console.WriteLine("menor valor = {0}", menor);
	}
}