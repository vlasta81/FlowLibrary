#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Contracts](FlowLibrary.Contracts.md 'FlowLibrary.Contracts')

## ICommand<TRequest,TResponse> Interface

Represents a command that can be executed asynchronously with a request and response.

```csharp
public interface ICommand<TRequest,TResponse>
```
#### Type parameters

<a name='FlowLibrary.Contracts.ICommand_TRequest,TResponse_.TRequest'></a>

`TRequest`

The type of the request parameter.

<a name='FlowLibrary.Contracts.ICommand_TRequest,TResponse_.TResponse'></a>

`TResponse`

The type of the response result.

Derived  
&#8627; [CommandDecorator&lt;TRequest,TResponse&gt;](CommandDecorator_TRequest,TResponse_.md 'FlowLibrary.Abstractions.CommandDecorator<TRequest,TResponse>')

| Methods | |
| :--- | :--- |
| [ExecuteAsync(TRequest)](ICommand_TRequest,TResponse_.ExecuteAsync.HN46vkQRZPM9T7CK7SPJuA.md 'FlowLibrary.Contracts.ICommand<TRequest,TResponse>.ExecuteAsync(TRequest)') | Executes the command asynchronously with the specified request. |
