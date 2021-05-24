using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento_DesignPattern_2.Bridge
{
    public class EnviaPorEmail : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviando mensagem por e-mail.");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
