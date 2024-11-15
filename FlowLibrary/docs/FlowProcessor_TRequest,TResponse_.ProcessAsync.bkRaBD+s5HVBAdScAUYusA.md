#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Builders](FlowLibrary.Builders.md 'FlowLibrary.Builders').[FlowProcessor&lt;TRequest,TResponse&gt;](FlowProcessor_TRequest,TResponse_.md 'FlowLibrary.Builders.FlowProcessor<TRequest,TResponse>')

## FlowProcessor<TRequest,TResponse>.ProcessAsync(TRequest) Method

Processes the request asynchronously through the chain of responsibility, middlewares, and command.

```csharp
public System.Threading.Tasks.Task<TResponse> ProcessAsync(TRequest request);
```
#### Parameters

<a name='FlowLibrary.Builders.FlowProcessor_TRequest,TResponse_.ProcessAsync(TRequest).request'></a>

`request` [TRequest](FlowProcessor_TRequest,TResponse_.md#FlowLibrary.Builders.FlowProcessor_TRequest,TResponse_.TRequest 'FlowLibrary.Builders.FlowProcessor<TRequest,TResponse>.TRequest')

The request to process.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TResponse](FlowProcessor_TRequest,TResponse_.md#FlowLibrary.Builders.FlowProcessor_TRequest,TResponse_.TResponse 'FlowLibrary.Builders.FlowProcessor<TRequest,TResponse>.TResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A task that represents the asynchronous operation. The task result contains the response.