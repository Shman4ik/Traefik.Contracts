using Newtonsoft.Json;

namespace Traefik.Contracts.HttpConfiguration
{
	public class MirroringHttpService : BaseHttpService
	{
		//public MirroringHttpService(Mirroring mirroring) : base(null, mirroring, null)
		//{
		//	Mirroring = mirroring;
		//}
		[JsonProperty("mirroring")]
		public Mirroring Mirroring { get; set; }
	}
}