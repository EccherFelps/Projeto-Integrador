using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JovemProgramador.Models
{
    public class EventoModel
    {



        public int Id { get; set; }
        public string Nome { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Contato { get; set; }
        public string Sobre { get; set; }
        public DateTime Data { get; set; }
        public string Capacidade { get; set; }
    }
}
