/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.45
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
    public interface IModuleUserApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a new User of type Ezsignuser
        /// </summary>
        /// <remarks>
        /// The endpoint allows to initiate the creation or a user of type Ezsignuser.  The user will be created only once the email verification process will be completed
        /// </remarks>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userCreateEzsignuserV1Request"></param>
        /// <returns>UserCreateEzsignuserV1Response</returns>
        UserCreateEzsignuserV1Response UserCreateEzsignuserV1 (List<UserCreateEzsignuserV1Request> userCreateEzsignuserV1Request);

        /// <summary>
        /// Create a new User of type Ezsignuser
        /// </summary>
        /// <remarks>
        /// The endpoint allows to initiate the creation or a user of type Ezsignuser.  The user will be created only once the email verification process will be completed
        /// </remarks>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userCreateEzsignuserV1Request"></param>
        /// <returns>ApiResponse of UserCreateEzsignuserV1Response</returns>
        ApiResponse<UserCreateEzsignuserV1Response> UserCreateEzsignuserV1WithHttpInfo (List<UserCreateEzsignuserV1Request> userCreateEzsignuserV1Request);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create a new User of type Ezsignuser
        /// </summary>
        /// <remarks>
        /// The endpoint allows to initiate the creation or a user of type Ezsignuser.  The user will be created only once the email verification process will be completed
        /// </remarks>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userCreateEzsignuserV1Request"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of UserCreateEzsignuserV1Response</returns>
        System.Threading.Tasks.Task<UserCreateEzsignuserV1Response> UserCreateEzsignuserV1Async (List<UserCreateEzsignuserV1Request> userCreateEzsignuserV1Request, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create a new User of type Ezsignuser
        /// </summary>
        /// <remarks>
        /// The endpoint allows to initiate the creation or a user of type Ezsignuser.  The user will be created only once the email verification process will be completed
        /// </remarks>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userCreateEzsignuserV1Request"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (UserCreateEzsignuserV1Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserCreateEzsignuserV1Response>> UserCreateEzsignuserV1WithHttpInfoAsync (List<UserCreateEzsignuserV1Request> userCreateEzsignuserV1Request, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ModuleUserApi : IModuleUserApi
    {
        private eZmaxApi.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ModuleUserApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ModuleUserApi(String basePath)
        {
            this.Configuration = new eZmaxApi.Client.Configuration { BasePath = basePath };

            ExceptionFactory = eZmaxApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModuleUserApi"/> class
        /// </summary>
        /// <returns></returns>
        public ModuleUserApi()
        {
            this.Configuration = eZmaxApi.Client.Configuration.Default;

            ExceptionFactory = eZmaxApi.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModuleUserApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ModuleUserApi(eZmaxApi.Client.Configuration configuration = null)
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
        /// Create a new User of type Ezsignuser The endpoint allows to initiate the creation or a user of type Ezsignuser.  The user will be created only once the email verification process will be completed
        /// </summary>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userCreateEzsignuserV1Request"></param>
        /// <returns>UserCreateEzsignuserV1Response</returns>
        public UserCreateEzsignuserV1Response UserCreateEzsignuserV1 (List<UserCreateEzsignuserV1Request> userCreateEzsignuserV1Request)
        {
             ApiResponse<UserCreateEzsignuserV1Response> localVarResponse = UserCreateEzsignuserV1WithHttpInfo(userCreateEzsignuserV1Request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a new User of type Ezsignuser The endpoint allows to initiate the creation or a user of type Ezsignuser.  The user will be created only once the email verification process will be completed
        /// </summary>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userCreateEzsignuserV1Request"></param>
        /// <returns>ApiResponse of UserCreateEzsignuserV1Response</returns>
        public ApiResponse<UserCreateEzsignuserV1Response> UserCreateEzsignuserV1WithHttpInfo (List<UserCreateEzsignuserV1Request> userCreateEzsignuserV1Request)
        {
            // verify the required parameter 'userCreateEzsignuserV1Request' is set
            if (userCreateEzsignuserV1Request == null)
                throw new ApiException(400, "Missing required parameter 'userCreateEzsignuserV1Request' when calling ModuleUserApi->UserCreateEzsignuserV1");

            var localVarPath = "/1/module/user/createezsignuser";
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

            if (userCreateEzsignuserV1Request != null && userCreateEzsignuserV1Request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(userCreateEzsignuserV1Request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = userCreateEzsignuserV1Request; // byte array
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
                Exception exception = ExceptionFactory("UserCreateEzsignuserV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserCreateEzsignuserV1Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (UserCreateEzsignuserV1Response) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserCreateEzsignuserV1Response)));
        }

        /// <summary>
        /// Create a new User of type Ezsignuser The endpoint allows to initiate the creation or a user of type Ezsignuser.  The user will be created only once the email verification process will be completed
        /// </summary>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userCreateEzsignuserV1Request"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of UserCreateEzsignuserV1Response</returns>
        public async System.Threading.Tasks.Task<UserCreateEzsignuserV1Response> UserCreateEzsignuserV1Async (List<UserCreateEzsignuserV1Request> userCreateEzsignuserV1Request, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<UserCreateEzsignuserV1Response> localVarResponse = await UserCreateEzsignuserV1WithHttpInfoAsync(userCreateEzsignuserV1Request, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a new User of type Ezsignuser The endpoint allows to initiate the creation or a user of type Ezsignuser.  The user will be created only once the email verification process will be completed
        /// </summary>
        /// <exception cref="eZmaxApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userCreateEzsignuserV1Request"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (UserCreateEzsignuserV1Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserCreateEzsignuserV1Response>> UserCreateEzsignuserV1WithHttpInfoAsync (List<UserCreateEzsignuserV1Request> userCreateEzsignuserV1Request, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'userCreateEzsignuserV1Request' is set
            if (userCreateEzsignuserV1Request == null)
                throw new ApiException(400, "Missing required parameter 'userCreateEzsignuserV1Request' when calling ModuleUserApi->UserCreateEzsignuserV1");

            var localVarPath = "/1/module/user/createezsignuser";
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

            if (userCreateEzsignuserV1Request != null && userCreateEzsignuserV1Request.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(userCreateEzsignuserV1Request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = userCreateEzsignuserV1Request; // byte array
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
                Exception exception = ExceptionFactory("UserCreateEzsignuserV1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UserCreateEzsignuserV1Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (UserCreateEzsignuserV1Response) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserCreateEzsignuserV1Response)));
        }

    }
}
