# IO.Swagger.Api.BreachedemailApi

All URIs are relative to *https://breachedemails.swagger.io/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Add**](BreachedemailApi.md#add) | **POST** /breachedemails/ | Add a breached email
[**Delete**](BreachedemailApi.md#delete) | **DELETE** /breachedemails/{breachedemail} | Deletes a breachedemail
[**Get**](BreachedemailApi.md#get) | **GET** /breachedemails/{breachedemail} | Confirm ok if breached email exist


<a name="add"></a>
# **Add**
> void Add (Breachedemail body)

Add a breached email

Add a breached email

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AddExample
    {
        public void main()
        {
            var apiInstance = new BreachedemailApi();
            var body = new Breachedemail(); // Breachedemail | Add a breached email

            try
            {
                // Add a breached email
                apiInstance.Add(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BreachedemailApi.Add: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Breachedemail**](Breachedemail.md)| Add a breached email | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="delete"></a>
# **Delete**
> void Delete (string breachedemail)

Deletes a breachedemail

Deletes a breachedemail

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class DeleteExample
    {
        public void main()
        {
            var apiInstance = new BreachedemailApi();
            var breachedemail = breachedemail_example;  // string | Breached email to delete

            try
            {
                // Deletes a breachedemail
                apiInstance.Delete(breachedemail);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BreachedemailApi.Delete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **breachedemail** | **string**| Breached email to delete | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get"></a>
# **Get**
> void Get (string breachedemail)

Confirm ok if breached email exist

Returns OK or NotFound

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetExample
    {
        public void main()
        {
            var apiInstance = new BreachedemailApi();
            var breachedemail = breachedemail_example;  // string | Breachedemail to return

            try
            {
                // Confirm ok if breached email exist
                apiInstance.Get(breachedemail);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BreachedemailApi.Get: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **breachedemail** | **string**| Breachedemail to return | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/xml, application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

