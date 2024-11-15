#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Contracts](FlowLibrary.Contracts.md 'FlowLibrary.Contracts')

## IRepository<TEntity> Interface

Generic repository interface for performing CRUD operations on entities.

```csharp
public interface IRepository<TEntity>
    where TEntity : class
```
#### Type parameters

<a name='FlowLibrary.Contracts.IRepository_TEntity_.TEntity'></a>

`TEntity`

The type of the entity.

Derived  
&#8627; [Repository&lt;TEntity&gt;](Repository_TEntity_.md 'FlowLibrary.Common.Repository<TEntity>')

| Methods | |
| :--- | :--- |
| [AddAsync(TEntity)](IRepository_TEntity_.AddAsync.opAlPfPsOmhzYnbNaxucEg.md 'FlowLibrary.Contracts.IRepository<TEntity>.AddAsync(TEntity)') | Adds a new entity. |
| [AddRangeAsync(IEnumerable&lt;TEntity&gt;)](IRepository_TEntity_.AddRangeAsync.SmDOLZ9xlwH8+NrC4jlFZw.md 'FlowLibrary.Contracts.IRepository<TEntity>.AddRangeAsync(System.Collections.Generic.IEnumerable<TEntity>)') | Adds a range of new entities. |
| [FindAsync(Expression&lt;Func&lt;TEntity,bool&gt;&gt;)](IRepository_TEntity_.FindAsync.I1FMe/ClwC/mQG8a6dY+Sg.md 'FlowLibrary.Contracts.IRepository<TEntity>.FindAsync(System.Linq.Expressions.Expression<System.Func<TEntity,bool>>)') | Finds entities based on a predicate. |
| [GetAllAsync()](IRepository_TEntity_.GetAllAsync().md 'FlowLibrary.Contracts.IRepository<TEntity>.GetAllAsync()') | Gets all entities. |
| [GetByIdAsync(int)](IRepository_TEntity_.GetByIdAsync.i7RzpUXd+zcvMbQ5vALBZg.md 'FlowLibrary.Contracts.IRepository<TEntity>.GetByIdAsync(int)') | Gets an entity by its integer identifier. |
| [GetByIdAsync(Guid)](IRepository_TEntity_.GetByIdAsync.LLf42KhAbr/nnvbv8ZebWA.md 'FlowLibrary.Contracts.IRepository<TEntity>.GetByIdAsync(System.Guid)') | Gets an entity by its GUID identifier. |
| [RemoveAsync(TEntity)](IRepository_TEntity_.RemoveAsync.Pc2ku4yyM2mXs4QJFsvOUA.md 'FlowLibrary.Contracts.IRepository<TEntity>.RemoveAsync(TEntity)') | Removes an entity. |
| [RemoveRangeAsync(IEnumerable&lt;TEntity&gt;)](IRepository_TEntity_.RemoveRangeAsync.W4pqYhSIgR8dw/OJ9K9oVQ.md 'FlowLibrary.Contracts.IRepository<TEntity>.RemoveRangeAsync(System.Collections.Generic.IEnumerable<TEntity>)') | Removes a range of entities. |
| [UpdateAsync(TEntity)](IRepository_TEntity_.UpdateAsync.tBzX98JuAkUcirVaJDOA6w.md 'FlowLibrary.Contracts.IRepository<TEntity>.UpdateAsync(TEntity)') | Updates an entity. |
