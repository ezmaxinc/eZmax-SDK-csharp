/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.
 *
 * The version of the OpenAPI document: 1.0.30
 * Contact: support-api@ezmax.ca
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using eZmaxinc/eZmax-SDK-csharp.Client;
using eZmaxinc/eZmax-SDK-csharp.Model;

namespace eZmaxinc/eZmax-SDK-csharp.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IObjectPeriodApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve Periods and IDs
        /// </summary>
        /// <remarks>
        /// Get the list of Periods to be used in a dropdown or autocomplete control.
        /// </remarks>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The types of Periods to return</param>
        /// <param name="sQuery">Allow to filter on the option value (optional)</param>
        /// <returns>CommonGetAutocompleteV1Response</returns>
        CommonGetAutocompleteV1Response PeriodGetAutocompleteV1 (string sSelector, string sQuery = default(string));

        /// <summary>
        /// Retrieve Periods and IDs
        /// </summary>
        /// <remarks>
        /// Get the list of Periods to be used in a dropdown or autocomplete control.
        /// </remarks>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The types of Periods to return</param>
        /// <param name="sQuery">Allow to filter on the option value (optional)</param>
        /// <returns>ApiResponse of CommonGetAutocompleteV1Response</returns>
        ApiResponse<CommonGetAutocompleteV1Response> PeriodGetAutocompleteV1WithHttpInfo (string sSelector, string sQuery = default(string));
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve Periods and IDs
        /// </summary>
        /// <remarks>
        /// Get the list of Periods to be used in a dropdown or autocomplete control.
        /// </remarks>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The types of Periods to return</param>
        /// <param name="sQuery">Allow to filter on the option value (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of CommonGetAutocompleteV1Response</returns>
        System.Threading.Tasks.Task<CommonGetAutocompleteV1Response> PeriodGetAutocompleteV1Async (string sSelector, string sQuery = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Retrieve Periods and IDs
        /// </summary>
        /// <remarks>
        /// Get the list of Periods to be used in a dropdown or autocomplete control.
        /// </remarks>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The types of Periods to return</param>
        /// <param name="sQuery">Allow to filter on the option value (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (CommonGetAutocompleteV1Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<CommonGetAutocompleteV1Response>> PeriodGetAutocompleteV1WithHttpInfoAsync (string sSelector, string sQuery = default(string), CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ObjectPeriodApi : IObjectPeriodApi
    {
        private eZmaxinc/eZmax-SDK-csharp.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectPeriodApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ObjectPeriodApi(String basePath)
        {
            this.Configuration = new eZmaxinc/eZmax-SDK-csharp.Client.Configuration { BasePath = basePath };

            ExceptionFactory = eZmaxinc/eZmax-SDK-csharp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectPeriodApi"/> class
        /// </summary>
        /// <returns></returns>
        public ObjectPeriodApi()
        {
            this.Configuration = eZmaxinc/eZmax-SDK-csharp.Client.Configuration.Default;

            ExceptionFactory = eZmaxinc/eZmax-SDK-csharp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectPeriodApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ObjectPeriodApi(eZmaxinc/eZmax-SDK-csharp.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = eZmaxinc/eZmax-SDK-csharp.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = eZmaxinc/eZmax-SDK-csharp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public eZmaxinc/eZmax-SDK-csharp.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public eZmaxinc/eZmax-SDK-csharp.Client.ExceptionFactory ExceptionFactory
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

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Retrieve Periods and IDs Get the list of Periods to be used in a dropdown or autocomplete control.
        /// </summary>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The types of Periods to return</param>
        /// <param name="sQuery">Allow to filter on the option value (optional)</param>
        /// <returns>CommonGetAutocompleteV1Response</returns>
        public CommonGetAutocompleteV1Response PeriodGetAutocompleteV1 (string sSelector, string sQuery = default(string))
        {
             ApiResponse<CommonGetAutocompleteV1Response> localVarResponse = PeriodGetAutocompleteV1WithHttpInfo(sSelector, sQuery);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve Periods and IDs Get the list of Periods to be used in a dropdown or autocomplete control.
        /// </summary>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The types of Periods to return</param>
        /// <param name="sQuery">Allow to filter on the option value (optional)</param>
        /// <returns>ApiResponse of CommonGetAutocompleteV1Response</returns>
        public ApiResponse<CommonGetAutocompleteV1Response> PeriodGetAutocompleteV1WithHttpInfo (string sSelector, string sQuery = default(string))
        {
            // verify the required parameter 'sSelector' is set
            if (sSelector == null)
                throw new ApiException(400, "Missing required parameter 'sSelector' when calling ObjectPeriodApi->PeriodGetAutocompleteV1");

            var localVarPath = "/1/object/period/getAutocomplete/{sSelector}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (sSelector != null) localVarPathParams.Add("sSelector", this.Configuration.ApiClient.ParameterToString(sSelector)); // path parameter
            if (sQuery != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sQuery", sQuery)); // query parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PeriodGetAutocompleteV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CommonGetAutocompleteV1Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CommonGetAutocompleteV1Response) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonGetAutocompleteV1Response)));
        }

        /// <summary>
        /// Retrieve Periods and IDs Get the list of Periods to be used in a dropdown or autocomplete control.
        /// </summary>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The types of Periods to return</param>
        /// <param name="sQuery">Allow to filter on the option value (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of CommonGetAutocompleteV1Response</returns>
        public async System.Threading.Tasks.Task<CommonGetAutocompleteV1Response> PeriodGetAutocompleteV1Async (string sSelector, string sQuery = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<CommonGetAutocompleteV1Response> localVarResponse = await PeriodGetAutocompleteV1WithHttpInfoAsync(sSelector, sQuery, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve Periods and IDs Get the list of Periods to be used in a dropdown or autocomplete control.
        /// </summary>
        /// <exception cref="eZmaxinc/eZmax-SDK-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sSelector">The types of Periods to return</param>
        /// <param name="sQuery">Allow to filter on the option value (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (CommonGetAutocompleteV1Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CommonGetAutocompleteV1Response>> PeriodGetAutocompleteV1WithHttpInfoAsync (string sSelector, string sQuery = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'sSelector' is set
            if (sSelector == null)
                throw new ApiException(400, "Missing required parameter 'sSelector' when calling ObjectPeriodApi->PeriodGetAutocompleteV1");

            var localVarPath = "/1/object/period/getAutocomplete/{sSelector}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (sSelector != null) localVarPathParams.Add("sSelector", this.Configuration.ApiClient.ParameterToString(sSelector)); // path parameter
            if (sQuery != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sQuery", sQuery)); // query parameter

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PeriodGetAutocompleteV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CommonGetAutocompleteV1Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CommonGetAutocompleteV1Response) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CommonGetAutocompleteV1Response)));
        }

    }
}
