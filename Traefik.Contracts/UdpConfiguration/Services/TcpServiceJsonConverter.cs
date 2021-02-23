using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Traefik.Contracts.UdpConfiguration
{
	public class UdpServiceJsonConverter : JsonConverter<BaseUdpService>
	{
		public override BaseUdpService Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			while (reader.Read())
			{
				if (reader.TokenType == JsonTokenType.EndObject)
				{
					throw new JsonException();
				}

				if (reader.TokenType != JsonTokenType.PropertyName)
				{
					throw new JsonException();
				}

				var propertyName = reader.GetString();
				switch (propertyName)
				{
					case "loadBalancer":
						{
							var loadBalancer = JsonSerializer.Deserialize<LoadBalancer>(ref reader, options);
							reader.Read();
							return new LoadBalancerUdpService { LoadBalancer = loadBalancer };
						}
					case "weighted":
						{
							var weighted = JsonSerializer.Deserialize<Weighted>(ref reader, options);
							reader.Read();
							return new WeightedUdpService { Weighted = weighted };
						}
				}
			}
			throw new JsonException();
		}

		public override void Write(Utf8JsonWriter writer, BaseUdpService value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case LoadBalancerUdpService loadBalancerUdpService:
					JsonSerializer.Serialize(writer, loadBalancerUdpService, options);
					return;
				case WeightedUdpService weightedUdpService:
					JsonSerializer.Serialize(writer, weightedUdpService, options);
					return;
			}
			throw new JsonException($"Type {value.GetType()} unsupported to serialize.");
		}

	}
}
