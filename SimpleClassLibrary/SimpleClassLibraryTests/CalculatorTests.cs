using SimpleClassLibrary;
using Xunit.Sdk;

namespace SimpleClassLibraryTests
{
    public class CalculatorTests
    {
        private Calculator _sut;

        [Fact]
        public void Add_TwoNumber_CalculatesCorrectValue()
        {
            // Assemble
            int x = 1;
            int y = 2;
            _sut = new Calculator();
            // Act
            int result = _sut.Add(x, y);
            // Assert
            Assert.Equal(x + y, result);
        }

        [Fact]
        public void Multiply_TwoNumber_CalculatesCorrectValue()
        {
            // Assemble
            int x = 1;
            int y = 2;
            _sut = new Calculator();
            // Act
            int result = _sut.Multiply(x, y);
            // Assert
            Assert.Equal(x * y, result);
        }
    }
}