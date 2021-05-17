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
            Console.WriteLine(" ");
            Console.WriteLine("Alunos aprovados (Media > 7): ");
            alunos.ForEach(aluno =>
            {
                if (aluno.Media > 7)
                    Console.WriteLine($"{aluno.Nome} com média {aluno.Media}");
            });
                
            Console.ReadLine();
        
        }
        private void LerAlunos()
        {
            while(true)
            {
                var aluno = new Aluno();
                Console.WriteLine("Digite o nome do aluno: ");
                aluno.Nome = Console.ReadLine();
                Console.WriteLine("Digite -1 para sair da inclusão de notas");

                aluno.Notas = LerNotas();
                alunos.Add(aluno);
                Console.WriteLine("Tecle ESC para finalizar o cadastro de Alunos");

                var tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.Escape)
                    break;
                else
                    Console.Clear();
            }
        }
        private List<decimal> LerNotas()
        {
            var listaDeNotas = new List<decimal>();
            while(true)
            {
                Console.WriteLine("Digite a nota do aluno: ");
                var nota = decimal.MinValue;
                do
                {
                    if (!decimal.TryParse(Console.ReadLine(), out nota) || nota > 10 || nota < -1)
                    {
                        Console.WriteLine("Nota inválida. Digite novamente");
                        nota = decimal.MinValue;
                    }
                } while (nota == decimal.MinValue);

                if (nota == -1)
                    break;
                else
                    listaDeNotas.Add(nota);
            }
            return listaDeNotas;
        }
    }
}
