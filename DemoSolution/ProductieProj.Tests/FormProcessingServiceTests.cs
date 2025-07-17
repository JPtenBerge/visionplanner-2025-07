using FluentAssertions;
using Moq;
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
    Mock<IOpslagService> _opslagServiceMock;

    [SetUp]
    public void Setup()
    {
        _opslagServiceMock = new Mock<IOpslagService>();
        //_opslagServiceMock.Setup(x => x.Store()).Throw


        _sut = new FormProcessingService(_opslagServiceMock.Object);
    }

    [Test]
    public void Process_ValidData_FormProcessedAndTrue()
    {
        var result = _sut.Process("JP", 38, "Sprite");
        _opslagServiceMock.Verify(x => x.Store());
        result.Should().BeTrue();
    }

    [Test]
    public void Process_TooHighAge_FormNotProcessedAndFalse()
    {
        var result = _sut.Process("JP", 238, "Sprite");
        _opslagServiceMock.Verify(x => x.Store(), Times.Never);
        result.Should().BeFalse();
    }

    [Test]
    public void Process_NullAsBeverage_FormNotProcessedAndException()
    {
        var result = () => _sut.Process("JP", 38, null);
        result.Should().Throw<ArgumentNullException>();
    }
}
