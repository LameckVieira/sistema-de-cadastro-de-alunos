using System;

namespace sistema_de_cadastro_de_alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();

            Console.WriteLine("Digite o nome do aluno: ");
            aluno1.nome = Console.ReadLine();

            Console.WriteLine("Digite o RG do aluno:");
            aluno1.rg = Console.ReadLine();
            
            Console.WriteLine("Digite o idade do aluno:");
            aluno1.idade = Console.ReadLine();

            Console.WriteLine("Digite o média do aluno:");
            aluno1.mediaFinal = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valo da mensalidade do aluno:");
            aluno1.valorMensalidade = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite se o Aluno for bolsista:");
            string resposta = Console.ReadLine();
            if(resposta == "s"){
                aluno.bolsista = true;  
            }else{
                aluno.bolsista = false;
            }

            //menu

            do
            {
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("[1] - ver Média do aluno");
                Console.WriteLine("[2] - ver Mensalidade do aluno");
                Console.WriteLine("[0] - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"A média final do aluno {aluno.nome} = {aluno.VerMediaAluno()}");
                        break;
                    case 2:
                        Console.WriteLine($"O valor damensalidade do aluno fiv=ca em: {aluno.VerMensalidade()}");
                        break;
                    case 0:
                        Console.WriteLine("Obrigado por acessar!");
                        break;
                    default:
                        Console.WriteLine("!Opção invalida!")
                        break;
                }
                    
            } while (opcao != 0);


        }
    }       
}
