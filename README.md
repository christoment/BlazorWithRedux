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

## Important Notes for Fluxor
Fluxor needs the following dependencies added:
1. Javascript file in `index.html`
    ```html
    <script src="_content/Fluxor.Blazor.Web/scripts/index.js"></script>
    ```
2. Store initialiser + DOM for the ReduxDevTool to look for:
    ```html
    <Fluxor.Blazor.Web.StoreInitializer/>
    ```
3. Fluxor initialisation in `Program.cs`
    ```csharp
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddFluxor(options =>
            {
                options
                    .ScanAssemblies(typeof(Program).Assembly)
                    .UseReduxDevTools(); // For ReduxDevTool support. Recommended to remove this on Production
            });

            // ...
        }
    }
    ```