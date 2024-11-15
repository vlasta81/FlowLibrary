#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Contracts](FlowLibrary.Contracts.md 'FlowLibrary.Contracts').[IRepository&lt;TEntity&gt;](IRepository_TEntity_.md 'FlowLibrary.Contracts.IRepository<TEntity>')

## IRepository<TEntity>.FindAsync(Expression<Func<TEntity,bool>>) Method

Finds entities based on a predicate.

```csharp
System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<TEntity>> FindAsync(System.Linq.Expressions.Expression<System.Func<TEntity,bool>> predicate);
```
#### Parameters

<a name='FlowLibrary.Contracts.IRepository_TEntity_.FindAsync(System.Linq.Expressions.Expression_System.Func_TEntity,bool__).predicate'></a>

`predicate` [System.Linq.Expressions.Expression&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TEntity](IRepository_TEntity_.md#FlowLibrary.Contracts.IRepository_TEntity_.TEntity 'FlowLibrary.Contracts.IRepository<TEntity>.TEntity')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression-1 'System.Linq.Expressions.Expression`1')

The expression to filter entities.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TEntity](IRepository_TEntity_.md#FlowLibrary.Contracts.IRepository_TEntity_.TEntity 'FlowLibrary.Contracts.IRepository<TEntity>.TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
A task that represents the asynchronous operation. The task result contains a collection of entities that match the predicate.