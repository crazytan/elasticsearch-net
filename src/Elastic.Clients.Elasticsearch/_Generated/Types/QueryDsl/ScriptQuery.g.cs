// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.QueryDsl;
public sealed partial class ScriptQuery : SearchQuery
{
	[JsonInclude, JsonPropertyName("_name")]
	public string? QueryName { get; set; }

	[JsonInclude, JsonPropertyName("boost")]
	public float? Boost { get; set; }

	[JsonInclude, JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.Script Script { get; set; }

	public static implicit operator Query(ScriptQuery scriptQuery) => QueryDsl.Query.Script(scriptQuery);
}

public sealed partial class ScriptQueryDescriptor : SerializableDescriptor<ScriptQueryDescriptor>
{
	internal ScriptQueryDescriptor(Action<ScriptQueryDescriptor> configure) => configure.Invoke(this);
	public ScriptQueryDescriptor() : base()
	{
	}

	private string? QueryNameValue { get; set; }

	private float? BoostValue { get; set; }

	private Elastic.Clients.Elasticsearch.Script ScriptValue { get; set; }

	public ScriptQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public ScriptQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public ScriptQueryDescriptor Script(Elastic.Clients.Elasticsearch.Script script)
	{
		ScriptValue = script;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		writer.WritePropertyName("script");
		JsonSerializer.Serialize(writer, ScriptValue, options);
		writer.WriteEndObject();
	}
}