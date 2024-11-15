#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Builders](FlowLibrary.Builders.md 'FlowLibrary.Builders').[FlowBuilder&lt;TRequest,TResponse&gt;](FlowBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.FlowBuilder<TRequest,TResponse>')

## FlowBuilder<TRequest,TResponse>.AddCommand() Method

Adds a command to the flow.

```csharp
public FlowLibrary.Builders.CommandBuilder<TRequest,TResponse> AddCommand();
```

#### Returns
[FlowLibrary.Builders.CommandBuilder&lt;](CommandBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>')[TRequest](FlowBuilder_TRequest,TResponse_.md#FlowLibrary.Builders.FlowBuilder_TRequest,TResponse_.TRequest 'FlowLibrary.Builders.FlowBuilder<TRequest,TResponse>.TRequest')[,](CommandBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>')[TResponse](FlowBuilder_TRequest,TResponse_.md#FlowLibrary.Builders.FlowBuilder_TRequest,TResponse_.TResponse 'FlowLibrary.Builders.FlowBuilder<TRequest,TResponse>.TResponse')[&gt;](CommandBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>')  
A [CommandBuilder&lt;TRequest,TResponse&gt;](CommandBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>') to configure the command.

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
Thrown if a command has already been added to the flow.