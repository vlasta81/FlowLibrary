#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Common](FlowLibrary.Common.md 'FlowLibrary.Common').[Repository&lt;TEntity&gt;](Repository_TEntity_.md 'FlowLibrary.Common.Repository<TEntity>')

## Repository<TEntity>.AddRangeAsync(IEnumerable<TEntity>) Method

Adds a range of entities to the database asynchronously.

```csharp
public System.Threading.Tasks.Task AddRangeAsync(System.Collections.Generic.IEnumerable<TEntity> entities);
```
#### Parameters

<a name='FlowLibrary.Common.Repository_TEntity_.AddRangeAsync(System.Collections.Generic.IEnumerable_TEntity_).entities'></a>

`entities` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TEntity](Repository_TEntity_.md#FlowLibrary.Common.Repository_TEntity_.TEntity 'FlowLibrary.Common.Repository<TEntity>.TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The entities to add.

Implements [AddRangeAsync(IEnumerable&lt;TEntity&gt;)](IRepository_TEntity_.AddRangeAsync.SmDOLZ9xlwH8+NrC4jlFZw.md 'FlowLibrary.Contracts.IRepository<TEntity>.AddRangeAsync(System.Collections.Generic.IEnumerable<TEntity>)')

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task that represents the asynchronous operation.