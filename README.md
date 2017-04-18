# IO.Swagger - the C# library for the Switch Database REST API

Switch API is the primary endpoint of data sevices and Switch DB's platform. You can do adding, editing, deleting or listing data works to your database with query operations by using this low-level API based on HTTP.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.2.1
- SDK version: 1.0.0
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```

<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.Swagger.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            
            var apiInstance = new AuthorizationApi();
            var aPIKey = aPIKey_example;  // string | Your Switch API Key.
            var signature = signature_example;  // string | Signature parameter is generated as md5(APISecret + ExpireTimestamp) format.
            var expire = 789;  // long? | Expire parameter, token's expire date and time information must be proper to ISO 8601 standarts and Unix Time format with msec information.

            try
            {
                // Generate Access Token
                string result = apiInstance.TokenGet(aPIKey, signature, expire);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthorizationApi.TokenGet: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://tr02.switchapi.com/*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthorizationApi* | [**TokenGet**](docs/AuthorizationApi.md#tokenget) | **GET** /Token | Generate Access Token
*DBOperationsApi* | [**AddPost**](docs/DBOperationsApi.md#addpost) | **POST** /Add | Add is used for adding a data object to the list created at Switch DB.
*DBOperationsApi* | [**ListPost**](docs/DBOperationsApi.md#listpost) | **POST** /List | It's used for listing a data added before.
*DBOperationsApi* | [**SetDelete**](docs/DBOperationsApi.md#setdelete) | **DELETE** /Set | It's used for deleting a data added before at Switch DB.
*DBOperationsApi* | [**SetPost**](docs/DBOperationsApi.md#setpost) | **POST** /Set | It's used for updating a data object that is already added to Switch DB.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AddResponse](docs/AddResponse.md)
 - [Model.Body](docs/Body.md)
 - [Model.Error](docs/Error.md)
 - [Model.ListOrder](docs/ListOrder.md)
 - [Model.SetResponse](docs/SetResponse.md)
 - [Model.WhereItem](docs/WhereItem.md)
 
 ## Authors

* **[Mert Sarac](https://github.com/saracmert)** - *Initial work*