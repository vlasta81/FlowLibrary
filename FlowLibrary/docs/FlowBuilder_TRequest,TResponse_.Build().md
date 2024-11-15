#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Builders](FlowLibrary.Builders.md 'FlowLibrary.Builders').[FlowBuilder&lt;TRequest,TResponse&gt;](FlowBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.FlowBuilder<TRequest,TResponse>')

## FlowBuilder<TRequest,TResponse>.Build() Method

Builds the flow processor with the configured components.

```csharp
public FlowLibrary.Builders.FlowProcessor<TRequest,TResponse> Build();
```

#### Returns
[FlowLibrary.Builders.FlowProcessor&lt;](FlowProcessor_TRequest,TResponse_.md 'FlowLibrary.Builders.FlowProcessor<TRequest,TResponse>')[TRequest](FlowBuilder_TRequest,TResponse_.md#FlowLibrary.Builders.FlowBuilder_TRequest,TResponse_.TRequest 'FlowLibrary.Builders.FlowBuilder<TRequest,TResponse>.TRequest')[,](FlowProcessor_TRequest,TResponse_.md 'FlowLibrary.Builders.FlowProcessor<TRequest,TResponse>')[TResponse](FlowBuilder_TRequest,TResponse_.md#FlowLibrary.Builders.FlowBuilder_TRequest,TResponse_.TResponse 'FlowLibrary.Builders.FlowBuilder<TRequest,TResponse>.TResponse')[&gt;](FlowProcessor_TRequest,TResponse_.md 'FlowLibrary.Builders.FlowProcessor<TRequest,TResponse>')  
A [FlowProcessor&lt;TRequest,TResponse&gt;](FlowProcessor_TRequest,TResponse_.md 'FlowLibrary.Builders.FlowProcessor<TRequest,TResponse>') instance.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
Thrown if the command is not set.