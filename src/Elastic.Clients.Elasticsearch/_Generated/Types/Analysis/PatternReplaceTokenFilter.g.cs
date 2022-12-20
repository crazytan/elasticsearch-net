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
namespace Elastic.Clients.Elasticsearch.Analysis;
public sealed partial class PatternReplaceTokenFilter : ITokenFilter
{
	[JsonInclude]
	[JsonPropertyName("all")]
	public bool? All { get; set; }

	[JsonInclude]
	[JsonPropertyName("flags")]
	public string? Flags { get; set; }

	[JsonInclude]
	[JsonPropertyName("pattern")]
	public string Pattern { get; set; }

	[JsonInclude]
	[JsonPropertyName("replacement")]
	public string? Replacement { get; set; }

	[JsonInclude]
	[JsonPropertyName("type")]
	public string Type => "pattern_replace";
	[JsonInclude]
	[JsonPropertyName("version")]
	public string? Version { get; set; }
}

public sealed partial class PatternReplaceTokenFilterDescriptor : SerializableDescriptor<PatternReplaceTokenFilterDescriptor>, IBuildableDescriptor<PatternReplaceTokenFilter>
{
	internal PatternReplaceTokenFilterDescriptor(Action<PatternReplaceTokenFilterDescriptor> configure) => configure.Invoke(this);
	public PatternReplaceTokenFilterDescriptor() : base()
	{
	}

	private bool? AllValue { get; set; }

	private string? FlagsValue { get; set; }

	private string PatternValue { get; set; }

	private string? ReplacementValue { get; set; }

	private string? VersionValue { get; set; }

	public PatternReplaceTokenFilterDescriptor All(bool? all = true)
	{
		AllValue = all;
		return Self;
	}

	public PatternReplaceTokenFilterDescriptor Flags(string? flags)
	{
		FlagsValue = flags;
		return Self;
	}

	public PatternReplaceTokenFilterDescriptor Pattern(string pattern)
	{
		PatternValue = pattern;
		return Self;
	}

	public PatternReplaceTokenFilterDescriptor Replacement(string? replacement)
	{
		ReplacementValue = replacement;
		return Self;
	}

	public PatternReplaceTokenFilterDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AllValue.HasValue)
		{
			writer.WritePropertyName("all");
			writer.WriteBooleanValue(AllValue.Value);
		}

		if (!string.IsNullOrEmpty(FlagsValue))
		{
			writer.WritePropertyName("flags");
			writer.WriteStringValue(FlagsValue);
		}

		writer.WritePropertyName("pattern");
		writer.WriteStringValue(PatternValue);
		if (!string.IsNullOrEmpty(ReplacementValue))
		{
			writer.WritePropertyName("replacement");
			writer.WriteStringValue(ReplacementValue);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("pattern_replace");
		if (VersionValue is not null)
		{
			writer.WritePropertyName("version");
			JsonSerializer.Serialize(writer, VersionValue, options);
		}

		writer.WriteEndObject();
	}

	PatternReplaceTokenFilter IBuildableDescriptor<PatternReplaceTokenFilter>.Build() => new()
	{ All = AllValue, Flags = FlagsValue, Pattern = PatternValue, Replacement = ReplacementValue, Version = VersionValue };
}