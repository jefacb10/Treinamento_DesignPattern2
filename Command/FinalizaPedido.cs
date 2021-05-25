using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento_DesignPattern_2.Command
{
    public class FinalizaPedido : IComando
    {
        public Pedido Pedido { get; private set; }

        public FinalizaPedido(Pedido pedido)
        {
            this.Pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine("Pedido de " + this.Pedido.Nome + " finalizado com sucesso.");
            this.Pedido.Finaliza();
        }
    }
}
