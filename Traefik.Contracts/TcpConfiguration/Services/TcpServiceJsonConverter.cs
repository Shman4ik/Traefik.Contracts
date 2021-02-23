using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Traefik.Contracts.TcpConfiguration
{
	public class TcpServiceJsonConverter : JsonConverter<BaseTcpService>
	{
		public override BaseTcpService Read(ref Utf8JsonReader reader, Type typeToConvert,
			JsonSerializerOptions options)
		{
			while (reader.Read())
			{
				if (reader.TokenType == JsonTokenType.EndObject) throw new JsonException();

				if (reader.TokenType != JsonTokenType.PropertyName) throw new JsonException();

				var propertyName = reader.GetString();
				switch (propertyName)
				{
					case "loadBalancer":
					{
						var loadBalancer = JsonSerializer.Deserialize<LoadBalancer>(ref reader, options);
						reader.Read();
						return new LoadBalancerTcpService {LoadBalancer = loadBalancer};
					}
					case "weighted":
					{
						var weighted = JsonSerializer.Deserialize<Weighted>(ref reader, options);
						reader.Read();
						return new WeightedTcpService {Weighted = weighted};
					}
				}
			}

			throw new JsonException();
		}

		public override void Write(Utf8JsonWriter writer, BaseTcpService value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case LoadBalancerTcpService loadBalancerTcpService:
					JsonSerializer.Serialize(writer, loadBalancerTcpService, options);
					return;
				case WeightedTcpService weightedTcpService:
					JsonSerializer.Serialize(writer, weightedTcpService, options);
					return;
			}

			throw new JsonException($"Type {value.GetType()} unsupported to serialize.");
		}
	}
}