#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Common](FlowLibrary.Common.md 'FlowLibrary.Common').[Repository&lt;TEntity&gt;](Repository_TEntity_.md 'FlowLibrary.Common.Repository<TEntity>')

## Repository<TEntity>.GetByIdAsync(int) Method

Gets an entity by its integer ID asynchronously.

```csharp
public System.Threading.Tasks.Task<TEntity?> GetByIdAsync(int id);
```
#### Parameters

<a name='FlowLibrary.Common.Repository_TEntity_.GetByIdAsync(int).id'></a>

`id` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The ID of the entity.

Implements [GetByIdAsync(int)](IRepository_TEntity_.GetByIdAsync.i7RzpUXd+zcvMbQ5vALBZg.md 'FlowLibrary.Contracts.IRepository<TEntity>.GetByIdAsync(int)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TEntity](Repository_TEntity_.md#FlowLibrary.Common.Repository_TEntity_.TEntity 'FlowLibrary.Common.Repository<TEntity>.TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A task that represents the asynchronous operation. The task result contains the entity if found; otherwise, null.