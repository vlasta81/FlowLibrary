#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Common](FlowLibrary.Common.md 'FlowLibrary.Common').[Repository&lt;TEntity&gt;](Repository_TEntity_.md 'FlowLibrary.Common.Repository<TEntity>')

## Repository<TEntity>.GetByIdAsync(Guid) Method

Gets an entity by its GUID ID asynchronously.

```csharp
public System.Threading.Tasks.Task<TEntity?> GetByIdAsync(System.Guid id);
```
#### Parameters

<a name='FlowLibrary.Common.Repository_TEntity_.GetByIdAsync(System.Guid).id'></a>

`id` [System.Guid](https://docs.microsoft.com/en-us/dotnet/api/System.Guid 'System.Guid')

The GUID ID of the entity.

Implements [GetByIdAsync(Guid)](IRepository_TEntity_.GetByIdAsync.LLf42KhAbr/nnvbv8ZebWA.md 'FlowLibrary.Contracts.IRepository<TEntity>.GetByIdAsync(System.Guid)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TEntity](Repository_TEntity_.md#FlowLibrary.Common.Repository_TEntity_.TEntity 'FlowLibrary.Common.Repository<TEntity>.TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A task that represents the asynchronous operation. The task result contains the entity if found; otherwise, null.