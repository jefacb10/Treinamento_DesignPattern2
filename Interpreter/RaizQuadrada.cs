using System;
using System.Collections.Generic;
using System.Text;
using Treinamento_DesignPattern_2.Visitor;

namespace Treinamento_DesignPattern_2.Interpreter
{
    public class RaizQuadrada : IExpressao
    {
        public IExpressao Numero { get; set; }

        public RaizQuadrada(IExpressao numero)
        {
            this.Numero = numero;
        }

        public int Avalia()
        {
            var numero = Numero.Avalia();
            return Convert.ToInt32(Math.Sqrt(numero));
        }

        public void Aceita(Impressora impressora)
        {
            impressora.ImprimeRaizQuadrada(this);
        }
    }
}
