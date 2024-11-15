#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Abstractions](FlowLibrary.Abstractions.md 'FlowLibrary.Abstractions')

## Responsibility<TRequest,TResponse> Class

Represents an abstract base class for handling a request and producing a response.  
Implements the Chain of Responsibility pattern.

```csharp
public abstract class Responsibility<TRequest,TResponse>
```
#### Type parameters

<a name='FlowLibrary.Abstractions.Responsibility_TRequest,TResponse_.TRequest'></a>

`TRequest`

The type of the request.

<a name='FlowLibrary.Abstractions.Responsibility_TRequest,TResponse_.TResponse'></a>

`TResponse`

The type of the response.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Responsibility<TRequest,TResponse>

| Methods | |
| :--- | :--- |
| [HandleAsync(TRequest)](Responsibility_TRequest,TResponse_.HandleAsync.fIo8HHqby8AlyHUfXkyQdA.md 'FlowLibrary.Abstractions.Responsibility<TRequest,TResponse>.HandleAsync(TRequest)') | Handles the request asynchronously. If the current handler cannot handle the request,<br/>it delegates to the next handler in the chain. |
| [SetNext(Responsibility&lt;TRequest,TResponse&gt;)](Responsibility_TRequest,TResponse_.SetNext.McdS8rhPTXuAW3N8w1vBWw.md 'FlowLibrary.Abstractions.Responsibility<TRequest,TResponse>.SetNext(FlowLibrary.Abstractions.Responsibility<TRequest,TResponse>)') | Sets the next handler in the chain of responsibility. |
