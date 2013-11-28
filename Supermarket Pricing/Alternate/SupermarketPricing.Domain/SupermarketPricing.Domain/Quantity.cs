using System;

namespace SupermarketPricing.Domain
{
    /// <summary>
    /// Represents the concept of Quantity
    /// </summary>
    public abstract class Quantity
    {
        protected internal readonly ProductMeasurementType   _measurementType;
        private readonly string                              _unitName;
        protected float                                      _quantity;

        protected Quantity(ProductMeasurementType measurementType, string unitName, float quantity)
        {
            _measurementType = measurementType;
            _unitName = unitName;
            _quantity = quantity;
        }

        public string UnitName
        {
            get { return _unitName; }
        }

        public float QuantityValue
        {
            get { return _quantity; }
        }

        public abstract void Replenish(Quantity quantity);

        public abstract void Deplete(Quantity quantity);

        public static bool operator <(Quantity firstQuantity, Quantity secondQuantity)
        {
            if ((firstQuantity._measurementType == secondQuantity._measurementType)
                && (firstQuantity._unitName == secondQuantity._unitName))
            {
                return firstQuantity._quantity < secondQuantity._quantity;
            }
            throw new ArgumentException("Mismatch of Measurement Types");
        }

        public static bool operator >(Quantity firstQuantity, Quantity secondQuantity)
        {
            if ((firstQuantity._measurementType == secondQuantity._measurementType)
                && (firstQuantity._unitName == secondQuantity._unitName))
            {
                return firstQuantity._quantity > secondQuantity._quantity;
            }
            throw new ArgumentException("Mismatch of Measurement Types");
        }

        public static bool operator <=(Quantity firstQuantity, Quantity secondQuantity)
        {
            if ((firstQuantity._measurementType == secondQuantity._measurementType)
                && (firstQuantity._unitName == secondQuantity._unitName))
            {
                return firstQuantity._quantity <= secondQuantity._quantity;
            }
            throw new ArgumentException("Mismatch of Measurement Types");
        }

        public static bool operator >=(Quantity firstQuantity, Quantity secondQuantity)
        {
            if ((firstQuantity._measurementType == secondQuantity._measurementType)
                && (firstQuantity._unitName == secondQuantity._unitName))
            {
                return firstQuantity._quantity >= secondQuantity._quantity;
            }
            throw new ArgumentException("Mismatch of Measurement Types");
        }
    }
}