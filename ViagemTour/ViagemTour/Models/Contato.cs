using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViagemTour.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public  string Email { get; set; }
        public string Mensagem { get; set; }
    }
}