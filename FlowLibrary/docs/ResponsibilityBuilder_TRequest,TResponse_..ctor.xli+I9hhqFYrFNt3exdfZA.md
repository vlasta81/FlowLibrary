#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Builders](FlowLibrary.Builders.md 'FlowLibrary.Builders').[ResponsibilityBuilder&lt;TRequest,TResponse&gt;](ResponsibilityBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.ResponsibilityBuilder<TRequest,TResponse>')

## ResponsibilityBuilder(IServiceProvider, Action<Responsibility<TRequest,TResponse>>) Constructor

Initializes a new instance of the [ResponsibilityBuilder&lt;TRequest,TResponse&gt;](ResponsibilityBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.ResponsibilityBuilder<TRequest,TResponse>') class.

```csharp
public ResponsibilityBuilder(System.IServiceProvider serviceProvider, System.Action<FlowLibrary.Abstractions.Responsibility<TRequest,TResponse>> addResponsibility);
```
#### Parameters

<a name='FlowLibrary.Builders.ResponsibilityBuilder_TRequest,TResponse_.ResponsibilityBuilder(System.IServiceProvider,System.Action_FlowLibrary.Abstractions.Responsibility_TRequest,TResponse__).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider for resolving dependencies.

<a name='FlowLibrary.Builders.ResponsibilityBuilder_TRequest,TResponse_.ResponsibilityBuilder(System.IServiceProvider,System.Action_FlowLibrary.Abstractions.Responsibility_TRequest,TResponse__).addResponsibility'></a>

`addResponsibility` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[FlowLibrary.Abstractions.Responsibility&lt;](Responsibility_TRequest,TResponse_.md 'FlowLibrary.Abstractions.Responsibility<TRequest,TResponse>')[TRequest](ResponsibilityBuilder_TRequest,TResponse_.md#FlowLibrary.Builders.ResponsibilityBuilder_TRequest,TResponse_.TRequest 'FlowLibrary.Builders.ResponsibilityBuilder<TRequest,TResponse>.TRequest')[,](Responsibility_TRequest,TResponse_.md 'FlowLibrary.Abstractions.Responsibility<TRequest,TResponse>')[TResponse](ResponsibilityBuilder_TRequest,TResponse_.md#FlowLibrary.Builders.ResponsibilityBuilder_TRequest,TResponse_.TResponse 'FlowLibrary.Builders.ResponsibilityBuilder<TRequest,TResponse>.TResponse')[&gt;](Responsibility_TRequest,TResponse_.md 'FlowLibrary.Abstractions.Responsibility<TRequest,TResponse>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The action to add the constructed responsibility chain.