#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Builders](FlowLibrary.Builders.md 'FlowLibrary.Builders').[CommandBuilder&lt;TRequest,TResponse&gt;](CommandBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>')

## CommandBuilder(IServiceProvider, Action<ICommand<TRequest,TResponse>>) Constructor

Initializes a new instance of the [CommandBuilder&lt;TRequest,TResponse&gt;](CommandBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>') class.

```csharp
public CommandBuilder(System.IServiceProvider serviceProvider, System.Action<FlowLibrary.Contracts.ICommand<TRequest,TResponse>> addCommand);
```
#### Parameters

<a name='FlowLibrary.Builders.CommandBuilder_TRequest,TResponse_.CommandBuilder(System.IServiceProvider,System.Action_FlowLibrary.Contracts.ICommand_TRequest,TResponse__).serviceProvider'></a>

`serviceProvider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider for resolving dependencies.

<a name='FlowLibrary.Builders.CommandBuilder_TRequest,TResponse_.CommandBuilder(System.IServiceProvider,System.Action_FlowLibrary.Contracts.ICommand_TRequest,TResponse__).addCommand'></a>

`addCommand` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[FlowLibrary.Contracts.ICommand&lt;](ICommand_TRequest,TResponse_.md 'FlowLibrary.Contracts.ICommand<TRequest,TResponse>')[TRequest](CommandBuilder_TRequest,TResponse_.md#FlowLibrary.Builders.CommandBuilder_TRequest,TResponse_.TRequest 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>.TRequest')[,](ICommand_TRequest,TResponse_.md 'FlowLibrary.Contracts.ICommand<TRequest,TResponse>')[TResponse](CommandBuilder_TRequest,TResponse_.md#FlowLibrary.Builders.CommandBuilder_TRequest,TResponse_.TResponse 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>.TResponse')[&gt;](ICommand_TRequest,TResponse_.md 'FlowLibrary.Contracts.ICommand<TRequest,TResponse>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The action to add the constructed command.