using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MeuTeste.Models;

namespace MeuTeste.Models
{
    public class Viagem
    {
        [Key]
        public int ID_Viagem { get; set; }
        public string destino { get; set; }
        public DateTime data { get; set; }
        public int passagem { get; set; }
       
        public virtual Cliente Cliente {get; set;}
        
    }
}
