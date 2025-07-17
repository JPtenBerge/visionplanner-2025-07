using FluentAssertions;

namespace ProductieProj.Tests;

public class CalculatorTests
{
    Calculator _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new Calculator(); // system under test
    }

    [Test]
    public void Add_TwoPositiveIntegers_SumOfBothIntegers()
    {
        // Arrange (given)

        // Act (when)
        var result = _sut.Add(4, 8);

        // Assert (then)
        result.Should().Be(12);
    }

    private void ArrangeSpul()
    {

    }
}