using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class Subject
	{
		[JsonPropertyName("country")]
		public bool Country { get; set; }

		[JsonPropertyName("province")]
		public bool Province { get; set; }

		[JsonPropertyName("locality")]
		public bool Locality { get; set; }

		[JsonPropertyName("organization")]
		public bool Organization { get; set; }

		[JsonPropertyName("commonName")]
		public bool CommonName { get; set; }

		[JsonPropertyName("serialNumber")]
		public bool SerialNumber { get; set; }

		[JsonPropertyName("domainComponent")]
		public bool DomainComponent { get; set; }
	}
}