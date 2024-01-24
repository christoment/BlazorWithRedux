# BlazorWithRedux
Implementing [Redux](https://redux.js.org/introduction/three-principles) pattern in Blazor WebAssembly using [.NET 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) and [Fluxor](https://github.com/mrpmorris/Fluxor).
You can also find the related YouTube video [here](https://www.youtube.com/watch?v=sAyH-O0dFaI).

## Prerequisites
- [.NET 8 SDK (8.0.1)](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- (Optional) [Redux DevTools Chrome extension](https://chrome.google.com/webstore/detail/redux-devtools/lmhkpmbekcpmknklioeibfkpmmfibljd?hl=en). Very handy to debug action dispatches and state changes.

## Dependencies added
- `Fluxor.Blazor.Web` [v5.9.1](https://www.nuget.org/packages/Fluxor.Blazor.Web)
- `Fluxor.Blazor.Web.ReduxDevTools` [v5.9.1](https://www.nuget.org/packages/Fluxor.Blazor.Web.ReduxDevTools)

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
