using System;

namespace MestreDosCodigosLucas.Modulos.Funcionarios
{
    public class FuncionariosModulo : Modulo
    {
        private Funcionario[] funcionarios;
        private int tamanhoLogico = 0;
        public void Executar()
        {
            funcionarios = new Funcionario[100];
            LerFuncionarios();
            ExibirResultado();
        }
        private void ExibirResultado()
        {
            var funcionarioMaiorSalario = funcionarios[0];
            var funcionarioMenorSalario = funcionarios[0];
            for (int i = 0; i < tamanhoLogico; i++)
            {
                if (funcionarios[i].Salario > funcionarioMaiorSalario.Salario)
                    funcionarioMaiorSalario = funcionarios[i];
            }

            var b = 0;
            while(b < tamanhoLogico)
            {
                if (funcionarios[b].Salario < funcionarioMenorSalario.Salario)
                    funcionarioMenorSalario = funcionarios[b];
                b++;
            }

            Console.WriteLine($"Funcionario com o maior salário {funcionarioMaiorSalario.Nome} com o salário: {funcionarioMaiorSalario.Salario}");
            Console.WriteLine($"Funcionario com o menor salário {funcionarioMenorSalario.Nome} com o salário: {funcionarioMenorSalario.Salario}");
            Console.ReadKey();
            Console.Clear();
        }
        private void LerFuncionarios()
        {
            while (true)
            {
                var funcionario = new Funcionario();
                Console.WriteLine("Digite o nome do Funcionario: ");
                funcionario.Nome = Console.ReadLine();
                Console.WriteLine("Digite o salário do Funcionario: ");
                var salario = 0m;
                do
                {
                    if (!decimal.TryParse(Console.ReadLine(), out salario))
                    {
                        Console.WriteLine("Número inválido. Digite novamente: ");
                        salario = 0;
                    }
                } while (salario == 0);
                funcionario.Salario = salario;

                AdicionarFuncionario(funcionario);

                Console.WriteLine("Tecle ESC para finalizar o cadastro de Funcionarios");

                var tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.Escape)
                    break;
                else
                    Console.Clear();
            }
        }
        private void AdicionarFuncionario(Funcionario funcionario)
        {
            funcionarios[tamanhoLogico++] = funcionario;
        }
    }
}
