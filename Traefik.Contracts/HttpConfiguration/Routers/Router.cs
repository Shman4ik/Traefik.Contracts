using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class Router
	{
		[JsonPropertyName("entryPoints")]
		public string[] EntryPoints { get; set; }

		[JsonPropertyName("middlewares")]
		public string[] Middlewares { get; set; }

		[JsonPropertyName("service")]
		public string Service { get; set; }

		[JsonPropertyName("rule")]
		public string Rule { get; set; }

		[JsonPropertyName("priority")]
		public int Priority { get; set; }

		[JsonPropertyName("tls")]
		public Tls Tls { get; set; }
	}
}