using System;

namespace UnitConversionApp.Services
{
    public static class ConversionService
    {
        public static double? Convert(double value, string fromUnit, string toUnit)
        {
            try
            {
                return fromUnit.ToLower() switch
                {
                    "fahrenheit" when toUnit.ToLower() == "celsius" => (value - 32) * 5 / 9,
                    "celsius" when toUnit.ToLower() == "fahrenheit" => (value * 9 / 5) + 32,
                    "fahrenheit" when toUnit.ToLower() == "rankine" => value + 459.67,
                    "rankine" when toUnit.ToLower() == "fahrenheit" => value - 459.67,
                    "kelvin" when toUnit.ToLower() == "celsius" => value - 273.15,
                    "celsius" when toUnit.ToLower() == "kelvin" => value + 273.15,
                    _ => null
                };
            }
            catch
            {
                return null; 
            }
        }

        public static bool ValidateResponse(double correctValue, double studentResponse)
        {
            return Math.Round(correctValue, 1) == Math.Round(studentResponse, 1);
        }
    }
}
