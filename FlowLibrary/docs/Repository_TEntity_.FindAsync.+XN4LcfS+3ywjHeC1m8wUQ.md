#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Common](FlowLibrary.Common.md 'FlowLibrary.Common').[Repository&lt;TEntity&gt;](Repository_TEntity_.md 'FlowLibrary.Common.Repository<TEntity>')

## Repository<TEntity>.FindAsync(Expression<Func<TEntity,bool>>) Method

Finds entities in the database that match the specified predicate asynchronously.

```csharp
public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<TEntity>> FindAsync(System.Linq.Expressions.Expression<System.Func<TEntity,bool>> predicate);
```
#### Parameters

<a name='FlowLibrary.Common.Repository_TEntity_.FindAsync(System.Linq.Expressions.Expression_System.Func_TEntity,bool__).predicate'></a>

`predicate` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](Repository_TEntity_.md#FlowLibrary.Common.Repository_TEntity_.TEntity 'FlowLibrary.Common.Repository<TEntity>.TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The predicate to filter the entities.

Implements [FindAsync(Expression&lt;Func&lt;TEntity,bool&gt;&gt;)](IRepository_TEntity_.FindAsync.I1FMe/ClwC/mQG8a6dY+Sg.md 'FlowLibrary.Contracts.IRepository<TEntity>.FindAsync(System.Linq.Expressions.Expression<System.Func<TEntity,bool>>)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TEntity](Repository_TEntity_.md#FlowLibrary.Common.Repository_TEntity_.TEntity 'FlowLibrary.Common.Repository<TEntity>.TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A task that represents the asynchronous operation. The task result contains the list of entities that match the predicate.