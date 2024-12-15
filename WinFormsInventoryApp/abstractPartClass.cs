using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsInventoryApp
{
    internal abstract class abstractPartClass 
    {
        public int PartID { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }
}
