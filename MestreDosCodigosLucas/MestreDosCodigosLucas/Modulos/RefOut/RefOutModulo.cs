using System;

namespace MestreDosCodigosLucas.Modulos.RefOut
{
    public class RefOutModulo : Modulo
    {
        public void Executar()
        {
            ExecutarRef();
            ExecutarOut();
            Console.ReadLine();
        }

        private void ExecutarRef()
        {
            Console.WriteLine("Somando com Ref");
            var valor = 1;
            var valorSomado = 2;
            SomarRef(valorSomado, ref valor);
            Console.WriteLine($"O valor somado usando ref é {valor}");
        }
        //Utilizando ref o que muda na variavel passada dentro do método é refletido na externa, não precisando retornar
        public void SomarRef(int valorSomado, ref int valor)
        {
            valor += 2;
        }

        private void ExecutarOut()
        {
            Console.WriteLine("Somando com Out");
            var valor = 1;
            var valorSomado = 2;
            int novoValor;
            SomarOut(valor, valorSomado, out novoValor);
            Console.WriteLine($"O valor somado usando out é {novoValor}");
        }
        //Com o out a variavel de saida só pode ser atribuida, então é necessário passar uma outra variavel para retornar
        private void SomarOut(int valor, int valorSomado, out int novoValor)
        {
            novoValor = valor + valorSomado;
        }
    }
}
