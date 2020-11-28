using System;
using DmxUsbProCSharp.Enttec.Message;
using Xunit;

namespace DmxUsbProCSharp.UnitTests.Enttec.EnttecMessageTests
{
	public class Footer
	{
		[Fact]
		public void EndCodeByte()
		{
			// Arrange
			var footer1 = new EnttecMessageFooter();
			var footer2 = new EnttecMessageFooter(new byte[]
			{
				0x02
			});

			// Act
			footer1.SetEndCodeByte(0x01);

			// Assert
			Assert.Equal(0x01, footer1.GetEndCodeByte());
			Assert.Equal(0x02, footer2.GetEndCodeByte());
		}

		[Fact]
		public void DataBiggerThanOneByteThrowsException()
		{
			// Arrange, Act, Assert
			Assert.Throws<ArgumentException>(() =>
			{
				var test = new EnttecMessageFooter(new byte[2]);
			});
		}

		[Fact]
		public void IsValid()
		{
			// Arrange
			var footer1 = new EnttecMessageFooter();
			var footer2 = new EnttecMessageFooter();

			// Act
			footer1.SetEndCodeByte(0x02);
			footer2.SetEndCodeByte(EnttecMessageFooter.EndCodeByte);

			// Assert
			Assert.False(footer1.IsValid());
			Assert.True(footer2.IsValid());
		}
	}
}
