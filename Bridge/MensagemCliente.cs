using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento_DesignPattern_2.Bridge
{
    public class MensagemCliente : IMensagem
    {
        public string Nome { get; private set; }
        public IEnviador Enviador { get ; set ; }

        public MensagemCliente(string nome)
        {
            this.Nome = nome;
        }

        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return String.Format("Mensagem para o cliente {0}", this.Nome);
        }
    }
}
