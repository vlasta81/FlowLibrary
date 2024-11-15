#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Contracts](FlowLibrary.Contracts.md 'FlowLibrary.Contracts')

## IFlowUnit Interface

Represents a unit of work that encapsulates a set of operations to be performed on a repository.

```csharp
public interface IFlowUnit :
System.IDisposable
```

Derived  
&#8627; [FlowUnit](FlowUnit.md 'FlowLibrary.FlowUnit')

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')

| Methods | |
| :--- | :--- |
| [BeginTransactionAsync()](IFlowUnit.BeginTransactionAsync().md 'FlowLibrary.Contracts.IFlowUnit.BeginTransactionAsync()') | Begins a transaction asynchronously. |
| [CommitTransactionAsync()](IFlowUnit.CommitTransactionAsync().md 'FlowLibrary.Contracts.IFlowUnit.CommitTransactionAsync()') | Commits the current transaction asynchronously. |
| [ExecuteInTransactionAsync(Func&lt;Task&gt;)](IFlowUnit.ExecuteInTransactionAsync.GtNqh3Vpd2Uo/Iyz+vEmmA.md 'FlowLibrary.Contracts.IFlowUnit.ExecuteInTransactionAsync(System.Func<System.Threading.Tasks.Task>)') | Executes the specified action within a transaction asynchronously. |
| [ExecuteInTransactionAsync&lt;TResult&gt;(Func&lt;Task&lt;TResult&gt;&gt;)](IFlowUnit.ExecuteInTransactionAsync.rrGJfME/AYOyo10X9g1ofw.md 'FlowLibrary.Contracts.IFlowUnit.ExecuteInTransactionAsync<TResult>(System.Func<System.Threading.Tasks.Task<TResult>>)') | Executes the specified action within a transaction asynchronously and returns a result. |
| [GetRepository&lt;TEntity&gt;()](IFlowUnit.GetRepository_TEntity_().md 'FlowLibrary.Contracts.IFlowUnit.GetRepository<TEntity>()') | Gets the repository for the specified entity type. |
| [RollbackTransactionAsync()](IFlowUnit.RollbackTransactionAsync().md 'FlowLibrary.Contracts.IFlowUnit.RollbackTransactionAsync()') | Rolls back the current transaction asynchronously. |
| [SaveChangesAsync()](IFlowUnit.SaveChangesAsync().md 'FlowLibrary.Contracts.IFlowUnit.SaveChangesAsync()') | Saves all changes made in this unit of work asynchronously. |
