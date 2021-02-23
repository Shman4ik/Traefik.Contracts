using System.Text.Json.Serialization;

namespace Traefik.Contracts.HttpConfiguration
{
	public class MirroringHttpService : BaseHttpService
	{
		//public MirroringHttpService(Mirroring mirroring) : base(null, mirroring, null)
		//{
		//	Mirroring = mirroring;
		//}
		[JsonPropertyName("mirroring")]
		public Mirroring Mirroring { get; set; }
	}
}