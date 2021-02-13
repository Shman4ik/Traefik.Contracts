using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using Traefik.Contracts.HttpConfiguration;

namespace Traefik.Contracts
{
	public class DynamicConfiguration
	{
		[JsonPropertyName("http")]
		public Http Http { get; set; }
		public Tcp tcp { get; set; }
		public Udp udp { get; set; }
		public Tls5 tls { get; set; }

	}
}
