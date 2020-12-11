using System;

class MainClass {
  public static void Main (string[] args) {
		string nome, email, senha;
		long telefone=0;
		int opcao=1;
		bool fecha = false;
		char continuar;

		Acesso novoAcesso = new Acesso();
		//Console.WriteLine(novoAcesso.getCadastros());

		while (!fecha) {
			switch (opcao) {
				case 1: //cadastro
					do {
						novoAcesso.addCadastro(Cadastro.Cadastrar());
						Console.Clear();
						Console.WriteLine("\nSeu cadastro foi realizado com sucesso! Deseja realizar um novo cadastro? (s/n)");
						continuar = char.Parse(Console.ReadLine());
					} while (continuar == 's');

					break;
				case 2: //login
					do {
						Console.Clear();
						Console.WriteLine("\nRealize o login abaixo:\n");
						Console.Write("E-mail >> ");
						email = Console.ReadLine();
						Console.Write("Senha >> ");
						senha = Console.ReadLine();
						Console.Clear();
					} while (!novoAcesso.validaAcesso(email, Md5.Hash(senha))); //valida acesso email+senha
					Console.WriteLine("\nOs dados estão corretos. SEJA BEM-VINDO(A)!");

					break;
				case 3: //lista cadastros
					//construção
					break;

				case 0: //fecha
					fecha = true;
					break;

				break;
			}

			if (opcao > 0) {
				Console.Clear();
				try {
					Console.WriteLine("*** Escolha uma opção ***\n   1 Novo usuário\n   2 Login\n   3 Usuários\n   0 Sair");
					opcao = int.Parse(Console.ReadLine());
				} catch (FormatException) {
					Console.WriteLine("Digite uma opção válida!");
				}
			}
		}

  }
}