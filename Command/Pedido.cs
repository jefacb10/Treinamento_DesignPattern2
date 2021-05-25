using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento_DesignPattern_2.Command
{
    public class Pedido
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }
        public DateTime DataFinalizado { get; set; }
        public Status Status { get; private set; }

        public Pedido(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
            this.Status = Status.Novo;
        }

        public void Paga()
        {
            this.Status = Status.Pago;
        }

        public void Finaliza()
        {
            this.Status = Status.Entregue;
            this.DataFinalizado = DateTime.Now;
        }

    }
}
