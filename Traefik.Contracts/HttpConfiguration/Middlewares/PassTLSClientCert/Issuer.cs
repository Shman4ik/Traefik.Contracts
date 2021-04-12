using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// The info.issuer selects the specific client certificate issuer details you want to add to the X-Forwarded-Tls-Client-Cert-Info header.
	/// </summary>
	public class Issuer
	{
		/// <summary>
		/// Set the info.issuer.country option to true to add the country information into the issuer.
		/// </summary>
		[JsonPropertyName("country")]
		public bool Country { get; set; }

		/// <summary>
		/// Set the info.issuer.province option to true to add the province information into the issuer.
		/// </summary>
		[JsonPropertyName("province")]
		public bool Province { get; set; }

		/// <summary>
		/// Set the info.issuer.locality option to true to add the locality information into the issuer.
		/// </summary>
		[JsonPropertyName("locality")]
		public bool Locality { get; set; }

		/// <summary>
		/// Set the info.issuer.organization option to true to add the organization information into the issuer.
		/// </summary>
		[JsonPropertyName("organization")]
		public bool Organization { get; set; }

		/// <summary>
		/// Set the info.issuer.commonName option to true to add the commonName information into the issuer.
		/// </summary>
		[JsonPropertyName("commonName")]
		public bool CommonName { get; set; }

		/// <summary>
		/// Set the info.issuer.serialNumber option to true to add the serialNumber information into the issuer.
		/// </summary>
		[JsonPropertyName("serialNumber")]
		public bool SerialNumber { get; set; }

		/// <summary>
		/// Set the info.issuer.domainComponent option to true to add the domainComponent information into the issuer.
		/// </summary>
		[JsonPropertyName("domainComponent")]
		public bool DomainComponent { get; set; }
	}
}