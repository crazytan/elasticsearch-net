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
namespace Elastic.Clients.Elasticsearch.Aggregations;
public sealed partial class TestPopulation
{
	[JsonInclude]
	[JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Field Field { get; set; }

	[JsonInclude]
	[JsonPropertyName("filter")]
	public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? Filter { get; set; }

	[JsonInclude]
	[JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.Script? Script { get; set; }
}

public sealed partial class TestPopulationDescriptor<TDocument> : SerializableDescriptor<TestPopulationDescriptor<TDocument>>
{
	internal TestPopulationDescriptor(Action<TestPopulationDescriptor<TDocument>> configure) => configure.Invoke(this);
	public TestPopulationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? FilterValue { get; set; }

	private QueryDsl.QueryContainerDescriptor<TDocument> FilterDescriptor { get; set; }

	private Action<QueryDsl.QueryContainerDescriptor<TDocument>> FilterDescriptorAction { get; set; }

	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }

	public TestPopulationDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterValue = filter;
		return Self;
	}

	public TestPopulationDescriptor<TDocument> Filter(QueryDsl.QueryContainerDescriptor<TDocument> descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public TestPopulationDescriptor<TDocument> Filter(Action<QueryDsl.QueryContainerDescriptor<TDocument>> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	public TestPopulationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public TestPopulationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public TestPopulationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<TDocument>(FilterDescriptorAction), options);
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterValue, options);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class TestPopulationDescriptor : SerializableDescriptor<TestPopulationDescriptor>
{
	internal TestPopulationDescriptor(Action<TestPopulationDescriptor> configure) => configure.Invoke(this);
	public TestPopulationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? FilterValue { get; set; }

	private QueryDsl.QueryContainerDescriptor FilterDescriptor { get; set; }

	private Action<QueryDsl.QueryContainerDescriptor> FilterDescriptorAction { get; set; }

	private Elastic.Clients.Elasticsearch.Field FieldValue { get; set; }

	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }

	public TestPopulationDescriptor Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterValue = filter;
		return Self;
	}

	public TestPopulationDescriptor Filter(QueryDsl.QueryContainerDescriptor descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public TestPopulationDescriptor Filter(Action<QueryDsl.QueryContainerDescriptor> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	public TestPopulationDescriptor Field(Elastic.Clients.Elasticsearch.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public TestPopulationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public TestPopulationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public TestPopulationDescriptor Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptValue = script;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor(FilterDescriptorAction), options);
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterValue, options);
		}

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		writer.WriteEndObject();
	}
}