using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration.Middlewares
{
	/// <summary>
	/// The info.subject selects the specific client certificate subject details you want to add to the X-Forwarded-Tls-Client-Cert-Info header.
	/// </summary>
	public class Subject
	{
		/// <summary>
		/// Set the info.subject.country option to true to add the country information into the subject.
		/// </summary>
		[JsonPropertyName("country")]
		public bool Country { get; set; }

		/// <summary>
		/// Set the info.subject.province option to true to add the province information into the subject.
		/// </summary>
		[JsonPropertyName("province")]
		public bool Province { get; set; }

		/// <summary>
		/// Set the info.subject.locality option to true to add the locality information into the subject.
		/// </summary>
		[JsonPropertyName("locality")]
		public bool Locality { get; set; }

		/// <summary>
		/// Set the info.subject.organization option to true to add the organization information into the subject.
		/// </summary>
		[JsonPropertyName("organization")]
		public bool Organization { get; set; }

		/// <summary>
		/// Set the info.subject.commonName option to true to add the commonName information into the subject.
		/// </summary>
		[JsonPropertyName("commonName")]
		public bool CommonName { get; set; }

		/// <summary>
		/// Set the info.subject.serialNumber option to true to add the serialNumber information into the subject.
		/// </summary>
		[JsonPropertyName("serialNumber")]
		public bool SerialNumber { get; set; }

		/// <summary>
		/// Set the info.subject.domainComponent option to true to add the domainComponent information into the subject.
		/// </summary>
		[JsonPropertyName("domainComponent")]
		public bool DomainComponent { get; set; }
	}
}