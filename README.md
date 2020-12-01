# eZmaxinc/eZmax-SDK-csharp - the C# library for the eZmax API Definition

This API expose all the functionnalities for the eZmax and eZsign application.

We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.

You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.

If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0.19
- SDK version: 1.0.19
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://www.ezmax.ca/en/contact](https://www.ezmax.ca/en/contact)

## Frameworks supported


- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using eZmaxinc/eZmax-SDK-csharp.Api;
using eZmaxinc/eZmax-SDK-csharp.Client;
using eZmaxinc/eZmax-SDK-csharp.Model;

```


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out eZmaxinc/eZmax-SDK-csharp.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using eZmaxinc/eZmax-SDK-csharp.Api;
using eZmaxinc/eZmax-SDK-csharp.Client;
using eZmaxinc/eZmax-SDK-csharp.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration.Default.BasePath = "https://prod.api.appcluster01.ca-central-1.ezmax.com/rest";
            // Configure API key authorization: Authorization
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ActivesessionApi(Configuration.Default);

            try
            {
                // Get Current Activesession
                ActivesessionGetCurrentV1Response result = apiInstance.ActivesessionGetCurrentV1();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling ActivesessionApi.ActivesessionGetCurrentV1: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *https://prod.api.appcluster01.ca-central-1.ezmax.com/rest*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ActivesessionApi* | [**ActivesessionGetCurrentV1**](docs/ActivesessionApi.md#activesessiongetcurrentv1) | **GET** /1/object/activesession/getCurrent | Get Current Activesession
*EzsigndocumentApi* | [**EzsigndocumentCreateObjectV1**](docs/EzsigndocumentApi.md#ezsigndocumentcreateobjectv1) | **POST** /1/object/ezsigndocument | Create a new Ezsigndocument
*EzsigndocumentApi* | [**EzsigndocumentDeleteObjectV1**](docs/EzsigndocumentApi.md#ezsigndocumentdeleteobjectv1) | **DELETE** /1/object/ezsigndocument/{pkiEzsigndocumentID} | Delete an existing Ezsigndocument
*EzsigndocumentApi* | [**EzsigndocumentEditObjectV1**](docs/EzsigndocumentApi.md#ezsigndocumenteditobjectv1) | **PUT** /1/object/ezsigndocument/{pkiEzsigndocumentID} | Modify an existing Ezsigndocument
*EzsigndocumentApi* | [**EzsigndocumentGetDownloadUrlV1**](docs/EzsigndocumentApi.md#ezsigndocumentgetdownloadurlv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getDownloadUrl/{eDocumentType} | Retrieve a URL to download documents.
*EzsigndocumentApi* | [**EzsigndocumentGetObjectGetChildrenV1**](docs/EzsigndocumentApi.md#ezsigndocumentgetobjectgetchildrenv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID}/getChildren | Retrieve an existing Ezsigndocument's children IDs
*EzsigndocumentApi* | [**EzsigndocumentGetObjectV1**](docs/EzsigndocumentApi.md#ezsigndocumentgetobjectv1) | **GET** /1/object/ezsigndocument/{pkiEzsigndocumentID} | Retrieve an existing Ezsigndocument
*EzsignfolderApi* | [**EzsignfolderCreateObjectV1**](docs/EzsignfolderApi.md#ezsignfoldercreateobjectv1) | **POST** /1/object/ezsignfolder | Create a new Ezsignfolder
*EzsignfolderApi* | [**EzsignfolderDeleteObjectV1**](docs/EzsignfolderApi.md#ezsignfolderdeleteobjectv1) | **DELETE** /1/object/ezsignfolder/{pkiEzsignfolderID} | Delete an existing Ezsignfolder
*EzsignfolderApi* | [**EzsignfolderEditObjectV1**](docs/EzsignfolderApi.md#ezsignfoldereditobjectv1) | **PUT** /1/object/ezsignfolder/{pkiEzsignfolderID} | Modify an existing Ezsignfolder
*EzsignfolderApi* | [**EzsignfolderGetObjectGetChildrenV1**](docs/EzsignfolderApi.md#ezsignfoldergetobjectgetchildrenv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID}/getChildren | Retrieve an existing Ezsignfolder's children IDs
*EzsignfolderApi* | [**EzsignfolderGetObjectV1**](docs/EzsignfolderApi.md#ezsignfoldergetobjectv1) | **GET** /1/object/ezsignfolder/{pkiEzsignfolderID} | Retrieve an existing Ezsignfolder
*EzsignfolderApi* | [**EzsignfolderSendV1**](docs/EzsignfolderApi.md#ezsignfoldersendv1) | **POST** /1/object/ezsignfolder/{pkiEzsignfolderID}/send | Send the Ezsignfolder to the signatories for signature
*EzsignfoldersignerassociationApi* | [**EzsignfoldersignerassociationCreateObjectV1**](docs/EzsignfoldersignerassociationApi.md#ezsignfoldersignerassociationcreateobjectv1) | **POST** /1/object/ezsignfoldersignerassociation | Create a new Ezsignfoldersignerassociation
*EzsignfoldersignerassociationApi* | [**EzsignfoldersignerassociationDeleteObjectV1**](docs/EzsignfoldersignerassociationApi.md#ezsignfoldersignerassociationdeleteobjectv1) | **DELETE** /1/object/ezsignfoldersignerassociation/{pkiEzsignfoldersignerassociationID} | Delete an existing Ezsignfoldersignerassociation
*EzsignfoldersignerassociationApi* | [**EzsignfoldersignerassociationEditObjectV1**](docs/EzsignfoldersignerassociationApi.md#ezsignfoldersignerassociationeditobjectv1) | **PUT** /1/object/ezsignfoldersignerassociation/{pkiEzsignfoldersignerassociationID} | Modify an existing Ezsignfoldersignerassociation
*EzsignfoldersignerassociationApi* | [**EzsignfoldersignerassociationGetInPersonLoginUrlV1**](docs/EzsignfoldersignerassociationApi.md#ezsignfoldersignerassociationgetinpersonloginurlv1) | **GET** /1/object/ezsignfoldersignerassociation/{pkiEzsignfoldersignerassociationID}/getInPersonLoginUrl | Retrieve a Login Url to allow In-Person signing
*EzsignfoldersignerassociationApi* | [**EzsignfoldersignerassociationGetObjectGetChildrenV1**](docs/EzsignfoldersignerassociationApi.md#ezsignfoldersignerassociationgetobjectgetchildrenv1) | **GET** /1/object/ezsignfoldersignerassociation/{pkiEzsignfoldersignerassociationID}/getChildren | Retrieve an existing Ezsignfoldersignerassociation's children IDs
*EzsignfoldersignerassociationApi* | [**EzsignfoldersignerassociationGetObjectV1**](docs/EzsignfoldersignerassociationApi.md#ezsignfoldersignerassociationgetobjectv1) | **GET** /1/object/ezsignfoldersignerassociation/{pkiEzsignfoldersignerassociationID} | Retrieve an existing Ezsignfoldersignerassociation
*EzsignsignatureApi* | [**EzsignsignatureCreateObjectV1**](docs/EzsignsignatureApi.md#ezsignsignaturecreateobjectv1) | **POST** /1/object/ezsignsignature | Create a new Ezsignsignature
*EzsignsignatureApi* | [**EzsignsignatureDeleteObjectV1**](docs/EzsignsignatureApi.md#ezsignsignaturedeleteobjectv1) | **DELETE** /1/object/ezsignsignature/{pkiEzsignsignatureID} | Delete an existing Ezsignsignature
*EzsignsignatureApi* | [**EzsignsignatureEditObjectV1**](docs/EzsignsignatureApi.md#ezsignsignatureeditobjectv1) | **PUT** /1/object/ezsignsignature/{pkiEzsignsignatureID} | Modify an existing Ezsignsignature
*EzsignsignatureApi* | [**EzsignsignatureGetObjectGetChildrenV1**](docs/EzsignsignatureApi.md#ezsignsignaturegetobjectgetchildrenv1) | **GET** /1/object/ezsignsignature/{pkiEzsignsignatureID}/getChildren | Retrieve an existing Ezsignsignature's children IDs
*EzsignsignatureApi* | [**EzsignsignatureGetObjectV1**](docs/EzsignsignatureApi.md#ezsignsignaturegetobjectv1) | **GET** /1/object/ezsignsignature/{pkiEzsignsignatureID} | Retrieve an existing Ezsignsignature
*FranchisebrokerApi* | [**FranchisebrokerGetAutocompleteV1**](docs/FranchisebrokerApi.md#franchisebrokergetautocompletev1) | **GET** /1/object/franchisebroker/getAutocomplete/{sSelector} | Retrieve Franchisebrokers and IDs
*FranchiseofficeApi* | [**FranchiseofficeGetAutocompleteV1**](docs/FranchiseofficeApi.md#franchiseofficegetautocompletev1) | **GET** /1/object/franchiseoffice/getAutocomplete/{sSelector} | Retrieve Franchiseoffices and IDs
*FranchisereferalincomeApi* | [**FranchisereferalincomeCreateObjectV1**](docs/FranchisereferalincomeApi.md#franchisereferalincomecreateobjectv1) | **POST** /1/object/franchisereferalincome | Create a new Franchisereferalincome
*PeriodApi* | [**PeriodGetAutocompleteV1**](docs/PeriodApi.md#periodgetautocompletev1) | **GET** /1/object/period/getAutocomplete/{sSelector} | Retrieve Periods and IDs


## Documentation for Models

 - [Model.ActivesessionGetCurrentV1Response](docs/ActivesessionGetCurrentV1Response.md)
 - [Model.ActivesessionGetCurrentV1ResponseMPayload](docs/ActivesessionGetCurrentV1ResponseMPayload.md)
 - [Model.AddressRequest](docs/AddressRequest.md)
 - [Model.AttemptResponse](docs/AttemptResponse.md)
 - [Model.CommonAudit](docs/CommonAudit.md)
 - [Model.CommonGetAutocompleteV1Response](docs/CommonGetAutocompleteV1Response.md)
 - [Model.CommonGetAutocompleteV1ResponseMPayload](docs/CommonGetAutocompleteV1ResponseMPayload.md)
 - [Model.CommonResponse](docs/CommonResponse.md)
 - [Model.CommonResponseError](docs/CommonResponseError.md)
 - [Model.CommonResponseObjDebug](docs/CommonResponseObjDebug.md)
 - [Model.CommonResponseObjDebugPayload](docs/CommonResponseObjDebugPayload.md)
 - [Model.CommonResponseObjSQLQuery](docs/CommonResponseObjSQLQuery.md)
 - [Model.CommonWebhook](docs/CommonWebhook.md)
 - [Model.ContactRequest](docs/ContactRequest.md)
 - [Model.ContactRequestCompound](docs/ContactRequestCompound.md)
 - [Model.ContactRequestCompoundAllOf](docs/ContactRequestCompoundAllOf.md)
 - [Model.ContactinformationsRequest](docs/ContactinformationsRequest.md)
 - [Model.ContactinformationsRequestCompound](docs/ContactinformationsRequestCompound.md)
 - [Model.EmailRequest](docs/EmailRequest.md)
 - [Model.EzsigndocumentCreateObjectV1Request](docs/EzsigndocumentCreateObjectV1Request.md)
 - [Model.EzsigndocumentCreateObjectV1Response](docs/EzsigndocumentCreateObjectV1Response.md)
 - [Model.EzsigndocumentCreateObjectV1ResponseMPayload](docs/EzsigndocumentCreateObjectV1ResponseMPayload.md)
 - [Model.EzsigndocumentDeleteObjectV1Response](docs/EzsigndocumentDeleteObjectV1Response.md)
 - [Model.EzsigndocumentEditObjectV1Request](docs/EzsigndocumentEditObjectV1Request.md)
 - [Model.EzsigndocumentEditObjectV1Response](docs/EzsigndocumentEditObjectV1Response.md)
 - [Model.EzsigndocumentGetDownloadUrlV1Response](docs/EzsigndocumentGetDownloadUrlV1Response.md)
 - [Model.EzsigndocumentGetDownloadUrlV1ResponseMPayload](docs/EzsigndocumentGetDownloadUrlV1ResponseMPayload.md)
 - [Model.EzsigndocumentGetObjectV1Response](docs/EzsigndocumentGetObjectV1Response.md)
 - [Model.EzsigndocumentGetObjectV1ResponseMPayload](docs/EzsigndocumentGetObjectV1ResponseMPayload.md)
 - [Model.EzsigndocumentRequest](docs/EzsigndocumentRequest.md)
 - [Model.EzsigndocumentRequestCompound](docs/EzsigndocumentRequestCompound.md)
 - [Model.EzsigndocumentResponse](docs/EzsigndocumentResponse.md)
 - [Model.EzsigndocumentResponseAllOf](docs/EzsigndocumentResponseAllOf.md)
 - [Model.EzsigndocumentResponseCompound](docs/EzsigndocumentResponseCompound.md)
 - [Model.EzsignfolderCreateObjectV1Request](docs/EzsignfolderCreateObjectV1Request.md)
 - [Model.EzsignfolderCreateObjectV1Response](docs/EzsignfolderCreateObjectV1Response.md)
 - [Model.EzsignfolderCreateObjectV1ResponseMPayload](docs/EzsignfolderCreateObjectV1ResponseMPayload.md)
 - [Model.EzsignfolderDeleteObjectV1Response](docs/EzsignfolderDeleteObjectV1Response.md)
 - [Model.EzsignfolderEditObjectV1Request](docs/EzsignfolderEditObjectV1Request.md)
 - [Model.EzsignfolderEditObjectV1Response](docs/EzsignfolderEditObjectV1Response.md)
 - [Model.EzsignfolderGetObjectV1Response](docs/EzsignfolderGetObjectV1Response.md)
 - [Model.EzsignfolderGetObjectV1ResponseMPayload](docs/EzsignfolderGetObjectV1ResponseMPayload.md)
 - [Model.EzsignfolderRequest](docs/EzsignfolderRequest.md)
 - [Model.EzsignfolderRequestCompound](docs/EzsignfolderRequestCompound.md)
 - [Model.EzsignfolderResponse](docs/EzsignfolderResponse.md)
 - [Model.EzsignfolderResponseAllOf](docs/EzsignfolderResponseAllOf.md)
 - [Model.EzsignfolderResponseCompound](docs/EzsignfolderResponseCompound.md)
 - [Model.EzsignfolderSendV1Request](docs/EzsignfolderSendV1Request.md)
 - [Model.EzsignfolderSendV1Response](docs/EzsignfolderSendV1Response.md)
 - [Model.EzsignfoldersignerassociationCreateObjectV1Request](docs/EzsignfoldersignerassociationCreateObjectV1Request.md)
 - [Model.EzsignfoldersignerassociationCreateObjectV1Response](docs/EzsignfoldersignerassociationCreateObjectV1Response.md)
 - [Model.EzsignfoldersignerassociationCreateObjectV1ResponseMPayload](docs/EzsignfoldersignerassociationCreateObjectV1ResponseMPayload.md)
 - [Model.EzsignfoldersignerassociationDeleteObjectV1Response](docs/EzsignfoldersignerassociationDeleteObjectV1Response.md)
 - [Model.EzsignfoldersignerassociationEditObjectV1Request](docs/EzsignfoldersignerassociationEditObjectV1Request.md)
 - [Model.EzsignfoldersignerassociationEditObjectV1Response](docs/EzsignfoldersignerassociationEditObjectV1Response.md)
 - [Model.EzsignfoldersignerassociationGetInPersonLoginUrlV1Response](docs/EzsignfoldersignerassociationGetInPersonLoginUrlV1Response.md)
 - [Model.EzsignfoldersignerassociationGetInPersonLoginUrlV1ResponseMPayload](docs/EzsignfoldersignerassociationGetInPersonLoginUrlV1ResponseMPayload.md)
 - [Model.EzsignfoldersignerassociationGetObjectV1Response](docs/EzsignfoldersignerassociationGetObjectV1Response.md)
 - [Model.EzsignfoldersignerassociationRequest](docs/EzsignfoldersignerassociationRequest.md)
 - [Model.EzsignfoldersignerassociationRequestCompound](docs/EzsignfoldersignerassociationRequestCompound.md)
 - [Model.EzsignsignatureCreateObjectV1Request](docs/EzsignsignatureCreateObjectV1Request.md)
 - [Model.EzsignsignatureCreateObjectV1Response](docs/EzsignsignatureCreateObjectV1Response.md)
 - [Model.EzsignsignatureCreateObjectV1ResponseMPayload](docs/EzsignsignatureCreateObjectV1ResponseMPayload.md)
 - [Model.EzsignsignatureDeleteObjectV1Response](docs/EzsignsignatureDeleteObjectV1Response.md)
 - [Model.EzsignsignatureEditObjectV1Request](docs/EzsignsignatureEditObjectV1Request.md)
 - [Model.EzsignsignatureEditObjectV1Response](docs/EzsignsignatureEditObjectV1Response.md)
 - [Model.EzsignsignatureGetObjectV1Response](docs/EzsignsignatureGetObjectV1Response.md)
 - [Model.EzsignsignatureRequest](docs/EzsignsignatureRequest.md)
 - [Model.EzsignsignatureRequestCompound](docs/EzsignsignatureRequestCompound.md)
 - [Model.EzsignsignerRequest](docs/EzsignsignerRequest.md)
 - [Model.EzsignsignerRequestCompound](docs/EzsignsignerRequestCompound.md)
 - [Model.EzsignsignerRequestCompoundContact](docs/EzsignsignerRequestCompoundContact.md)
 - [Model.FieldEEzsigndocumentStep](docs/FieldEEzsigndocumentStep.md)
 - [Model.FieldEEzsignfolderSendreminderfrequency](docs/FieldEEzsignfolderSendreminderfrequency.md)
 - [Model.FieldEEzsignfolderStep](docs/FieldEEzsignfolderStep.md)
 - [Model.FieldEPhoneType](docs/FieldEPhoneType.md)
 - [Model.FranchisereferalincomeCreateObjectV1Request](docs/FranchisereferalincomeCreateObjectV1Request.md)
 - [Model.FranchisereferalincomeCreateObjectV1Response](docs/FranchisereferalincomeCreateObjectV1Response.md)
 - [Model.FranchisereferalincomeCreateObjectV1ResponseMPayload](docs/FranchisereferalincomeCreateObjectV1ResponseMPayload.md)
 - [Model.FranchisereferalincomeRequest](docs/FranchisereferalincomeRequest.md)
 - [Model.FranchisereferalincomeRequestCompound](docs/FranchisereferalincomeRequestCompound.md)
 - [Model.PhoneRequest](docs/PhoneRequest.md)
 - [Model.WebhookEzsignDocumentCompleted](docs/WebhookEzsignDocumentCompleted.md)
 - [Model.WebhookEzsignDocumentCompletedAllOf](docs/WebhookEzsignDocumentCompletedAllOf.md)
 - [Model.WebhookEzsignFolderCompleted](docs/WebhookEzsignFolderCompleted.md)
 - [Model.WebhookEzsignFolderCompletedAllOf](docs/WebhookEzsignFolderCompletedAllOf.md)
 - [Model.WebhookResponse](docs/WebhookResponse.md)
 - [Model.WebsiteRequest](docs/WebsiteRequest.md)


## Documentation for Authorization


### Authorization

- **Type**: API key

- **API key parameter name**: Authorization
- **Location**: HTTP header

