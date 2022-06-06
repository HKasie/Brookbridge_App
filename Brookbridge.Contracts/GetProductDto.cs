using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brookbridge.Contracts
{
    public class GetProductDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public bool Veg { get; set; }
    }
}
