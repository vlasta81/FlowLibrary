#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary](FlowLibrary.md 'FlowLibrary')

## FlowFactory Class

Factory class for creating instances of [FlowBuilder&lt;TRequest,TResponse&gt;](FlowBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.FlowBuilder<TRequest,TResponse>').

```csharp
public sealed class FlowFactory :
FlowLibrary.Contracts.IFlowFactory
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FlowFactory

Implements [IFlowFactory](IFlowFactory.md 'FlowLibrary.Contracts.IFlowFactory')

| Constructors | |
| :--- | :--- |
| [FlowFactory(IServiceProvider)](FlowFactory..ctor.Rk8wJjYLJC5S+jf/pNgXRg.md 'FlowLibrary.FlowFactory.FlowFactory(System.IServiceProvider)') | Initializes a new instance of the [FlowFactory](FlowFactory.md 'FlowLibrary.FlowFactory') class. |

| Methods | |
| :--- | :--- |
| [CreateFor&lt;TRequest,TResponse&gt;()](FlowFactory.CreateFor_TRequest,TResponse_().md 'FlowLibrary.FlowFactory.CreateFor<TRequest,TResponse>()') | Creates a new instance of [FlowBuilder&lt;TRequest,TResponse&gt;](FlowBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.FlowBuilder<TRequest,TResponse>'). |
