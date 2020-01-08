namespace DmxUsbProCSharp.Enttec.Message
{
	public enum ApplicationMessages : byte
	{
		Unknown = 0,
		ReprogramFirmwareRequest = 1,
		ProgramFlashPageRequest = 2,
		ProgramFlashPageReply = 2,
		GetWidgetParametersRequest = 3,
		GetWidgetParametersReply = 3,
		SetWidgetParametersRequest = 4,
		ReceivedDmxPacket = 5,
		OutputOnlySendDmxPacketRequest = 6,
		SendRdmPacketRequest = 7,
		ReceiveDmxOnChange = 8,
		ReceivedDmxChangeOfStatePacket = 9,
		GetWidgetSerialNumberRequest = 10,
		GetWidgetSerialNumberReply = 10,
		SendRdmDiscoveryRequest = 11
	}
}
