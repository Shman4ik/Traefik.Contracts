namespace Traefik.Contracts
{
	public class Retry
	{
		public int attempts { get; set; }
		public int initialInterval { get; set; }
	}

}
