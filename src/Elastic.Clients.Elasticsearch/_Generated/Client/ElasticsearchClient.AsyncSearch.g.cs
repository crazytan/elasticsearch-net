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
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Elastic.Clients.Elasticsearch.AsyncSearch;
public partial class AsyncSearchNamespacedClient : NamespacedClientProxy
{
	/// <summary>
	/// Initializes a new instance of the <see cref="AsyncSearchNamespacedClient"/> class for mocking.
	/// </summary>			
	protected AsyncSearchNamespacedClient() : base()
	{
	}

	internal AsyncSearchNamespacedClient(ElasticsearchClient client) : base(client)
	{
	}

	public virtual AsyncSearchStatusResponse Status(AsyncSearchStatusRequest request)
	{
		request.BeforeRequest();
		return DoRequest<AsyncSearchStatusRequest, AsyncSearchStatusResponse, AsyncSearchStatusRequestParameters>(request);
	}

	public virtual Task<AsyncSearchStatusResponse> StatusAsync(AsyncSearchStatusRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<AsyncSearchStatusRequest, AsyncSearchStatusResponse, AsyncSearchStatusRequestParameters>(request, cancellationToken);
	}

	public virtual AsyncSearchStatusResponse Status(Elastic.Clients.Elasticsearch.Id id)
	{
		var descriptor = new AsyncSearchStatusRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequest<AsyncSearchStatusRequestDescriptor, AsyncSearchStatusResponse, AsyncSearchStatusRequestParameters>(descriptor);
	}

	public virtual AsyncSearchStatusResponse Status(Elastic.Clients.Elasticsearch.Id id, Action<AsyncSearchStatusRequestDescriptor> configureRequest)
	{
		var descriptor = new AsyncSearchStatusRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<AsyncSearchStatusRequestDescriptor, AsyncSearchStatusResponse, AsyncSearchStatusRequestParameters>(descriptor);
	}

	public virtual AsyncSearchStatusResponse Status<TDocument>(Elastic.Clients.Elasticsearch.Id id, Action<AsyncSearchStatusRequestDescriptor<TDocument>> configureRequest)
	{
		var descriptor = new AsyncSearchStatusRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<AsyncSearchStatusRequestDescriptor<TDocument>, AsyncSearchStatusResponse, AsyncSearchStatusRequestParameters>(descriptor);
	}

	public virtual Task<AsyncSearchStatusResponse> StatusAsync(Elastic.Clients.Elasticsearch.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new AsyncSearchStatusRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<AsyncSearchStatusRequestDescriptor, AsyncSearchStatusResponse, AsyncSearchStatusRequestParameters>(descriptor);
	}

	public virtual Task<AsyncSearchStatusResponse> StatusAsync(Elastic.Clients.Elasticsearch.Id id, Action<AsyncSearchStatusRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new AsyncSearchStatusRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<AsyncSearchStatusRequestDescriptor, AsyncSearchStatusResponse, AsyncSearchStatusRequestParameters>(descriptor);
	}

	public virtual Task<AsyncSearchStatusResponse> StatusAsync<TDocument>(Elastic.Clients.Elasticsearch.Id id, Action<AsyncSearchStatusRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new AsyncSearchStatusRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<AsyncSearchStatusRequestDescriptor<TDocument>, AsyncSearchStatusResponse, AsyncSearchStatusRequestParameters>(descriptor);
	}

	public virtual AsyncSearchSubmitResponse<TDocument> Submit<TDocument>(AsyncSearchSubmitRequest request)
	{
		request.BeforeRequest();
		return DoRequest<AsyncSearchSubmitRequest, AsyncSearchSubmitResponse<TDocument>, AsyncSearchSubmitRequestParameters>(request);
	}

	public virtual Task<AsyncSearchSubmitResponse<TDocument>> SubmitAsync<TDocument>(AsyncSearchSubmitRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<AsyncSearchSubmitRequest, AsyncSearchSubmitResponse<TDocument>, AsyncSearchSubmitRequestParameters>(request, cancellationToken);
	}

	public virtual AsyncSearchSubmitResponse<TDocument> Submit<TDocument>()
	{
		var descriptor = new AsyncSearchSubmitRequestDescriptor<TDocument>();
		descriptor.BeforeRequest();
		return DoRequest<AsyncSearchSubmitRequestDescriptor<TDocument>, AsyncSearchSubmitResponse<TDocument>, AsyncSearchSubmitRequestParameters>(descriptor);
	}

	public virtual AsyncSearchSubmitResponse<TDocument> Submit<TDocument>(Action<AsyncSearchSubmitRequestDescriptor<TDocument>> configureRequest)
	{
		var descriptor = new AsyncSearchSubmitRequestDescriptor<TDocument>();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<AsyncSearchSubmitRequestDescriptor<TDocument>, AsyncSearchSubmitResponse<TDocument>, AsyncSearchSubmitRequestParameters>(descriptor);
	}

	public virtual Task<AsyncSearchSubmitResponse<TDocument>> SubmitAsync<TDocument>(CancellationToken cancellationToken = default)
	{
		var descriptor = new AsyncSearchSubmitRequestDescriptor<TDocument>();
		descriptor.BeforeRequest();
		return DoRequestAsync<AsyncSearchSubmitRequestDescriptor<TDocument>, AsyncSearchSubmitResponse<TDocument>, AsyncSearchSubmitRequestParameters>(descriptor);
	}

	public virtual Task<AsyncSearchSubmitResponse<TDocument>> SubmitAsync<TDocument>(Action<AsyncSearchSubmitRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new AsyncSearchSubmitRequestDescriptor<TDocument>();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<AsyncSearchSubmitRequestDescriptor<TDocument>, AsyncSearchSubmitResponse<TDocument>, AsyncSearchSubmitRequestParameters>(descriptor);
	}

	public virtual DeleteAsyncSearchResponse Delete(DeleteAsyncSearchRequest request)
	{
		request.BeforeRequest();
		return DoRequest<DeleteAsyncSearchRequest, DeleteAsyncSearchResponse, DeleteAsyncSearchRequestParameters>(request);
	}

	public virtual Task<DeleteAsyncSearchResponse> DeleteAsync(DeleteAsyncSearchRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<DeleteAsyncSearchRequest, DeleteAsyncSearchResponse, DeleteAsyncSearchRequestParameters>(request, cancellationToken);
	}

	public virtual DeleteAsyncSearchResponse Delete(Elastic.Clients.Elasticsearch.Id id)
	{
		var descriptor = new DeleteAsyncSearchRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequest<DeleteAsyncSearchRequestDescriptor, DeleteAsyncSearchResponse, DeleteAsyncSearchRequestParameters>(descriptor);
	}

	public virtual DeleteAsyncSearchResponse Delete(Elastic.Clients.Elasticsearch.Id id, Action<DeleteAsyncSearchRequestDescriptor> configureRequest)
	{
		var descriptor = new DeleteAsyncSearchRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<DeleteAsyncSearchRequestDescriptor, DeleteAsyncSearchResponse, DeleteAsyncSearchRequestParameters>(descriptor);
	}

	public virtual DeleteAsyncSearchResponse Delete<TDocument>(Elastic.Clients.Elasticsearch.Id id, Action<DeleteAsyncSearchRequestDescriptor<TDocument>> configureRequest)
	{
		var descriptor = new DeleteAsyncSearchRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<DeleteAsyncSearchRequestDescriptor<TDocument>, DeleteAsyncSearchResponse, DeleteAsyncSearchRequestParameters>(descriptor);
	}

	public virtual Task<DeleteAsyncSearchResponse> DeleteAsync(Elastic.Clients.Elasticsearch.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteAsyncSearchRequestDescriptor(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteAsyncSearchRequestDescriptor, DeleteAsyncSearchResponse, DeleteAsyncSearchRequestParameters>(descriptor);
	}

	public virtual Task<DeleteAsyncSearchResponse> DeleteAsync(Elastic.Clients.Elasticsearch.Id id, Action<DeleteAsyncSearchRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteAsyncSearchRequestDescriptor(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteAsyncSearchRequestDescriptor, DeleteAsyncSearchResponse, DeleteAsyncSearchRequestParameters>(descriptor);
	}

	public virtual Task<DeleteAsyncSearchResponse> DeleteAsync<TDocument>(Elastic.Clients.Elasticsearch.Id id, Action<DeleteAsyncSearchRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteAsyncSearchRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteAsyncSearchRequestDescriptor<TDocument>, DeleteAsyncSearchResponse, DeleteAsyncSearchRequestParameters>(descriptor);
	}

	public virtual GetAsyncSearchResponse<TDocument> Get<TDocument>(GetAsyncSearchRequest request)
	{
		request.BeforeRequest();
		return DoRequest<GetAsyncSearchRequest, GetAsyncSearchResponse<TDocument>, GetAsyncSearchRequestParameters>(request);
	}

	public virtual Task<GetAsyncSearchResponse<TDocument>> GetAsync<TDocument>(GetAsyncSearchRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<GetAsyncSearchRequest, GetAsyncSearchResponse<TDocument>, GetAsyncSearchRequestParameters>(request, cancellationToken);
	}

	public virtual GetAsyncSearchResponse<TDocument> Get<TDocument>(Elastic.Clients.Elasticsearch.Id id)
	{
		var descriptor = new GetAsyncSearchRequestDescriptor<TDocument>(id);
		descriptor.BeforeRequest();
		return DoRequest<GetAsyncSearchRequestDescriptor<TDocument>, GetAsyncSearchResponse<TDocument>, GetAsyncSearchRequestParameters>(descriptor);
	}

	public virtual GetAsyncSearchResponse<TDocument> Get<TDocument>(Elastic.Clients.Elasticsearch.Id id, Action<GetAsyncSearchRequestDescriptor<TDocument>> configureRequest)
	{
		var descriptor = new GetAsyncSearchRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<GetAsyncSearchRequestDescriptor<TDocument>, GetAsyncSearchResponse<TDocument>, GetAsyncSearchRequestParameters>(descriptor);
	}

	public virtual Task<GetAsyncSearchResponse<TDocument>> GetAsync<TDocument>(Elastic.Clients.Elasticsearch.Id id, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetAsyncSearchRequestDescriptor<TDocument>(id);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncSearchRequestDescriptor<TDocument>, GetAsyncSearchResponse<TDocument>, GetAsyncSearchRequestParameters>(descriptor);
	}

	public virtual Task<GetAsyncSearchResponse<TDocument>> GetAsync<TDocument>(Elastic.Clients.Elasticsearch.Id id, Action<GetAsyncSearchRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetAsyncSearchRequestDescriptor<TDocument>(id);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetAsyncSearchRequestDescriptor<TDocument>, GetAsyncSearchResponse<TDocument>, GetAsyncSearchRequestParameters>(descriptor);
	}
}