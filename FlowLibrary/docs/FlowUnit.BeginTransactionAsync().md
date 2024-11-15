#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary](FlowLibrary.md 'FlowLibrary').[FlowUnit](FlowUnit.md 'FlowLibrary.FlowUnit')

## FlowUnit.BeginTransactionAsync() Method

Begins a new transaction.

```csharp
public System.Threading.Tasks.Task BeginTransactionAsync();
```

Implements [BeginTransactionAsync()](IFlowUnit.BeginTransactionAsync().md 'FlowLibrary.Contracts.IFlowUnit.BeginTransactionAsync()')

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task that represents the asynchronous operation.

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
Thrown if a transaction is already running.