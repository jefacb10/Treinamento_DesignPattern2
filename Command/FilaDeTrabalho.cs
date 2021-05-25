using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento_DesignPattern_2.Command
{
    public class FilaDeTrabalho
    {
        public IList<IComando> Comandos { get; set; } = new List<IComando>();


        public void Adiciona(IComando comando)
        {
            this.Comandos.Add(comando);
        }

        public void Processa()
        {
            foreach(var comando in this.Comandos)
            {
                comando.Executa();
            }
        }
    }
}
