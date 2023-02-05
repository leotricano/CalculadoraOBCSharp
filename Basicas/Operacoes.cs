using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Basicas
{
    internal class Operacoes
    {
    public Soma Soma { get; private set; }
    public Subtracao Subtracao { get; private set; }
    public Multiplicador Multiplicador { get; private set; }
    public Divisao Divisao { get; private set; }
    public Operacoes()
        {
            this.Soma = new Soma();
            this.Subtracao = new Subtracao();
            this.Multiplicador = new Multiplicador();
            this.Divisao = new Divisao();
        }
    }
}
