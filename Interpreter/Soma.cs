using System;
using System.Collections.Generic;
using System.Text;
using Treinamento_DesignPattern_2.Visitor;

namespace Treinamento_DesignPattern_2.Interpreter
{
    public class Soma : IExpressao
    {
        public IExpressao Esquerda { get; set; }
        public IExpressao Direita { get; set; }
        public Soma(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avalia()
        {
            var esquerda = Esquerda.Avalia();
            var direita = Direita.Avalia();
            return esquerda + direita;
        }

        public void Aceita(Impressora impressora)
        {
            impressora.ImprimeSoma(this);
        }
    }
}
