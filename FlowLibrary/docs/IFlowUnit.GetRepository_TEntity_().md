#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Contracts](FlowLibrary.Contracts.md 'FlowLibrary.Contracts').[IFlowUnit](IFlowUnit.md 'FlowLibrary.Contracts.IFlowUnit')

## IFlowUnit.GetRepository<TEntity>() Method

Gets the repository for the specified entity type.

```csharp
FlowLibrary.Contracts.IRepository<TEntity> GetRepository<TEntity>()
    where TEntity : class;
```
#### Type parameters

<a name='FlowLibrary.Contracts.IFlowUnit.GetRepository_TEntity_().TEntity'></a>

`TEntity`

The type of the entity.

#### Returns
[FlowLibrary.Contracts.IRepository&lt;](IRepository_TEntity_.md 'FlowLibrary.Contracts.IRepository<TEntity>')[TEntity](IFlowUnit.GetRepository_TEntity_().md#FlowLibrary.Contracts.IFlowUnit.GetRepository_TEntity_().TEntity 'FlowLibrary.Contracts.IFlowUnit.GetRepository<TEntity>().TEntity')[&gt;](IRepository_TEntity_.md 'FlowLibrary.Contracts.IRepository<TEntity>')  
The repository for the specified entity type.