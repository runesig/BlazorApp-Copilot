# BlazorApp-Copilot
BlazorApp-Copilot is a .NET 8.0 Blazor Server application that demonstrates interactive server-side rendering with real-time web UI components. The application includes a home page, an interactive counter, and a weather data display component.

Always reference these instructions first and fallback to search or bash commands only when you encounter unexpected information that does not match the info here.

## Working Effectively
- Bootstrap, build, and test the repository:
  - `dotnet restore` -- takes ~1 second. Restores NuGet packages.
  - `dotnet build` -- takes 2-11 seconds depending on clean vs incremental build. NEVER CANCEL. Set timeout to 30+ seconds.
  - `dotnet build --configuration Release` -- takes ~2 seconds for Release build.
- `dotnet test` -- no tests exist in this project. Command completes immediately with no output.
- Run the web application:
  - ALWAYS run the build steps first.
  - `dotnet run` -- starts the application on http://localhost:5148. NEVER CANCEL. Set timeout to 30+ seconds for startup.
  - Application startup takes ~8 seconds and shows "Now listening on: http://localhost:5148" when ready.
  - HTTPS is available on https://localhost:7139 (configured in launchSettings.json).
- Clean build artifacts:
  - `dotnet clean` -- takes ~1 second. Removes bin/ and obj/ folders.

## Validation
- Always test the application manually after making changes by running `dotnet run` and accessing all pages.
- Test these validation scenarios after making changes:
  - **Home page**: Visit http://localhost:5148/ and verify "Hello, world!" message appears.
  - **Counter functionality**: Visit http://localhost:5148/counter and click the "Click me" button multiple times to verify the counter increments correctly.
  - **Weather data**: Visit http://localhost:5148/weather and verify the weather table loads with 5 rows of random temperature data after a ~500ms loading delay.
- Always run `dotnet format --verify-no-changes` before committing (takes ~12 seconds). NEVER CANCEL. Set timeout to 30+ seconds.
- Build artifacts are excluded via .gitignore (bin/, obj/ directories should not be committed).

## Technology Stack & Dependencies
- **.NET 8.0**: Target framework for the application
- **Blazor Server**: Interactive server-side rendering with SignalR
- **Bootstrap**: CSS framework included in wwwroot/bootstrap/
- **No external NuGet packages**: Uses only built-in ASP.NET Core and Blazor components

## Project Structure
```
BlazorApp-Copilot/
├── BlazorApp-Copilot.sln           # Visual Studio solution file
├── README.md                       # Basic project description
├── .gitignore                     # Excludes bin/, obj/, and other build artifacts
└── BlazorApp-Copilot/             # Main project directory
    ├── BlazorApp-Copilot.csproj   # Project file (.NET 8.0 Web SDK)
    ├── Program.cs                  # Application entry point and configuration
    ├── Components/                 # Blazor components
    │   ├── App.razor              # Root app component with HTML document structure
    │   ├── Routes.razor           # Router configuration
    │   ├── _Imports.razor         # Global using statements
    │   ├── Layout/                # Layout components
    │   │   ├── MainLayout.razor   # Main application layout
    │   │   ├── MainLayout.razor.css
    │   │   ├── NavMenu.razor      # Navigation sidebar
    │   │   └── NavMenu.razor.css
    │   └── Pages/                 # Page components
    │       ├── Home.razor         # Home page (/)
    │       ├── Counter.razor      # Interactive counter (/counter)
    │       ├── Weather.razor      # Weather data display (/weather)
    │       └── Error.razor        # Error page
    ├── Properties/
    │   └── launchSettings.json    # Development server configuration
    ├── appsettings.json          # Application configuration
    ├── appsettings.Development.json
    └── wwwroot/                   # Static web assets
        ├── app.css               # Custom application styles
        ├── favicon.png           # Application icon
        └── bootstrap/            # Bootstrap CSS framework
```

## Common Tasks
The following are outputs from frequently run commands. Reference them instead of viewing, searching, or running bash commands to save time.

### Repository root files
```
ls -la /
.git/
BlazorApp-Copilot/
BlazorApp-Copilot.sln
README.md
.gitignore
```

### Main project directory
```
ls -la BlazorApp-Copilot/
BlazorApp-Copilot.csproj
Components/
Program.cs
Properties/
appsettings.Development.json
appsettings.json
wwwroot/
```

### Application URLs and Endpoints
- **Home**: http://localhost:5148/ - Displays welcome message
- **Counter**: http://localhost:5148/counter - Interactive counter with "Click me" button
- **Weather**: http://localhost:5148/weather - Table showing 5 days of random weather data
- **HTTPS**: https://localhost:7139 - Secure endpoint (redirects HTTP traffic)

### BlazorApp-Copilot.csproj
```xml
<Project Sdk="Microsoft.NET.Sdk.Web">
  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
    <RootNamespace>BlazorApp-Copilot</RootNamespace>
    <AssemblyName>$(AssemblyName.Replace(' ', '_'))</AssemblyName>
  </PropertyGroup>
</Project>
```

### Program.cs Key Configuration
- Uses Blazor Server with Interactive Server Components
- Configured for HTTPS redirection and static files
- Includes antiforgery token support
- Error handling for non-development environments

## Development Workflow
1. Always start with `dotnet restore` to ensure packages are available
2. Use `dotnet build` to compile and verify no build errors exist
3. Run `dotnet run` to start the development server
4. Test functionality by visiting all three pages in browser
5. Make code changes to Components/ directory as needed
6. Restart application to see changes (no hot reload configured)
7. Run `dotnet format --verify-no-changes` before committing
8. Use `dotnet clean` to clear build artifacts when needed

## Key Interactive Features to Test
- **Counter Page**: Click the button and verify the count increments from 0 to higher numbers
- **Weather Page**: Verify the table shows 5 rows of weather data with dates, temperatures (C/F), and weather descriptions
- **Navigation**: Verify all navigation links work correctly and highlight the active page
- **Responsive Layout**: Application uses Bootstrap and should work on different screen sizes

## Troubleshooting
- If the application fails to start, ensure .NET 8.0 SDK is installed
- If pages don't load, verify the application is running on http://localhost:5148
- If SignalR connection fails, check browser console for WebSocket connection errors
- Build artifacts in bin/ and obj/ directories are automatically excluded from git via .gitignore