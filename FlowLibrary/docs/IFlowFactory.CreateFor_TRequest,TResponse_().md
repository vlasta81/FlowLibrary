#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Contracts](FlowLibrary.Contracts.md 'FlowLibrary.Contracts').[IFlowFactory](IFlowFactory.md 'FlowLibrary.Contracts.IFlowFactory')

## IFlowFactory.CreateFor<TRequest,TResponse>() Method

Creates a flow builder for the specified request and response types.

```csharp
FlowLibrary.Builders.FlowBuilder<TRequest,TResponse> CreateFor<TRequest,TResponse>();
```
#### Type parameters

<a name='FlowLibrary.Contracts.IFlowFactory.CreateFor_TRequest,TResponse_().TRequest'></a>

`TRequest`

The type of the request.

<a name='FlowLibrary.Contracts.IFlowFactory.CreateFor_TRequest,TResponse_().TResponse'></a>

`TResponse`

The type of the response.

#### Returns
[FlowLibrary.Builders.FlowBuilder&lt;](FlowBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.FlowBuilder<TRequest,TResponse>')[TRequest](IFlowFactory.CreateFor_TRequest,TResponse_().md#FlowLibrary.Contracts.IFlowFactory.CreateFor_TRequest,TResponse_().TRequest 'FlowLibrary.Contracts.IFlowFactory.CreateFor<TRequest,TResponse>().TRequest')[,](FlowBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.FlowBuilder<TRequest,TResponse>')[TResponse](IFlowFactory.CreateFor_TRequest,TResponse_().md#FlowLibrary.Contracts.IFlowFactory.CreateFor_TRequest,TResponse_().TResponse 'FlowLibrary.Contracts.IFlowFactory.CreateFor<TRequest,TResponse>().TResponse')[&gt;](FlowBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.FlowBuilder<TRequest,TResponse>')  
A flow builder for the specified request and response types.