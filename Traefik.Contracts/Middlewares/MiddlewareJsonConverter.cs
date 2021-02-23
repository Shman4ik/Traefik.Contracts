using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Traefik.Contracts.Middlewares
{
	public class MiddlewareJsonConverter : JsonConverter<BaseMiddleware>
	{
		public override BaseMiddleware Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
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
					case "addPrefix":
						{
							var addPrefix = JsonSerializer.Deserialize<AddPrefix>(ref reader, options);
							reader.Read();
							return new AddPrefixMiddleware() { AddPrefix = addPrefix };
						}
					case "basicAuth":
						{
							var basicAuth = JsonSerializer.Deserialize<BasicAuth>(ref reader, options);
							reader.Read();
							return new BasicAuthMiddleware() { BasicAuth = basicAuth };
						}
					case "buffering":
						{
							var buffering = JsonSerializer.Deserialize<Buffering>(ref reader, options);
							reader.Read();
							return new BufferingMiddleware() { Buffering = buffering };
						}
					case "chain":
						{
							var chain = JsonSerializer.Deserialize<Chain>(ref reader, options);
							reader.Read();
							return new ChainMiddleware() { Chain = chain };
						}
					case "circuitBreaker":
						{
							var circuitBreaker = JsonSerializer.Deserialize<CircuitBreaker>(ref reader, options);
							reader.Read();
							return new CircuitBreakerMiddleware() { CircuitBreaker = circuitBreaker };
						}
					case "compress":
						{
							var compress = JsonSerializer.Deserialize<Compress>(ref reader, options);
							reader.Read();
							return new CompressMiddleware() { Compress = compress };
						}
					case "contentType":
						{
							var contentType = JsonSerializer.Deserialize<ContentType>(ref reader, options);
							reader.Read();
							return new ContentTypeMiddleware() { ContentType = contentType };
						}
					case "digestAuth":
						{
							var digestAuth = JsonSerializer.Deserialize<DigestAuth>(ref reader, options);
							reader.Read();
							return new DigestAuthMiddleware() { DigestAuth = digestAuth };
						}
					case "errors":
						{
							var errors = JsonSerializer.Deserialize<Errors>(ref reader, options);
							reader.Read();
							return new ErrorsMiddleware() { Errors = errors };
						}
					case "forwardAuth":
						{
							var forwardAuth = JsonSerializer.Deserialize<ForwardAuth>(ref reader, options);
							reader.Read();
							return new ForwardAuthMiddleware() { ForwardAuth = forwardAuth };
						}
					case "headers":
						{
							var headers = JsonSerializer.Deserialize<Headers>(ref reader, options);
							reader.Read();
							return new HeadersMiddleware() { Headers = headers };
						}
					case "inFlightReq":
						{
							var inFlightReq = JsonSerializer.Deserialize<InFlightReq>(ref reader, options);
							reader.Read();
							return new InFlightReqMiddleware() { InFlightReq = inFlightReq };
						}
					case "ipWhiteList":
						{
							var ipWhiteList = JsonSerializer.Deserialize<IpWhiteList>(ref reader, options);
							reader.Read();
							return new IpWhiteListMiddleware() { IpWhiteList = ipWhiteList };
						}
					case "passTLSClientCert":
						{
							var passTLSClientCert = JsonSerializer.Deserialize<PassTLSClientCert>(ref reader, options);
							reader.Read();
							return new PassTLSClientCertMiddleware() { PassTLSClientCert = passTLSClientCert };
						}
					case "rateLimit":
						{
							var rateLimit = JsonSerializer.Deserialize<RateLimit>(ref reader, options);
							reader.Read();
							return new RateLimitMiddleware() { RateLimit = rateLimit };
						}
					case "redirectRegex":
						{
							var redirectRegex = JsonSerializer.Deserialize<RedirectRegex>(ref reader, options);
							reader.Read();
							return new RedirectRegexMiddleware() { RedirectRegex = redirectRegex };
						}
					case "redirectScheme":
						{
							var redirectScheme = JsonSerializer.Deserialize<RedirectScheme>(ref reader, options);
							reader.Read();
							return new RedirectSchemeMiddleware() { RedirectScheme = redirectScheme };
						}
					case "replacePath":
						{
							var replacePath = JsonSerializer.Deserialize<ReplacePath>(ref reader, options);
							reader.Read();
							return new ReplacePathMiddleware() { ReplacePath = replacePath };
						}
					case "replacePathRegex":
						{
							var replacePathRegex = JsonSerializer.Deserialize<ReplacePathRegex>(ref reader, options);
							reader.Read();
							return new ReplacePathRegexMiddleware() { ReplacePathRegex = replacePathRegex };
						}
					case "retry":
						{
							var retry = JsonSerializer.Deserialize<Retry>(ref reader, options);
							reader.Read();
							return new RetryMiddleware() { Retry = retry };
						}
					case "stripPrefix":
						{
							var stripPrefix = JsonSerializer.Deserialize<StripPrefix>(ref reader, options);
							reader.Read();
							return new StripPrefixMiddleware() { StripPrefix = stripPrefix };
						}
					case "stripPrefixRegex":
						{
							var stripPrefixRegex = JsonSerializer.Deserialize<StripPrefixRegex>(ref reader, options);
							reader.Read();
							return new StripPrefixRegexMiddleware() { StripPrefixRegex = stripPrefixRegex };
						}
				}
			}
			throw new JsonException();
		}

		public override void Write(Utf8JsonWriter writer, BaseMiddleware value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case AddPrefixMiddleware addPrefixMiddleware:
					JsonSerializer.Serialize(writer, addPrefixMiddleware, options);
					break;
				case BasicAuthMiddleware basicAuthMiddleware:
					JsonSerializer.Serialize(writer, basicAuthMiddleware, options);
					break;
				case BufferingMiddleware bufferingMiddleware:
					JsonSerializer.Serialize(writer, bufferingMiddleware, options);
					break;
				case ChainMiddleware chainMiddleware:
					JsonSerializer.Serialize(writer, chainMiddleware, options);
					break;
				case CircuitBreakerMiddleware circuitBreakerMiddleware:
					JsonSerializer.Serialize(writer, circuitBreakerMiddleware, options);
					break;
				case CompressMiddleware compressMiddleware:
					JsonSerializer.Serialize(writer, compressMiddleware, options);
					break;
				case ContentTypeMiddleware contentTypeMiddleware:
					JsonSerializer.Serialize(writer, contentTypeMiddleware, options);
					break;
				case DigestAuthMiddleware digestAuthMiddleware:
					JsonSerializer.Serialize(writer, digestAuthMiddleware, options);
					break;
				case ErrorsMiddleware errorsMiddleware:
					JsonSerializer.Serialize(writer, errorsMiddleware, options);
					break;
				case ForwardAuthMiddleware forwardAuthMiddleware:
					JsonSerializer.Serialize(writer, forwardAuthMiddleware, options);
					break;
				case HeadersMiddleware headersMiddleware:
					JsonSerializer.Serialize(writer, headersMiddleware, options);
					break;
				case InFlightReqMiddleware inFlightReqMiddleware:
					JsonSerializer.Serialize(writer, inFlightReqMiddleware, options);
					break;
				case IpWhiteListMiddleware ipWhiteListMiddleware:
					JsonSerializer.Serialize(writer, ipWhiteListMiddleware, options);
					break;
				case PassTLSClientCertMiddleware passTlsClientCertMiddleware:
					JsonSerializer.Serialize(writer, passTlsClientCertMiddleware, options);
					break;
				case RateLimitMiddleware rateLimitMiddleware:
					JsonSerializer.Serialize(writer, rateLimitMiddleware, options);
					break;
				case RedirectRegexMiddleware redirectRegexMiddleware:
					JsonSerializer.Serialize(writer, redirectRegexMiddleware, options);
					break;
				case RedirectSchemeMiddleware redirectSchemeMiddleware:
					JsonSerializer.Serialize(writer, redirectSchemeMiddleware, options);
					break;
				case ReplacePathMiddleware replacePathMiddleware:
					JsonSerializer.Serialize(writer, replacePathMiddleware, options);
					break;
				case ReplacePathRegexMiddleware replacePathRegexMiddleware:
					JsonSerializer.Serialize(writer, replacePathRegexMiddleware, options);
					break;
				case RetryMiddleware retryMiddleware:
					JsonSerializer.Serialize(writer, retryMiddleware, options);
					break;
				case StripPrefixMiddleware stripPrefixMiddleware:
					JsonSerializer.Serialize(writer, stripPrefixMiddleware, options);
					break;
				case StripPrefixRegexMiddleware stripPrefixRegexMiddleware:
					JsonSerializer.Serialize(writer, stripPrefixRegexMiddleware, options);
					break;
			}
			throw new JsonException($"Type {value.GetType()} unsupported to serialize.");
		}

	}
}
