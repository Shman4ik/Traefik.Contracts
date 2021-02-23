using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	[JsonConverter(typeof(HttpServiceJsonConverter))]
	public abstract class BaseHttpService { }
}
