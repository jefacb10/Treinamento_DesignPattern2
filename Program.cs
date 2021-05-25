using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using Treinamento_DesignPattern_2.Adapter;
using Treinamento_DesignPattern_2.Bridge;
using Treinamento_DesignPattern_2.Command;
using Treinamento_DesignPattern_2.Facade;
using Treinamento_DesignPattern_2.Factory;
using Treinamento_DesignPattern_2.Flyweight;
using Treinamento_DesignPattern_2.Interpreter;
using Treinamento_DesignPattern_2.Memento;
using Treinamento_DesignPattern_2.Singleton;
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

            #region Command
            Console.WriteLine("\n\n-----COMMAND-----\n");

            FilaDeTrabalho filaDeTrabalho = new FilaDeTrabalho();
            Pedido p1 = new Pedido("Jeferson",300.0);
            Pedido p2 = new Pedido("Maria", 200.0);
            filaDeTrabalho.Adiciona(new PagaPedido(p1)); 
            filaDeTrabalho.Adiciona(new PagaPedido(p2));

            filaDeTrabalho.Adiciona(new FinalizaPedido(p1));
            filaDeTrabalho.Processa();

            #endregion

            #region Adapter
            Console.WriteLine("\n\n-----ADAPTER-----\n");
            Cliente cliente1 = new Cliente();
            cliente1.Nome = "Maria Teresa";
            cliente1.Endereco = "Rua dos Limoeiros";
            cliente1.DataNasc = DateTime.Parse("1991-02-18");

            IGerador geradorDeXml = new GeradorDeXml();
            Console.WriteLine(geradorDeXml.Gera(cliente1));

            Cliente cliente2 = new Cliente();
            cliente2.Nome = "Augusto Barros";
            cliente2.Endereco = "Rua dos Eucaliptos";
            cliente2.DataNasc = DateTime.Parse("1995-05-20");

            IGerador geradorDeJson = new GeradorDeJson();
            Console.WriteLine(geradorDeJson.Gera(cliente2));

            #endregion

            #region Facade
            Console.WriteLine("\n\n-----FAÇADE-----\n");

            Cliente cliente3 = new EmpresaFacade().BuscaCliente("1234");
            Console.WriteLine(cliente3.Nome);

            #endregion

            #region Singleton
            Console.WriteLine("\n\n-----SINGLETON-----\n");

            Cliente cliente4 = new EmpresaFacadeSingleton().Instancia.BuscaCliente("4321");
            Console.WriteLine(cliente4.Endereco);
            #endregion
        }
    }
}
