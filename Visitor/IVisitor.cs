using System;
using System.Collections.Generic;
using System.Text;
using Treinamento_DesignPattern_2.Interpreter;

namespace Treinamento_DesignPattern_2
{
    public interface IVisitor
    {
        void ImprimeSoma(Soma soma);
        void ImprimeSubtracao(Subtracao subtracao);
        void ImprimeMultiplicacao(Multiplicacao multiplicacao);
        void ImprimeDivisao(Divisao divisao);
        void ImprimeRaizQuadrada(RaizQuadrada raizQuadrada);
        void ImprimeNumero(Numero numero);
    }
}
