using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViagemTour.Models
{
    public class Promocao
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public int QuantidadeDias { get; set; }
        public string Hospedagem { get; set; }
        public string CafeDaManha { get; set; }
        public string PassagemAerea { get; set; }
        public float Preco { get; set; }
    }
}
