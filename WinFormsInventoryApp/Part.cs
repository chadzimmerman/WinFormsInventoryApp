using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsInventoryApp
{
    public abstract class Part 
    {
        public int PartID { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public int Inventory { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        //public abstract string DynamicInfo { get; }
    }

    public class InHouse : Part
    {
        //public int MachineID { get; set; }
        //public override string DynamicInfo => $"Machine ID: {MachineID}";
    }

    public class OutsourcedPart : Part
    {
        //public int CompanyName { get; set; }
        //public override string DynamicInfo => $"Company: {CompanyName}";
    }
}