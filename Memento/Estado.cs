using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento_DesignPattern_2.Memento
{
    public class Estado
    {
        public Contrato Contrato { get; set; }

        public Estado(Contrato contrato)
        {
            this.Contrato = contrato;
        }

    }
}
