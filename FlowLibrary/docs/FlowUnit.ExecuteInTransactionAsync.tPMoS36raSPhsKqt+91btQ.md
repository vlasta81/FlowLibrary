#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary](FlowLibrary.md 'FlowLibrary').[FlowUnit](FlowUnit.md 'FlowLibrary.FlowUnit')

## FlowUnit.ExecuteInTransactionAsync<TResult>(Func<Task<TResult>>) Method

Executes the specified action within a transaction and returns the result.

```csharp
public System.Threading.Tasks.Task<TResult> ExecuteInTransactionAsync<TResult>(System.Func<System.Threading.Tasks.Task<TResult>> action);
```
#### Type parameters

<a name='FlowLibrary.FlowUnit.ExecuteInTransactionAsync_TResult_(System.Func_System.Threading.Tasks.Task_TResult__).TResult'></a>

`TResult`

The type of the result.
#### Parameters

<a name='FlowLibrary.FlowUnit.ExecuteInTransactionAsync_TResult_(System.Func_System.Threading.Tasks.Task_TResult__).action'></a>

`action` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TResult](FlowUnit.ExecuteInTransactionAsync.tPMoS36raSPhsKqt+91btQ.md#FlowLibrary.FlowUnit.ExecuteInTransactionAsync_TResult_(System.Func_System.Threading.Tasks.Task_TResult__).TResult 'FlowLibrary.FlowUnit.ExecuteInTransactionAsync<TResult>(System.Func<System.Threading.Tasks.Task<TResult>>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

The action to be executed.

Implements [ExecuteInTransactionAsync&lt;TResult&gt;(Func&lt;Task&lt;TResult&gt;&gt;)](IFlowUnit.ExecuteInTransactionAsync.rrGJfME/AYOyo10X9g1ofw.md 'FlowLibrary.Contracts.IFlowUnit.ExecuteInTransactionAsync<TResult>(System.Func<System.Threading.Tasks.Task<TResult>>)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TResult](FlowUnit.ExecuteInTransactionAsync.tPMoS36raSPhsKqt+91btQ.md#FlowLibrary.FlowUnit.ExecuteInTransactionAsync_TResult_(System.Func_System.Threading.Tasks.Task_TResult__).TResult 'FlowLibrary.FlowUnit.ExecuteInTransactionAsync<TResult>(System.Func<System.Threading.Tasks.Task<TResult>>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The result of the action.