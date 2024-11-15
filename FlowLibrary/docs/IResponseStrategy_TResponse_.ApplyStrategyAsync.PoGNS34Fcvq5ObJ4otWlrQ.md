#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Contracts](FlowLibrary.Contracts.md 'FlowLibrary.Contracts').[IResponseStrategy&lt;TResponse&gt;](IResponseStrategy_TResponse_.md 'FlowLibrary.Contracts.IResponseStrategy<TResponse>')

## IResponseStrategy<TResponse>.ApplyStrategyAsync(TResponse) Method

Applies the strategy to the given response asynchronously.

```csharp
System.Threading.Tasks.Task<TResponse> ApplyStrategyAsync(TResponse response);
```
#### Parameters

<a name='FlowLibrary.Contracts.IResponseStrategy_TResponse_.ApplyStrategyAsync(TResponse).response'></a>

`response` [TResponse](IResponseStrategy_TResponse_.md#FlowLibrary.Contracts.IResponseStrategy_TResponse_.TResponse 'FlowLibrary.Contracts.IResponseStrategy<TResponse>.TResponse')

The response to which the strategy will be applied.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TResponse](IResponseStrategy_TResponse_.md#FlowLibrary.Contracts.IResponseStrategy_TResponse_.TResponse 'FlowLibrary.Contracts.IResponseStrategy<TResponse>.TResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A task that represents the asynchronous operation. The task result contains the processed response.