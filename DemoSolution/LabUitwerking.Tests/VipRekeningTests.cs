using FluentAssertions;
using LabUitwerking.Rekeningen;
using Moq;

namespace LabUitwerking.Tests
{
    public class Tests
    {
        VipRekening _sut;
        Mock<IKortingService> _kortingServiceMock;

        [SetUp]
        public void Setup()
        {
            _kortingServiceMock = new Mock<IKortingService>();
            _kortingServiceMock
                .Setup(x => x.GeefKortingBedrag(It.IsAny<int>(), It.IsAny<decimal>()))
                .Returns(15);
            // hier setup?

            _sut = new VipRekening(_kortingServiceMock.Object) { Balance = 5000, Discount = 12 };
        }

        [Test]
        public void Test1()
        {
            _kortingServiceMock.Setup(x => x.GeefKortingBedrag(500, 12m)).Returns(15);
            _sut.Withdraw(500);
            _sut.Balance.Should().Be(4985);
            _kortingServiceMock
                .Verify(x => x.GeefKortingBedrag(It.IsAny<int>(), It.IsAny<decimal>()));
        }
    }
}