# Release History

## 1.0.0-beta.9 (Unreleased)

### Features Added

### Breaking Changes

- Base type of `KeyVaultPrivateEndpointConnectionData` changed to `Azure.ResourceManager.Models.ResourceData`.
- Base type of `ManagedHsmData` changed to `Azure.ResourceManager.Models.ResourceData`.
- Base type of `ManagedHsmPrivateEndpointConnectionData` changed to `Azure.ResourceManager.Models.ResourceData`.
- Type `KeyVaultResourceData` was removed.
- Base type of `ManagedHsmPrivateLinkResourceData` changed to `Azure.ResourceManager.Models.ResourceData`.
- Type `ManagedHsmTrackedResourceData` was removed.
- Base type of `PrivateLinkResourceData` changed to `Azure.ResourceManager.Models.ResourceData`.

### Bugs Fixed

### Other Changes

## 1.0.0-beta.8 (2022-04-08)

### Breaking Changes

- Simplify `type` property names.
- Normalized the body parameter type names for PUT / POST / PATCH operations if it is only used as input.

### Other Changes

- Upgrade dependency to Azure.ResourceManager 1.0.0

## 1.0.0-beta.7 (2022-03-31)

### Breaking Changes

- Now all the resource classes would have a `Resource` suffix (if it previously does not have one).
- Renamed some models to more comprehensive names.
- `bool waitForCompletion` parameter in all long running operations were changed to `WaitUntil waitUntil`.
- Removed `GetIfExists` methods from all the resource classes.
- All properties of the type `object` were changed to `BinaryData`.

## 1.0.0-beta.6 (2022-01-29)

### Breaking Changes

- waitForCompletion is now a required parameter and moved to the first parameter in LRO operations.
- Removed GetAllAsGenericResources in [Resource]Collections.
- Added Resource constructor to use ArmClient for ClientContext information and removed previous constructors with parameters.
- Couple of renamings.

## 1.0.0-beta.5 (2021-12-28)

### Features Added

- Added `CreateResourceIdentifier` for each resource class

### Breaking Changes

- Renamed `CheckIfExists` to `Exists` for each resource collection class
- Renamed `Get{Resource}ByName` to `Get{Resource}AsGenericResources` in `SubscriptionExtensions`

### Bugs Fixed

- Fixed comments for `FirstPageFunc` of each pageable resource class

## 1.0.0-beta.4 (2021-12-07)

### Breaking Changes

- Unified the identification rule of detecting resources, therefore some resources might become non-resources, and vice versa.

### Bugs Fixed

- Fixed problematic internal parameter invocation from the context `Id` property to the corresponding `RestOperations`.

## 1.0.0-beta.3 (2021-10-28)

### Breaking Changes

- Renamed [Resource]Container to [Resource]Collection and added the IEnumerable<T> and IAsyncEnumerable<T> interfaces to them making it easier to iterate over the list in the simple case.

## 1.0.0-beta.2 (2021-09-14)

### Features Added

- Added ArmClient extension methods to support [start from the middle scenario](https://github.com/Azure/azure-sdk-for-net/tree/main/sdk/resourcemanager/Azure.ResourceManager#managing-existing-resources-by-id).

## 1.0.0-beta.1 (2021-08-31)

### Breaking Changes

Guidance to migrate from previous version of Azure Management SDK

### General New Features

    - Support MSAL.NET, Azure.Identity is out of box for supporting MSAL.NET
    - Support [OpenTelemetry](https://opentelemetry.io/) for distributed tracing
    - HTTP pipeline with custom policies
    - Better error-handling
    - Support uniform telemetry across all languages

> NOTE: For more information about unified authentication, please refer to [Azure Identity documentation for .NET](https://docs.microsoft.com//dotnet/api/overview/azure/identity-readme?view=azure-dotnet)

#### Package Name
The package name has been changed from `Microsoft.Azure.Management.KeyVault` to `Azure.ResourceManager.KeyVault`

#### Management Client Changes

Example: Create a Key Vault Instance:

Before upgrade:

```C#
using Microsoft.Azure.Management.KeyVault;
using Microsoft.Azure.Management.KeyVault.Models;
using Microsoft.Rest;
```

```C#
var tokenCredentials = new TokenCredentials("YOUR ACCESS TOKEN");
var keyVaultManagementClient = new KeyVaultManagementClient(tokenCredentials);
var vault = await keyVaultManagementClient.Vaults.BeginCreateOrUpdateAsync
                (
                    resourceGroupName,
                    vaultName,
                    parameters
                );
```

After upgrade:

```C# Snippet:Changelog_Namespaces
using System;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.KeyVault;
using Azure.ResourceManager.KeyVault.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Resources.Models;
```

```C# Snippet:Changelog_NewCode
ArmClient armClient = new ArmClient(new DefaultAzureCredential());
SubscriptionResource subscription = await armClient.GetDefaultSubscriptionAsync();
ResourceGroupResource resourceGroup = await subscription.GetResourceGroups().GetAsync("myRgName");

VaultCollection vaultCollection = resourceGroup.GetVaults();
VaultCreateOrUpdateContent parameters = new VaultCreateOrUpdateContent(AzureLocation.WestUS2, new VaultProperties(Guid.NewGuid(), new VaultSku(VaultSkuFamily.A, VaultSkuName.Standard)));

ArmOperation<VaultResource> lro = await vaultCollection.CreateOrUpdateAsync(WaitUntil.Completed, "myVaultName", parameters);
VaultResource vault = lro.Value;
```

#### Object Model Changes

Example: Create a Permissions Model

Before upgrade:

```C#
VaultProperties properties = new VaultProperties(Guid.NewGuid(), new Sku(SkuFamily.A, SkuName.Standard));
VaultCreateOrUpdateParameters parameters = new VaultCreateOrUpdateParameters(Location.WestUS2, properties);
```

After upgrade:

```C# Snippet:Changelog_CreateModel
VaultProperties properties = new VaultProperties(Guid.NewGuid(), new VaultSku(VaultSkuFamily.A, VaultSkuName.Standard));
VaultCreateOrUpdateContent parameters = new VaultCreateOrUpdateContent(AzureLocation.WestUS2, properties);
```
