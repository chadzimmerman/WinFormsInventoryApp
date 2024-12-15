using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsInventoryApp
{
    internal class productClass
    {
        public BindingList<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min {  get; set; }
        public int Max { get; set; }
        public static void AddAssociatedPart(Part)
        {

        }
        public static bool RemoveAssociatedPart(int)
        {

        }
        public static Part AddAssociatedPart(int)
        {

        }
    }
}
