using System;
using System.Text.RegularExpressions;

class Cadastro {
	private string nome, email, senha;
	private long telefone;

	public Cadastro(string n, string em, string s, long t) {
		nome = n;
		email = em;
		senha = s;
		telefone = t;
	}

	public string getEmail() {
		return email;
	}

	public string getSenha() {
		return senha;
	}

	//view Cadastro
	public static Cadastro Cadastrar() {
		string nome, email, senha;
		long telefone=0;
		bool validaTelefone = false;

    Console.Clear();
		Console.WriteLine("\nSeja bem-vindo(a)!\nPara se cadastrar, informe os dados abaixo:\n");

		do {
			Console.Write("Nome >> ");
			nome = Console.ReadLine();
		} while (!Cadastro.validaNome(nome)); //valida nome digitado

		do {
			Console.Write("E-mail >> ");
			email = Console.ReadLine();
		} while (!Cadastro.validaEmail(email)); //valida email digitado

		do {
			Console.Write("Telefone (somente números) >> ");
			try {
				telefone = long.Parse(Console.ReadLine());
				validaTelefone = true;
			} catch (FormatException) {
				Console.WriteLine("Digite um telefone válido!");
			}
		} while (!validaTelefone); //valida telefone digitado
		
		do {
			Console.Write("Senha (mín. 8 caracteres, 1 letra maiúscula, 1 letra minúscula e 1 caractere especial) >> ");
			senha = Console.ReadLine();
		} while (!Cadastro.validaSenha(senha)); //valida senha digitada

		//efetiva cadastro
		Cadastro novoCadastro = new Cadastro(nome, email, Md5.Hash(senha), telefone);

		return novoCadastro;
	}


	//validações
	public static bool validaNome(string n) {
		if (!string.IsNullOrEmpty(n) && !Regex.IsMatch(n, @"\d")) {
			return true;
		} else {
			Console.WriteLine("Digite um nome válido!");
			return false;
		}
	}

	public static bool validaEmail(string e) {
		if (!string.IsNullOrEmpty(e) && Regex.IsMatch(e, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250))) {
			return true;
		} else {
			Console.WriteLine("Digite um e-mail válido!");
			return false;
		}
	}
	
	public static bool validaSenha(string s) {
		if (!string.IsNullOrEmpty(s) && Regex.IsMatch(s, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$", 0, TimeSpan.FromMilliseconds(250))) {
			return true;
		} else {
			Console.WriteLine("A senha deve atender aos requisitos: mín. 8 caracteres, 1 letra maiúscula, 1 letra minúscula e 1 caractere especial!");
			return false;
		}
	}

}