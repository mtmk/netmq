﻿using System;
using NetMQ;
using NetMQ.zmq;

namespace NetMQ.Sockets
{
	/// <summary>
	/// Subscriber socket, will receive messages from publisher socket
	/// </summary>
	class SubscriberSocket : NetMQSocket
	{
		public SubscriberSocket(SocketBase socketHandle)
			: base(socketHandle)
		{
		}

		public override void Send(byte[] data, int length, SendReceiveOptions options)
		{
			throw new NotSupportedException("Subscriber socket doesn't support sending");
		}	
	}
}
