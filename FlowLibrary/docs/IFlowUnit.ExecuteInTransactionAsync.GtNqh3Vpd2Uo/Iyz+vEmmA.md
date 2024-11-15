#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Contracts](FlowLibrary.Contracts.md 'FlowLibrary.Contracts').[IFlowUnit](IFlowUnit.md 'FlowLibrary.Contracts.IFlowUnit')

## IFlowUnit.ExecuteInTransactionAsync(Func<Task>) Method

Executes the specified action within a transaction asynchronously.

```csharp
System.Threading.Tasks.Task ExecuteInTransactionAsync(System.Func<System.Threading.Tasks.Task> action);
```
#### Parameters

<a name='FlowLibrary.Contracts.IFlowUnit.ExecuteInTransactionAsync(System.Func_System.Threading.Tasks.Task_).action'></a>

`action` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

The action to execute.

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task that represents the asynchronous operation.