using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductieProj.Tests;

public class FormProcessingServiceTests
{
    FormProcessingService _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new FormProcessingService();
    }

    [Test]
    public void Process_ValidData_FormProcessedAndTrue()
    {
        var result = _sut.Process("JP", 38, "Sprite");
        result.Should().BeTrue();
    }

    [Test]
    public void Process_TooHighAge_FormNotProcessedAndFalse()
    {
        var result = _sut.Process("JP", 238, "Sprite");
        result.Should().BeFalse();
    }

    [Test]
    public void Process_NullAsBeverage_FormNotProcessedAndException()
    {
        var result = () => _sut.Process("JP", 38, null);
        result.Should().Throw<ArgumentNullException>();
    }
}
