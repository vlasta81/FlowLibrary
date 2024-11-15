#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary](FlowLibrary.md 'FlowLibrary')

## FlowUnit Class

Represents a unit of work that encapsulates a DbContext and provides methods for managing transactions and repositories.

```csharp
public class FlowUnit :
FlowLibrary.Contracts.IFlowUnit,
System.IDisposable
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FlowUnit

Implements [IFlowUnit](IFlowUnit.md 'FlowLibrary.Contracts.IFlowUnit'), [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')

| Constructors | |
| :--- | :--- |
| [FlowUnit(DbContext)](FlowUnit..ctor.6BX4E/mHiv+8VV3v7c2boQ.md 'FlowLibrary.FlowUnit.FlowUnit(Microsoft.EntityFrameworkCore.DbContext)') | Initializes a new instance of the [FlowUnit](FlowUnit.md 'FlowLibrary.FlowUnit') class. |

| Methods | |
| :--- | :--- |
| [BeginTransactionAsync()](FlowUnit.BeginTransactionAsync().md 'FlowLibrary.FlowUnit.BeginTransactionAsync()') | Begins a new transaction. |
| [CommitTransactionAsync()](FlowUnit.CommitTransactionAsync().md 'FlowLibrary.FlowUnit.CommitTransactionAsync()') | Commits the current transaction. |
| [Dispose()](FlowUnit.Dispose().md 'FlowLibrary.FlowUnit.Dispose()') | Releases all resources used by the [FlowUnit](FlowUnit.md 'FlowLibrary.FlowUnit'). |
| [Dispose(bool)](FlowUnit.Dispose./7gYkrPrDq/v0nx9qc8bnA.md 'FlowLibrary.FlowUnit.Dispose(bool)') | Releases the unmanaged resources used by the [FlowUnit](FlowUnit.md 'FlowLibrary.FlowUnit') and optionally releases the managed resources. |
| [ExecuteInTransactionAsync(Func&lt;Task&gt;)](FlowUnit.ExecuteInTransactionAsync.djWsyUzGOo85spKfT6DpiQ.md 'FlowLibrary.FlowUnit.ExecuteInTransactionAsync(System.Func<System.Threading.Tasks.Task>)') | Executes the specified action within a transaction. |
| [ExecuteInTransactionAsync&lt;TResult&gt;(Func&lt;Task&lt;TResult&gt;&gt;)](FlowUnit.ExecuteInTransactionAsync.tPMoS36raSPhsKqt+91btQ.md 'FlowLibrary.FlowUnit.ExecuteInTransactionAsync<TResult>(System.Func<System.Threading.Tasks.Task<TResult>>)') | Executes the specified action within a transaction and returns the result. |
| [GetRepository&lt;TEntity&gt;()](FlowUnit.GetRepository_TEntity_().md 'FlowLibrary.FlowUnit.GetRepository<TEntity>()') | Gets the repository for the specified entity type. |
| [RollbackTransactionAsync()](FlowUnit.RollbackTransactionAsync().md 'FlowLibrary.FlowUnit.RollbackTransactionAsync()') | Rolls back the current transaction. |
| [SaveChangesAsync()](FlowUnit.SaveChangesAsync().md 'FlowLibrary.FlowUnit.SaveChangesAsync()') | Saves all changes made in this unit of work to the underlying database. |
