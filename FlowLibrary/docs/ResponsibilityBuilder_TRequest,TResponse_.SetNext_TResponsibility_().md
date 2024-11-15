#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Builders](FlowLibrary.Builders.md 'FlowLibrary.Builders').[ResponsibilityBuilder&lt;TRequest,TResponse&gt;](ResponsibilityBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.ResponsibilityBuilder<TRequest,TResponse>')

## ResponsibilityBuilder<TRequest,TResponse>.SetNext<TResponsibility>() Method

Sets the next responsibility in the chain.

```csharp
public FlowLibrary.Builders.ResponsibilityBuilder<TRequest,TResponse> SetNext<TResponsibility>()
    where TResponsibility : FlowLibrary.Abstractions.Responsibility<TRequest, TResponse>;
```
#### Type parameters

<a name='FlowLibrary.Builders.ResponsibilityBuilder_TRequest,TResponse_.SetNext_TResponsibility_().TResponsibility'></a>

`TResponsibility`

The type of the responsibility to add.

#### Returns
[FlowLibrary.Builders.ResponsibilityBuilder&lt;](ResponsibilityBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.ResponsibilityBuilder<TRequest,TResponse>')[TRequest](ResponsibilityBuilder_TRequest,TResponse_.md#FlowLibrary.Builders.ResponsibilityBuilder_TRequest,TResponse_.TRequest 'FlowLibrary.Builders.ResponsibilityBuilder<TRequest,TResponse>.TRequest')[,](ResponsibilityBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.ResponsibilityBuilder<TRequest,TResponse>')[TResponse](ResponsibilityBuilder_TRequest,TResponse_.md#FlowLibrary.Builders.ResponsibilityBuilder_TRequest,TResponse_.TResponse 'FlowLibrary.Builders.ResponsibilityBuilder<TRequest,TResponse>.TResponse')[&gt;](ResponsibilityBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.ResponsibilityBuilder<TRequest,TResponse>')  
The current instance of [ResponsibilityBuilder&lt;TRequest,TResponse&gt;](ResponsibilityBuilder_TRequest,TResponse_.md 'FlowLibrary.Builders.ResponsibilityBuilder<TRequest,TResponse>').