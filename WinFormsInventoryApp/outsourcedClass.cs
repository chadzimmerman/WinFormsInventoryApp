using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsInventoryApp
{
    internal class outsourcedClass : Part
    {
        public required string CompanyName { get; set; }

        //public override string DynamicInfo => $"Company: {CompanyName}";
    }
}
