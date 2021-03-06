// ************************************************************************
//
// * Copyright 2018 OSIsoft, LLC
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// * 
// *   <http://www.apache.org/licenses/LICENSE-2.0>
// * 
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// ************************************************************************

using System;
using System.Threading;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Linq;
using OSIsoft.PIDevClub.PIWebApiClient.Client;
using OSIsoft.PIDevClub.PIWebApiClient.Model;

namespace OSIsoft.PIDevClub.PIWebApiClient.Api
{


	/// <summary>
	/// Represents a collection of functions to interact with the PI Web API System controller.
	/// </summary>
	public interface ISystemApi
	{
		#region Synchronous Operations
		/// <summary>
		/// Get system links for this PI System Web API instance.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>PISystemLanding</returns>
		PISystemLanding Landing();

		/// <summary>
		/// Get system links for this PI System Web API instance.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse<PISystemLanding></returns>
		ApiResponse<PISystemLanding> LandingWithHttpInfo();

		/// <summary>
		/// Get AF cache instances currently in use by the system. These are caches from which user requests are serviced. The number of instances depends on the number of users connected to the service, the service's authentication method, and the cache instance configuration.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>PIItemsCacheInstance</returns>
		PIItemsCacheInstance CacheInstances();

		/// <summary>
		/// Get AF cache instances currently in use by the system. These are caches from which user requests are serviced. The number of instances depends on the number of users connected to the service, the service's authentication method, and the cache instance configuration.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse<PIItemsCacheInstance></returns>
		ApiResponse<PIItemsCacheInstance> CacheInstancesWithHttpInfo();

		/// <summary>
		/// Get information about this PI Web API instance. Examples of information returned include the system uptime, the number of cache instances for this PI System Web API instance, and the system run state.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>PISystemStatus</returns>
		PISystemStatus Status();

		/// <summary>
		/// Get information about this PI Web API instance. Examples of information returned include the system uptime, the number of cache instances for this PI System Web API instance, and the system run state.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse<PISystemStatus></returns>
		ApiResponse<PISystemStatus> StatusWithHttpInfo();

		/// <summary>
		/// Get information about the Windows identity used to fulfill the request. This depends on the service's authentication method and the credentials passed by the client. The impersonation level of the Windows identity is included.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>PIUserInfo</returns>
		PIUserInfo UserInfo();

		/// <summary>
		/// Get information about the Windows identity used to fulfill the request. This depends on the service's authentication method and the credentials passed by the client. The impersonation level of the Windows identity is included.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse<PIUserInfo></returns>
		ApiResponse<PIUserInfo> UserInfoWithHttpInfo();

		/// <summary>
		/// Get the current versions of the PI Web API instance and all external plugins.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Dictionary<string, PIVersion></returns>
		Dictionary<string, PIVersion> Versions();

		/// <summary>
		/// Get the current versions of the PI Web API instance and all external plugins.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse<Dictionary<string, PIVersion>></returns>
		ApiResponse<Dictionary<string, PIVersion>> VersionsWithHttpInfo();

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Get system links for this PI System Web API instance.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PISystemLanding></returns>
		System.Threading.Tasks.Task<PISystemLanding> LandingAsync(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Get system links for this PI System Web API instance.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PISystemLanding>></returns>
		System.Threading.Tasks.Task<ApiResponse<PISystemLanding>> LandingAsyncWithHttpInfo(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Get AF cache instances currently in use by the system. These are caches from which user requests are serviced. The number of instances depends on the number of users connected to the service, the service's authentication method, and the cache instance configuration.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsCacheInstance></returns>
		System.Threading.Tasks.Task<PIItemsCacheInstance> CacheInstancesAsync(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Get AF cache instances currently in use by the system. These are caches from which user requests are serviced. The number of instances depends on the number of users connected to the service, the service's authentication method, and the cache instance configuration.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsCacheInstance>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsCacheInstance>> CacheInstancesAsyncWithHttpInfo(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Get information about this PI Web API instance. Examples of information returned include the system uptime, the number of cache instances for this PI System Web API instance, and the system run state.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PISystemStatus></returns>
		System.Threading.Tasks.Task<PISystemStatus> StatusAsync(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Get information about this PI Web API instance. Examples of information returned include the system uptime, the number of cache instances for this PI System Web API instance, and the system run state.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PISystemStatus>></returns>
		System.Threading.Tasks.Task<ApiResponse<PISystemStatus>> StatusAsyncWithHttpInfo(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Get information about the Windows identity used to fulfill the request. This depends on the service's authentication method and the credentials passed by the client. The impersonation level of the Windows identity is included.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIUserInfo></returns>
		System.Threading.Tasks.Task<PIUserInfo> UserInfoAsync(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Get information about the Windows identity used to fulfill the request. This depends on the service's authentication method and the credentials passed by the client. The impersonation level of the Windows identity is included.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIUserInfo>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIUserInfo>> UserInfoAsyncWithHttpInfo(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Get the current versions of the PI Web API instance and all external plugins.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Dictionary<string, PIVersion>></returns>
		System.Threading.Tasks.Task<Dictionary<string, PIVersion>> VersionsAsync(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Get the current versions of the PI Web API instance and all external plugins.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Dictionary<string, PIVersion>>></returns>
		System.Threading.Tasks.Task<ApiResponse<Dictionary<string, PIVersion>>> VersionsAsyncWithHttpInfo(CancellationToken cancellationToken = default(CancellationToken));

		#endregion
	}

	public class SystemApi : ISystemApi
	{
		private OSIsoft.PIDevClub.PIWebApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public SystemApi(Configuration configuration = null)
		{
			this.Configuration = configuration;
			ExceptionFactory = OSIsoft.PIDevClub.PIWebApiClient.Client.Configuration.DefaultExceptionFactory;
			if (Configuration.ApiClient.Configuration == null)
			{
				this.Configuration.ApiClient.Configuration = this.Configuration;
			}
		}

		public Configuration Configuration { get; set; }

		public OSIsoft.PIDevClub.PIWebApiClient.Client.ExceptionFactory ExceptionFactory
		{
			get
			{
				if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
				{
					throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
				}
				return _exceptionFactory;
			}
			set { _exceptionFactory = value; }
		}

		#region Synchronous Operations
		/// <summary>
		/// Get system links for this PI System Web API instance.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>PISystemLanding</returns>
		public PISystemLanding Landing()
		{
			ApiResponse<PISystemLanding> localVarResponse = LandingWithHttpInfo();
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get system links for this PI System Web API instance.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse<PISystemLanding></returns>
		public ApiResponse<PISystemLanding> LandingWithHttpInfo()
		{

			var localVarPath = "/system";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("LandingWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PISystemLanding>(localVarStatusCode,
				localVarResponse.Headers,
				(PISystemLanding)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PISystemLanding)));
		}

		/// <summary>
		/// Get AF cache instances currently in use by the system. These are caches from which user requests are serviced. The number of instances depends on the number of users connected to the service, the service's authentication method, and the cache instance configuration.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>PIItemsCacheInstance</returns>
		public PIItemsCacheInstance CacheInstances()
		{
			ApiResponse<PIItemsCacheInstance> localVarResponse = CacheInstancesWithHttpInfo();
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get AF cache instances currently in use by the system. These are caches from which user requests are serviced. The number of instances depends on the number of users connected to the service, the service's authentication method, and the cache instance configuration.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse<PIItemsCacheInstance></returns>
		public ApiResponse<PIItemsCacheInstance> CacheInstancesWithHttpInfo()
		{

			var localVarPath = "/system/cacheinstances";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CacheInstancesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsCacheInstance>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsCacheInstance)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsCacheInstance)));
		}

		/// <summary>
		/// Get information about this PI Web API instance. Examples of information returned include the system uptime, the number of cache instances for this PI System Web API instance, and the system run state.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>PISystemStatus</returns>
		public PISystemStatus Status()
		{
			ApiResponse<PISystemStatus> localVarResponse = StatusWithHttpInfo();
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get information about this PI Web API instance. Examples of information returned include the system uptime, the number of cache instances for this PI System Web API instance, and the system run state.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse<PISystemStatus></returns>
		public ApiResponse<PISystemStatus> StatusWithHttpInfo()
		{

			var localVarPath = "/system/status";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("StatusWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PISystemStatus>(localVarStatusCode,
				localVarResponse.Headers,
				(PISystemStatus)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PISystemStatus)));
		}

		/// <summary>
		/// Get information about the Windows identity used to fulfill the request. This depends on the service's authentication method and the credentials passed by the client. The impersonation level of the Windows identity is included.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>PIUserInfo</returns>
		public PIUserInfo UserInfo()
		{
			ApiResponse<PIUserInfo> localVarResponse = UserInfoWithHttpInfo();
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get information about the Windows identity used to fulfill the request. This depends on the service's authentication method and the credentials passed by the client. The impersonation level of the Windows identity is included.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse<PIUserInfo></returns>
		public ApiResponse<PIUserInfo> UserInfoWithHttpInfo()
		{

			var localVarPath = "/system/userinfo";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UserInfoWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIUserInfo>(localVarStatusCode,
				localVarResponse.Headers,
				(PIUserInfo)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIUserInfo)));
		}

		/// <summary>
		/// Get the current versions of the PI Web API instance and all external plugins.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Dictionary<string, PIVersion></returns>
		public Dictionary<string, PIVersion> Versions()
		{
			ApiResponse<Dictionary<string, PIVersion>> localVarResponse = VersionsWithHttpInfo();
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get the current versions of the PI Web API instance and all external plugins.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse<Dictionary<string, PIVersion>></returns>
		public ApiResponse<Dictionary<string, PIVersion>> VersionsWithHttpInfo()
		{

			var localVarPath = "/system/versions";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("VersionsWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Dictionary<string, PIVersion>>(localVarStatusCode,
				localVarResponse.Headers,
				(Dictionary<string, PIVersion>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, PIVersion>)));
		}

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Get system links for this PI System Web API instance.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PISystemLanding></returns>
		public async System.Threading.Tasks.Task<PISystemLanding> LandingAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PISystemLanding> localVarResponse = await LandingAsyncWithHttpInfo(cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get system links for this PI System Web API instance.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PISystemLanding>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PISystemLanding>> LandingAsyncWithHttpInfo(CancellationToken cancellationToken = default(CancellationToken))
		{

			var localVarPath = "/system";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("LandingAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PISystemLanding>(localVarStatusCode,
				localVarResponse.Headers,
				(PISystemLanding)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PISystemLanding)));
		}

		/// <summary>
		/// Get AF cache instances currently in use by the system. These are caches from which user requests are serviced. The number of instances depends on the number of users connected to the service, the service's authentication method, and the cache instance configuration.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsCacheInstance></returns>
		public async System.Threading.Tasks.Task<PIItemsCacheInstance> CacheInstancesAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsCacheInstance> localVarResponse = await CacheInstancesAsyncWithHttpInfo(cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get AF cache instances currently in use by the system. These are caches from which user requests are serviced. The number of instances depends on the number of users connected to the service, the service's authentication method, and the cache instance configuration.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsCacheInstance>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsCacheInstance>> CacheInstancesAsyncWithHttpInfo(CancellationToken cancellationToken = default(CancellationToken))
		{

			var localVarPath = "/system/cacheinstances";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CacheInstancesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsCacheInstance>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsCacheInstance)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsCacheInstance)));
		}

		/// <summary>
		/// Get information about this PI Web API instance. Examples of information returned include the system uptime, the number of cache instances for this PI System Web API instance, and the system run state.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PISystemStatus></returns>
		public async System.Threading.Tasks.Task<PISystemStatus> StatusAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PISystemStatus> localVarResponse = await StatusAsyncWithHttpInfo(cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get information about this PI Web API instance. Examples of information returned include the system uptime, the number of cache instances for this PI System Web API instance, and the system run state.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PISystemStatus>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PISystemStatus>> StatusAsyncWithHttpInfo(CancellationToken cancellationToken = default(CancellationToken))
		{

			var localVarPath = "/system/status";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("StatusAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PISystemStatus>(localVarStatusCode,
				localVarResponse.Headers,
				(PISystemStatus)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PISystemStatus)));
		}

		/// <summary>
		/// Get information about the Windows identity used to fulfill the request. This depends on the service's authentication method and the credentials passed by the client. The impersonation level of the Windows identity is included.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIUserInfo></returns>
		public async System.Threading.Tasks.Task<PIUserInfo> UserInfoAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIUserInfo> localVarResponse = await UserInfoAsyncWithHttpInfo(cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get information about the Windows identity used to fulfill the request. This depends on the service's authentication method and the credentials passed by the client. The impersonation level of the Windows identity is included.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIUserInfo>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIUserInfo>> UserInfoAsyncWithHttpInfo(CancellationToken cancellationToken = default(CancellationToken))
		{

			var localVarPath = "/system/userinfo";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UserInfoAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIUserInfo>(localVarStatusCode,
				localVarResponse.Headers,
				(PIUserInfo)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIUserInfo)));
		}

		/// <summary>
		/// Get the current versions of the PI Web API instance and all external plugins.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Dictionary<string, PIVersion>></returns>
		public async System.Threading.Tasks.Task<Dictionary<string, PIVersion>> VersionsAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Dictionary<string, PIVersion>> localVarResponse = await VersionsAsyncWithHttpInfo(cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get the current versions of the PI Web API instance and all external plugins.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Dictionary<string, PIVersion>>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Dictionary<string, PIVersion>>> VersionsAsyncWithHttpInfo(CancellationToken cancellationToken = default(CancellationToken))
		{

			var localVarPath = "/system/versions";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("VersionsAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Dictionary<string, PIVersion>>(localVarStatusCode,
				localVarResponse.Headers,
				(Dictionary<string, PIVersion>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, PIVersion>)));
		}

		#endregion
	}
}
