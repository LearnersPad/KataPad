using System;

namespace SupermarketPricing.Domain
{
    /// <summary>
    /// This is basically a class to help the product to price itself
    /// </summary>
    public class ProductPriceQuantifierUnit
    {
        private readonly ProductMeasurementType _measurementType;
        private readonly float                  _minimumMeasurementUnit;
        private readonly double                 _minimumMeasurementUnitPrice;
        private readonly string                 _unitName;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="unitType"></param>
        /// <param name="unitName"></param>
        /// <param name="minMeasurementUnit"></param>
        /// <param name="unitPrice"></param>
        public ProductPriceQuantifierUnit(ProductMeasurementType unitType,
            string unitName,
            float minMeasurementUnit,
            double unitPrice)
        {
            _measurementType = unitType;
            _unitName = unitName;
            _minimumMeasurementUnit = minMeasurementUnit;
            _minimumMeasurementUnitPrice = unitPrice;
        }

        /// <summary>
        /// The Measurement Unit Name
        /// </summary>
        public string MeasurementUnitName
        {
            get
            {
                return _unitName;
            }
        }

        /// <summary>
        /// Calcualtes the Price for a given Quantity
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public double CalculatePrice(Quantity quantity)
        {
            if (_measurementType == ProductMeasurementType.Continious)
            {
                double multiplicationFactor = quantity.QuantityValue/_minimumMeasurementUnit;
                return multiplicationFactor*_minimumMeasurementUnitPrice;
            }
            else
            {
                if (Math.Abs(quantity.QuantityValue%_minimumMeasurementUnit) > 0.00)
                    throw new ArgumentException();
                var multiplicationFactor = (int) (quantity.QuantityValue/_minimumMeasurementUnit);
                return multiplicationFactor*_minimumMeasurementUnitPrice;
            }
        }

    }
}