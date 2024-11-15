#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Builders](FlowLibrary.Builders.md 'FlowLibrary.Builders').[FlowBuilder&lt;TRequest,TResponse&gt;](FlowBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.FlowBuilder<TRequest,TResponse>')

## FlowBuilder<TRequest,TResponse>.SetResponseStrategy<TStrategy>() Method

Sets the response strategy for the flow.

```csharp
public FlowLibrary.Builders.FlowBuilder<TRequest,TResponse> SetResponseStrategy<TStrategy>()
    where TStrategy : FlowLibrary.Contracts.IResponseStrategy<TResponse>;
```
#### Type parameters

<a name='FlowLibrary.Builders.FlowBuilder_TRequest,TResponse_.SetResponseStrategy_TStrategy_().TStrategy'></a>

`TStrategy`

The type of the response strategy.

#### Returns
[FlowLibrary.Builders.FlowBuilder&lt;](FlowBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.FlowBuilder<TRequest,TResponse>')[TRequest](FlowBuilder_TRequest,TResponse_.md#FlowLibrary.Builders.FlowBuilder_TRequest,TResponse_.TRequest 'FlowLibrary.Builders.FlowBuilder<TRequest,TResponse>.TRequest')[,](FlowBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.FlowBuilder<TRequest,TResponse>')[TResponse](FlowBuilder_TRequest,TResponse_.md#FlowLibrary.Builders.FlowBuilder_TRequest,TResponse_.TResponse 'FlowLibrary.Builders.FlowBuilder<TRequest,TResponse>.TResponse')[&gt;](FlowBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.FlowBuilder<TRequest,TResponse>')  
The current [FlowBuilder&lt;TRequest,TResponse&gt;](FlowBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.FlowBuilder<TRequest,TResponse>') instance.