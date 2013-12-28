WebConsole
==========

C# scripting console for a ASP.NET MVC project base on Roslyn

### Motivation

I needed a way to provide the advanced users scripting support in a ASP.NET MVC application running in Windows Azure. I choose C# as tre scripting language.

### Implementation

The C# scripting solution is based on [Roslyn](http://msdn.microsoft.com/en-us/vstudio/roslyn.aspx). The sample solution shows a basic scripting console to run C# scripts in a context containing one repository class.

### Sample script

```csharp
var data = Repository.GetAll();      
data.Count()    
```
