using System.Collections.Generic;

namespace SupermarketPricing.Domain
{
    /// <summary>
    /// Represents the abstract concept of a Cart of items that the Customer is willing to purchase
    /// </summary>
    public class Cart
    {
        private readonly Customer           _customer;
        private readonly List<LineItem>     _lineItems;

        /// <summary>
        /// CTor
        /// </summary>
        /// <param name="customer"></param>
        public Cart(Customer customer)
        {
            _customer = customer;
            _lineItems = new List<LineItem>();
        }

        /// <summary>
        /// Gets the customer to whom the cart belongs
        /// </summary>
        public Customer Customer
        {
            get { return _customer; }
        }

        /// <summary>
        /// Adds to the Cart
        /// </summary>
        /// <param name="product"></param>
        /// <param name="quantity"></param>
        public void AddToCart(Product product, Quantity quantity)
        {
            var lineItem = _lineItems.Find(
                li => li.Product.Name == product.Name && li.Product.Brand.BrandName == product.Brand.BrandName);
            
            if(lineItem == null)
                lineItem = new LineItem(product, quantity);
            else
            {
                lineItem.AddQuantity(quantity);
            }

            _lineItems.Add(lineItem);
        }

        /// <summary>
        /// Removes from the Cart
        /// </summary>
        /// <param name="product"></param>
        public void RemoveFromCart(Product product)
        {
            var lineItem =_lineItems.Find(
                li => li.Product.Name == product.Name && li.Product.Brand.BrandName == product.Brand.BrandName);

            _lineItems.Remove(lineItem);
        }

        /// <summary>
        /// Gets the line item corresponding to the 
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public LineItem GetLineItem(Product product)
        {
            var lineItem = _lineItems.Find(
                li => li.Product.Name == product.Name && li.Product.Brand.BrandName == product.Brand.BrandName);
            return lineItem;
        }
    }
}