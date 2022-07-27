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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Analysis
{
	public sealed partial class PatternAnalyzer : IAnalyzer
	{
		[JsonInclude]
		[JsonPropertyName("flags")]
		public string? Flags { get; set; }

		[JsonInclude]
		[JsonPropertyName("lowercase")]
		public bool? Lowercase { get; set; }

		[JsonInclude]
		[JsonPropertyName("pattern")]
		public string Pattern { get; set; }

		[JsonInclude]
		[JsonPropertyName("stopwords")]
		[JsonConverter(typeof(StopWordsConverter))]
		public IEnumerable<string>? Stopwords { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "pattern";
		[JsonInclude]
		[JsonPropertyName("version")]
		public string? Version { get; set; }
	}

	public sealed partial class PatternAnalyzerDescriptor : SerializableDescriptorBase<PatternAnalyzerDescriptor>, IBuildableDescriptor<PatternAnalyzer>
	{
		internal PatternAnalyzerDescriptor(Action<PatternAnalyzerDescriptor> configure) => configure.Invoke(this);
		public PatternAnalyzerDescriptor() : base()
		{
		}

		private string? FlagsValue { get; set; }

		private bool? LowercaseValue { get; set; }

		private string PatternValue { get; set; }

		private IEnumerable<string>? StopwordsValue { get; set; }

		private string? VersionValue { get; set; }

		public PatternAnalyzerDescriptor Flags(string? flags)
		{
			FlagsValue = flags;
			return Self;
		}

		public PatternAnalyzerDescriptor Lowercase(bool? lowercase = true)
		{
			LowercaseValue = lowercase;
			return Self;
		}

		public PatternAnalyzerDescriptor Pattern(string pattern)
		{
			PatternValue = pattern;
			return Self;
		}

		public PatternAnalyzerDescriptor Stopwords(IEnumerable<string>? stopwords)
		{
			StopwordsValue = stopwords;
			return Self;
		}

		public PatternAnalyzerDescriptor Version(string? version)
		{
			VersionValue = version;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(FlagsValue))
			{
				writer.WritePropertyName("flags");
				writer.WriteStringValue(FlagsValue);
			}

			if (LowercaseValue.HasValue)
			{
				writer.WritePropertyName("lowercase");
				writer.WriteBooleanValue(LowercaseValue.Value);
			}

			writer.WritePropertyName("pattern");
			writer.WriteStringValue(PatternValue);
			if (StopwordsValue is not null)
			{
				writer.WritePropertyName("stopwords");
				SingleOrManySerializationHelper.Serialize<string>(StopwordsValue, writer, options);
			}

			writer.WritePropertyName("type");
			writer.WriteStringValue("pattern");
			if (VersionValue is not null)
			{
				writer.WritePropertyName("version");
				JsonSerializer.Serialize(writer, VersionValue, options);
			}

			writer.WriteEndObject();
		}

		PatternAnalyzer IBuildableDescriptor<PatternAnalyzer>.Build() => new()
		{ Flags = FlagsValue, Lowercase = LowercaseValue, Pattern = PatternValue, Stopwords = StopwordsValue, Version = VersionValue };
	}
}