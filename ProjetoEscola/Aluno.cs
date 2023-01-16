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
				Console.Write("Informe o nome: ");
				string nome = Console.ReadLine();
				Console.Write("Informe a Matricula: ");
			 	string matricula = Console.ReadLine();
				Console.write("Informe o Email");
				string email = Console.ReadLine();
				Console.Write("Informe o Id da Turma: ");
				int idturma = int.Parse(Console.ReadLine());
			
				Aluno a = new Aluno {
					Id = id, Nome = nome,	Matricula = matricula, Email = email, IdTurma = idturma 
				};
				
				NAluno.Inserir(t);
				break;
				
			case 2:
				foreach (Turma x in NAluno.Listar())
					Console.WriteLine(x);
				break;

			case 3: 
					NAluno.Salvar();
				break;
			case 4:
					NAluno.Abrir();
				break;
			}
			Console.WriteLine("---------------------------------------------");
			Console.WriteLine("1-Inserir, 2-Listar, 3-Salvar, 4-Abrir, 0-Fim");
			op = int.Parse(Console.ReadLine());
	}
}

public class Aluno {
	public int Id { get; set; }
	public string Nome { get; set; }
	public string Matricula { get; set; }
	public string Email { get; set; }
	public int IdTurma { get; set; }

	public override string ToString() {
		return $"{ID} - {Nome} - {Matricula} - {Email} - {IdTurma}";
	}
}

static class NAluno {
	private static List<Aluno> Alunos = new List<Aluno>();

	public static void Inserir(Aluno a) {
		Abrir();
		Alunos.Add(a);
		Salvar();
	}
	public static List<Aluno> Listar() {
		Abrir();
		return Alunos;
	}
	public static Turma Listar(int id)
  {
    // Encontra, se existir, uma turma com o id
    foreach (Aluno obj in Alunos)
      if (obj.Id == id) return obj;
    return null;
  }
	public static void Atualizar() {
		Abrir();
    Turma obj = Listar(a.Id);
		if (obj != null) {
			obj.Nome = a.Nome;
    	obj.Matricula = a.Matricula;
   	 	obj.Email = a.Email;
			obj.IdTurma = a.IdTurma;
		}
    Salvar();
	}
	public static void Excluir() {
		Abrir();
    Alunos.Remove(Listar(a.Id));
    Salvar();
	}
	public static void Abrir() {
		StreamReader s = null;
    
		try
    {
      XmlSerializer xml = new XmlSerializer(typeof(List<Aluno>));
      s = new StreamReader("./alunos.xml");
      alunos = (List<Aluno>)xml.Deserialize(s);
    }
    catch
    {
      alunos = new List<Aluno>();
    }
    if (s != null) s.Close();
	}
	public static void Salvar() {
		XmlSerializer xml = new XmlSerializer(typeof(List<Turma>));
    StreamWriter s = new StreamWriter("./alunos.xml", false);
    xml.Serialize(s, Alunos);
    s.Close();
	}
	public static void Matricula(Aluno a, Turma t) {
		a.IdTurma = t.Id;      
    Atualizar(a);
	}
	public static List<Aluno> Listar(Turma t) {
		Abrir(); // Abre a lista com todos os alunos
  	List<Aluno> diario = new List<Aluno>(); // Lista de alunos da turma t
    foreach (Aluno obj in alunos)
      if (obj.IdTurma == t.Id) diario.Add(obj);
    return diario;
	}
}