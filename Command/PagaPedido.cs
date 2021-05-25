using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento_DesignPattern_2.Command
{
    public class PagaPedido : IComando
    {
        public Pedido Pedido { get; private set; }

        public PagaPedido(Pedido pedido)
        {
            this.Pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine("Pedido de "+ this.Pedido.Nome +" pago com sucesso.");
            this.Pedido.Paga();
        }
    }
}
