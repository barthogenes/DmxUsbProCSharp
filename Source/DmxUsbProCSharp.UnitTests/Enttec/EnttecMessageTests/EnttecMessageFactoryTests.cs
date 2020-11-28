using DmxUsbProCSharp.Enttec;
using DmxUsbProCSharp.Enttec.Message;
using Xunit;

namespace DmxUsbProCSharp.UnitTests.Enttec.EnttecMessageTests
{
	public class EnttecMessageFactoryTests
	{
		[Fact]
		public void CreatesValidEnttecMessage()
		{
			// Arrange
			var sut = new EnttecMessageFactory();
			var messageData = new byte[]
			{
				1, 2, 3
			};

			// Act
			var actual = sut.CreateMessage(
				ApplicationMessages.OutputOnlySendDmxPacketRequest,
				messageData);

			// Assert
			Assert.Equal(EnttecMessageHeader.StartCodeByte, actual[0]);
			Assert.Equal((byte)ApplicationMessages.OutputOnlySendDmxPacketRequest, actual[1]);
			Assert.Equal(3 & 0xFF, actual[2]);
			Assert.Equal(3 >> 8, actual[3]);
			Assert.Equal(1, actual[4]);
			Assert.Equal(2, actual[5]);
			Assert.Equal(3, actual[6]);
			Assert.Equal(EnttecMessageFooter.EndCodeByte, actual[7]);
		}
	}
}
