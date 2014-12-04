New Relic rest API
==================

This repository would be used to store my development efforts to access New Relic rest API from C# code.
This project is not endorsed or supported by New Relic.

## Authentication

New Relic supports an api key-based authentication mechanism.
So, when creating client, one should pass api key to constructor.
```csharp
using (var accessor = new NewRelicAccessor(ApiKey))
{
}
```

## Methods built and usage examples

### Deployment Notifications

As deployment notifications could be sent either for application id (IMHO, preferred way) or application name, there is 2 classes in code, which could be used.
Both classes have 1 required parameter (application name or id) and all other are optional.
Following, examples of usage.

*Application id*

```csharp
using (var accessor = new NewRelicAccessor(ApiKey))
{
	var postCommand = new PostDeploymentWithApplicationId
	{
		Item = new DeploymentsApplicationId
		{
			Application_Id = "Application id for which deployment is held",
			Revision = "A revision number (e.g., git commit SHA)",
			Changelog = "A list of changes for this deployment",
			User = "The name of the user/process that triggered this deployment",
			Description = "Text annotation for the deployment; notes for you",
			AppName = "Name of the application for deployment",
			Environment = "The environment for this deployment"
		}
	};
	
	HttpResponseMessage response = accessor.Post(postCommand);
}
```

*Application name*

```csharp
using (var accessor = new NewRelicAccessor(ApiKey))
{
	var postCommand = new PostDeploymentWithApplicationName
	{
		Item = new DeploymentsApplicationName
		{
			App_Name = "Application name for which deployment is held",
			Revision = "A revision number (e.g., git commit SHA)",
			Changelog = "A list of changes for this deployment",
			User = "The name of the user/process that triggered this deployment",
			Description = "Text annotation for the deployment; notes for you",
			AppName = "Name of the application for deployment",
			Environment = "The environment for this deployment"
		}
	};
	
	HttpResponseMessage response = accessor.Post(postCommand);
}
```

## Nuget and SymbolsSource

[Nuget package](https://www.nuget.org/packages/NewRelicSharp/)

[SymbolSource package](https://www.symbolsource.org/Public/Metadata/NuGet/Project/NewRelicSharp)