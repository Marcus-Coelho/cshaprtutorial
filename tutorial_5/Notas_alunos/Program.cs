namespace Notas_alunos
{
    class MyClass
    {
        static void Main(string[] args)
        {
            Aluno[] todosAlunos = new Aluno[5];
            var indiceAluno = 0;

            string opcaoUsuario = obterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")

            {
                switch (opcaoUsuario)

                {
                    case "1":
                        Console.WriteLine("INSERIR NOME E NOTA DO ALUNO ESCOLHIDO\n");
                        Console.WriteLine("Digite o nome do aluno");
                        Aluno dadosAluno = new Aluno(); //instanciando o objeto dadosAluno

                        dadosAluno.Nome = Console.ReadLine();

                        Console.WriteLine();
                        Console.WriteLine("Digite a nota do aluno");

                        if (decimal.TryParse(Console.ReadLine(), out decimal Nota)) //verifica se o que foi digitado é possível de se trasnsformar em 
                                                                                    // decimal, se possível a saída (out) é decimal e a variável 
                                                                                    // se chama Nota, que já recebe o valor digitado
                        {
                            dadosAluno.Nota = Nota;
                        }

                        else
                        {
                            throw new ArgumentException("Valor inválido, tente novamente\n"); //tentar implementar algo mais eficiente no sentido de
                            //haver uma verificação anterior que impeça a saída do programa.
                        }

                        Console.WriteLine();
                        todosAlunos[indiceAluno] = dadosAluno;
                        indiceAluno++;


                        break;
                    case "2":
                        Console.WriteLine("listar aluno escolhido\n");
                        Console.WriteLine();

                        foreach (var a in todosAlunos) // vai pegar para cada elemento existente o nome e a nota dos alunos e listar
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {

                                Console.WriteLine($"ALUNO: {a.Nome} - NOTA {a.Nota}");

                            }

                        }


                        break;
                    case "3":
                        Console.WriteLine("Calcular a média escolhido\n");

                        decimal notaTotal = 0;
                        int numeroAlunos = 0;
                        for (int i = 0; i < todosAlunos.Length; i++)

                        {
                            if (!string.IsNullOrEmpty(todosAlunos[i].Nome))
                            {
                                notaTotal = notaTotal + todosAlunos[i].Nota;
                                numeroAlunos++;
                            }
                        }


                        decimal mediageral = notaTotal / numeroAlunos;

                        Console.WriteLine("a média geral é: " + mediageral);

                        Conceito ConceitoGeral;


                        if (mediageral > 0 && mediageral <= 2)
                        {
                            ConceitoGeral = Conceito.E;
                        }

                        else if (mediageral <= 4)
                        {
                            ConceitoGeral = Conceito.D;
                        }

                        else if (mediageral <= 6)
                        {
                            ConceitoGeral = Conceito.C;
                        }

                        else if (mediageral <= 8)
                        {
                            ConceitoGeral = Conceito.B;
                        }

                        else
                        {
                            ConceitoGeral = Conceito.A;
                        }

                        Console.WriteLine();
                        Console.WriteLine("o conceito da turma é: " + ConceitoGeral);

                        break;

                    default:
                        Console.WriteLine("Opção inválida!\n");
                        break;
                }

                opcaoUsuario = obterOpcaoUsuario();

            }

            Console.WriteLine("ENCERRANDO PROGRAMA");
        }

        private static string obterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("MENU INICIAL:");
            Console.WriteLine("informe a opção desejasa:");
            Console.WriteLine("1-Inserir novo Aluno");
            Console.WriteLine("2-Listar alunos");
            Console.WriteLine("3-Calcular a média geral dos alunos");
            Console.WriteLine("X - sair");
            Console.WriteLine();
            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }




}



