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
// Run the following in the root of the repository:
//
// ------------------------------------------------

using Elastic.Transport;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Nest.Enrich
{
	[ConvertAs(typeof(DeletePolicyRequest))]
	public partial interface IDeletePolicyRequest : IRequest<DeletePolicyRequestParameters>
	{
	}

	public partial class DeletePolicyRequest : PlainRequestBase<DeletePolicyRequestParameters>, IDeletePolicyRequest
	{
		protected IDeletePolicyRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.EnrichDeletePolicy;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_enrich/policy/{name}</summary>
        public DeletePolicyRequest(Nest.Name name) : base(r => r.Required("name", name))
		{
		}
	}

	[ConvertAs(typeof(ExecutePolicyRequest))]
	public partial interface IExecutePolicyRequest : IRequest<ExecutePolicyRequestParameters>
	{
	}

	public partial class ExecutePolicyRequest : PlainRequestBase<ExecutePolicyRequestParameters>, IExecutePolicyRequest
	{
		protected IExecutePolicyRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.EnrichExecutePolicy;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_enrich/policy/{name}/_execute</summary>
        public ExecutePolicyRequest(Nest.Name name) : base(r => r.Required("name", name))
		{
		}

		[JsonIgnore]
		public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
	}

	[ConvertAs(typeof(GetPolicyRequest))]
	public partial interface IGetPolicyRequest : IRequest<GetPolicyRequestParameters>
	{
	}

	public partial class GetPolicyRequest : PlainRequestBase<GetPolicyRequestParameters>, IGetPolicyRequest
	{
		protected IGetPolicyRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.EnrichGetPolicy;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_enrich/policy/{name}</summary>
        public GetPolicyRequest(Nest.Names? name) : base(r => r.Optional("name", name))
		{
		}

		///<summary>/_enrich/policy/</summary>
        public GetPolicyRequest() : base()
		{
		}
	}

	[ConvertAs(typeof(PutPolicyRequest))]
	public partial interface IPutPolicyRequest : IRequest<PutPolicyRequestParameters>
	{
	}

	public partial class PutPolicyRequest : PlainRequestBase<PutPolicyRequestParameters>, IPutPolicyRequest
	{
		protected IPutPolicyRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.EnrichPutPolicy;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_enrich/policy/{name}</summary>
        public PutPolicyRequest(Nest.Name name) : base(r => r.Required("name", name))
		{
		}

		[JsonPropertyName("geo_match")]
		public Nest.Enrich.Policy? GeoMatch
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("match")]
		public Nest.Enrich.Policy? Match
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	[ConvertAs(typeof(StatsRequest))]
	public partial interface IStatsRequest : IRequest<StatsRequestParameters>
	{
	}

	public partial class StatsRequest : PlainRequestBase<StatsRequestParameters>, IStatsRequest
	{
		protected IStatsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.EnrichStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_enrich/_stats</summary>
        public StatsRequest() : base()
		{
		}
	}
}