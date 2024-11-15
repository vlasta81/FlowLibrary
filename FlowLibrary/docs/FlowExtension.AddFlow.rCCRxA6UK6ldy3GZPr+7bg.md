#### [FlowLibrary](FlowLibrary.md 'FlowLibrary')
### [FlowLibrary.Extensions](FlowLibrary.Extensions.md 'FlowLibrary.Extensions').[FlowExtension](FlowExtension.md 'FlowLibrary.Extensions.FlowExtension')

## FlowExtension.AddFlow<TContext>(this IServiceCollection, Assembly) Method

Adds Flow services to the specified [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection').

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection AddFlow<TContext>(this Microsoft.Extensions.DependencyInjection.IServiceCollection services, System.Reflection.Assembly assembly)
    where TContext : Microsoft.EntityFrameworkCore.DbContext;
```
#### Type parameters

<a name='FlowLibrary.Extensions.FlowExtension.AddFlow_TContext_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Reflection.Assembly).TContext'></a>

`TContext`

The type of the [Microsoft.EntityFrameworkCore.DbContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.EntityFrameworkCore.DbContext 'Microsoft.EntityFrameworkCore.DbContext') to use.
#### Parameters

<a name='FlowLibrary.Extensions.FlowExtension.AddFlow_TContext_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Reflection.Assembly).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') to add services to.

<a name='FlowLibrary.Extensions.FlowExtension.AddFlow_TContext_(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection,System.Reflection.Assembly).assembly'></a>

`assembly` [System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly')

The [System.Reflection.Assembly](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.Assembly 'System.Reflection.Assembly') to scan for Flow components.

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
The [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') so that additional calls can be chained.