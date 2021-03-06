# eZmaxApi.Api.ObjectEzsignfoldersignerassociationApi

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EzsignfoldersignerassociationCreateObjectV1**](ObjectEzsignfoldersignerassociationApi.md#ezsignfoldersignerassociationcreateobjectv1) | **POST** /1/object/ezsignfoldersignerassociation | Create a new Ezsignfoldersignerassociation
[**EzsignfoldersignerassociationDeleteObjectV1**](ObjectEzsignfoldersignerassociationApi.md#ezsignfoldersignerassociationdeleteobjectv1) | **DELETE** /1/object/ezsignfoldersignerassociation/{pkiEzsignfoldersignerassociationID} | Delete an existing Ezsignfoldersignerassociation
[**EzsignfoldersignerassociationGetChildrenV1**](ObjectEzsignfoldersignerassociationApi.md#ezsignfoldersignerassociationgetchildrenv1) | **GET** /1/object/ezsignfoldersignerassociation/{pkiEzsignfoldersignerassociationID}/getChildren | Retrieve an existing Ezsignfoldersignerassociation&#39;s children IDs
[**EzsignfoldersignerassociationGetInPersonLoginUrlV1**](ObjectEzsignfoldersignerassociationApi.md#ezsignfoldersignerassociationgetinpersonloginurlv1) | **GET** /1/object/ezsignfoldersignerassociation/{pkiEzsignfoldersignerassociationID}/getInPersonLoginUrl | Retrieve a Login Url to allow In-Person signing
[**EzsignfoldersignerassociationGetObjectV1**](ObjectEzsignfoldersignerassociationApi.md#ezsignfoldersignerassociationgetobjectv1) | **GET** /1/object/ezsignfoldersignerassociation/{pkiEzsignfoldersignerassociationID} | Retrieve an existing Ezsignfoldersignerassociation



## EzsignfoldersignerassociationCreateObjectV1

> EzsignfoldersignerassociationCreateObjectV1Response EzsignfoldersignerassociationCreateObjectV1 (List<EzsignfoldersignerassociationCreateObjectV1Request> ezsignfoldersignerassociationCreateObjectV1Request)

Create a new Ezsignfoldersignerassociation

The endpoint allows to create one or many elements at once.  The array can contain simple (Just the object) or compound (The object and its child) objects.  Creating compound elements allows to reduce the multiple requests to create all child objects.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfoldersignerassociationCreateObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfoldersignerassociationApi(Configuration.Default);
            var ezsignfoldersignerassociationCreateObjectV1Request = new List<EzsignfoldersignerassociationCreateObjectV1Request>(); // List<EzsignfoldersignerassociationCreateObjectV1Request> | 

            try
            {
                // Create a new Ezsignfoldersignerassociation
                EzsignfoldersignerassociationCreateObjectV1Response result = apiInstance.EzsignfoldersignerassociationCreateObjectV1(ezsignfoldersignerassociationCreateObjectV1Request);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfoldersignerassociationApi.EzsignfoldersignerassociationCreateObjectV1: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ezsignfoldersignerassociationCreateObjectV1Request** | [**List&lt;EzsignfoldersignerassociationCreateObjectV1Request&gt;**](EzsignfoldersignerassociationCreateObjectV1Request.md)|  | 

### Return type

[**EzsignfoldersignerassociationCreateObjectV1Response**](EzsignfoldersignerassociationCreateObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EzsignfoldersignerassociationDeleteObjectV1

> EzsignfoldersignerassociationDeleteObjectV1Response EzsignfoldersignerassociationDeleteObjectV1 (int pkiEzsignfoldersignerassociationID)

Delete an existing Ezsignfoldersignerassociation

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfoldersignerassociationDeleteObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfoldersignerassociationApi(Configuration.Default);
            var pkiEzsignfoldersignerassociationID = 56;  // int | The unique ID of the Ezsignfoldersignerassociation

            try
            {
                // Delete an existing Ezsignfoldersignerassociation
                EzsignfoldersignerassociationDeleteObjectV1Response result = apiInstance.EzsignfoldersignerassociationDeleteObjectV1(pkiEzsignfoldersignerassociationID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfoldersignerassociationApi.EzsignfoldersignerassociationDeleteObjectV1: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiEzsignfoldersignerassociationID** | **int**| The unique ID of the Ezsignfoldersignerassociation | 

### Return type

[**EzsignfoldersignerassociationDeleteObjectV1Response**](EzsignfoldersignerassociationDeleteObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The element you are trying to work on does not exist |  -  |
| **422** | The syntax of the request is valid but the request cannot be completed. Look for detail in body. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EzsignfoldersignerassociationGetChildrenV1

> void EzsignfoldersignerassociationGetChildrenV1 (int pkiEzsignfoldersignerassociationID)

Retrieve an existing Ezsignfoldersignerassociation's children IDs

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfoldersignerassociationGetChildrenV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfoldersignerassociationApi(Configuration.Default);
            var pkiEzsignfoldersignerassociationID = 56;  // int | The unique ID of the Ezsignfoldersignerassociation

            try
            {
                // Retrieve an existing Ezsignfoldersignerassociation's children IDs
                apiInstance.EzsignfoldersignerassociationGetChildrenV1(pkiEzsignfoldersignerassociationID);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfoldersignerassociationApi.EzsignfoldersignerassociationGetChildrenV1: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiEzsignfoldersignerassociationID** | **int**| The unique ID of the Ezsignfoldersignerassociation | 

### Return type

void (empty response body)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **404** | The element you are trying to work on does not exist |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EzsignfoldersignerassociationGetInPersonLoginUrlV1

> EzsignfoldersignerassociationGetInPersonLoginUrlV1Response EzsignfoldersignerassociationGetInPersonLoginUrlV1 (int pkiEzsignfoldersignerassociationID)

Retrieve a Login Url to allow In-Person signing

This endpoint returns a Login Url that can be used in a browser or embedded in an I-Frame to allow in person signing.  The signer Login type must be configured as In-Person.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfoldersignerassociationGetInPersonLoginUrlV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfoldersignerassociationApi(Configuration.Default);
            var pkiEzsignfoldersignerassociationID = 56;  // int | The unique ID of the Ezsignfoldersignerassociation

            try
            {
                // Retrieve a Login Url to allow In-Person signing
                EzsignfoldersignerassociationGetInPersonLoginUrlV1Response result = apiInstance.EzsignfoldersignerassociationGetInPersonLoginUrlV1(pkiEzsignfoldersignerassociationID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfoldersignerassociationApi.EzsignfoldersignerassociationGetInPersonLoginUrlV1: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiEzsignfoldersignerassociationID** | **int**| The unique ID of the Ezsignfoldersignerassociation | 

### Return type

[**EzsignfoldersignerassociationGetInPersonLoginUrlV1Response**](EzsignfoldersignerassociationGetInPersonLoginUrlV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The element you are trying to work on does not exist |  -  |
| **422** | The syntax of the request is valid but the request cannot be completed. Look for detail in body. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EzsignfoldersignerassociationGetObjectV1

> EzsignfoldersignerassociationGetObjectV1Response EzsignfoldersignerassociationGetObjectV1 (int pkiEzsignfoldersignerassociationID)

Retrieve an existing Ezsignfoldersignerassociation

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxApi.Api;
using eZmaxApi.Client;
using eZmaxApi.Model;

namespace Example
{
    public class EzsignfoldersignerassociationGetObjectV1Example
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ObjectEzsignfoldersignerassociationApi(Configuration.Default);
            var pkiEzsignfoldersignerassociationID = 56;  // int | The unique ID of the Ezsignfoldersignerassociation

            try
            {
                // Retrieve an existing Ezsignfoldersignerassociation
                EzsignfoldersignerassociationGetObjectV1Response result = apiInstance.EzsignfoldersignerassociationGetObjectV1(pkiEzsignfoldersignerassociationID);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ObjectEzsignfoldersignerassociationApi.EzsignfoldersignerassociationGetObjectV1: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pkiEzsignfoldersignerassociationID** | **int**| The unique ID of the Ezsignfoldersignerassociation | 

### Return type

[**EzsignfoldersignerassociationGetObjectV1Response**](EzsignfoldersignerassociationGetObjectV1Response.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **404** | The element you are trying to work on does not exist |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

