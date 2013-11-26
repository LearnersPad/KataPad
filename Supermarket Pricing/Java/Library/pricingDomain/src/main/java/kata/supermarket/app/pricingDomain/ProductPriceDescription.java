package kata.supermarket.app.pricingDomain;

public class ProductPriceDescription {
	
	private MeasuringUnit 	_measurementType;
	private float			_minimumMeasurementUnit;
	private double		  	_minimumMeasurementUnitPrice;
	private String		  	_unitName;
	
	public ProductPriceDescription(MeasuringUnit unitType, 
			String unitName, 
			float minMeasurementUnit, 
			double unitPrice){
		_measurementType = unitType;
		_unitName = unitName;
		_minimumMeasurementUnit = minMeasurementUnit;
		_minimumMeasurementUnitPrice = unitPrice;
	}
	
	public String getMeasurementUnitName(){
		return _unitName;
	}
	
	public double CalculatePrice(float quantity) throws Exception{
		if(_measurementType == MeasuringUnit.Continious)
		{
			double multiplicationFactor = quantity/_minimumMeasurementUnit;
			return multiplicationFactor * _minimumMeasurementUnitPrice;
		}
		else
		{
			if(quantity % _minimumMeasurementUnit != 0)
				throw new java.lang.Exception(
						"Discreet Measureing Units must be exact multiple of the minimum measuring Unit");
			int multiplicationFactor = (int) (quantity/_minimumMeasurementUnit);
			return multiplicationFactor * _minimumMeasurementUnitPrice;		
		}
	}
	
}
