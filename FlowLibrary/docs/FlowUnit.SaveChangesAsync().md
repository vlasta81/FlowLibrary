#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary](FlowLibrary.md 'FlowLibrary').[FlowUnit](FlowUnit.md 'FlowLibrary.FlowUnit')

## FlowUnit.SaveChangesAsync() Method

Saves all changes made in this unit of work to the underlying database.

```csharp
public System.Threading.Tasks.Task<int> SaveChangesAsync();
```

Implements [SaveChangesAsync()](IFlowUnit.SaveChangesAsync().md 'FlowLibrary.Contracts.IFlowUnit.SaveChangesAsync()')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The number of state entries written to the database.