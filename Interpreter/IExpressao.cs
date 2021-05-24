using System;
using System.Collections.Generic;
using System.Text;
using Treinamento_DesignPattern_2.Visitor;

namespace Treinamento_DesignPattern_2.Interpreter
{
    public interface IExpressao
    {
        int Avalia();
        void Aceita(Impressora impressora);
    }
}
