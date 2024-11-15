#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Common](FlowLibrary.Common.md 'FlowLibrary.Common').[Response](Response.md 'FlowLibrary.Common.Response')

## Response(string, int, bool, IEnumerable<string>) Constructor

Initializes a new instance of the [Response](Response.md 'FlowLibrary.Common.Response') class with specified title, status code, success flag, and errors.

```csharp
public Response(string title, int statusCode=400, bool isSuccessfully=false, System.Collections.Generic.IEnumerable<string> errors=null);
```
#### Parameters

<a name='FlowLibrary.Common.Response.Response(string,int,bool,System.Collections.Generic.IEnumerable_string_).title'></a>

`title` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The title of the response.

<a name='FlowLibrary.Common.Response.Response(string,int,bool,System.Collections.Generic.IEnumerable_string_).statusCode'></a>

`statusCode` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The status code of the response. Default is 400.

<a name='FlowLibrary.Common.Response.Response(string,int,bool,System.Collections.Generic.IEnumerable_string_).isSuccessfully'></a>

`isSuccessfully` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

A value indicating whether the response is successful. Default is false.

<a name='FlowLibrary.Common.Response.Response(string,int,bool,System.Collections.Generic.IEnumerable_string_).errors'></a>

`errors` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The collection of errors associated with the response.