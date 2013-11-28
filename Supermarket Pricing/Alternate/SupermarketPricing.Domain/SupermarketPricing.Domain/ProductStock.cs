using System;

namespace SupermarketPricing.Domain
{
    /// <summary>
    /// Represents concept of Stock of a Product
    /// </summary>
    public class ProductStock
    {
        private readonly Product   _product;
        private readonly Quantity  _stockQuantity;
        private readonly Quantity _lowThresholdQuantity;

        public event Action<Product, Quantity> OnStockDepletedBelowThreshold;

        /// <summary>
        /// CTor
        /// </summary>
        public ProductStock(Product product, Quantity productQuantity, Quantity thresholdQuantity)
        {
            _product = product;
            _stockQuantity = productQuantity;
            _lowThresholdQuantity = thresholdQuantity;
        }

        /// <summary>
        /// Gets the current Stock held in the store
        /// </summary>
        public Quantity CurrentStock
        {
            get { return _stockQuantity; }
        }

        /// <summary>
        /// Adds Stocks
        /// </summary>
        /// <param name="quantity"></param>
        public void AddStock(Quantity quantity)
        {
            _stockQuantity.Replenish(quantity);
        }

        /// <summary>
        /// Removes Stock
        /// </summary>
        /// <param name="quantity"></param>
        public void RemoveStock(Quantity quantity)
        {
            _stockQuantity.Deplete(quantity);
            if (_stockQuantity >= _lowThresholdQuantity) 
                return;
            if (OnStockDepletedBelowThreshold != null)
                OnStockDepletedBelowThreshold(_product, _stockQuantity);
        }
    }
}