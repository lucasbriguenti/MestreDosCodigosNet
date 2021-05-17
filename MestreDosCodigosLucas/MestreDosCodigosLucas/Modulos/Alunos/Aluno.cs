using System;
using System.Collections.Generic;
using System.Linq;

namespace MestreDosCodigosLucas.Modulos.Alunos
{
    public class Aluno
    {
        public string Nome { get; set; }
        public List<decimal> Notas { get; set; }
        public decimal Media => Math.Round(Notas.Sum(x => x) / Notas.Count, 2);
    }
}
