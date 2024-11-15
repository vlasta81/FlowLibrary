#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Common](FlowLibrary.Common.md 'FlowLibrary.Common')

## Response Class

Represents a response with status code, success flag, title, and errors.

```csharp
public class Response
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Response

| Constructors | |
| :--- | :--- |
| [Response()](Response.Response().md 'FlowLibrary.Common.Response.Response()') | Initializes a new instance of the [Response](Response.md 'FlowLibrary.Common.Response') class. |
| [Response(string, int, bool, IEnumerable&lt;string&gt;)](Response..ctor.frii3cz1/2sG4i7BOI1Hqg.md 'FlowLibrary.Common.Response.Response(string, int, bool, System.Collections.Generic.IEnumerable<string>)') | Initializes a new instance of the [Response](Response.md 'FlowLibrary.Common.Response') class with specified title, status code, success flag, and errors. |

| Properties | |
| :--- | :--- |
| [Errors](Response.Errors.md 'FlowLibrary.Common.Response.Errors') | Gets or sets the collection of errors associated with the response. |
| [IsSuccessfully](Response.IsSuccessfully.md 'FlowLibrary.Common.Response.IsSuccessfully') | Gets or sets a value indicating whether the response is successful. Default is false. |
| [StatusCode](Response.StatusCode.md 'FlowLibrary.Common.Response.StatusCode') | Gets or sets the status code of the response. Default is 400. |
| [Title](Response.Title.md 'FlowLibrary.Common.Response.Title') | Gets or sets the title of the response. |
