using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento_DesignPattern_2.Bridge
{
    public interface IEnviador
    {
        void Envia(IMensagem mensagem);
    }
}
