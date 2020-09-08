# BlazorWithRedux
Implementing [Redux](https://redux.js.org/introduction/three-principles) pattern in Blazor WebAssembly using C#9 and [Fluxor](https://github.com/mrpmorris/Fluxor) on [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0) Preview 8.

## Dependencies added
- `Fluxor.Blazor.Web` [v3.7.0](https://www.nuget.org/packages/Fluxor.Blazor.Web/3.7.0)
- `Fluxor.Blazor.Web.ReduxDevTools` [v3.7.0](https://www.nuget.org/packages/Fluxor.Blazor.Web.ReduxDevTools/3.7.0)

## F5 Experience
1. Install .NET 5 Preview 8 https://dotnet.microsoft.com/download/dotnet/5.0
2. Clone this repository
    ```cmd
    git clone https://github.com/christoment/BlazorWithRedux
    ```
3. Restore dependencies using
    ```cmd
    dotnet restore
    ```
4. Run Blazor WebAssembly in watch mode.
    ```cmd
    dotnet watch run
    ```
5. Your default browser should automatically opened for you.