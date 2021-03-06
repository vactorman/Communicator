﻿using System;
using System.Threading.Tasks;

namespace Common.Interfaces
{
	public interface ISocketSender
	{
		Task<int> Send(byte[] packet, Guid clientId = default(Guid));
	}
}
