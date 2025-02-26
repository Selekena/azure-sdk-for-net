# Release History

## 1.0.0-beta.5 (Unreleased)

### Features Added

### Breaking Changes

- Base type of `DisasterRecoveryData` changed to `Azure.ResourceManager.Models.ResourceData`.
- Base type of `MigrationConfigPropertiesData` changed to `Azure.ResourceManager.Models.ResourceData`.
- Base type of `NetworkRuleSetData` changed to `Azure.ResourceManager.Models.ResourceData`.
- Base type of `ServiceBusAuthorizationRuleData` changed to `Azure.ResourceManager.Models.ResourceData`.
- Base type of `ServiceBusPrivateEndpointConnectionData` changed to `Azure.ResourceManager.Models.ResourceData`.
- Base type of `ServiceBusQueueData` changed to `Azure.ResourceManager.Models.ResourceData`.
- Base type of `ServiceBusRuleData` changed to `Azure.ResourceManager.Models.ResourceData`.
- Base type of `ServiceBusSubscriptionData` changed to `Azure.ResourceManager.Models.ResourceData`.
- Base type of `ServiceBusTopicData` changed to `Azure.ResourceManager.Models.ResourceData`.
- Type `ProxyResource` was removed.

### Bugs Fixed

### Other Changes

## 1.0.0-beta.4 (2022-04-08)

### Breaking Changes

- Simplify `type` property names.
- Normalized the body parameter type names for PUT / POST / PATCH operations if it is only used as input.

### Other Changes

- Upgrade dependency to Azure.ResourceManager 1.0.0

## 1.0.0-beta.3 (2022-03-31)

### Breaking Changes

- Now all the resource classes would have a `Resource` suffix (if it previously does not have one).
- Renamed some models to more comprehensive names.
- `bool waitForCompletion` parameter in all long running operations were changed to `WaitUntil waitUntil`.
- All properties of the type `object` were changed to `BinaryData`.
- Removed `GetIfExists` methods from all the resource classes.

## 1.0.0-beta.2 (2021-12-28)

### Features Added

- Added `CreateResourceIdentifier` for each resource class

### Breaking Changes

- Renamed `CheckIfExists` to `Exists` for each resource collection class
- Renamed `Get{Resource}ByName` to `Get{Resource}AsGenericResources` in `SubscriptionExtensions`

## 1.0.0-beta.1 (2021-12-02)

This package follows the [Azure SDK Design Guidelines for .NET](https://azure.github.io/azure-sdk/dotnet_introduction.html) which provide a number of core capabilities that are shared amongst all Azure SDKs, including the intuitive Azure Identity library, an HTTP Pipeline with custom policies, error-handling, distributed tracing, and much more.

This is a Public Preview version, so expect incompatible changes in subsequent releases as we improve the product. To provide feedback, please submit an issue in our [Azure SDK for .NET GitHub repo](https://github.com/Azure/azure-sdk-for-net/issues).
