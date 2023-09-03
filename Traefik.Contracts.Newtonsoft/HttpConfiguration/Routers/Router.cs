using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration
{
	public class Router
	{
		/// <summary>
		/// If not specified, HTTP routers will accept requests from all defined entry points. If you want to limit the router scope to a set of entry points, set the entryPoints option.
		/// </summary>
		/// <seealso cref="http://doc.traefik.io/traefik/routing/routers/#entrypoints"/>
		[JsonProperty("entryPoints")]
		public string[] EntryPoints { get; set; }

		/// <summary>
		/// You can attach a list of middlewares to each HTTP router. The middlewares will take effect only if the rule matches, and before forwarding the request to the service.
		/// </summary>
		/// <seealso cref="http://doc.traefik.io/traefik/routing/routers/#middlewares"/>
		[JsonProperty("middlewares")]
		public string[] Middlewares { get; set; }

		/// <summary>
		/// Each request must eventually be handled by a service, which is why each router definition should include a service target, which is basically where the request will be passed along to.
		/// </summary>
		/// <seealso cref="http://doc.traefik.io/traefik/routing/routers/#service"/>
		[JsonProperty("service")]
		public string Service { get; set; }

		/// <summary>
		/// Rules are a set of matchers configured with values, that determine if a particular request matches specific criteria. If the rule is verified, the router becomes active, calls middlewares, and then forwards the request to the service.
		/// </summary>
		/// <seealso cref="http://doc.traefik.io/traefik/routing/routers/#rule"/>
		[JsonProperty("rule")]
		public string Rule { get; set; }

		/// <summary>
		/// To avoid path overlap, routes are sorted, by default, in descending order using rules length. The priority is directly equal to the length of the rule, and so the longest length has the highest priority.
		/// </summary>
		/// <remarks>A value of 0 for the priority is ignored: priority = 0 means that the default rules length sorting is used.</remarks>
		/// <seealso cref="http://doc.traefik.io/traefik/routing/routers/#priority"/>
		[JsonProperty("priority")]
		public int Priority { get; set; }

		/// <summary>
		/// When a TLS section is specified, it instructs Traefik that the current router is dedicated to HTTPS requests only (and that the router should ignore HTTP (non TLS) requests). Traefik will terminate the SSL connections (meaning that it will send decrypted data to the services).
		/// </summary>
		/// <seealso cref="http://doc.traefik.io/traefik/routing/routers/#tls"/>
		[JsonProperty("tls")]
		public Tls Tls { get; set; }
	}
}