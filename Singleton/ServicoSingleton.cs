using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento_DesignPattern_2.Singleton
{
    public class ServicoSingleton
    {
        private static Servico _servico = new Servico();

        public Servico Servico { get { return _servico; } }
    }
}
