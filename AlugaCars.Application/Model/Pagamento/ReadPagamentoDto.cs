using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlugaCars.Application.Model.Pagamento
{
    public class ReadPagamentoDto
    {
        public int ReservaId { get; set; }
        public decimal Quantia { get; set; }
        public DateTime DataPagamento { get; set; }
        public string MetodoPagamento { get; set; }
    }
}
