#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Builders](FlowLibrary.Builders.md 'FlowLibrary.Builders').[CommandBuilder&lt;TRequest,TResponse&gt;](CommandBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>')

## CommandBuilder<TRequest,TResponse>.SetCommand<TCommand>() Method

Sets the command to be built.

```csharp
public FlowLibrary.Builders.CommandBuilder<TRequest,TResponse> SetCommand<TCommand>()
    where TCommand : FlowLibrary.Contracts.ICommand<TRequest, TResponse>;
```
#### Type parameters

<a name='FlowLibrary.Builders.CommandBuilder_TRequest,TResponse_.SetCommand_TCommand_().TCommand'></a>

`TCommand`

The type of the command to set.

#### Returns
[FlowLibrary.Builders.CommandBuilder&lt;](CommandBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>')[TRequest](CommandBuilder_TRequest,TResponse_.md#FlowLibrary.Builders.CommandBuilder_TRequest,TResponse_.TRequest 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>.TRequest')[,](CommandBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>')[TResponse](CommandBuilder_TRequest,TResponse_.md#FlowLibrary.Builders.CommandBuilder_TRequest,TResponse_.TResponse 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>.TResponse')[&gt;](CommandBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>')  
The current instance of [CommandBuilder&lt;TRequest,TResponse&gt;](CommandBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>').