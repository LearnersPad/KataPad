using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace SuperMarketPricing
{
    class Program
    {
        static void Main(string[] args)
        {
            AddToCollections addToCollections = new AddToCollections();
            addToCollections.AddProducts();
            addToCollections.PrintProducts();
            addToCollections.PrintCategories();
        }
    }
}
