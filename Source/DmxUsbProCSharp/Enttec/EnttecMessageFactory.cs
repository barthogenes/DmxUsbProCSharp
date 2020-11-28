using System;
using System.Collections.Generic;
using DmxUsbProCSharp.Enttec.Message;

namespace DmxUsbProCSharp.Enttec
{
	public class EnttecMessageFactory
	{
		public virtual byte[] CreateOutputDmxRequest(byte[] dmxBytes)
		{
			return CreateMessage(ApplicationMessages.OutputOnlySendDmxPacketRequest,
				dmxBytes);
		}

		public byte[] CreateMessage(ApplicationMessages messageType, byte[] messageData)
		{
			var header = new EnttecMessageHeader();
			header.SetMessageType(messageType);
			header.SetDataLength(messageData.Length);
			var body = new EnttecMessageBody(messageData);
			var footer = new EnttecMessageFooter();

			if (!header.IsValid() || !footer.IsValid())
				throw new ArgumentException("Invalid message data!");

			return CreateMessageFromParts(header, body, footer);
		}

		public byte[] CreateMessageFromParts(EnttecMessageHeader header, EnttecMessageBody body,
			EnttecMessageFooter footer)
		{
			var message = new List<byte>();
			message.AddRange(header.Data);
			message.AddRange(body.Data);
			message.AddRange(footer.Data);

			return message.ToArray();
		}
	}
}
