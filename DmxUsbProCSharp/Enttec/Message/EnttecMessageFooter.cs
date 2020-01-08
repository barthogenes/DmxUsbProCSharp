using System;

namespace DmxUsbProCSharp.Enttec.Message
{
	public class EnttecMessageFooter
	{
		public static readonly byte EndCodeByte = 0xE7;
		public readonly byte[] Data;

		public EnttecMessageFooter(byte[] footerBytes)
		{
			if (footerBytes.Length != 1)
				throw new ArgumentException("Footer should be 1 byte!");

			Data = footerBytes;
		}

		public EnttecMessageFooter()
		{
			Data = new byte[1];
			SetEndCodeByte(EndCodeByte);
		}

		public byte GetEndCodeByte()
		{
			return Data[0];
		}

		public void SetEndCodeByte(byte endCodeByte)
		{
			Data[0] = endCodeByte;
		}

		public bool IsValid()
		{
			if (Data[0] != EndCodeByte || Data.Length != 1)
				return false;

			return true;
		}
	}
}
