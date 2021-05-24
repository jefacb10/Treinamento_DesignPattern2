using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento_DesignPattern_2.Flyweight
{
    public class NotasMusicais
    {
        public static IDictionary<string, INota> notas = new Dictionary<string, INota>() {
            { "do", new Do() },
            { "re", new Re() },
            { "mi", new Mi() },
            { "fa", new Fa() },
            { "sol", new Sol() },
            { "la", new La() },
            { "si", new Si() },
        };

        public INota getNota(string nome)
        {
            return notas[nome];
        }
    }
}
