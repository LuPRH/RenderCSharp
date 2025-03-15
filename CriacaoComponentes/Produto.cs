using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoComponentes
{
    public class Produto
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Desc { get; set; }
        public int Quant { get; set; }

        public Produto(string name, double price, string desc, int quant)
        {
            Name = name;
            Price = price;
            Desc = desc;
            Quant = quant;
        }
    }
}
