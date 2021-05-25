using System;
using System.Collections.Generic;
using System.Text;
using Treinamento_DesignPattern_2.Facade;

namespace Treinamento_DesignPattern_2.Singleton
{
    public class EmpresaFacadeSingleton
    {
        private static EmpresaFacade _instancia = new EmpresaFacade();

        public EmpresaFacade Instancia { get { return _instancia; } }
    }
}
