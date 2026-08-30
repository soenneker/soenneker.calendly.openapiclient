[![](https://img.shields.io/nuget/v/soenneker.calendly.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.calendly.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.calendly.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.calendly.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.calendly.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.calendly.openapiclient/actions/workflows/codeql.yml)
[![](https://img.shields.io/nuget/dt/soenneker.calendly.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.calendly.openapiclient/)

# Soenneker.Calendly.OpenApiClient

A Kiota-generated .NET client for Calendly's API.

## Installation

```bash
dotnet add package Soenneker.Calendly.OpenApiClient
```

## Usage

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Calendly.OpenApiClient;
using Soenneker.Calendly.OpenApiClient.Models;

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "your-personal-access-token");

var adapter = new HttpClientRequestAdapter(new AnonymousAuthenticationProvider(), httpClient: httpClient);
var client = new CalendlyOpenApiClient(adapter);

GetCurrentUser200Response? response = await client.Users.Me.GetAsync();
```

Keep the `HttpClient` long-lived rather than creating one per request. For dependency injection, configuration-based authentication, and managed client reuse, use `Soenneker.Calendly.OpenApiClientUtil`.

The request builders and models are generated from Calendly's OpenAPI document and can change when that document changes. Review package upgrades when you depend on generated names or response shapes.
