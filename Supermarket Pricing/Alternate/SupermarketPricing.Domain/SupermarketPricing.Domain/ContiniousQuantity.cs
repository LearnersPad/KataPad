using System;

namespace SupermarketPricing.Domain
{
    public class ContiniousQuantity:Quantity
    {
        public ContiniousQuantity(string unitName, float quantity) : 
            base(ProductMeasurementType.Continious, unitName, quantity)
        {
        }

        public override void Replenish(Quantity quantity)
        {
            if (quantity.UnitName == UnitName && quantity._measurementType == _measurementType)
            {
                _quantity += quantity.QuantityValue;
            }
        }

        public override void Deplete(Quantity quantity)
        {
            if (quantity.UnitName == UnitName && quantity._measurementType == _measurementType)
            {
                if (this < quantity)
                {
                    throw new ArgumentOutOfRangeException("quantity","We are trying to take away more than we have!");
                }
                _quantity -= quantity.QuantityValue; 
            }
        }
    }
}