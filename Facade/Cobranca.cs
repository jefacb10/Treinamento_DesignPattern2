using System;

namespace Treinamento_DesignPattern_2.Facade
{
    public class Cobranca
    {
        private TipoCobranca boleto;
        private Fatura fatura;

        public Cobranca(TipoCobranca boleto, Fatura fatura)
        {
            this.boleto = boleto;
            this.fatura = fatura;
        }

        internal void Emite()
        {
            throw new NotImplementedException();
        }
    }
}