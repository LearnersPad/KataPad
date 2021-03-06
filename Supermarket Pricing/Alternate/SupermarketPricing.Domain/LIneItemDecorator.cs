﻿namespace SupermarketPricing.Domain
{
    public abstract class LineItemDecorator:LineItem
    {

        protected readonly LineItem ContainedLineItem;

        protected LineItemDecorator(LineItem lineItem) 
            : base(null, null)
        {
            ContainedLineItem = lineItem;
        }

        public override Product Product
        {
            get { return ContainedLineItem.Product; }
        }

        public override void AddQuantity(Quantity qunatity)
        {
            ContainedLineItem.AddQuantity(qunatity);
        }

        public override void RemoveQuantity(Quantity quantity)
        {
            ContainedLineItem.RemoveQuantity(quantity);
        }

        public abstract override double CalculatePrice();

    }
}