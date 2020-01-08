using DmxUsbProCSharp.Enttec;
using DmxUsbProCSharp.Enttec.Message;
using DmxUsbProCSharp.Ftdi;
using NLog;
using NSubstitute;
using Xunit;
using Xunit.Abstractions;

namespace DmxUsbProCSharp.UnitTests.Enttec.DmxUsbProDeviceTests
{
	public class Connecting
	{
		private readonly ILogger _logger;

		public Connecting(ITestOutputHelper outputHelper)
		{
			_logger = new NLogTestOutputHelper(outputHelper);
		}


		[Fact]
		public void CantFindAnyDevices()
		{
			// Arrange
			var fakeDriver = Substitute.For<FtdiDriver>();
			fakeDriver.OpenDevice()
				.Returns(false);
			var stubMessageFactory = Substitute.For<EnttecMessageFactory>();
			var sut = new DmxUsbProDevice(fakeDriver, stubMessageFactory);
			DmxUsbProDevice.Logger = _logger;

			// Act
			var isConnected = sut.Connect();

			// Assert
			Assert.False(isConnected);

			// Cleanup
			sut.Dispose();
		}

		[Fact]
		public void SendsGetWidgetMessageAndConnects()
		{
			// Arrange
			var fakeDriver = Substitute.For<FtdiDriver>();
			fakeDriver.SetBaudRate(Arg.Any<uint>()).Returns(true);
			fakeDriver.SetTimeouts(Arg.Any<uint>(), Arg.Any<uint>()).Returns(true);
			fakeDriver.PurgeReadBuffer().Returns(true);
			fakeDriver.OpenDevice()
				.Returns(true);

			var stubMessageFactory = Substitute.For<EnttecMessageFactory>();
			var sut = Substitute.ForPartsOf<DmxUsbProDevice>(fakeDriver, stubMessageFactory);
			sut.Send(
				Arg.Is<ApplicationMessages>(type => type.Equals(ApplicationMessages.GetWidgetParametersRequest)),
				Arg.Any<byte[]>()
			).Returns(true);
			sut.Receive(
				Arg.Is<ApplicationMessages>(type => type.Equals(ApplicationMessages.GetWidgetParametersRequest))
			).Returns(new byte[]
			{
				4,
				2,
				9,
				1,
				40
			});


			// Act
			var isConnected = sut.Connect();

			// Assert
			Assert.True(isConnected);
		}

		[Fact]
		public void FailsToSendsGetWidgetMessageAndDisposes()
		{
			// Arrange
			var fakeDriver = Substitute.For<FtdiDriver>();
			var stubMessageFactory = Substitute.For<EnttecMessageFactory>();
			fakeDriver.OpenDevice()
				.Returns(true);
			fakeDriver.Write(Arg.Any<byte[]>()).Returns(false);
			var sut = new DmxUsbProDevice(fakeDriver, stubMessageFactory);

			// Act
			var isConnected = sut.Connect();

			// Assert
			Assert.False(isConnected);
			fakeDriver.Received(2).Dispose();

			// Cleanup
			sut.Dispose();
		}
	}
}
