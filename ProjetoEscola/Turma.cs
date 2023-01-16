using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

class Program {
	public static void Main() {
		Console.WriteLine("---------------------------------------------");
		Console.WriteLine("1-Inserir, 2-Listar, 3-Salvar, 4-Abrir, 0-Fim");
		int op = int.Parse(Console.ReadLine());
		while (op != 0) {
			switch(op){
			case 1:
				Console.Write("Informe o ID: ");
				int id = int.Parse(Console.ReadLine());
				Console.Write("Informe o Curso: ");
				string curso = Console.ReadLine();
				Console.Write("Informe a Descrição da Turma: ");
			 	string descricao = Console.ReadLine();
				Console.Write("Informe o Ano Letivo: ");
				int anoletivo = int.Parse(Console.ReadLine());
			
				Turma t = new Turma {
					Id = id, Curso = curso,
					Descricao = descricao, AnoLetivo = anoletivo };
				
				NTurma.Inserir(t);
				break;
				
			case 2:
				foreach (Turma x in NTurma.Listar())
					Console.WriteLine(x);
				break;

			case 3: 
					NTurma.Salvar();
				break;
			case 4:
					NTurma.Abrir();
				break;
			}
			Console.WriteLine("---------------------------------------------");
			Console.WriteLine("1-Inserir, 2-Listar, 3-Salvar, 4-Abrir, 0-Fim");
			op = int.Parse(Console.ReadLine());
		}

		/*Turma t = new Turma {
			//Id = 1, Curso = "infoWeb",
			//Descricao = "2º ano", AnoLetivo = 2022 };

		//Classe Estática
		//NTurma.Inserir(t);

		//Classe Não estática
		//NTurma x = new Turma();
		// x.Inserir(t);
		
		//foreach (Turma x in NTurma.Listar())
			//Console.WriteLine(x);*/
		
	}
}


public class Turma {
	public int Id { get; set; }
	public string Curso { get; set; }
	public string Descricao { get; set; }
	public int AnoLetivo { get; set; }
	
	public override string ToString() {
		return $"{Id} - {Curso} - {Descricao} - {AnoLetivo}";
	}
}


static class NTurma {
	//private Truma[] turmas = new turma[10];
	private static List<Turma> turmas = new List<Turma>();

	public static void Inserir(Turma t) { // C - Create
		Abrir();
		turmas.Add(t);
		Salvar();
	}
	public static List<Turma> Listar() { // R - Read
		Abrir();
		return turmas;
	}
	public static Turma Listar(int id)
  {
    // Encontra, se existir, uma turma com o id
    foreach (turma obj in turmas)
      if (obj.Id == id) return obj;
    return null;
  }
	public static void Atualizar(Turma t) { // U - Update
		Abrir();
    Turma obj = Listar(t.Id);
		if (obj != null) {
			obj.Curso = t.Curso;
    	obj.Descricao = t.Descricao;
    	obj.AnoLetivo = t.AnoLetivo;
		}
    Salvar();
	}
	public static void Excluir(Turma t) { // D - Delete
		Abrir();
  	turmas.Remove(Listar(t.Id));
    Salvar();
	}
	public static void Abrir() {
    StreamReader f = null;
		
    try
    {
    	XmlSerializer xml = new XmlSerializer(typeof(List<Turma>));
  		f = new StreamReader("./turma.xml");
    	turmas = (List<Turma>)xml.Deserialize(f);
    }
    catch
    {
      turmas = new List<Turma>();
    }
      if (f != null) f.Close();
	}
	public static void Salvar() {
		XmlSerializer xml = new XmlSerializer(typeof(List<Turma>));
    StreamWriter f = new StreamWriter("./turma.xml", false);
    xml.Serialize(f, turmas);
    f.Close();
	}
}