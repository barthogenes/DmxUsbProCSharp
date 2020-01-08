using System;
using DmxUsbProCSharp.Enttec.Message;

namespace DmxUsbProCSharp.Enttec
{
	public class DmxUsbProDevice : IDmxUsbProDevice
	{
		public static NLog.ILogger Logger = NLog.LogManager.GetCurrentClassLogger();
		private readonly IFtdiDriver _ftdiDriver;
		private readonly EnttecMessageFactory _messageFactory;

		public DmxUsbProDevice(IFtdiDriver ftdiDriver, EnttecMessageFactory messageFactory)
		{
			_ftdiDriver = ftdiDriver;
			_messageFactory = messageFactory;
		}

		public bool IsConnected()
		{
			return _ftdiDriver.IsOpened();
		}

		public bool Connect()
		{
			// Disconnect in the case that it was already connected
			Dispose();

			if (!_ftdiDriver.OpenDevice())
			{
				Logger.Error("Failed to find or open a DMX USB PRO device!");
				Dispose();
				return false;
			}

			Logger.Info("Driver version: {0}", _ftdiDriver.GetDriverVersion());
			Logger.Info("Latency timer: {0}", _ftdiDriver.GetLatencyTimer());

			if (!_ftdiDriver.SetBaudRate(115200))
			{
				Dispose();
				return false;
			}

			if (!_ftdiDriver.SetTimeouts(120, 100))
			{
				Dispose();
				return false;
			}

			// Send Get Widget Parameters Request
			if (!Send(ApplicationMessages.GetWidgetParametersRequest,
				new byte[2]))
			{
				// Retry Sending
				if (!_ftdiDriver.PurgeWriteBuffer())
				{
					Dispose();
					return false;
				}

				if (!Send(ApplicationMessages.GetWidgetParametersRequest,
					new byte[2]))
				{
					Dispose();
					return false;
				}
			}

			// Try Read Widget Parameters
			var proParameters = new ProParameters(Receive(ApplicationMessages.GetWidgetParametersReply));
			Logger.Info("Firmware Version: {0}", proParameters.GetFirmwareVersion());
			Logger.Info("Break Time: {0} micro seconds", proParameters.GetBreakTimeInMicroSeconds());
			Logger.Info("MaB Time: {0} micro seconds", proParameters.GetMabTimeInMicroSeconds());
			Logger.Info("Send Refresh Rate: {0} packets/second", proParameters.GetSendRefreshRateInPacketsPerSecond());

			return true;
		}

		public bool StopDmxOutput()
		{
			if (!Send(ApplicationMessages.GetWidgetSerialNumberRequest, new byte[2]))
				return false;

			Receive(ApplicationMessages.GetWidgetSerialNumberRequest);
			return true;
		}

		public bool SetDmxOutput(byte[] dmxBytes)
		{
			if (dmxBytes.Length < 25 || dmxBytes.Length > 513)
				throw new ArgumentException("DMX Data should be between 25 and 513 bytes!");

			_ftdiDriver.PurgeWriteBuffer();
			var data = _messageFactory.CreateOutputDmxRequest(dmxBytes);

			return _ftdiDriver.Write(data);
		}

		public byte[] ReadDmxInput()
		{
			var result = Receive(ApplicationMessages.ReceivedDmxPacket);
			return result;
		}

		public virtual bool Send(ApplicationMessages messageType, byte[] messageData)
		{
			return SendInternal(messageType, messageData);
		}

		private bool SendInternal(ApplicationMessages messageType, byte[] messageData)
		{
			var header = new EnttecMessageHeader();
			header.SetMessageType(messageType);
			header.SetDataLength(messageData.Length);
			if (!header.IsValid())
				throw new ArgumentException("Invalid message data!");
			if (!_ftdiDriver.Write(header.Data))
				return false;

			var body = new EnttecMessageBody(messageData);
			if (!_ftdiDriver.Write(body.Data))
				return false;

			var footer = new EnttecMessageFooter();
			if (!_ftdiDriver.Write(footer.Data))
				return false;

			return true;
		}

		public virtual byte[] Receive(ApplicationMessages messageType)
		{
			return ReceiveInternal(messageType);
		}

		private byte[] ReceiveInternal(ApplicationMessages messageType)
		{
			var startCode = new byte[1];
			if (!_ftdiDriver.Read(startCode))
				return null;

			if (EnttecMessageHeader.StartCodeByte != startCode[0])
				return null;

			var byte1 = new byte[1];
			var byte2 = new byte[1];
			var byte3 = new byte[1];

			if (!_ftdiDriver.Read(byte1))
				return null;

			if (!_ftdiDriver.Read(byte2))
				return null;

			if (!_ftdiDriver.Read(byte3))
				return null;

			if (byte1[0] != (byte)messageType)
				return null;

			var header = new EnttecMessageHeader(new byte[]
			{
				startCode[0],
				byte1[0],
				byte2[0],
				byte3[0]
			});

			if (!header.IsValid())
				return null;

			var body = new EnttecMessageBody(new byte[header.GetDataLength()]);

			if (!_ftdiDriver.Read(body.Data))
				return null;

			var footer = new EnttecMessageFooter();
			if (!(_ftdiDriver.Read(footer.Data) & footer.IsValid()))
				return null;

			return body.Data;
		}

		public void Dispose()
		{
			if (IsConnected())
				StopDmxOutput();
			_ftdiDriver.Dispose();
		}
	}
}
