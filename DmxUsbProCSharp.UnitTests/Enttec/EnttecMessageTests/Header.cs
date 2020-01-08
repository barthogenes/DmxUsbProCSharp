using System;
using DmxUsbProCSharp.Enttec.Message;
using Xunit;

namespace DmxUsbProCSharp.UnitTests.Enttec.EnttecMessageTests
{
	public class Header
	{
		[Fact]
		public void StartCodeByte()
		{
			// Arrange
			var header1 = new EnttecMessageHeader();
			var header2 = new EnttecMessageHeader(new byte[]
			{
				0x02,
				0x03,
				0x04,
				0x05
			});

			// Act
			header1.SetStartCodeByte(0x01);

			// Assert
			Assert.Equal(0x01, header1.GetStartCodeByte());
			Assert.Equal(0x02, header2.GetStartCodeByte());
			Assert.Equal(0x02, header2.Data[0]);
			Assert.Equal(0x03, header2.Data[1]);
			Assert.Equal(0x04, header2.Data[2]);
			Assert.Equal(0x05, header2.Data[3]);
		}

		[Fact]
		public void DataBiggerThanFourByteThrowsException()
		{
			// Arrange, Act, Assert
			Assert.Throws<ArgumentException>(() =>
			{
				var test = new EnttecMessageHeader(new byte[5]);
			});
		}

		[Fact]
		public void MessageType()
		{
			// Arrange
			var header = new EnttecMessageHeader();

			// Act
			header.SetMessageType(ApplicationMessages.GetWidgetSerialNumberRequest);

			// Assert
			Assert.Equal(10,
				header.Data[1]);
		}


		[Fact]
		public void DataLength()
		{
			// Arrange
			var header = new EnttecMessageHeader();

			// Act
			header.SetDataLength(10);

			// Assert
			Assert.Equal(10, header.GetDataLength());
		}

		[Fact]
		public void IsValidStartCode()
		{
			// Arrange
			var header1 = new EnttecMessageHeader();
			var header2 = new EnttecMessageHeader();
			header1.SetMessageType(ApplicationMessages.OutputOnlySendDmxPacketRequest);
			header2.SetMessageType(ApplicationMessages.OutputOnlySendDmxPacketRequest);
			header1.SetDataLength(1);
			header2.SetDataLength(1);

			// Act
			header1.SetStartCodeByte(0x00);

			// Assert
			Assert.False(header1.IsValid());
			Assert.True(header2.IsValid());
		}

		[Fact]
		public void IsValidMessageType()
		{
			// Arrange
			var header1 = new EnttecMessageHeader();
			var header2 = new EnttecMessageHeader();
			header1.SetDataLength(1);
			header2.SetDataLength(1);

			// Act
			header1.SetMessageType((ApplicationMessages)123);
			header2.SetMessageType(ApplicationMessages.OutputOnlySendDmxPacketRequest);

			// Assert
			Assert.False(header1.IsValid());
			Assert.True(header2.IsValid());
		}

		[Fact]
		public void IsValidDataLength()
		{
			// Arrange
			var header1 = new EnttecMessageHeader();
			var header2 = new EnttecMessageHeader();
			var header3 = new EnttecMessageHeader();
			var header4 = new EnttecMessageHeader();

			header1.SetMessageType(ApplicationMessages.OutputOnlySendDmxPacketRequest);
			header2.SetMessageType(ApplicationMessages.OutputOnlySendDmxPacketRequest);
			header3.SetMessageType(ApplicationMessages.OutputOnlySendDmxPacketRequest);
			header4.SetMessageType(ApplicationMessages.OutputOnlySendDmxPacketRequest);

			// Act
			header1.SetDataLength(601);
			header2.SetDataLength(0);
			header3.SetDataLength(1);
			header4.SetDataLength(600);

			// Assert
			Assert.False(header1.IsValid());
			Assert.False(header2.IsValid());
			Assert.True(header3.IsValid());
			Assert.True(header4.IsValid());
		}
	}
}
