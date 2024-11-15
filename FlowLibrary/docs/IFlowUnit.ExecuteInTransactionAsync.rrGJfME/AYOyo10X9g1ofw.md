#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Contracts](FlowLibrary.Contracts.md 'FlowLibrary.Contracts').[IFlowUnit](IFlowUnit.md 'FlowLibrary.Contracts.IFlowUnit')

## IFlowUnit.ExecuteInTransactionAsync<TResult>(Func<Task<TResult>>) Method

Executes the specified action within a transaction asynchronously and returns a result.

```csharp
System.Threading.Tasks.Task<TResult> ExecuteInTransactionAsync<TResult>(System.Func<System.Threading.Tasks.Task<TResult>> action);
```
#### Type parameters

<a name='FlowLibrary.Contracts.IFlowUnit.ExecuteInTransactionAsync_TResult_(System.Func_System.Threading.Tasks.Task_TResult__).TResult'></a>

`TResult`

The type of the result.
#### Parameters

<a name='FlowLibrary.Contracts.IFlowUnit.ExecuteInTransactionAsync_TResult_(System.Func_System.Threading.Tasks.Task_TResult__).action'></a>

`action` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TResult](IFlowUnit.ExecuteInTransactionAsync.rrGJfME/AYOyo10X9g1ofw.md#FlowLibrary.Contracts.IFlowUnit.ExecuteInTransactionAsync_TResult_(System.Func_System.Threading.Tasks.Task_TResult__).TResult 'FlowLibrary.Contracts.IFlowUnit.ExecuteInTransactionAsync<TResult>(System.Func<System.Threading.Tasks.Task<TResult>>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

The action to execute.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TResult](IFlowUnit.ExecuteInTransactionAsync.rrGJfME/AYOyo10X9g1ofw.md#FlowLibrary.Contracts.IFlowUnit.ExecuteInTransactionAsync_TResult_(System.Func_System.Threading.Tasks.Task_TResult__).TResult 'FlowLibrary.Contracts.IFlowUnit.ExecuteInTransactionAsync<TResult>(System.Func<System.Threading.Tasks.Task<TResult>>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A task that represents the asynchronous operation. The task result contains the result of the action.