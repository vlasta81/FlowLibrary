#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Builders](FlowLibrary.Builders.md 'FlowLibrary.Builders')

## ResponsibilityBuilder<TRequest,TResponse> Class

A builder class for constructing a chain of responsibility pattern.

```csharp
public sealed class ResponsibilityBuilder<TRequest,TResponse>
```
#### Type parameters

<a name='FlowLibrary.Builders.ResponsibilityBuilder_TRequest,TResponse_.TRequest'></a>

`TRequest`

The type of the request.

<a name='FlowLibrary.Builders.ResponsibilityBuilder_TRequest,TResponse_.TResponse'></a>

`TResponse`

The type of the response.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ResponsibilityBuilder<TRequest,TResponse>

| Constructors | |
| :--- | :--- |
| [ResponsibilityBuilder(IServiceProvider, Action&lt;Responsibility&lt;TRequest,TResponse&gt;&gt;)](ResponsibilityBuilder_TRequest,TResponse_..ctor.xli+I9hhqFYrFNt3exdfZA.md 'FlowLibrary.Builders.ResponsibilityBuilder<TRequest,TResponse>.ResponsibilityBuilder(System.IServiceProvider, System.Action<FlowLibrary.Abstractions.Responsibility<TRequest,TResponse>>)') | Initializes a new instance of the [ResponsibilityBuilder&lt;TRequest,TResponse&gt;](ResponsibilityBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.ResponsibilityBuilder<TRequest,TResponse>') class. |

| Methods | |
| :--- | :--- |
| [Build()](ResponsibilityBuilder_TRequest,TResponse_.Build().md 'FlowLibrary.Builders.ResponsibilityBuilder<TRequest,TResponse>.Build()') | Builds the responsibility chain and adds it using the provided action. |
| [SetNext&lt;TResponsibility&gt;()](ResponsibilityBuilder_TRequest,TResponse_.SetNext_TResponsibility_().md 'FlowLibrary.Builders.ResponsibilityBuilder<TRequest,TResponse>.SetNext<TResponsibility>()') | Sets the next responsibility in the chain. |
