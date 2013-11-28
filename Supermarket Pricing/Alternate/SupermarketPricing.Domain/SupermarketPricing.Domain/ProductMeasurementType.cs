namespace SupermarketPricing.Domain
{
    /// <summary>
    /// Describes the Measurement type for quantifying the Quantity of the Product
    /// </summary>
    public enum ProductMeasurementType
    {
        /// <summary>
        /// Whether the Product is available as a continious unit
        /// </summary>
        Continious, 
        /// <summary>
        /// Whether the Product is available as Discreet Units 
        /// </summary>
        Discreet
    }
}