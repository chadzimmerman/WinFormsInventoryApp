using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinFormsInventoryApp
{
    internal class inventoryClass
    {
        public required BindingList<Product> Products { get; set; }
        public required BindingList<Part> AllParts { get; set; }

        public inventoryClass() 
        {
            Products = new BindingList<Product>();
            AllParts = new BindingList<Part>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public bool RemoveProduct(int productId)
        {
            var productToRemove = Products.FirstOrDefault(p => p.ProductID == productId);
            if (productToRemove != null)
            {
                Products.Remove(productToRemove);
                return true;
            }
            return false;
        }
        public Product LookupProduct(int productId)
        {
            var productToLookup = Products.FirstOrDefault(p => p.ProductID == productId);
            if (productToLookup != null)
            {
                return productToLookup;
            } 
            else 
            {
                throw new Exception("No matching product found.");
            }
        }
        public void UpdateProduct(int productId, string newName, int newInventory, decimal newPrice, int newMin, int newMax)
        {
            var productToLookup = Products.FirstOrDefault(p => p.ProductID == productId);
            if (productToLookup != null)
            {
                productToLookup.Name = newName;
                productToLookup.Price = newPrice;
                productToLookup.Inventory = newInventory;
                productToLookup.Min = newMin;
                productToLookup.Max = newMax;

                MessageBox.Show("Product updated successfully.");
            }
            else
            {
                MessageBox.Show("Product not found.");
            }
        }
        public void AddPart(Part part)
        {
            AllParts.Add(part);
        }
        public bool DeletePart(int partId)
        {
            var partToRemove = AllParts.FirstOrDefault(p => p.PartID == partId);
            if (partToRemove != null)
            {
                AllParts.Remove(partToRemove);
                return true;
            }
            return false;
        }
        public Part LookupPart(int partId)
        {
            var partToLookup = AllParts.FirstOrDefault(p => p.PartID == partId);
            if (partToLookup != null)
            {
                return partToLookup;
            }
            else
            {
                throw new Exception("No matching part found.");
            }
        }
        public void UpdatePart(int partId, string newName, int newInventory, decimal newPrice, int newMin, int newMax )
        {
            var partToLookup = AllParts.FirstOrDefault(p => p.PartID == partId);
            if (partToLookup != null)
            {
                partToLookup.Name = newName;
                partToLookup.Price = newPrice;
                partToLookup.Inventory = newInventory;
                partToLookup.Min = newMin;
                partToLookup.Max = newMax;

                MessageBox.Show("Part updated successfully.");
            }
            else
            {
                MessageBox.Show("Part not found.");
            }
        }
    }
}
