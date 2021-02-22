using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class MirroringHttpService : BaseHttpService
	{
		[JsonPropertyName("mirroring")]
		public Mirroring Mirroring { get; set; }
	}

}
