using System;
using System.Collections.Generic;

namespace MestreDosCodigosLucas.Modulos.Alunos
{
    public class AlunosModulo : Modulo
    {
        private List<Aluno> alunos = new List<Aluno>();
        public void Executar()
        {
            LerAlunos();
            ExibirResultado();
        }
        private void ExibirResultado()
        {
            Console.Clear();
            Console.WriteLine("Alunos aprovados (Nota > 7): ");
            foreach (var aluno in alunos)
                if(aluno.Nota > 7)
                    Console.WriteLine($"{aluno.Nome} com nota {aluno.Nota}");
            Console.ReadLine();
        }
        private void LerAlunos()
        {
            while(true)
            {
                var aluno = new Aluno();
                Console.WriteLine("Digite o nome do aluno: ");
                aluno.Nome = Console.ReadLine();
                Console.WriteLine("Digite a nota do aluno: ");
                var nota = 0m;
                do
                {
                    if (!decimal.TryParse(Console.ReadLine(), out nota) || nota > 10)
                    {
                        Console.WriteLine("Nota inválida. Digite novamente");
                        nota = 0;
                    }
                } while (nota == 0);
                aluno.Nota = nota;
                alunos.Add(aluno);
                Console.WriteLine("Tecle ESC para finalizar o cadastro de Alunos");

                var tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.Escape)
                    break;
                else
                    Console.Clear();
            }
        }
    }
}
