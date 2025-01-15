using System;
using UnitConversionApp.Services;
using Xunit;

namespace UnitConversionCSTests
{
    public class ConversionServiceTests
    {
        [Theory]
        [InlineData(32, "fahrenheit", "celsius", 0)]
        [InlineData(0, "celsius", "fahrenheit", 32)]
        [InlineData(100, "fahrenheit", "rankine", 559.67)]
        [InlineData(300, "kelvin", "celsius", 26.85)]
        [InlineData(1, "liters", "cups", 4.22675)]
        [InlineData(4.22675, "cups", "liters", 1)]
        public void Convert_ShouldReturnExpectedValue(double value, string fromUnit, string toUnit, double expected)
        {
            var result = ConversionService.Convert(value, fromUnit, toUnit);

            Assert.NotNull(result);
            Assert.Equal(expected, Math.Round(result.Value, 5)); // Rounded to 5 decimals for precision
        }

        [Fact]
        public void Convert_ShouldReturnNullForInvalidUnits()
        {
            var result = ConversionService.Convert(10, "unknownUnit", "celsius");

            Assert.Null(result);
        }

        [Theory]
        [InlineData(100, 100.0, true)] // Exact match
        [InlineData(100, 100.04, true)] // Close enough after rounding
        [InlineData(100, 99.95, true)] // Close enough after rounding
        [InlineData(100, 99.9, false)] // Outside rounding tolerance
        public void ValidateResponse_ShouldReturnExpectedValue(double correctValue, double studentResponse, bool expected)
        {
            var result = ConversionService.ValidateResponse(correctValue, studentResponse);

            Assert.Equal(expected, result);
        }
    }
}

