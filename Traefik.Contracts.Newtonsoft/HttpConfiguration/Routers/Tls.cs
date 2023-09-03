using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration
{
	/// <summary>
	/// When a TLS section is specified, it instructs Traefik that the current router is dedicated to HTTPS requests only (and that the router should ignore HTTP (non TLS) requests). Traefik will terminate the SSL connections (meaning that it will send decrypted data to the services).
	/// </summary>
	public class Tls
	{
		/// <summary>
		/// The options field enables fine-grained control of the TLS parameters. It refers to a TLS Options and will be applied only if a Host rule is defined.
		/// </summary>
		/// <seealso cref="http://doc.traefik.io/traefik/routing/routers/#options"/>
		[JsonProperty("options")]
		public string Options { get; set; }

		/// <summary>
		/// If certResolver is defined, Traefik will try to generate certificates based on routers Host & HostSNI rules.
		/// </summary>
		/// <seealso cref="http://doc.traefik.io/traefik/routing/routers/#certresolver"/>
		[JsonProperty("certResolver")]
		public string CertResolver { get; set; }

		/// <summary>
		/// You can set SANs (alternative domains) for each main domain. Every domain must have A/AAAA records pointing to Traefik. Each domain & SAN will lead to a certificate request.
		/// </summary>
		/// <seealso cref="http://doc.traefik.io/traefik/routing/routers/#domains"/>
		[JsonProperty("domains")]
		public Domain[] Domains { get; set; }
	}
}