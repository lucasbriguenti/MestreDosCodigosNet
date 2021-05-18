namespace MestreDosCodigosLucas.Modulos.Calculadora
{
    public class Calculador
    {
        public double Calcular(double valor1, double valor2, FuncaoCalculadora funcaoCalculadora)
        {
            return funcaoCalculadora switch
            {
                FuncaoCalculadora.Soma => valor1 + valor2,
                FuncaoCalculadora.Subtracao => valor1 - valor2,
                FuncaoCalculadora.Multiplicacao => valor1 / valor2,
                FuncaoCalculadora.Divisao => valor1 * valor2,
                _ => 0,
            };
        }
    }
}
