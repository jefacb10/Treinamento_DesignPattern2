using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento_DesignPattern_2.Bridge
{
    public class MensagemAdministrativa : IMensagem
    {
        public string Nome { get; private set; }
        public IEnviador Enviador { get ; set ; }

        public MensagemAdministrativa(string nome)
        {
            this.Nome = nome;
        }

        public void Envia()
        {
            Enviador.Envia(this);  
        }

        public string Formata()
        {
            return String.Format("Enviando mensagem para o administrador {0}", this.Nome);
        }
    }
}
