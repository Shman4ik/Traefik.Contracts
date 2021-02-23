using System.IO;
using System.Text.Json;
using NUnit.Framework;

namespace Traefik.Contracts.Tests
{
	public class Tests
	{
		[Test]
		public void TestDeserializeConfig()
		{
			var exampleConfig = File.OpenText("example.json").ReadToEnd();
			var dynamicConfiguration = JsonSerializer.Deserialize<DynamicConfiguration>(exampleConfig);
			Assert.NotNull(dynamicConfiguration);
			var result = JsonSerializer.Serialize(dynamicConfiguration);
			Assert.NotNull(result);
		}
	}
}