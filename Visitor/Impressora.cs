using System;
using System.Collections.Generic;
using System.Text;
using Treinamento_DesignPattern_2.Interpreter;

namespace Treinamento_DesignPattern_2.Visitor
{
    public class Impressora : IVisitor
    {
        public void ImprimeDivisao(Divisao divisao)
        {
            Console.Write("( ");
            divisao.Esquerda.Aceita(this);
            Console.Write(" / ");
            divisao.Direita.Aceita(this);
            Console.Write(" )");
        }

        public void ImprimeMultiplicacao(Multiplicacao multiplicacao)
        {
            Console.Write("( ");
            multiplicacao.Esquerda.Aceita(this);
            Console.Write(" * ");
            multiplicacao.Direita.Aceita(this);
            Console.Write(" )");
        }

        public void ImprimeNumero(Numero numero)
        {
            Console.Write(numero.Valor);
        }

        public void ImprimeRaizQuadrada(RaizQuadrada raizQuadrada)
        {
            Console.Write("sqrt( ");
            raizQuadrada.Numero.Aceita(this);
            Console.Write(" )");
        }

        public void ImprimeSoma(Soma soma)
        {
            Console.Write("( ");
            soma.Esquerda.Aceita(this);
            Console.Write(" + ");
            soma.Direita.Aceita(this);
            Console.Write(" )");
        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("( ");
            subtracao.Esquerda.Aceita(this);
            Console.Write(" - ");
            subtracao.Direita.Aceita(this);
            Console.Write(" )");
        }
    }
}
