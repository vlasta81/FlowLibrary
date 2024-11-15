#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Builders](FlowLibrary.Builders.md 'FlowLibrary.Builders')

## FlowBuilder<TRequest,TResponse> Class

A builder class for constructing a flow with a command, chain of responsibilities, middlewares, and a response strategy.

```csharp
public sealed class FlowBuilder<TRequest,TResponse>
```
#### Type parameters

<a name='FlowLibrary.Builders.FlowBuilder_TRequest,TResponse_.TRequest'></a>

`TRequest`

The type of the request.

<a name='FlowLibrary.Builders.FlowBuilder_TRequest,TResponse_.TResponse'></a>

`TResponse`

The type of the response.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; FlowBuilder<TRequest,TResponse>

| Constructors | |
| :--- | :--- |
| [FlowBuilder(IServiceProvider)](FlowBuilder_TRequest,TResponse_..ctor.3lCCq29LM1hkR6Wo4dGmcQ.md 'FlowLibrary.Builders.FlowBuilder<TRequest,TResponse>.FlowBuilder(System.IServiceProvider)') | Initializes a new instance of the [FlowBuilder&lt;TRequest,TResponse&gt;](FlowBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.FlowBuilder<TRequest,TResponse>') class. |

| Methods | |
| :--- | :--- |
| [AddCommand()](FlowBuilder_TRequest,TResponse_.AddCommand().md 'FlowLibrary.Builders.FlowBuilder<TRequest,TResponse>.AddCommand()') | Adds a command to the flow. |
| [AddChainOfResponsibilities()](FlowBuilder_TRequest,TResponse_.AddChainOfResponsibilities().md 'FlowLibrary.Builders.FlowBuilder<TRequest,TResponse>.AddChainOfResponsibilities()') | Adds a chain of responsibilities to the flow. |
| [AddMiddlewares()](FlowBuilder_TRequest,TResponse_.AddMiddlewares().md 'FlowLibrary.Builders.FlowBuilder<TRequest,TResponse>.AddMiddlewares()') | Adds middlewares to the flow. |
| [Build()](FlowBuilder_TRequest,TResponse_.Build().md 'FlowLibrary.Builders.FlowBuilder<TRequest,TResponse>.Build()') | Builds the flow processor with the configured components. |
| [SetResponseStrategy&lt;TStrategy&gt;()](FlowBuilder_TRequest,TResponse_.SetResponseStrategy_TStrategy_().md 'FlowLibrary.Builders.FlowBuilder<TRequest,TResponse>.SetResponseStrategy<TStrategy>()') | Sets the response strategy for the flow. |
