using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class Subject
	{
		[JsonPropertyName("country")]
		public bool country { get; set; }
		[JsonPropertyName("province")]
		public bool province { get; set; }
		[JsonPropertyName("locality")]
		public bool locality { get; set; }
		[JsonPropertyName("organization")]
		public bool organization { get; set; }
		[JsonPropertyName("commonName")]
		public bool commonName { get; set; }
		[JsonPropertyName("serialNumber")]
		public bool serialNumber { get; set; }
		[JsonPropertyName("domainComponent")]
		public bool domainComponent { get; set; }
	}

}
