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
namespace Elastic.Clients.Elasticsearch
{
	public sealed class RankEvalRequestParameters : RequestParameters<RankEvalRequestParameters>
	{
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public string? SearchType { get => Q<string?>("search_type"); set => Q("search_type", value); }
	}

	public partial class RankEvalRequest : PlainRequestBase<RankEvalRequestParameters>
	{
		public RankEvalRequest(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceRankEval;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>? ExpandWildcards { get => Q<IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public string? SearchType { get => Q<string?>("search_type"); set => Q("search_type", value); }

		[JsonInclude]
		[JsonPropertyName("requests")]
		public IEnumerable<Elastic.Clients.Elasticsearch.RankEvalRequestItem> Requests { get; set; }

		[JsonInclude]
		[JsonPropertyName("metric")]
		public Elastic.Clients.Elasticsearch.RankEvalMetric? Metric { get; set; }
	}

	public sealed partial class RankEvalRequestDescriptor<TDocument> : RequestDescriptorBase<RankEvalRequestDescriptor<TDocument>, RankEvalRequestParameters>
	{
		internal RankEvalRequestDescriptor(Action<RankEvalRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		public RankEvalRequestDescriptor(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
		{
		}

		internal RankEvalRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceRankEval;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		public RankEvalRequestDescriptor<TDocument> AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
		public RankEvalRequestDescriptor<TDocument> ExpandWildcards(IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public RankEvalRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
		public RankEvalRequestDescriptor<TDocument> SearchType(string? searchType) => Qs("search_type", searchType);
		public RankEvalRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices indices)
		{
			RouteValues.Required("index", indices);
			return Self;
		}

		private IEnumerable<Elastic.Clients.Elasticsearch.RankEvalRequestItem> RequestsValue { get; set; }

		private RankEvalRequestItemDescriptor<TDocument> RequestsDescriptor { get; set; }

		private Action<RankEvalRequestItemDescriptor<TDocument>> RequestsDescriptorAction { get; set; }

		private Action<RankEvalRequestItemDescriptor<TDocument>>[] RequestsDescriptorActions { get; set; }

		private Elastic.Clients.Elasticsearch.RankEvalMetric? MetricValue { get; set; }

		private RankEvalMetricDescriptor MetricDescriptor { get; set; }

		private Action<RankEvalMetricDescriptor> MetricDescriptorAction { get; set; }

		public RankEvalRequestDescriptor<TDocument> Requests(IEnumerable<Elastic.Clients.Elasticsearch.RankEvalRequestItem> requests)
		{
			RequestsDescriptor = null;
			RequestsDescriptorAction = null;
			RequestsDescriptorActions = null;
			RequestsValue = requests;
			return Self;
		}

		public RankEvalRequestDescriptor<TDocument> Requests(RankEvalRequestItemDescriptor<TDocument> descriptor)
		{
			RequestsValue = null;
			RequestsDescriptorAction = null;
			RequestsDescriptorActions = null;
			RequestsDescriptor = descriptor;
			return Self;
		}

		public RankEvalRequestDescriptor<TDocument> Requests(Action<RankEvalRequestItemDescriptor<TDocument>> configure)
		{
			RequestsValue = null;
			RequestsDescriptor = null;
			RequestsDescriptorActions = null;
			RequestsDescriptorAction = configure;
			return Self;
		}

		public RankEvalRequestDescriptor<TDocument> Requests(params Action<RankEvalRequestItemDescriptor<TDocument>>[] configure)
		{
			RequestsValue = null;
			RequestsDescriptor = null;
			RequestsDescriptorAction = null;
			RequestsDescriptorActions = configure;
			return Self;
		}

		public RankEvalRequestDescriptor<TDocument> Metric(Elastic.Clients.Elasticsearch.RankEvalMetric? metric)
		{
			MetricDescriptor = null;
			MetricDescriptorAction = null;
			MetricValue = metric;
			return Self;
		}

		public RankEvalRequestDescriptor<TDocument> Metric(RankEvalMetricDescriptor descriptor)
		{
			MetricValue = null;
			MetricDescriptorAction = null;
			MetricDescriptor = descriptor;
			return Self;
		}

		public RankEvalRequestDescriptor<TDocument> Metric(Action<RankEvalMetricDescriptor> configure)
		{
			MetricValue = null;
			MetricDescriptor = null;
			MetricDescriptorAction = configure;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (RequestsDescriptor is not null)
			{
				writer.WritePropertyName("requests");
				writer.WriteStartArray();
				JsonSerializer.Serialize(writer, RequestsDescriptor, options);
				writer.WriteEndArray();
			}
			else if (RequestsDescriptorAction is not null)
			{
				writer.WritePropertyName("requests");
				writer.WriteStartArray();
				JsonSerializer.Serialize(writer, new RankEvalRequestItemDescriptor<TDocument>(RequestsDescriptorAction), options);
				writer.WriteEndArray();
			}
			else if (RequestsDescriptorActions is not null)
			{
				writer.WritePropertyName("requests");
				writer.WriteStartArray();
				foreach (var action in RequestsDescriptorActions)
				{
					JsonSerializer.Serialize(writer, new RankEvalRequestItemDescriptor<TDocument>(action), options);
				}

				writer.WriteEndArray();
			}
			else
			{
				writer.WritePropertyName("requests");
				JsonSerializer.Serialize(writer, RequestsValue, options);
			}

			if (MetricDescriptor is not null)
			{
				writer.WritePropertyName("metric");
				JsonSerializer.Serialize(writer, MetricDescriptor, options);
			}
			else if (MetricDescriptorAction is not null)
			{
				writer.WritePropertyName("metric");
				JsonSerializer.Serialize(writer, new RankEvalMetricDescriptor(MetricDescriptorAction), options);
			}
			else if (MetricValue is not null)
			{
				writer.WritePropertyName("metric");
				JsonSerializer.Serialize(writer, MetricValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class RankEvalRequestDescriptor : RequestDescriptorBase<RankEvalRequestDescriptor, RankEvalRequestParameters>
	{
		internal RankEvalRequestDescriptor(Action<RankEvalRequestDescriptor> configure) => configure.Invoke(this);
		public RankEvalRequestDescriptor(Elastic.Clients.Elasticsearch.Indices indices) : base(r => r.Required("index", indices))
		{
		}

		internal RankEvalRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespaceRankEval;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		public RankEvalRequestDescriptor AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
		public RankEvalRequestDescriptor ExpandWildcards(IEnumerable<Elastic.Clients.Elasticsearch.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public RankEvalRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
		public RankEvalRequestDescriptor SearchType(string? searchType) => Qs("search_type", searchType);
		public RankEvalRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices indices)
		{
			RouteValues.Required("index", indices);
			return Self;
		}

		private IEnumerable<Elastic.Clients.Elasticsearch.RankEvalRequestItem> RequestsValue { get; set; }

		private RankEvalRequestItemDescriptor RequestsDescriptor { get; set; }

		private Action<RankEvalRequestItemDescriptor> RequestsDescriptorAction { get; set; }

		private Action<RankEvalRequestItemDescriptor>[] RequestsDescriptorActions { get; set; }

		private Elastic.Clients.Elasticsearch.RankEvalMetric? MetricValue { get; set; }

		private RankEvalMetricDescriptor MetricDescriptor { get; set; }

		private Action<RankEvalMetricDescriptor> MetricDescriptorAction { get; set; }

		public RankEvalRequestDescriptor Requests(IEnumerable<Elastic.Clients.Elasticsearch.RankEvalRequestItem> requests)
		{
			RequestsDescriptor = null;
			RequestsDescriptorAction = null;
			RequestsDescriptorActions = null;
			RequestsValue = requests;
			return Self;
		}

		public RankEvalRequestDescriptor Requests(RankEvalRequestItemDescriptor descriptor)
		{
			RequestsValue = null;
			RequestsDescriptorAction = null;
			RequestsDescriptorActions = null;
			RequestsDescriptor = descriptor;
			return Self;
		}

		public RankEvalRequestDescriptor Requests(Action<RankEvalRequestItemDescriptor> configure)
		{
			RequestsValue = null;
			RequestsDescriptor = null;
			RequestsDescriptorActions = null;
			RequestsDescriptorAction = configure;
			return Self;
		}

		public RankEvalRequestDescriptor Requests(params Action<RankEvalRequestItemDescriptor>[] configure)
		{
			RequestsValue = null;
			RequestsDescriptor = null;
			RequestsDescriptorAction = null;
			RequestsDescriptorActions = configure;
			return Self;
		}

		public RankEvalRequestDescriptor Metric(Elastic.Clients.Elasticsearch.RankEvalMetric? metric)
		{
			MetricDescriptor = null;
			MetricDescriptorAction = null;
			MetricValue = metric;
			return Self;
		}

		public RankEvalRequestDescriptor Metric(RankEvalMetricDescriptor descriptor)
		{
			MetricValue = null;
			MetricDescriptorAction = null;
			MetricDescriptor = descriptor;
			return Self;
		}

		public RankEvalRequestDescriptor Metric(Action<RankEvalMetricDescriptor> configure)
		{
			MetricValue = null;
			MetricDescriptor = null;
			MetricDescriptorAction = configure;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (RequestsDescriptor is not null)
			{
				writer.WritePropertyName("requests");
				writer.WriteStartArray();
				JsonSerializer.Serialize(writer, RequestsDescriptor, options);
				writer.WriteEndArray();
			}
			else if (RequestsDescriptorAction is not null)
			{
				writer.WritePropertyName("requests");
				writer.WriteStartArray();
				JsonSerializer.Serialize(writer, new RankEvalRequestItemDescriptor(RequestsDescriptorAction), options);
				writer.WriteEndArray();
			}
			else if (RequestsDescriptorActions is not null)
			{
				writer.WritePropertyName("requests");
				writer.WriteStartArray();
				foreach (var action in RequestsDescriptorActions)
				{
					JsonSerializer.Serialize(writer, new RankEvalRequestItemDescriptor(action), options);
				}

				writer.WriteEndArray();
			}
			else
			{
				writer.WritePropertyName("requests");
				JsonSerializer.Serialize(writer, RequestsValue, options);
			}

			if (MetricDescriptor is not null)
			{
				writer.WritePropertyName("metric");
				JsonSerializer.Serialize(writer, MetricDescriptor, options);
			}
			else if (MetricDescriptorAction is not null)
			{
				writer.WritePropertyName("metric");
				JsonSerializer.Serialize(writer, new RankEvalMetricDescriptor(MetricDescriptorAction), options);
			}
			else if (MetricValue is not null)
			{
				writer.WritePropertyName("metric");
				JsonSerializer.Serialize(writer, MetricValue, options);
			}

			writer.WriteEndObject();
		}
	}
}