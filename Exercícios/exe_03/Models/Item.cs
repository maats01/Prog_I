using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace __ex_03.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public float Valor { get; set; }
        public int NroComodos { get; set; }
        public int IdCategoria { get; set; }
        public int IdLocalidade { get; set; }
        public int IdVenda { get; set; }
    }
}