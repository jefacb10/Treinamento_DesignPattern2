using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento_DesignPattern_2.Flyweight
{
    public class Piano
    {
        public void Toca(IList<INota> notas)
        {
            foreach(var nota in notas)
            {
                Console.Beep(nota.Frequencia, 300);
                Console.Write(nota.GetType().Name + ", ");
            }
        }
    }
}
