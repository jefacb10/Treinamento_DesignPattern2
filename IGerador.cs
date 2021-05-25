using System;
using System.Collections.Generic;
using System.Text;
using Treinamento_DesignPattern_2.Adapter;

namespace Treinamento_DesignPattern_2
{
    public interface IGerador
    {
        string Gera(Cliente cliente); 
    }
}
