using System;
using DmxUsbProCSharp.Enttec.Message;
using Xunit;

namespace DmxUsbProCSharp.UnitTests.Enttec.EnttecMessageTests
{
	public class Body
	{
		[Fact]
		public void CanSetAndReadData()
		{
			// Arrange
			var body = new EnttecMessageBody(new byte[512]);

			// Act (Set the first led to the color orange)
			body.Data[1] = 255;
			body.Data[2] = 125;
			body.Data[3] = 0;

			// Assert
			Assert.Equal(255, body.Data[1]);
			Assert.Equal(125, body.Data[2]);
			Assert.Equal(0, body.Data[3]);
		}

		[Fact]
		public void ExceedingMaxDataLengthThrowsException()
		{
			// Arrange, Act, Assert
			Assert.Throws<ArgumentException>(() =>
			{
				var test = new EnttecMessageBody(new byte[601]);
			});
		}

		[Fact]
		public void IsValid()
		{
			// Arrange, Act, Assert
			Assert.Throws<ArgumentException>(() =>
			{
				var body1 = new EnttecMessageBody(new byte[601]);
			});

			Assert.Throws<ArgumentException>(() =>
			{
				var body2 = new EnttecMessageBody(new byte[0]);
			});

			var body3 = new EnttecMessageBody(new byte[1]);
		}
	}
}
