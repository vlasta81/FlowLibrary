#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Builders](FlowLibrary.Builders.md 'FlowLibrary.Builders').[MiddlewaresBuilder&lt;TRequest,TResponse&gt;](MiddlewaresBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.MiddlewaresBuilder<TRequest,TResponse>')

## MiddlewaresBuilder(IServiceProvider, Action<IMiddleware<TRequest,TResponse>>) Constructor

Initializes a new instance of the [MiddlewaresBuilder&lt;TRequest,TResponse&gt;](MiddlewaresBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.MiddlewaresBuilder<TRequest,TResponse>') class.

```csharp
public MiddlewaresBuilder(System.IServiceProvider serviceProvider, System.Action<FlowLibrary.Contracts.IMiddleware<TRequest,TResponse>> addMiddleware);
```
#### Parameters

<a name='FlowLibrary.Builders.MiddlewaresBuilder_TRequest,TResponse_.MiddlewaresBuilder(System.IServiceProvider,System.Action_FlowLibrary.Contracts.IMiddleware_TRequest,TResponse__).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider for resolving middleware instances.

<a name='FlowLibrary.Builders.MiddlewaresBuilder_TRequest,TResponse_.MiddlewaresBuilder(System.IServiceProvider,System.Action_FlowLibrary.Contracts.IMiddleware_TRequest,TResponse__).addMiddleware'></a>

`addMiddleware` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[FlowLibrary.Contracts.IMiddleware&lt;](IMiddleware_TRequest,TResponse_.md 'FlowLibrary.Contracts.IMiddleware<TRequest,TResponse>')[TRequest](MiddlewaresBuilder_TRequest,TResponse_.md#FlowLibrary.Builders.MiddlewaresBuilder_TRequest,TResponse_.TRequest 'FlowLibrary.Builders.MiddlewaresBuilder<TRequest,TResponse>.TRequest')[,](IMiddleware_TRequest,TResponse_.md 'FlowLibrary.Contracts.IMiddleware<TRequest,TResponse>')[TResponse](MiddlewaresBuilder_TRequest,TResponse_.md#FlowLibrary.Builders.MiddlewaresBuilder_TRequest,TResponse_.TResponse 'FlowLibrary.Builders.MiddlewaresBuilder<TRequest,TResponse>.TResponse')[&gt;](IMiddleware_TRequest,TResponse_.md 'FlowLibrary.Contracts.IMiddleware<TRequest,TResponse>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The action to add a middleware to the pipeline.