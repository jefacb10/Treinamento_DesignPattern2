using System;
using Treinamento_DesignPattern_2.Adapter;

namespace Treinamento_DesignPattern_2.Facade
{
    public class ContatoCliente
    {
        private Cliente cliente;
        private Cobranca cobranca;

        public ContatoCliente(Cliente cliente, Cobranca cobranca)
        {
            this.cliente = cliente;
            this.cobranca = cobranca;
        }

        internal void Dispara()
        {
            throw new NotImplementedException();
        }
    }
}