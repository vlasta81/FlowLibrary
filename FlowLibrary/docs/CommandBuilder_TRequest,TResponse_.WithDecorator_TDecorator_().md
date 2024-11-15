#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Builders](FlowLibrary.Builders.md 'FlowLibrary.Builders').[CommandBuilder&lt;TRequest,TResponse&gt;](CommandBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>')

## CommandBuilder<TRequest,TResponse>.WithDecorator<TDecorator>() Method

Adds a decorator to the command.

```csharp
public FlowLibrary.Builders.CommandBuilder<TRequest,TResponse> WithDecorator<TDecorator>()
    where TDecorator : FlowLibrary.Abstractions.CommandDecorator<TRequest, TResponse>;
```
#### Type parameters

<a name='FlowLibrary.Builders.CommandBuilder_TRequest,TResponse_.WithDecorator_TDecorator_().TDecorator'></a>

`TDecorator`

The type of the decorator to add.

#### Returns
[FlowLibrary.Builders.CommandBuilder&lt;](CommandBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>')[TRequest](CommandBuilder_TRequest,TResponse_.md#FlowLibrary.Builders.CommandBuilder_TRequest,TResponse_.TRequest 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>.TRequest')[,](CommandBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>')[TResponse](CommandBuilder_TRequest,TResponse_.md#FlowLibrary.Builders.CommandBuilder_TRequest,TResponse_.TResponse 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>.TResponse')[&gt;](CommandBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>')  
The current instance of [CommandBuilder&lt;TRequest,TResponse&gt;](CommandBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>').