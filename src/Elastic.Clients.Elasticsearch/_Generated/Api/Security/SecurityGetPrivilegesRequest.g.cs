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
namespace Elastic.Clients.Elasticsearch.Security
{
	public class SecurityGetPrivilegesRequestParameters : RequestParameters<SecurityGetPrivilegesRequestParameters>
	{
	}

	public partial class SecurityGetPrivilegesRequest : PlainRequestBase<SecurityGetPrivilegesRequestParameters>
	{
		public SecurityGetPrivilegesRequest()
		{
		}

		public SecurityGetPrivilegesRequest(Elastic.Clients.Elasticsearch.Name? application) : base(r => r.Optional("application", application))
		{
		}

		public SecurityGetPrivilegesRequest(Elastic.Clients.Elasticsearch.Name? application, Elastic.Clients.Elasticsearch.Names? name) : base(r => r.Optional("application", application).Optional("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityGetPrivileges;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public sealed partial class SecurityGetPrivilegesRequestDescriptor : RequestDescriptorBase<SecurityGetPrivilegesRequestDescriptor, SecurityGetPrivilegesRequestParameters>
	{
		internal SecurityGetPrivilegesRequestDescriptor(Action<SecurityGetPrivilegesRequestDescriptor> configure) => configure.Invoke(this);
		public SecurityGetPrivilegesRequestDescriptor()
		{
		}

		public SecurityGetPrivilegesRequestDescriptor(Elastic.Clients.Elasticsearch.Name? application, Elastic.Clients.Elasticsearch.Names? name) : base(r => r.Optional("application", application).Optional("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityGetPrivileges;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public SecurityGetPrivilegesRequestDescriptor Application(Elastic.Clients.Elasticsearch.Name? application)
		{
			RouteValues.Optional("application", application);
			return Self;
		}

		public SecurityGetPrivilegesRequestDescriptor Name(Elastic.Clients.Elasticsearch.Names? name)
		{
			RouteValues.Optional("name", name);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}