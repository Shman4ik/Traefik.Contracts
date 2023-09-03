using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration
{
	[JsonConverter(typeof(HttpServiceJsonConverter))]
	public abstract class BaseHttpService
	{
	}
}