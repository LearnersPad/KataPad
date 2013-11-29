using System;
using System.Collections.Generic;

namespace SupermarketPricing.Domain
{
    /// <summary>
    /// Represents the concept of the overall stock held by the Supermarket
    /// </summary>
    public class Stock
    {
        private readonly List<ProductStock> _productStocks;

        /// <summary>
        /// Initializes the Stocks Instance
        /// </summary>
        public Stock()
        {
            _productStocks = new List<ProductStock>();
        }

        public void AddStock(Product product, Quantity quantityAcquired, Quantity minimumThresholdQuantity)
        {
            _productStocks.Add(new ProductStock(product, quantityAcquired, minimumThresholdQuantity));
        }

        public void ReplenishStock(Product product, Quantity quantityToBeReplenished)
        {
            var productStock = _productStocks.Find(ps => ps.ProductDetail.Name == product.Name &&
                                      ps.ProductDetail.Brand.BrandName == product.Brand.BrandName);

            if(productStock == null)
                throw new ArgumentException("Product Stock has not been initialized");

            productStock.AddStock(quantityToBeReplenished);
        }

        public void DepleteStock(Product product, Quantity quantityToBeDepleted)
        {
            var productStock = _productStocks.Find(ps => ps.ProductDetail.Name == product.Name &&
                                                         ps.ProductDetail.Brand.BrandName == product.Brand.BrandName);

            if (productStock == null)
                throw new ArgumentException("Product Stock has not been initialized");

            productStock.RemoveStock(quantityToBeDepleted);
        }
    }
}