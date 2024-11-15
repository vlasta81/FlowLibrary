#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Common](FlowLibrary.Common.md 'FlowLibrary.Common')

## Repository<TEntity> Class

A generic repository class for performing CRUD operations on entities.

```csharp
public sealed class Repository<TEntity> :
FlowLibrary.Contracts.IRepository<TEntity>
    where TEntity : class
```
#### Type parameters

<a name='FlowLibrary.Common.Repository_TEntity_.TEntity'></a>

`TEntity`

The type of the entity.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Repository<TEntity>

Implements [FlowLibrary.Contracts.IRepository&lt;](IRepository_TEntity_.md 'FlowLibrary.Contracts.IRepository<TEntity>')[TEntity](Repository_TEntity_.md#FlowLibrary.Common.Repository_TEntity_.TEntity 'FlowLibrary.Common.Repository<TEntity>.TEntity')[&gt;](IRepository_TEntity_.md 'FlowLibrary.Contracts.IRepository<TEntity>')

| Constructors | |
| :--- | :--- |
| [Repository(DbContext)](Repository_TEntity_..ctor.kYqyeE26VOdZtqRtkgg2MA.md 'FlowLibrary.Common.Repository<TEntity>.Repository(Microsoft.EntityFrameworkCore.DbContext)') | Initializes a new instance of the [Repository&lt;TEntity&gt;](Repository_TEntity_.md 'FlowLibrary.Common.Repository<TEntity>') class. |

| Methods | |
| :--- | :--- |
| [AddAsync(TEntity)](Repository_TEntity_.AddAsync.FKS2pOOqNsDoEIdRRwNfig.md 'FlowLibrary.Common.Repository<TEntity>.AddAsync(TEntity)') | Adds an entity to the database asynchronously. |
| [AddRangeAsync(IEnumerable&lt;TEntity&gt;)](Repository_TEntity_.AddRangeAsync.0XmRdrvIOPreqOhGz+ixfA.md 'FlowLibrary.Common.Repository<TEntity>.AddRangeAsync(System.Collections.Generic.IEnumerable<TEntity>)') | Adds a range of entities to the database asynchronously. |
| [FindAsync(Expression&lt;Func&lt;TEntity,bool&gt;&gt;)](Repository_TEntity_.FindAsync.+XN4LcfS+3ywjHeC1m8wUQ.md 'FlowLibrary.Common.Repository<TEntity>.FindAsync(System.Linq.Expressions.Expression<System.Func<TEntity,bool>>)') | Finds entities in the database that match the specified predicate asynchronously. |
| [GetAllAsync()](Repository_TEntity_.GetAllAsync().md 'FlowLibrary.Common.Repository<TEntity>.GetAllAsync()') | Gets all entities from the database asynchronously. |
| [GetByIdAsync(int)](Repository_TEntity_.GetByIdAsync.7bqEAD2p3Xe+Xwc24e8B/A.md 'FlowLibrary.Common.Repository<TEntity>.GetByIdAsync(int)') | Gets an entity by its integer ID asynchronously. |
| [GetByIdAsync(Guid)](Repository_TEntity_.GetByIdAsync.NAjUiq0V5gdeVVaEHu3QgA.md 'FlowLibrary.Common.Repository<TEntity>.GetByIdAsync(System.Guid)') | Gets an entity by its GUID ID asynchronously. |
| [RemoveAsync(TEntity)](Repository_TEntity_.RemoveAsync.m3+Jaw1e8rBvsWaJjuGXYg.md 'FlowLibrary.Common.Repository<TEntity>.RemoveAsync(TEntity)') | Removes an entity from the database asynchronously. |
| [RemoveRangeAsync(IEnumerable&lt;TEntity&gt;)](Repository_TEntity_.RemoveRangeAsync.3ZrvOapX6k4BUztA/WE8Ag.md 'FlowLibrary.Common.Repository<TEntity>.RemoveRangeAsync(System.Collections.Generic.IEnumerable<TEntity>)') | Removes a range of entities from the database asynchronously. |
| [UpdateAsync(TEntity)](Repository_TEntity_.UpdateAsync.ro7bHmy8ZP6K0TUlVom5bg.md 'FlowLibrary.Common.Repository<TEntity>.UpdateAsync(TEntity)') | Updates an entity in the database asynchronously. |
