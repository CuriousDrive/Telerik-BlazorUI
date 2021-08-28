# What is Telerik-BlazorUI : BookStores?

Telerik-BlazorUI : BookSores app is built with Telerik components for Blazor. This app has sample code for Textboxes, Dropdown list, ListViews, GridViews, Drawer components. Also there's a Blazor server app showing how to use Telerik's document processing libraries. Please check it out.

## Telerik Components for Blazor

![Demo_App](https://raw.githubusercontent.com/CuriousDrive/Telerik/master/Documents/Demo_GIF-1.gif)

## Document Processing using Telerik.Documents Libraries

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

- This is a Blazor WASM app, please run the server project. 
- The final version of this app will be in the `src` folder.
- If you are watching tutorials and want to refer to particular code, then you can check out the `Source Code By Episode` folder

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

