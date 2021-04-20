using MestreDosCodigosPOOLucas.Modulos;
using MestreDosCodigosPOOLucas.Modulos.BancoModulo;
using MestreDosCodigosPOOLucas.Modulos.PessoaModulo;
using MestreDosCodigosPOOLucas.Modulos.TelevisaoModulo;
using System;

namespace MestreDosCodigosPOOLucas
{
    public class Program
    {
        private static Modulo _modulo = null;
        public static void Main(string[] args)
        {
            _modulo = new TelevisaoModulo();
            _modulo.Executar();
        }
    }
}
