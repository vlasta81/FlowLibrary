#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Abstractions](FlowLibrary.Abstractions.md 'FlowLibrary.Abstractions')

## CommandDecorator<TRequest,TResponse> Class

Abstract base class for command decorators.

```csharp
public abstract class CommandDecorator<TRequest,TResponse> :
FlowLibrary.Contracts.ICommand<TRequest, TResponse>
```
#### Type parameters

<a name='FlowLibrary.Abstractions.CommandDecorator_TRequest,TResponse_.TRequest'></a>

`TRequest`

The type of the request.

<a name='FlowLibrary.Abstractions.CommandDecorator_TRequest,TResponse_.TResponse'></a>

`TResponse`

The type of the response.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; CommandDecorator<TRequest,TResponse>

Implements [FlowLibrary.Contracts.ICommand&lt;](ICommand_TRequest,TResponse_.md 'FlowLibrary.Contracts.ICommand<TRequest,TResponse>')[TRequest](CommandDecorator_TRequest,TResponse_.md#FlowLibrary.Abstractions.CommandDecorator_TRequest,TResponse_.TRequest 'FlowLibrary.Abstractions.CommandDecorator<TRequest,TResponse>.TRequest')[,](ICommand_TRequest,TResponse_.md 'FlowLibrary.Contracts.ICommand<TRequest,TResponse>')[TResponse](CommandDecorator_TRequest,TResponse_.md#FlowLibrary.Abstractions.CommandDecorator_TRequest,TResponse_.TResponse 'FlowLibrary.Abstractions.CommandDecorator<TRequest,TResponse>.TResponse')[&gt;](ICommand_TRequest,TResponse_.md 'FlowLibrary.Contracts.ICommand<TRequest,TResponse>')

| Methods | |
| :--- | :--- |
| [ExecuteAsync(TRequest)](CommandDecorator_TRequest,TResponse_.ExecuteAsync.yEyf05GSMMpYvlq+y9fIYg.md 'FlowLibrary.Abstractions.CommandDecorator<TRequest,TResponse>.ExecuteAsync(TRequest)') | Executes the command asynchronously. |
| [SetNext(ICommand&lt;TRequest,TResponse&gt;)](CommandDecorator_TRequest,TResponse_.SetNext.wTInrPuH/JVU6v/BgMTN3g.md 'FlowLibrary.Abstractions.CommandDecorator<TRequest,TResponse>.SetNext(FlowLibrary.Contracts.ICommand<TRequest,TResponse>)') | Sets the next decorator in the chain. |
