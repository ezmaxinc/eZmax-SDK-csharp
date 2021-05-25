/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.43
 * Contact: support-api@ezmax.ca
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace eZmaxApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IObjectFranchisereferalincomeApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a new Franchisereferalincome
        /// </summary>
        /// <remarks>
        /// The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.
        /// </remarks>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="franchisereferalincomeCreateObjectV1Request"></param>
        /// <returns>FranchisereferalincomeCreateObjectV1Response</returns>
        FranchisereferalincomeCreateObjectV1Response FranchisereferalincomeCreateObjectV1 (List<FranchisereferalincomeCreateObjectV1Request> franchisereferalincomeCreateObjectV1Request);

        /// <summary>
        /// Create a new Franchisereferalincome
        /// </summary>
        /// <remarks>
        /// The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.
        /// </remarks>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="franchisereferalincomeCreateObjectV1Request"></param>
        /// <returns>ApiResponse of FranchisereferalincomeCreateObjectV1Response</returns>
        ApiResponse<FranchisereferalincomeCreateObjectV1Response> FranchisereferalincomeCreateObjectV1WithHttpInfo (List<FranchisereferalincomeCreateObjectV1Request> franchisereferalincomeCreateObjectV1Request);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create a new Franchisereferalincome
        /// </summary>
        /// <remarks>
        /// The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.
        /// </remarks>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="franchisereferalincomeCreateObjectV1Request"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of FranchisereferalincomeCreateObjectV1Response</returns>
        System.Threading.Tasks.Task<FranchisereferalincomeCreateObjectV1Response> FranchisereferalincomeCreateObjectV1Async (List<FranchisereferalincomeCreateObjectV1Request> franchisereferalincomeCreateObjectV1Request, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create a new Franchisereferalincome
        /// </summary>
        /// <remarks>
        /// The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.
        /// </remarks>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="franchisereferalincomeCreateObjectV1Request"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (FranchisereferalincomeCreateObjectV1Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<FranchisereferalincomeCreateObjectV1Response>> FranchisereferalincomeCreateObjectV1WithHttpInfoAsync (List<FranchisereferalincomeCreateObjectV1Request> franchisereferalincomeCreateObjectV1Request, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ObjectFranchisereferalincomeApi : IObjectFranchisereferalincomeApi
    {
        private eZmaxApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectFranchisereferalincomeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ObjectFranchisereferalincomeApi(String basePath)
        {
            this.Configuration = new eZmaxApi.Client.Configuration { BasePath = basePath };

            ExceptionFactory = eZmaxApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectFranchisereferalincomeApi"/> class
        /// </summary>
        /// <returns></returns>
        public ObjectFranchisereferalincomeApi()
        {
            this.Configuration = eZmaxApi.Client.Configuration.Default;

            ExceptionFactory = eZmaxApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectFranchisereferalincomeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ObjectFranchisereferalincomeApi(eZmaxApi.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = eZmaxApi.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = eZmaxApi.Client.Configuration.DefaultExceptionFactory;
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
        public eZmaxApi.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public eZmaxApi.Client.ExceptionFactory ExceptionFactory
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
        /// Create a new Franchisereferalincome The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.
        /// </summary>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="franchisereferalincomeCreateObjectV1Request"></param>
        /// <returns>FranchisereferalincomeCreateObjectV1Response</returns>
        public FranchisereferalincomeCreateObjectV1Response FranchisereferalincomeCreateObjectV1 (List<FranchisereferalincomeCreateObjectV1Request> franchisereferalincomeCreateObjectV1Request)
        {
             ApiResponse<FranchisereferalincomeCreateObjectV1Response> localVarResponse = FranchisereferalincomeCreateObjectV1WithHttpInfo(franchisereferalincomeCreateObjectV1Request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new Franchisereferalincome The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.
        /// </summary>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="franchisereferalincomeCreateObjectV1Request"></param>
        /// <returns>ApiResponse of FranchisereferalincomeCreateObjectV1Response</returns>
        public ApiResponse<FranchisereferalincomeCreateObjectV1Response> FranchisereferalincomeCreateObjectV1WithHttpInfo (List<FranchisereferalincomeCreateObjectV1Request> franchisereferalincomeCreateObjectV1Request)
        {
            // verify the required parameter 'franchisereferalincomeCreateObjectV1Request' is set
            if (franchisereferalincomeCreateObjectV1Request == null)
                throw new ApiException(400, "Missing required parameter 'franchisereferalincomeCreateObjectV1Request' when calling ObjectFranchisereferalincomeApi->FranchisereferalincomeCreateObjectV1");

            var localVarPath = "/1/object/franchisereferalincome";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (franchisereferalincomeCreateObjectV1Request != null && franchisereferalincomeCreateObjectV1Request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(franchisereferalincomeCreateObjectV1Request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = franchisereferalincomeCreateObjectV1Request; // byte array
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FranchisereferalincomeCreateObjectV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FranchisereferalincomeCreateObjectV1Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FranchisereferalincomeCreateObjectV1Response) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FranchisereferalincomeCreateObjectV1Response)));
        }

        /// <summary>
        /// Create a new Franchisereferalincome The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.
        /// </summary>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="franchisereferalincomeCreateObjectV1Request"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of FranchisereferalincomeCreateObjectV1Response</returns>
        public async System.Threading.Tasks.Task<FranchisereferalincomeCreateObjectV1Response> FranchisereferalincomeCreateObjectV1Async (List<FranchisereferalincomeCreateObjectV1Request> franchisereferalincomeCreateObjectV1Request, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<FranchisereferalincomeCreateObjectV1Response> localVarResponse = await FranchisereferalincomeCreateObjectV1WithHttpInfoAsync(franchisereferalincomeCreateObjectV1Request, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new Franchisereferalincome The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.
        /// </summary>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="franchisereferalincomeCreateObjectV1Request"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (FranchisereferalincomeCreateObjectV1Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FranchisereferalincomeCreateObjectV1Response>> FranchisereferalincomeCreateObjectV1WithHttpInfoAsync (List<FranchisereferalincomeCreateObjectV1Request> franchisereferalincomeCreateObjectV1Request, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'franchisereferalincomeCreateObjectV1Request' is set
            if (franchisereferalincomeCreateObjectV1Request == null)
                throw new ApiException(400, "Missing required parameter 'franchisereferalincomeCreateObjectV1Request' when calling ObjectFranchisereferalincomeApi->FranchisereferalincomeCreateObjectV1");

            var localVarPath = "/1/object/franchisereferalincome";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (franchisereferalincomeCreateObjectV1Request != null && franchisereferalincomeCreateObjectV1Request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(franchisereferalincomeCreateObjectV1Request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = franchisereferalincomeCreateObjectV1Request; // byte array
            }

            // authentication (Authorization) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FranchisereferalincomeCreateObjectV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FranchisereferalincomeCreateObjectV1Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (FranchisereferalincomeCreateObjectV1Response) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FranchisereferalincomeCreateObjectV1Response)));
        }

    }
}
