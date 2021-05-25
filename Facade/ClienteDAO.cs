using System;
using Treinamento_DesignPattern_2.Adapter;

namespace Treinamento_DesignPattern_2.Facade
{
    public class ClienteDAO
    {
        public ClienteDAO()
        {
        }

        public Cliente buscaClientePorCpf(string cpf)
        {
            return new Cliente()
            {
                Nome = "Teste Cliente",
                Endereco = "Rua do 0",
                DataNasc = DateTime.Parse("1990-01-05")
            };
        }
    }
}