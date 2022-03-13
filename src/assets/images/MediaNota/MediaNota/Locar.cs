using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNota
{
    class Locar
    {
        public int TempoLocacao;
        public double Valor;
        public DateTime DataLocacao;
        public DateTime DataDevolucao;
        public string Filme;
        public string Cpf;
        public double Saldo;
        public double Pagamento(double Valor)
        {
            return (Saldo += Valor);
        }
        public double ImprimirSaldo()
        {
            return Saldo;
        }
    }
}
