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
	public class SecurityChangePasswordRequestParameters : RequestParameters<SecurityChangePasswordRequestParameters>
	{
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Refresh?>("refresh"); set => Q("refresh", value); }
	}

	public partial class SecurityChangePasswordRequest : PlainRequestBase<SecurityChangePasswordRequestParameters>
	{
		public SecurityChangePasswordRequest()
		{
		}

		public SecurityChangePasswordRequest(Elastic.Clients.Elasticsearch.Username? username) : base(r => r.Optional("username", username))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityChangePassword;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Refresh?>("refresh"); set => Q("refresh", value); }

		[JsonInclude]
		[JsonPropertyName("password")]
		public string? Password { get; set; }

		[JsonInclude]
		[JsonPropertyName("password_hash")]
		public string? PasswordHash { get; set; }
	}

	public sealed partial class SecurityChangePasswordRequestDescriptor : RequestDescriptorBase<SecurityChangePasswordRequestDescriptor, SecurityChangePasswordRequestParameters>
	{
		internal SecurityChangePasswordRequestDescriptor(Action<SecurityChangePasswordRequestDescriptor> configure) => configure.Invoke(this);
		public SecurityChangePasswordRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.SecurityChangePassword;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		public SecurityChangePasswordRequestDescriptor Refresh(Elastic.Clients.Elasticsearch.Refresh? refresh) => Qs("refresh", refresh);
		public SecurityChangePasswordRequestDescriptor Username(Elastic.Clients.Elasticsearch.Username? username)
		{
			RouteValues.Optional("username", username);
			return Self;
		}

		private string? PasswordValue { get; set; }

		private string? PasswordHashValue { get; set; }

		public SecurityChangePasswordRequestDescriptor Password(string? password)
		{
			PasswordValue = password;
			return Self;
		}

		public SecurityChangePasswordRequestDescriptor PasswordHash(string? passwordHash)
		{
			PasswordHashValue = passwordHash;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (PasswordValue is not null)
			{
				writer.WritePropertyName("password");
				JsonSerializer.Serialize(writer, PasswordValue, options);
			}

			if (!string.IsNullOrEmpty(PasswordHashValue))
			{
				writer.WritePropertyName("password_hash");
				writer.WriteStringValue(PasswordHashValue);
			}

			writer.WriteEndObject();
		}
	}
}