using System;


namespace Conta_poup
{


    class Poupança
    {
        private decimal saldoPoup;
        private static double taxaDeJurosAnual;

        private const int MESES = 12;

        
        
        public Poupança()
        {
            saldoPoup = 0.0M;
            taxaDeJurosAnual = 0.0;
        }

       
       
       
        public Poupança(decimal saldoPoup)
        {
            this.saldoPoup= saldoPoup
            taxaDeJurosAnual = 0.0;
        }

        
        
        public decimal Saldo
        {
            get { return saldoPoupanca; }
            set { saldoPoupanca = value; }
        }

        
        public static double TaxaDeJuros
        {
            get { return taxaDeJurosAnual; }
            set { taxaDeJurosAnual = value; }
        }



        
        public decimal CalcularJuros()
        {
            decimal jurosMensal = (saldoPoup * (decimal)taxaDeJurosAnual) / MESES;
            return jurosMensal + saldoPoup;
        }

        
        
        public static void AlterarTaxaDeJuros(double taxaDeJuros)
        {
           
           
           taxaDeJurosAnual = taxaDeJuros;
        }
    }
}
