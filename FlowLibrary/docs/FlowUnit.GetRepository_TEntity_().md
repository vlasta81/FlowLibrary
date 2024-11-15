#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary](FlowLibrary.md 'FlowLibrary').[FlowUnit](FlowUnit.md 'FlowLibrary.FlowUnit')

## FlowUnit.GetRepository<TEntity>() Method

Gets the repository for the specified entity type.

```csharp
public FlowLibrary.Contracts.IRepository<TEntity> GetRepository<TEntity>()
    where TEntity : class;
```
#### Type parameters

<a name='FlowLibrary.FlowUnit.GetRepository_TEntity_().TEntity'></a>

`TEntity`

The type of the entity.

Implements [GetRepository&lt;TEntity&gt;()](IFlowUnit.GetRepository_TEntity_().md 'FlowLibrary.Contracts.IFlowUnit.GetRepository<TEntity>()')

#### Returns
[FlowLibrary.Contracts.IRepository&lt;](IRepository_TEntity_.md 'FlowLibrary.Contracts.IRepository<TEntity>')[TEntity](FlowUnit.GetRepository_TEntity_().md#FlowLibrary.FlowUnit.GetRepository_TEntity_().TEntity 'FlowLibrary.FlowUnit.GetRepository<TEntity>().TEntity')[&gt;](IRepository_TEntity_.md 'FlowLibrary.Contracts.IRepository<TEntity>')  
The repository for the specified entity type.