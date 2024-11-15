#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Abstractions](FlowLibrary.Abstractions.md 'FlowLibrary.Abstractions').[CommandDecorator&lt;TRequest,TResponse&gt;](CommandDecorator_TRequest,TResponse_.md 'FlowLibrary.Abstractions.CommandDecorator<TRequest,TResponse>')

## CommandDecorator<TRequest,TResponse>.ExecuteAsync(TRequest) Method

Executes the command asynchronously.

```csharp
public virtual System.Threading.Tasks.Task<TResponse> ExecuteAsync(TRequest request);
```
#### Parameters

<a name='FlowLibrary.Abstractions.CommandDecorator_TRequest,TResponse_.ExecuteAsync(TRequest).request'></a>

`request` [TRequest](CommandDecorator_TRequest,TResponse_.md#FlowLibrary.Abstractions.CommandDecorator_TRequest,TResponse_.TRequest 'FlowLibrary.Abstractions.CommandDecorator<TRequest,TResponse>.TRequest')

The request object.

Implements [ExecuteAsync(TRequest)](ICommand_TRequest,TResponse_.ExecuteAsync.HN46vkQRZPM9T7CK7SPJuA.md 'FlowLibrary.Contracts.ICommand<TRequest,TResponse>.ExecuteAsync(TRequest)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TResponse](CommandDecorator_TRequest,TResponse_.md#FlowLibrary.Abstractions.CommandDecorator_TRequest,TResponse_.TResponse 'FlowLibrary.Abstractions.CommandDecorator<TRequest,TResponse>.TResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A task that represents the asynchronous operation. The task result contains the response object.