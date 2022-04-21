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
namespace Elastic.Clients.Elasticsearch.Nodes
{
	public sealed class NodesInfoRequestParameters : RequestParameters<NodesInfoRequestParameters>
	{
		[JsonIgnore]
		public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }
	}

	public partial class NodesInfoRequest : PlainRequestBase<NodesInfoRequestParameters>
	{
		public NodesInfoRequest()
		{
		}

		public NodesInfoRequest(Elastic.Clients.Elasticsearch.NodeIds? node_id) : base(r => r.Optional("node_id", node_id))
		{
		}

		public NodesInfoRequest(Elastic.Clients.Elasticsearch.Metrics? metric) : base(r => r.Optional("metric", metric))
		{
		}

		public NodesInfoRequest(Elastic.Clients.Elasticsearch.NodeIds? node_id, Elastic.Clients.Elasticsearch.Metrics? metric) : base(r => r.Optional("node_id", node_id).Optional("metric", metric))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesInfo;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }
	}

	public sealed partial class NodesInfoRequestDescriptor : RequestDescriptorBase<NodesInfoRequestDescriptor, NodesInfoRequestParameters>
	{
		internal NodesInfoRequestDescriptor(Action<NodesInfoRequestDescriptor> configure) => configure.Invoke(this);
		public NodesInfoRequestDescriptor()
		{
		}

		public NodesInfoRequestDescriptor(Elastic.Clients.Elasticsearch.Metrics? metric) : base(r => r.Optional("metric", metric))
		{
		}

		public NodesInfoRequestDescriptor(Elastic.Clients.Elasticsearch.NodeIds? node_id, Elastic.Clients.Elasticsearch.Metrics? metric) : base(r => r.Optional("node_id", node_id).Optional("metric", metric))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesInfo;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public NodesInfoRequestDescriptor FlatSettings(bool? flatSettings = true) => Qs("flat_settings", flatSettings);
		public NodesInfoRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public NodesInfoRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		public NodesInfoRequestDescriptor NodeId(Elastic.Clients.Elasticsearch.NodeIds? node_id)
		{
			RouteValues.Optional("node_id", node_id);
			return Self;
		}

		public NodesInfoRequestDescriptor Metric(Elastic.Clients.Elasticsearch.Metrics? metric)
		{
			RouteValues.Optional("metric", metric);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}