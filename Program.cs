using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using Treinamento_DesignPattern_2.Bridge;
using Treinamento_DesignPattern_2.Factory;
using Treinamento_DesignPattern_2.Flyweight;
using Treinamento_DesignPattern_2.Interpreter;
using Treinamento_DesignPattern_2.Memento;
using Treinamento_DesignPattern_2.Visitor;

namespace Treinamento_DesignPattern_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Factory
            Console.WriteLine("-----FACTORY-----");
            IDbConnection conn = new ConnectionFactory().GetConnection();
            //conn.Close();
            Console.WriteLine("ConnectionString: "+ conn.ConnectionString);
            #endregion

            #region Flyweight
            Console.WriteLine("\n\n-----FLYWEIGHT-----");
            NotasMusicais notas = new NotasMusicais();
            IList<INota> listaNotas = new List<INota>()
            {
                notas.getNota("do"),
                notas.getNota("re"),
                notas.getNota("mi"),
                notas.getNota("fa"),
                notas.getNota("fa"),
                notas.getNota("fa"),

                notas.getNota("do"),
                notas.getNota("re"),
                notas.getNota("do"),
                notas.getNota("re"),
                notas.getNota("re"),
                notas.getNota("re"),

                notas.getNota("do"),
                notas.getNota("sol"),
                notas.getNota("fa"),
                notas.getNota("mi"),
                notas.getNota("mi"),
                notas.getNota("mi"),

                notas.getNota("do"),
                notas.getNota("re"),
                notas.getNota("mi"),
                notas.getNota("fa"),
                notas.getNota("fa"),
                notas.getNota("fa"),
            };

            Piano piano = new Piano();
            piano.Toca(listaNotas);

            #endregion

            #region Memento
            Console.WriteLine("\n\n-----MEMENTO-----");
            Historico historico = new Historico();

            Contrato contrato = new Contrato(DateTime.Now, "Jeferson", TipoContrato.Novo);
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            #endregion

            #region Interpreter
            Console.WriteLine("\n\n-----INTERPRETER-----");
            IExpressao esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));
            IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            IExpressao result = new RaizQuadrada(new Soma(new Numero(70), new Divisao(esquerda, direita)));
            Console.WriteLine("\n\n"+result.Avalia());

            //Utilizando o LinQ para realizar expressões
            Expression soma = Expression.Add(Expression.Constant(10), Expression.Constant(100));
            Func<int> interpreter = Expression.Lambda<Func<int>>(soma).Compile();
            Console.WriteLine("\nInterpreter da soma: " + interpreter());
            #endregion

            #region Visitor
            Console.WriteLine("\n\n-----VISITOR-----\n\n");
            Impressora impressora = new Impressora();
            result.Aceita(impressora);
            Console.WriteLine("\n");
            #endregion

            #region Bridge
            Console.WriteLine("\n\n-----BRIDGE-----\n");

            IMensagem mensagem = new MensagemAdministrativa("Jeferson");
            IEnviador enviador = new EnviaPorSMS();
            mensagem.Enviador = enviador;
            mensagem.Envia();

            #endregion
        }
    }
}
