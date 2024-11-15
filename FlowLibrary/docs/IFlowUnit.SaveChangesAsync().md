#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Contracts](FlowLibrary.Contracts.md 'FlowLibrary.Contracts').[IFlowUnit](IFlowUnit.md 'FlowLibrary.Contracts.IFlowUnit')

## IFlowUnit.SaveChangesAsync() Method

Saves all changes made in this unit of work asynchronously.

```csharp
System.Threading.Tasks.Task<int> SaveChangesAsync();
```

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A task that represents the asynchronous save operation. The task result contains the number of state entries written to the database.