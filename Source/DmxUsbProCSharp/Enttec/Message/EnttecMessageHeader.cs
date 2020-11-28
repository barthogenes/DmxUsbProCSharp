using System;

namespace DmxUsbProCSharp.Enttec.Message
{
	public class EnttecMessageHeader
	{
		public static readonly byte StartCodeByte = 0x7E;
		public readonly byte[] Data;
		public static NLog.ILogger Logger = NLog.LogManager.GetCurrentClassLogger();

		public EnttecMessageHeader(byte[] headerBytes)
		{
			if (headerBytes.Length != 4)
				throw new ArgumentException("Header should be 4 bytes!");
			Data = headerBytes;
		}

		public EnttecMessageHeader()
		{
			Data = new byte[4];
			SetStartCodeByte(StartCodeByte);
		}

		public byte GetStartCodeByte()
		{
			return Data[0];
		}

		public void SetStartCodeByte(byte startCodeByte)
		{
			Data[0] = startCodeByte;
		}

		public bool GetMessageType(out ApplicationMessages messageType)
		{
			var mType = Data[1];
			messageType = (ApplicationMessages)mType;
			if (Enum.IsDefined(typeof(ApplicationMessages), mType) && mType != (byte)ApplicationMessages.Unknown)
				return true;

			return false;
		}

		public void SetMessageType(ApplicationMessages messageType)
		{
			Data[1] = (byte)messageType;
		}

		public int GetDataLength()
		{
			var dataLength = Data[2] + (Data[3] << 8);
			return dataLength;
		}

		public void SetDataLength(int length)
		{
			Data[2] = (byte)(length & 0xFF);
			Data[3] = (byte)(length >> 8);
		}

		public bool IsValid()
		{
			if (GetStartCodeByte() != StartCodeByte)
				return false;

			if (!GetMessageType(out var messageType))
			{
				Logger.Error("Unknown ENTTEC message type found in header!", messageType);
				return false;
			}

			var dataLength = GetDataLength();
			if (dataLength < 1 || dataLength > 600)
				return false;

			return true;
		}
	}
}
