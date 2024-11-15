#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Builders](FlowLibrary.Builders.md 'FlowLibrary.Builders')

## CommandBuilder<TRequest,TResponse> Class

A builder class for constructing command objects with optional decorators.

```csharp
public sealed class CommandBuilder<TRequest,TResponse>
```
#### Type parameters

<a name='FlowLibrary.Builders.CommandBuilder_TRequest,TResponse_.TRequest'></a>

`TRequest`

The type of the request object.

<a name='FlowLibrary.Builders.CommandBuilder_TRequest,TResponse_.TResponse'></a>

`TResponse`

The type of the response object.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; CommandBuilder<TRequest,TResponse>

| Constructors | |
| :--- | :--- |
| [CommandBuilder(IServiceProvider, Action&lt;ICommand&lt;TRequest,TResponse&gt;&gt;)](CommandBuilder_TRequest,TResponse_..ctor.wDCHCDBq1UCdi/DlNKUUlw.md 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>.CommandBuilder(System.IServiceProvider, System.Action<FlowLibrary.Contracts.ICommand<TRequest,TResponse>>)') | Initializes a new instance of the [CommandBuilder&lt;TRequest,TResponse&gt;](CommandBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>') class. |

| Methods | |
| :--- | :--- |
| [Build()](CommandBuilder_TRequest,TResponse_.Build().md 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>.Build()') | Builds the command and adds it using the provided action. |
| [SetCommand&lt;TCommand&gt;()](CommandBuilder_TRequest,TResponse_.SetCommand_TCommand_().md 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>.SetCommand<TCommand>()') | Sets the command to be built. |
| [WithDecorator&lt;TDecorator&gt;()](CommandBuilder_TRequest,TResponse_.WithDecorator_TDecorator_().md 'FlowLibrary.Builders.CommandBuilder<TRequest,TResponse>.WithDecorator<TDecorator>()') | Adds a decorator to the command. |
