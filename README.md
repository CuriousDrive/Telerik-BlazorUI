# Book Stores

This is a demo showing how a full-stack .NET application can be built with ASP.NET Core, Blazor Wasm, and Telerik UI for Blazor.

![Demo_App](https://raw.githubusercontent.com/CuriousDrive/Telerik/master/Documents/Demo_GIF.gif)

## Videos

## Requirements

- .NET Core 3.1
- Telerik UI for Blazor (Trial or Commercial)

## Running the Application

- You should be able to just run it without any extra setup. 
- The final version of this app will be in the last episode's folder. 
- If you are watching tutorials and want to refer to the code, then you can check out the code from that video's folder

## Telerik UI for Blazor Trial

If you are using a trial version of Telerik UI for Blazor.

- In BookStores.Client add `.Trial` to the package path.

```
    <PackageReference Include="Telerik.UI.for.Blazor.Trial" Version="2.13.0" />
```

- In BookStores.Client/wwwroot, add `.Trial` to the script path.

```
    <script src="_content/telerik.ui.for.blazor/js/telerik-blazor.js"></script>
```

- In BookStores.Server, add .Trial to all Telerik.* package paths.

```
    <PackageReference Include="Telerik.Documents.Core.Trial" Version="2020.1.109" />
    <PackageReference Include="Telerik.Documents.Fixed.Trial" Version="2020.1.109" />
    <PackageReference Include="Telerik.Documents.Flow.Trial" Version="2020.1.109" />
    <PackageReference Include="Telerik.Documents.Flow.FormatProviders.Pdf.Trial" Version="2020.1.109" />
    <PackageReference Include="Telerik.Documents.Spreadsheet.Trial" Version="2020.1.109" />
    <PackageReference Include="Telerik.Documents.Spreadsheet.FormatProviders.OpenXml.Trial" Version="2020.1.109" />
    <PackageReference Include="Telerik.Documents.Spreadsheet.FormatProviders.Pdf.Trial" Version="2020.1.109" />
    <PackageReference Include="Telerik.Documents.SpreadsheetStreaming.Trial" Version="2020.1.109" />
    <PackageReference Include="Telerik.Zip.Trial" Version="2020.1.109" />
```

