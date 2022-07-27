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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Snapshot
{
	public sealed class CreateSnapshotRequestParameters : RequestParameters<CreateSnapshotRequestParameters>
	{
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
	}

	public sealed partial class CreateSnapshotRequest : PlainRequestBase<CreateSnapshotRequestParameters>
	{
		public CreateSnapshotRequest(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot) : base(r => r.Required("repository", repository).Required("snapshot", snapshot))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotCreate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }

		[JsonInclude]
		[JsonPropertyName("ignore_unavailable")]
		public bool? IgnoreUnavailable { get; set; }

		[JsonInclude]
		[JsonPropertyName("include_global_state")]
		public bool? IncludeGlobalState { get; set; }

		[JsonInclude]
		[JsonPropertyName("indices")]
		public Elastic.Clients.Elasticsearch.Indices? Indices { get; set; }

		[JsonInclude]
		[JsonPropertyName("feature_states")]
		public IEnumerable<string>? FeatureStates { get; set; }

		[JsonInclude]
		[JsonPropertyName("metadata")]
		public Dictionary<string, object>? Metadata { get; set; }

		[JsonInclude]
		[JsonPropertyName("partial")]
		public bool? Partial { get; set; }
	}

	public sealed partial class CreateSnapshotRequestDescriptor : RequestDescriptorBase<CreateSnapshotRequestDescriptor, CreateSnapshotRequestParameters>
	{
		internal CreateSnapshotRequestDescriptor(Action<CreateSnapshotRequestDescriptor> configure) => configure.Invoke(this);
		public CreateSnapshotRequestDescriptor(Elastic.Clients.Elasticsearch.Name repository, Elastic.Clients.Elasticsearch.Name snapshot) : base(r => r.Required("repository", repository).Required("snapshot", snapshot))
		{
		}

		internal CreateSnapshotRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.SnapshotCreate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		public CreateSnapshotRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);
		public CreateSnapshotRequestDescriptor WaitForCompletion(bool? waitForCompletion = true) => Qs("wait_for_completion", waitForCompletion);
		public CreateSnapshotRequestDescriptor Repository(Elastic.Clients.Elasticsearch.Name repository)
		{
			RouteValues.Required("repository", repository);
			return Self;
		}

		public CreateSnapshotRequestDescriptor Snapshot(Elastic.Clients.Elasticsearch.Name snapshot)
		{
			RouteValues.Required("snapshot", snapshot);
			return Self;
		}

		private IEnumerable<string>? FeatureStatesValue { get; set; }

		private bool? IgnoreUnavailableValue { get; set; }

		private bool? IncludeGlobalStateValue { get; set; }

		private Elastic.Clients.Elasticsearch.Indices? IndicesValue { get; set; }

		private Dictionary<string, object>? MetadataValue { get; set; }

		private bool? PartialValue { get; set; }

		public CreateSnapshotRequestDescriptor FeatureStates(IEnumerable<string>? featureStates)
		{
			FeatureStatesValue = featureStates;
			return Self;
		}

		public CreateSnapshotRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true)
		{
			IgnoreUnavailableValue = ignoreUnavailable;
			return Self;
		}

		public CreateSnapshotRequestDescriptor IncludeGlobalState(bool? includeGlobalState = true)
		{
			IncludeGlobalStateValue = includeGlobalState;
			return Self;
		}

		public CreateSnapshotRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices? indices)
		{
			IndicesValue = indices;
			return Self;
		}

		public CreateSnapshotRequestDescriptor Metadata(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetadataValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public CreateSnapshotRequestDescriptor Partial(bool? partial = true)
		{
			PartialValue = partial;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FeatureStatesValue is not null)
			{
				writer.WritePropertyName("feature_states");
				JsonSerializer.Serialize(writer, FeatureStatesValue, options);
			}

			if (IgnoreUnavailableValue.HasValue)
			{
				writer.WritePropertyName("ignore_unavailable");
				writer.WriteBooleanValue(IgnoreUnavailableValue.Value);
			}

			if (IncludeGlobalStateValue.HasValue)
			{
				writer.WritePropertyName("include_global_state");
				writer.WriteBooleanValue(IncludeGlobalStateValue.Value);
			}

			if (IndicesValue is not null)
			{
				writer.WritePropertyName("indices");
				JsonSerializer.Serialize(writer, IndicesValue, options);
			}

			if (MetadataValue is not null)
			{
				writer.WritePropertyName("metadata");
				JsonSerializer.Serialize(writer, MetadataValue, options);
			}

			if (PartialValue.HasValue)
			{
				writer.WritePropertyName("partial");
				writer.WriteBooleanValue(PartialValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}