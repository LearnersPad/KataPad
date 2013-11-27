using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace SuperMarketPricing
{
  public class AddToCollections
  {
      
      private List<SuperMarketPricingItems.Product>  _productCollection = new List<SuperMarketPricingItems.Product>();
      private List<SuperMarketPricingItems.Category> _categories = new List<SuperMarketPricingItems.Category>();
      public void AddProducts()
      {
          //read from xml and add to product

          var xPathDoc = new XPathDocument(@"Products.xml");
          XPathNavigator xpathNavigator = xPathDoc.CreateNavigator();

          var productNodeList = xpathNavigator.SelectSingleNode("//Products/Product");
          if (productNodeList != null)
              foreach (XPathNavigator product in xpathNavigator.Select("//Products/Product"))
              {
                  var tempproduct = new SuperMarketPricingItems.Product();
                  tempproduct.Name = product.SelectSingleNode(@"Name").Value;
                  tempproduct.ProductId = product.SelectSingleNode(@"ProductId").Value;
                  tempproduct.UnitPrice = double.Parse(product.SelectSingleNode(@"UnitPrice").Value);
                  tempproduct.UnitType = product.SelectSingleNode(@"UnitType").Value;
                  tempproduct.Brand = product.SelectSingleNode(@"Brand").Value;
                  tempproduct.Category = product.SelectSingleNode(@"Category").Value;
                  _productCollection.Add(tempproduct);
                  
                  _categories.Add(new SuperMarketPricingItems.Category(){Name = tempproduct.Category, ParentCategory =string.Empty});
              }
      }

      public void PrintProducts()
      {
          Console.WriteLine("Products Collection : ");
          foreach (var product in _productCollection)
          {
              Console.WriteLine("Product : \t"+ product.Name +"\tHaving UnitPrice:\t" + product.UnitPrice );
          }
          Console.WriteLine("--------------------------------------End----------------");
      }

      public void PrintCategories()
      {
          Console.WriteLine("-------------------Categories --------------- ");
          foreach (var category in _categories.Distinct())
          {
              Console.WriteLine("Category : \t" +category.Name );
          }
          Console.WriteLine("--------------------------------------End----------------");
      }

    }
}
