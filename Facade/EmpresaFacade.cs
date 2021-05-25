using System;
using System.Collections.Generic;
using System.Text;
using Treinamento_DesignPattern_2.Adapter;

namespace Treinamento_DesignPattern_2.Facade
{
    public class EmpresaFacade
    {
        public Cliente BuscaCliente(string cpf)
        {
            return new ClienteDAO().buscaClientePorCpf(cpf);
        }

        public Fatura CriaFatura(Cliente cliente, double valor)
        {
            Fatura fatura = new Fatura(cliente, valor);
            return fatura;
        }

        public Cobranca GeraCobranca(Fatura fatura)
        {
            Cobranca cobranca = new Cobranca(TipoCobranca.Boleto, fatura);
            cobranca.Emite();
            return cobranca;
        }

        public ContatoCliente FazContato(Cliente cliente, Cobranca cobranca)
        {
            ContatoCliente contato = new ContatoCliente(cliente, cobranca);
            contato.Dispara();
            return contato;
        }
    }
}
