# Book Stores

This is a sample app showing how you can build Blazor apps using Telerik UI for Blazor.

## Telerik Components for Blazor

![Demo_App](https://raw.githubusercontent.com/CuriousDrive/Telerik/master/Documents/Demo_GIF-1.gif)

## Document Processing using Telerik.Documents Librarires

![Demo_App](https://raw.githubusercontent.com/CuriousDrive/Telerik/master/Documents/Demo_GIF-2.gif)

## YouTube Videos

This app was made on YouTube. Please check the episodes below.

| Episodes | Topics |
| ----- | ---- |
| [Episode #1](/docs/00-get-started.md) | Telerik's UI for TextBox, AutoComplete, Button, DropDownList, MultiSelect & CheckBox  |
| [Episode #2](/docs/01-components-and-layout.md) | Get started with TelerikListView |
| [Episode #3](/docs/02-customize-a-pizza.md) | Get started with TelerikGrid  |
| [Episode #4](/docs/03-show-order-status.md) | Get started with TelerikDrawer |
| [Episode #5](/docs/04-refactor-state-management.md) | Get started with Document Processing |

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

