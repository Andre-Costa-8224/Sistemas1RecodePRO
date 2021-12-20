using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MeuTeste.Models;

namespace MeuTeste.Models
{
    public class Cliente
    {
        [Key]
        public int ID_Cliente { get; set; }
        public string Nome { get; set; }
        public string data_nasc { get; set; }
        public string email { get; set; }
        public string cpf { get; set; }
        public int telefone { get; set; }
        public virtual ICollection<Viagem> viagens { get; set; }
    }
}
