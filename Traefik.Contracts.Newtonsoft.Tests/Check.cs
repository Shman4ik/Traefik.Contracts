using System.IO;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Traefik.Contracts.Tests
{
	public class Tests
	{
		[Test]
		public void TestDeserializeConfig()
		{
			var exampleConfig = File.OpenText("example.json").ReadToEnd();
			var dynamicConfiguration = JsonConvert.DeserializeObject<DynamicConfiguration>(exampleConfig);
			Assert.NotNull(dynamicConfiguration);
			var result = JsonConvert.SerializeObject(dynamicConfiguration);
			Assert.NotNull(result);
		}
	}
}