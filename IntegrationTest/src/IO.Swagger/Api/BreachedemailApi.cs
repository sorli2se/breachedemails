/* 
 * Swagger breached emails
 *
 * This is a sample server breachedemails server.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBreachedemailApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Add a breached email
        /// </summary>
        /// <remarks>
        /// Add a breached email
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Add a breached email</param>
        /// <returns></returns>
        int Add (Breachedemail body);

        /// <summary>
        /// Add a breached email
        /// </summary>
        /// <remarks>
        /// Add a breached email
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Add a breached email</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> AddWithHttpInfo (Breachedemail body);
        /// <summary>
        /// Deletes a breachedemail
        /// </summary>
        /// <remarks>
        /// Deletes a breachedemail
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="breachedemail">Breached email to delete</param>
        /// <returns></returns>
        int Delete (string breachedemail);

        /// <summary>
        /// Deletes a breachedemail
        /// </summary>
        /// <remarks>
        /// Deletes a breachedemail
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="breachedemail">Breached email to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWithHttpInfo (string breachedemail);
        /// <summary>
        /// Confirm ok if breached email exist
        /// </summary>
        /// <remarks>
        /// Returns OK or NotFound
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="breachedemail">Breachedemail to return</param>
        /// <returns></returns>
        int Get (string breachedemail);

        /// <summary>
        /// Confirm ok if breached email exist
        /// </summary>
        /// <remarks>
        /// Returns OK or NotFound
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="breachedemail">Breachedemail to return</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetWithHttpInfo (string breachedemail);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Add a breached email
        /// </summary>
        /// <remarks>
        /// Add a breached email
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Add a breached email</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddAsync (Breachedemail body);

        /// <summary>
        /// Add a breached email
        /// </summary>
        /// <remarks>
        /// Add a breached email
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Add a breached email</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AddAsyncWithHttpInfo (Breachedemail body);
        /// <summary>
        /// Deletes a breachedemail
        /// </summary>
        /// <remarks>
        /// Deletes a breachedemail
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="breachedemail">Breached email to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteAsync (string breachedemail);

        /// <summary>
        /// Deletes a breachedemail
        /// </summary>
        /// <remarks>
        /// Deletes a breachedemail
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="breachedemail">Breached email to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAsyncWithHttpInfo (string breachedemail);
        /// <summary>
        /// Confirm ok if breached email exist
        /// </summary>
        /// <remarks>
        /// Returns OK or NotFound
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="breachedemail">Breachedemail to return</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetAsync (string breachedemail);

        /// <summary>
        /// Confirm ok if breached email exist
        /// </summary>
        /// <remarks>
        /// Returns OK or NotFound
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="breachedemail">Breachedemail to return</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetAsyncWithHttpInfo (string breachedemail);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class BreachedemailApi : IBreachedemailApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BreachedemailApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BreachedemailApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BreachedemailApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BreachedemailApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
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
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
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
        /// Add a breached email Add a breached email
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Add a breached email</param>
        /// <returns></returns>
        public int Add (Breachedemail body)
        {
            ApiResponse<Object> a = AddWithHttpInfo(body);
            return a.StatusCode;
        }

        /// <summary>
        /// Add a breached email Add a breached email
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Add a breached email</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> AddWithHttpInfo (Breachedemail body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling BreachedemailApi->Add");

            var localVarPath = "/breachedemails/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml",
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;


            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Add a breached email Add a breached email
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Add a breached email</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddAsync (Breachedemail body)
        {
             await AddAsyncWithHttpInfo(body);

        }

        /// <summary>
        /// Add a breached email Add a breached email
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Add a breached email</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AddAsyncWithHttpInfo (Breachedemail body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling BreachedemailApi->Add");

            var localVarPath = "/breachedemails/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml",
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Add", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Deletes a breachedemail Deletes a breachedemail
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="breachedemail">Breached email to delete</param>
        /// <returns></returns>
        public int Delete (string breachedemail)
        {
             return DeleteWithHttpInfo(breachedemail).StatusCode;
        }

        /// <summary>
        /// Deletes a breachedemail Deletes a breachedemail
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="breachedemail">Breached email to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteWithHttpInfo (string breachedemail)
        {
            // verify the required parameter 'breachedemail' is set
            if (breachedemail == null)
                throw new ApiException(400, "Missing required parameter 'breachedemail' when calling BreachedemailApi->Delete");

            var localVarPath = "/breachedemails/{breachedemail}";
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
                "application/xml",
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (breachedemail != null) localVarPathParams.Add("breachedemail", this.Configuration.ApiClient.ParameterToString(breachedemail)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;


            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Deletes a breachedemail Deletes a breachedemail
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="breachedemail">Breached email to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteAsync (string breachedemail)
        {
             await DeleteAsyncWithHttpInfo(breachedemail);

        }

        /// <summary>
        /// Deletes a breachedemail Deletes a breachedemail
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="breachedemail">Breached email to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAsyncWithHttpInfo (string breachedemail)
        {
            // verify the required parameter 'breachedemail' is set
            if (breachedemail == null)
                throw new ApiException(400, "Missing required parameter 'breachedemail' when calling BreachedemailApi->Delete");

            var localVarPath = "/breachedemails/{breachedemail}";
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
                "application/xml",
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (breachedemail != null) localVarPathParams.Add("breachedemail", this.Configuration.ApiClient.ParameterToString(breachedemail)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Confirm ok if breached email exist Returns OK or NotFound
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="breachedemail">Breachedemail to return</param>
        /// <returns></returns>
        public int Get (string breachedemail)
        {
             return GetWithHttpInfo(breachedemail).StatusCode;
        }

        /// <summary>
        /// Confirm ok if breached email exist Returns OK or NotFound
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="breachedemail">Breachedemail to return</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetWithHttpInfo (string breachedemail)
        {
            // verify the required parameter 'breachedemail' is set
            if (breachedemail == null)
                throw new ApiException(400, "Missing required parameter 'breachedemail' when calling BreachedemailApi->Get");

            var localVarPath = "/breachedemails/{breachedemail}";
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
                "application/xml",
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (breachedemail != null) localVarPathParams.Add("breachedemail", this.Configuration.ApiClient.ParameterToString(breachedemail)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Confirm ok if breached email exist Returns OK or NotFound
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="breachedemail">Breachedemail to return</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetAsync (string breachedemail)
        {
             await GetAsyncWithHttpInfo(breachedemail);

        }

        /// <summary>
        /// Confirm ok if breached email exist Returns OK or NotFound
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="breachedemail">Breachedemail to return</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetAsyncWithHttpInfo (string breachedemail)
        {
            // verify the required parameter 'breachedemail' is set
            if (breachedemail == null)
                throw new ApiException(400, "Missing required parameter 'breachedemail' when calling BreachedemailApi->Get");

            var localVarPath = "/breachedemails/{breachedemail}";
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
                "application/xml",
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (breachedemail != null) localVarPathParams.Add("breachedemail", this.Configuration.ApiClient.ParameterToString(breachedemail)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Get", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
