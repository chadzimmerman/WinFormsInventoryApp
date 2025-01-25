using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsInventoryApp
{
    public class Product
    {
        public required BindingList<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public int Inventory { get; set; }
        public int Min {  get; set; }
        public int Max { get; set; }

        public Product() 
        {
            AssociatedParts = new BindingList<Part>();
        }

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }
        public bool RemoveAssociatedPart(int partId)
        {
            var associatedPartToRemove = AssociatedParts.FirstOrDefault(p => p.PartID == partId);
            if (associatedPartToRemove != null)
            {
                AssociatedParts.Remove(associatedPartToRemove);
                return true;
            }
            return false;
        }
        public Part LookupAssociatedPart(int partId)
        {
            var partToLookup = AssociatedParts.FirstOrDefault(p => p.PartID == partId);
            if (partToLookup != null)
            {
                return partToLookup;
            }
            else
            {
                throw new Exception("No matching associated part found.");
            }
        }
    }
}
