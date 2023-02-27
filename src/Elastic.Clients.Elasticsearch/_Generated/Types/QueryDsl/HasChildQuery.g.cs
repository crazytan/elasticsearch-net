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
public sealed partial class HasChildQuery : SearchQuery
{
	[JsonInclude, JsonPropertyName("_name")]
	public string? QueryName { get; set; }

	[JsonInclude, JsonPropertyName("boost")]
	public float? Boost { get; set; }

	[JsonInclude, JsonPropertyName("ignore_unmapped")]
	public bool? IgnoreUnmapped { get; set; }

	[JsonInclude, JsonPropertyName("inner_hits")]
	public Elastic.Clients.Elasticsearch.Core.Search.InnerHits? InnerHits { get; set; }

	[JsonInclude, JsonPropertyName("max_children")]
	public int? MaxChildren { get; set; }

	[JsonInclude, JsonPropertyName("min_children")]
	public int? MinChildren { get; set; }

	[JsonInclude, JsonPropertyName("query")]
	public Elastic.Clients.Elasticsearch.QueryDsl.Query Query { get; set; }

	[JsonInclude, JsonPropertyName("score_mode")]
	public Elastic.Clients.Elasticsearch.QueryDsl.ChildScoreMode? ScoreMode { get; set; }

	[JsonInclude, JsonPropertyName("type")]
	public string Type { get; set; }

	public static implicit operator Query(HasChildQuery hasChildQuery) => QueryDsl.Query.HasChild(hasChildQuery);
}

public sealed partial class HasChildQueryDescriptor<TDocument> : SerializableDescriptor<HasChildQueryDescriptor<TDocument>>
{
	internal HasChildQueryDescriptor(Action<HasChildQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
	public HasChildQueryDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Core.Search.InnerHits? InnerHitsValue { get; set; }

	private Core.Search.InnerHitsDescriptor<TDocument> InnerHitsDescriptor { get; set; }

	private Action<Core.Search.InnerHitsDescriptor<TDocument>> InnerHitsDescriptorAction { get; set; }

	private Elastic.Clients.Elasticsearch.QueryDsl.Query QueryValue { get; set; }

	private QueryDescriptor<TDocument> QueryDescriptor { get; set; }

	private Action<QueryDescriptor<TDocument>> QueryDescriptorAction { get; set; }

	private string? QueryNameValue { get; set; }

	private float? BoostValue { get; set; }

	private bool? IgnoreUnmappedValue { get; set; }

	private int? MaxChildrenValue { get; set; }

	private int? MinChildrenValue { get; set; }

	private Elastic.Clients.Elasticsearch.QueryDsl.ChildScoreMode? ScoreModeValue { get; set; }

	private string TypeValue { get; set; }

	public HasChildQueryDescriptor<TDocument> InnerHits(Elastic.Clients.Elasticsearch.Core.Search.InnerHits? innerHits)
	{
		InnerHitsDescriptor = null;
		InnerHitsDescriptorAction = null;
		InnerHitsValue = innerHits;
		return Self;
	}

	public HasChildQueryDescriptor<TDocument> InnerHits(Core.Search.InnerHitsDescriptor<TDocument> descriptor)
	{
		InnerHitsValue = null;
		InnerHitsDescriptorAction = null;
		InnerHitsDescriptor = descriptor;
		return Self;
	}

	public HasChildQueryDescriptor<TDocument> InnerHits(Action<Core.Search.InnerHitsDescriptor<TDocument>> configure)
	{
		InnerHitsValue = null;
		InnerHitsDescriptor = null;
		InnerHitsDescriptorAction = configure;
		return Self;
	}

	public HasChildQueryDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.Query query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public HasChildQueryDescriptor<TDocument> Query(QueryDescriptor<TDocument> descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public HasChildQueryDescriptor<TDocument> Query(Action<QueryDescriptor<TDocument>> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	public HasChildQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public HasChildQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public HasChildQueryDescriptor<TDocument> IgnoreUnmapped(bool? ignoreUnmapped = true)
	{
		IgnoreUnmappedValue = ignoreUnmapped;
		return Self;
	}

	public HasChildQueryDescriptor<TDocument> MaxChildren(int? maxChildren)
	{
		MaxChildrenValue = maxChildren;
		return Self;
	}

	public HasChildQueryDescriptor<TDocument> MinChildren(int? minChildren)
	{
		MinChildrenValue = minChildren;
		return Self;
	}

	public HasChildQueryDescriptor<TDocument> ScoreMode(Elastic.Clients.Elasticsearch.QueryDsl.ChildScoreMode? scoreMode)
	{
		ScoreModeValue = scoreMode;
		return Self;
	}

	public HasChildQueryDescriptor<TDocument> Type(string type)
	{
		TypeValue = type;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (InnerHitsDescriptor is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, InnerHitsDescriptor, options);
		}
		else if (InnerHitsDescriptorAction is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, new Core.Search.InnerHitsDescriptor<TDocument>(InnerHitsDescriptorAction), options);
		}
		else if (InnerHitsValue is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, InnerHitsValue, options);
		}

		if (QueryDescriptor is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryDescriptor, options);
		}
		else if (QueryDescriptorAction is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, new QueryDescriptor<TDocument>(QueryDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
		}

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

		if (IgnoreUnmappedValue.HasValue)
		{
			writer.WritePropertyName("ignore_unmapped");
			writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
		}

		if (MaxChildrenValue.HasValue)
		{
			writer.WritePropertyName("max_children");
			writer.WriteNumberValue(MaxChildrenValue.Value);
		}

		if (MinChildrenValue.HasValue)
		{
			writer.WritePropertyName("min_children");
			writer.WriteNumberValue(MinChildrenValue.Value);
		}

		if (ScoreModeValue is not null)
		{
			writer.WritePropertyName("score_mode");
			JsonSerializer.Serialize(writer, ScoreModeValue, options);
		}

		writer.WritePropertyName("type");
		JsonSerializer.Serialize(writer, TypeValue, options);
		writer.WriteEndObject();
	}
}

public sealed partial class HasChildQueryDescriptor : SerializableDescriptor<HasChildQueryDescriptor>
{
	internal HasChildQueryDescriptor(Action<HasChildQueryDescriptor> configure) => configure.Invoke(this);
	public HasChildQueryDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Core.Search.InnerHits? InnerHitsValue { get; set; }

	private Core.Search.InnerHitsDescriptor InnerHitsDescriptor { get; set; }

	private Action<Core.Search.InnerHitsDescriptor> InnerHitsDescriptorAction { get; set; }

	private Elastic.Clients.Elasticsearch.QueryDsl.Query QueryValue { get; set; }

	private QueryDescriptor QueryDescriptor { get; set; }

	private Action<QueryDescriptor> QueryDescriptorAction { get; set; }

	private string? QueryNameValue { get; set; }

	private float? BoostValue { get; set; }

	private bool? IgnoreUnmappedValue { get; set; }

	private int? MaxChildrenValue { get; set; }

	private int? MinChildrenValue { get; set; }

	private Elastic.Clients.Elasticsearch.QueryDsl.ChildScoreMode? ScoreModeValue { get; set; }

	private string TypeValue { get; set; }

	public HasChildQueryDescriptor InnerHits(Elastic.Clients.Elasticsearch.Core.Search.InnerHits? innerHits)
	{
		InnerHitsDescriptor = null;
		InnerHitsDescriptorAction = null;
		InnerHitsValue = innerHits;
		return Self;
	}

	public HasChildQueryDescriptor InnerHits(Core.Search.InnerHitsDescriptor descriptor)
	{
		InnerHitsValue = null;
		InnerHitsDescriptorAction = null;
		InnerHitsDescriptor = descriptor;
		return Self;
	}

	public HasChildQueryDescriptor InnerHits(Action<Core.Search.InnerHitsDescriptor> configure)
	{
		InnerHitsValue = null;
		InnerHitsDescriptor = null;
		InnerHitsDescriptorAction = configure;
		return Self;
	}

	public HasChildQueryDescriptor Query(Elastic.Clients.Elasticsearch.QueryDsl.Query query)
	{
		QueryDescriptor = null;
		QueryDescriptorAction = null;
		QueryValue = query;
		return Self;
	}

	public HasChildQueryDescriptor Query(QueryDescriptor descriptor)
	{
		QueryValue = null;
		QueryDescriptorAction = null;
		QueryDescriptor = descriptor;
		return Self;
	}

	public HasChildQueryDescriptor Query(Action<QueryDescriptor> configure)
	{
		QueryValue = null;
		QueryDescriptor = null;
		QueryDescriptorAction = configure;
		return Self;
	}

	public HasChildQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	public HasChildQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public HasChildQueryDescriptor IgnoreUnmapped(bool? ignoreUnmapped = true)
	{
		IgnoreUnmappedValue = ignoreUnmapped;
		return Self;
	}

	public HasChildQueryDescriptor MaxChildren(int? maxChildren)
	{
		MaxChildrenValue = maxChildren;
		return Self;
	}

	public HasChildQueryDescriptor MinChildren(int? minChildren)
	{
		MinChildrenValue = minChildren;
		return Self;
	}

	public HasChildQueryDescriptor ScoreMode(Elastic.Clients.Elasticsearch.QueryDsl.ChildScoreMode? scoreMode)
	{
		ScoreModeValue = scoreMode;
		return Self;
	}

	public HasChildQueryDescriptor Type(string type)
	{
		TypeValue = type;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (InnerHitsDescriptor is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, InnerHitsDescriptor, options);
		}
		else if (InnerHitsDescriptorAction is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, new Core.Search.InnerHitsDescriptor(InnerHitsDescriptorAction), options);
		}
		else if (InnerHitsValue is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, InnerHitsValue, options);
		}

		if (QueryDescriptor is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryDescriptor, options);
		}
		else if (QueryDescriptorAction is not null)
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, new QueryDescriptor(QueryDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("query");
			JsonSerializer.Serialize(writer, QueryValue, options);
		}

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

		if (IgnoreUnmappedValue.HasValue)
		{
			writer.WritePropertyName("ignore_unmapped");
			writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
		}

		if (MaxChildrenValue.HasValue)
		{
			writer.WritePropertyName("max_children");
			writer.WriteNumberValue(MaxChildrenValue.Value);
		}

		if (MinChildrenValue.HasValue)
		{
			writer.WritePropertyName("min_children");
			writer.WriteNumberValue(MinChildrenValue.Value);
		}

		if (ScoreModeValue is not null)
		{
			writer.WritePropertyName("score_mode");
			JsonSerializer.Serialize(writer, ScoreModeValue, options);
		}

		writer.WritePropertyName("type");
		JsonSerializer.Serialize(writer, TypeValue, options);
		writer.WriteEndObject();
	}
}