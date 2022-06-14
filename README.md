# BlazorWithRedux
Implementing [Redux](https://redux.js.org/introduction/three-principles) pattern in Blazor WebAssembly using [.NET 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) and [Fluxor](https://github.com/mrpmorris/Fluxor).
You can also find the related YouTube video [here](https://www.youtube.com/watch?v=sAyH-O0dFaI).

## Prerequisites
- [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- (Optional) [Redux DevTools Chrome extension](https://chrome.google.com/webstore/detail/redux-devtools/lmhkpmbekcpmknklioeibfkpmmfibljd?hl=en). Very handy to debug action dispatches and state changes.

## Dependencies added
- `Fluxor.Blazor.Web` [v5.4.0](https://www.nuget.org/packages/Fluxor.Blazor.Web/3.9.0)
- `Fluxor.Blazor.Web.ReduxDevTools` [v5.4.0](https://www.nuget.org/packages/Fluxor.Blazor.Web.ReduxDevTools/3.9.0)

## F5 Experience
1. Clone this repository
    ```cmd
    git clone https://github.com/christoment/BlazorWithRedux
    ```
2. Restore dependencies using
    ```cmd
    dotnet restore
    ```
3. Run Blazor WebAssembly in watch mode.
    ```cmd
    dotnet watch run
    ```
4. Your default browser should automatically opened for you.
   Navigate to the Counter page to see the example. 

## Important Installation Notes on Fluxor
As per Fluxor v5.4.0, Fluxor requires the following additional setup:
1. Store initialiser + DOM for the ReduxDevTool to look for in `App.razor`:
    ```html
    <Fluxor.Blazor.Web.StoreInitializer/>
    ```
2. Fluxor initialisation in `Program.cs`
    ```csharp
   builder.Services.AddFluxor(options =>
   {
     options
       .ScanAssemblies(typeof(Program).Assembly)
       .UseReduxDevTools();
   });
    ```

### .NET 6 Minimal Hosting Model
.NET 6 introduces [minimal hosting model](https://docs.microsoft.com/en-us/aspnet/core/migration/50-to-60?view=aspnetcore-6.0&tabs=visual-studio#nhm)
which removes explicit class declaration from `Program.cs`.

The side effect is that we can no longer reference `Program` directly in the code to scan for assemblies.
The following workaround can be applied to the `.csproj` file to enable referencing `Program` back as mentioned in [this post in StackOverflow](https://stackoverflow.com/questions/71026438/net-6-asp-net-core-6-0-get-startup-or-program-assembly-from-test-project):
```xml
<ItemGroup>
   <!-- This exposes Program class in .NET 6 minimal hosting setup -->
   <InternalsVisibleTo Include="BlazorWithRedux" />
</ItemGroup>
```
