using System;
using System.Collections.Generic;
using System.Text;
using Treinamento_DesignPattern_2.Visitor;

namespace Treinamento_DesignPattern_2.Interpreter
{
    public class Numero : IExpressao
    {
        public int Valor { get; private set; }

        public Numero(int numero)
        {
            this.Valor = numero;
        }

        public void Aceita(Impressora impressora)
        {
            impressora.ImprimeNumero(this);
        }

        public int Avalia()
        {
            return this.Valor;
        }
    }
}
