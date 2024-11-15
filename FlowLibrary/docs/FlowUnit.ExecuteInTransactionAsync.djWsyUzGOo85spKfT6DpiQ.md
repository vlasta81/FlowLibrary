#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary](FlowLibrary.md 'FlowLibrary').[FlowUnit](FlowUnit.md 'FlowLibrary.FlowUnit')

## FlowUnit.ExecuteInTransactionAsync(Func<Task>) Method

Executes the specified action within a transaction.

```csharp
public System.Threading.Tasks.Task ExecuteInTransactionAsync(System.Func<System.Threading.Tasks.Task> action);
```
#### Parameters

<a name='FlowLibrary.FlowUnit.ExecuteInTransactionAsync(System.Func_System.Threading.Tasks.Task_).action'></a>

`action` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

The action to be executed.

Implements [ExecuteInTransactionAsync(Func&lt;Task&gt;)](IFlowUnit.ExecuteInTransactionAsync.GtNqh3Vpd2Uo/Iyz+vEmmA.md 'FlowLibrary.Contracts.IFlowUnit.ExecuteInTransactionAsync(System.Func<System.Threading.Tasks.Task>)')

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task that represents the asynchronous operation.