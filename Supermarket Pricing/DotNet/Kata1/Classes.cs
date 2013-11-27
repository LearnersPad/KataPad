using System;
using System.Collections.Generic;

namespace SuperMarketPricing
{
   public  class SuperMarketPricingItems
    {
       
    public class Product    
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public string UnitType { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
    }
    
    public class ProductStock
    {
        public string ProductId { get; set; }
        public double Quantity { get; set; }
    }

    public class Category
    {
        public string Name { get; set; }
        public string ParentCategory { get; set; }
    }

    public class Customer
    {
        public int CustId { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public double Points { get; set; }
    }

    public class Cart
    {
        public int CustId { get; set; }
        public List<LineItem> CustLineItem { get; set; }

        public Cart()
        {
            
        }
    }

    public class LineItem
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
    }

    public class OfferAdjustedLineItem
    {
        
    }
    public class CalculatedLineItem
    {
        
    }
    public class Receipt
    {
        public int CustId { get; set; }
        public DateTime Date { get; set; }
        public List<LineItem> LineItems { get; set; }
        public double CalculatedTotalPrice { get; set; }
        public double SavingsPoint { get; set; }
    }

    }

   }

