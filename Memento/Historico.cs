using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento_DesignPattern_2.Memento
{
    public class Historico
    {
        private IList<Estado> Estados = new List<Estado>();

        public Estado GetEstado(int index)
        {
            return this.Estados[index];
        }

        public void Adiciona(Estado estado)
        {
            this.Estados.Add(estado);
        }
    }
}
