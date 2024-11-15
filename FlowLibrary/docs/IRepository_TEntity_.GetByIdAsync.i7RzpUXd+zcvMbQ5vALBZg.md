#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Contracts](FlowLibrary.Contracts.md 'FlowLibrary.Contracts').[IRepository&lt;TEntity&gt;](IRepository_TEntity_.md 'FlowLibrary.Contracts.IRepository<TEntity>')

## IRepository<TEntity>.GetByIdAsync(int) Method

Gets an entity by its integer identifier.

```csharp
System.Threading.Tasks.Task<TEntity?> GetByIdAsync(int id);
```
#### Parameters

<a name='FlowLibrary.Contracts.IRepository_TEntity_.GetByIdAsync(int).id'></a>

`id` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The integer identifier of the entity.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TEntity](IRepository_TEntity_.md#FlowLibrary.Contracts.IRepository_TEntity_.TEntity 'FlowLibrary.Contracts.IRepository<TEntity>.TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A task that represents the asynchronous operation. The task result contains the entity if found; otherwise, null.