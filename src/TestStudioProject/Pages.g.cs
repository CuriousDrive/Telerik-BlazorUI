//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestStudioProject
{
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.ObjectModel;
    using ArtOfTest.WebAii.TestAttributes;
    using ArtOfTest.WebAii.TestTemplates;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    
    public class Pages
    {
        private Manager _manager;
        public Pages(Manager manager)
        {
            _manager = manager;
        }
        /// <summary>
        /// Page : https://localhost:5001/ 
        /// </summary>
        public BookStoresPage BookStores
        {
            get
            {
                return new BookStoresPage("https://localhost:5001/", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : https://localhost:5001/books 
        /// </summary>
        public BookStores1Page BookStores1
        {
            get
            {
                return new BookStores1Page("https://localhost:5001/books", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : https://localhost:5001/publishers 
        /// </summary>
        public BookStores0Page BookStores0
        {
            get
            {
                return new BookStores0Page("https://localhost:5001/publishers", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : https://localhost:5001/makeanappointment 
        /// </summary>
        public BookStores2Page BookStores2
        {
            get
            {
                return new BookStores2Page("https://localhost:5001/makeanappointment", _manager.ActiveBrowser.Find);
            }
        }
        public class BookStoresPage : HtmlPage
        {
            public BookStoresPage(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' cbAll] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputCheckBox CbAllCheckBox
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputCheckBox>("id=cbAll", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' app][tagIndex 'Exact' input:6]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputCheckBox CbSubsCheckBox
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputCheckBox>("id=app", "|", "tagIndex=input:6");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' app][tagIndex 'Exact' input:7]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputCheckBox CbSubsCheckBox0
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputCheckBox>("id=app", "|", "tagIndex=input:7");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' app][tagIndex 'Exact' input:8]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputCheckBox CbSubsCheckBox1
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputCheckBox>("id=app", "|", "tagIndex=input:8");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [class 'Contains' k-dropdown] AND [class 'Contains' telerik-blazor]
            ///
            /// </summary>
            public Telerik.TestingFramework.Controls.TelerikUI.Blazor.DropdownList.TelerikBlazorDropdownList DdlStatesSpan
            {
                get
                {
                    return Get<Telerik.TestingFramework.Controls.TelerikUI.Blazor.DropdownList.TelerikBlazorDropdownList>("class=~k-dropdown", "class=~telerik-blazor");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [class 'Contains' telerik-blazor] AND [class 'Contains' k-animation-container][class 'Contains' k-popup] AND [class 'Contains' k-reset]
            ///
            /// </summary>
            public Telerik.TestingFramework.Controls.TelerikUI.Blazor.List.TelerikBlazorList Div2
            {
                get
                {
                    return Get<Telerik.TestingFramework.Controls.TelerikUI.Blazor.List.TelerikBlazorList>("class=~telerik-blazor", "class=~k-animation-container", "|", "class=~k-popup", "class=~k-reset");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [TagIndex 'Exact' body:0]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl BodyTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("TagIndex=body:0");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' label] AND [TextContent 'Exact' First Name :]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl FirstNameLabelTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("TextContent=First Name :", "tagname=label");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [class 'Contains' k-textbox] AND [class 'Contains' telerik-blazor]
            ///
            /// </summary>
            public Telerik.TestingFramework.Controls.TelerikUI.Blazor.TextBox.TelerikBlazorTextBox TxtFirstNameText
            {
                get
                {
                    return Get<Telerik.TestingFramework.Controls.TelerikUI.Blazor.TextBox.TelerikBlazorTextBox>("class=~k-textbox", "class=~telerik-blazor");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' div] AND [TextContent 'Exact' F]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv FDiv
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv>("TextContent=F", "tagname=div");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' div] AND [TextContent 'Exact' Fa]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv FaDiv
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv>("TextContent=Fa", "tagname=div");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' div] AND [TextContent 'Exact' Faha]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv FahaDiv
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv>("TextContent=Faha", "tagname=div");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' div] AND [TextContent 'Exact' Fahad]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv FahadDiv
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv>("TextContent=Fahad", "tagname=div");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [class 'Contains' k-grid] AND [class 'Contains' k-widget] AND [class 'Contains' telerik-blazor] AND [class 'NotContain' k-grid-pager]
            ///
            /// </summary>
            public Telerik.TestingFramework.Controls.TelerikUI.Blazor.Grid.TelerikBlazorGrid Div0
            {
                get
                {
                    return Get<Telerik.TestingFramework.Controls.TelerikUI.Blazor.Grid.TelerikBlazorGrid>("class=~k-grid", "class=~k-widget", "class=~telerik-blazor", "class=!k-grid-pager");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [class 'Contains' k-button] AND [class 'Contains' telerik-blazor]
            ///
            /// </summary>
            public Telerik.TestingFramework.Controls.TelerikUI.Blazor.Button.TelerikBlazorButton ButtonTag
            {
                get
                {
                    return Get<Telerik.TestingFramework.Controls.TelerikUI.Blazor.Button.TelerikBlazorButton>("class=~k-button", "class=~telerik-blazor");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [class 'Contains' k-drawer-item] AND [class 'NotContain' k-drawer-items] AND [class 'NotContain' k-drawer-separator] AND [GroupIndex 'Exact' 1]
            ///
            /// </summary>
            public Telerik.TestingFramework.Controls.TelerikUI.Blazor.Drawer.TelerikBlazorDrawerItem ListItem0
            {
                get
                {
                    return Get<Telerik.TestingFramework.Controls.TelerikUI.Blazor.Drawer.TelerikBlazorDrawerItem>("class=~k-drawer-item", "class=!k-drawer-items", "class=!k-drawer-separator", "GroupIndex=1");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [class 'Contains' k-drawer-item] AND [class 'NotContain' k-drawer-items] AND [class 'NotContain' k-drawer-separator] AND [GroupIndex 'Exact' 2]
            ///
            /// </summary>
            public Telerik.TestingFramework.Controls.TelerikUI.Blazor.Drawer.TelerikBlazorDrawerItem ListItem
            {
                get
                {
                    return Get<Telerik.TestingFramework.Controls.TelerikUI.Blazor.Drawer.TelerikBlazorDrawerItem>("class=~k-drawer-item", "class=!k-drawer-items", "class=!k-drawer-separator", "GroupIndex=2");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' app][tagIndex 'Exact' input:0]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputCheckBox CheckBox0
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputCheckBox>("id=app", "|", "tagIndex=input:0");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [TagIndex 'Exact' input:0]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputCheckBox CheckBox
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputCheckBox>("TagIndex=input:0");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [src 'Exact' /img/blank-profile.png] AND [tagname 'Exact' img]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage BlankProfilePngImage
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage>("src=/img/blank-profile.png", "tagname=img");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [TagIndex 'Exact' div:1]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv Div1
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv>("TagIndex=div:1");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [class 'Exact' k-input] AND [class 'NotContain' telerik-blazor]
            ///
            /// </summary>
            public Telerik.TestingFramework.Controls.KendoUI.Angular.Input.KendoAngularTextBox AcCitiesText
            {
                get
                {
                    return Get<Telerik.TestingFramework.Controls.KendoUI.Angular.Input.KendoAngularTextBox>("class=k-input", "class=!telerik-blazor");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [class 'Contains' telerik-blazor] AND [class 'Contains' k-animation-container] AND [GroupIndex 'Exact' 2][class 'Contains' k-popup] AND [class 'Contains' k-reset]
            ///
            /// </summary>
            public Telerik.TestingFramework.Controls.TelerikUI.Blazor.List.TelerikBlazorList Div
            {
                get
                {
                    return Get<Telerik.TestingFramework.Controls.TelerikUI.Blazor.List.TelerikBlazorList>("class=~telerik-blazor", "class=~k-animation-container", "GroupIndex=2", "|", "class=~k-popup", "class=~k-reset");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [class 'Contains' k-textbox] AND [class 'Contains' telerik-blazor] AND [GroupIndex 'Exact' 1]
            ///
            /// </summary>
            public Telerik.TestingFramework.Controls.TelerikUI.Blazor.TextBox.TelerikBlazorTextBox TxtFirstNameText0
            {
                get
                {
                    return Get<Telerik.TestingFramework.Controls.TelerikUI.Blazor.TextBox.TelerikBlazorTextBox>("class=~k-textbox", "class=~telerik-blazor", "GroupIndex=1");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [class 'Contains' k-multiselect] AND [class 'Contains' k-widget] AND [class 'Contains' telerik-blazor]
            ///
            /// </summary>
            public Telerik.TestingFramework.Controls.TelerikUI.Blazor.MultiSelect.TelerikBlazorMultiSelect Div3
            {
                get
                {
                    return Get<Telerik.TestingFramework.Controls.TelerikUI.Blazor.MultiSelect.TelerikBlazorMultiSelect>("class=~k-multiselect", "class=~k-widget", "class=~telerik-blazor");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [class 'Contains' k-drawer-item] AND [class 'NotContain' k-drawer-items] AND [class 'NotContain' k-drawer-separator] AND [GroupIndex 'Exact' 4]
            ///
            /// </summary>
            public Telerik.TestingFramework.Controls.TelerikUI.Blazor.Drawer.TelerikBlazorDrawerItem ListItem2
            {
                get
                {
                    return Get<Telerik.TestingFramework.Controls.TelerikUI.Blazor.Drawer.TelerikBlazorDrawerItem>("class=~k-drawer-item", "class=!k-drawer-items", "class=!k-drawer-separator", "GroupIndex=4");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression CbAllCheckBox = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=cbAll", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression CbSubsCheckBox = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=app", "|", "tagIndex=input:6");
                public ArtOfTest.WebAii.Core.HtmlFindExpression CbSubsCheckBox0 = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=app", "|", "tagIndex=input:7");
                public ArtOfTest.WebAii.Core.HtmlFindExpression CbSubsCheckBox1 = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=app", "|", "tagIndex=input:8");
                public ArtOfTest.WebAii.Core.HtmlFindExpression DdlStatesSpan = new ArtOfTest.WebAii.Core.HtmlFindExpression("class=~k-dropdown", "class=~telerik-blazor");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Div2 = new ArtOfTest.WebAii.Core.HtmlFindExpression("class=~telerik-blazor", "class=~k-animation-container", "|", "class=~k-popup", "class=~k-reset");
                public ArtOfTest.WebAii.Core.HtmlFindExpression BodyTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("TagIndex=body:0");
                public ArtOfTest.WebAii.Core.HtmlFindExpression FirstNameLabelTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=First Name :", "tagname=label");
                public ArtOfTest.WebAii.Core.HtmlFindExpression TxtFirstNameText = new ArtOfTest.WebAii.Core.HtmlFindExpression("class=~k-textbox", "class=~telerik-blazor");
                public ArtOfTest.WebAii.Core.HtmlFindExpression FDiv = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=F", "tagname=div");
                public ArtOfTest.WebAii.Core.HtmlFindExpression FaDiv = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=Fa", "tagname=div");
                public ArtOfTest.WebAii.Core.HtmlFindExpression FahaDiv = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=Faha", "tagname=div");
                public ArtOfTest.WebAii.Core.HtmlFindExpression FahadDiv = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=Fahad", "tagname=div");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Div0 = new ArtOfTest.WebAii.Core.HtmlFindExpression("class=~k-grid", "class=~k-widget", "class=~telerik-blazor", "class=!k-grid-pager");
                public ArtOfTest.WebAii.Core.HtmlFindExpression ButtonTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("class=~k-button", "class=~telerik-blazor");
                public ArtOfTest.WebAii.Core.HtmlFindExpression ListItem0 = new ArtOfTest.WebAii.Core.HtmlFindExpression("class=~k-drawer-item", "class=!k-drawer-items", "class=!k-drawer-separator", "GroupIndex=1");
                public ArtOfTest.WebAii.Core.HtmlFindExpression ListItem = new ArtOfTest.WebAii.Core.HtmlFindExpression("class=~k-drawer-item", "class=!k-drawer-items", "class=!k-drawer-separator", "GroupIndex=2");
                public ArtOfTest.WebAii.Core.HtmlFindExpression CheckBox0 = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=app", "|", "tagIndex=input:0");
                public ArtOfTest.WebAii.Core.HtmlFindExpression CheckBox = new ArtOfTest.WebAii.Core.HtmlFindExpression("TagIndex=input:0");
                public ArtOfTest.WebAii.Core.HtmlFindExpression BlankProfilePngImage = new ArtOfTest.WebAii.Core.HtmlFindExpression("src=/img/blank-profile.png", "tagname=img");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Div1 = new ArtOfTest.WebAii.Core.HtmlFindExpression("TagIndex=div:1");
                public ArtOfTest.WebAii.Core.HtmlFindExpression AcCitiesText = new ArtOfTest.WebAii.Core.HtmlFindExpression("class=k-input", "class=!telerik-blazor");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Div = new ArtOfTest.WebAii.Core.HtmlFindExpression("class=~telerik-blazor", "class=~k-animation-container", "GroupIndex=2", "|", "class=~k-popup", "class=~k-reset");
                public ArtOfTest.WebAii.Core.HtmlFindExpression TxtFirstNameText0 = new ArtOfTest.WebAii.Core.HtmlFindExpression("class=~k-textbox", "class=~telerik-blazor", "GroupIndex=1");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Div3 = new ArtOfTest.WebAii.Core.HtmlFindExpression("class=~k-multiselect", "class=~k-widget", "class=~telerik-blazor");
                public ArtOfTest.WebAii.Core.HtmlFindExpression ListItem2 = new ArtOfTest.WebAii.Core.HtmlFindExpression("class=~k-drawer-item", "class=!k-drawer-items", "class=!k-drawer-separator", "GroupIndex=4");
            }
        }
        public class BookStores1Page : HtmlPage
        {
            public BookStores1Page(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [class 'Contains' k-drawer-item] AND [class 'NotContain' k-drawer-items] AND [class 'NotContain' k-drawer-separator] AND [GroupIndex 'Exact' 4]
            ///
            /// </summary>
            public Telerik.TestingFramework.Controls.TelerikUI.Blazor.Drawer.TelerikBlazorDrawerItem ListItem
            {
                get
                {
                    return Get<Telerik.TestingFramework.Controls.TelerikUI.Blazor.Drawer.TelerikBlazorDrawerItem>("class=~k-drawer-item", "class=!k-drawer-items", "class=!k-drawer-separator", "GroupIndex=4");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' label] AND [TextContent 'Exact' Books]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl BooksLabelTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("TextContent=Books", "tagname=label");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [class 'Contains' k-grid] AND [class 'Contains' k-widget] AND [class 'Contains' telerik-blazor] AND [class 'NotContain' k-grid-pager][class 'NotContain' k-group-cell] AND [GroupIndex 'Exact' 43] AND [role 'Exact' gridcell]
            ///
            /// </summary>
            public Telerik.TestingFramework.Controls.TelerikUI.Blazor.Grid.TelerikBlazorGridDataCell TheGreatTableCell
            {
                get
                {
                    return Get<Telerik.TestingFramework.Controls.TelerikUI.Blazor.Grid.TelerikBlazorGridDataCell>("class=~k-grid", "class=~k-widget", "class=~telerik-blazor", "class=!k-grid-pager", "|", "role=gridcell", "class=!k-group-cell", "GroupIndex=43");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' app][tagIndex 'Exact' span:11]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan Span
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan>("id=app", "|", "tagIndex=span:11");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [class 'Contains' k-textbox] AND [class 'Contains' telerik-blazor] AND [GroupIndex 'Exact' 2]
            ///
            /// </summary>
            public Telerik.TestingFramework.Controls.TelerikUI.Blazor.TextBox.TelerikBlazorTextBox x44e22a1f1ddd4e73B8f9D152b7f285a7Text
            {
                get
                {
                    return Get<Telerik.TestingFramework.Controls.TelerikUI.Blazor.TextBox.TelerikBlazorTextBox>("class=~k-textbox", "class=~telerik-blazor", "GroupIndex=2");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' button] AND [TextContent 'Exact' Filter]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton FilterButtonTag
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlButton>("TextContent=Filter", "tagname=button");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [class 'Contains' k-grid] AND [class 'Contains' k-widget] AND [class 'Contains' telerik-blazor] AND [class 'NotContain' k-grid-pager][class 'NotContain' k-group-cell] AND [GroupIndex 'Exact' 1] AND [role 'Exact' gridcell]
            ///
            /// </summary>
            public Telerik.TestingFramework.Controls.TelerikUI.Blazor.Grid.TelerikBlazorGridDataCell TheGreatTableCell0
            {
                get
                {
                    return Get<Telerik.TestingFramework.Controls.TelerikUI.Blazor.Grid.TelerikBlazorGridDataCell>("class=~k-grid", "class=~k-widget", "class=~telerik-blazor", "class=!k-grid-pager", "|", "role=gridcell", "class=!k-group-cell", "GroupIndex=1");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression ListItem = new ArtOfTest.WebAii.Core.HtmlFindExpression("class=~k-drawer-item", "class=!k-drawer-items", "class=!k-drawer-separator", "GroupIndex=4");
                public ArtOfTest.WebAii.Core.HtmlFindExpression BooksLabelTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=Books", "tagname=label");
                public ArtOfTest.WebAii.Core.HtmlFindExpression TheGreatTableCell = new ArtOfTest.WebAii.Core.HtmlFindExpression("class=~k-grid", "class=~k-widget", "class=~telerik-blazor", "class=!k-grid-pager", "|", "role=gridcell", "class=!k-group-cell", "GroupIndex=43");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Span = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=app", "|", "tagIndex=span:11");
                public ArtOfTest.WebAii.Core.HtmlFindExpression x44e22a1f1ddd4e73B8f9D152b7f285a7Text = new ArtOfTest.WebAii.Core.HtmlFindExpression("class=~k-textbox", "class=~telerik-blazor", "GroupIndex=2");
                public ArtOfTest.WebAii.Core.HtmlFindExpression FilterButtonTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=Filter", "tagname=button");
                public ArtOfTest.WebAii.Core.HtmlFindExpression TheGreatTableCell0 = new ArtOfTest.WebAii.Core.HtmlFindExpression("class=~k-grid", "class=~k-widget", "class=~telerik-blazor", "class=!k-grid-pager", "|", "role=gridcell", "class=!k-group-cell", "GroupIndex=1");
            }
        }
        public class BookStores0Page : HtmlPage
        {
            public BookStores0Page(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [class 'Contains' k-drawer-item] AND [class 'NotContain' k-drawer-items] AND [class 'NotContain' k-drawer-separator] AND [GroupIndex 'Exact' 3]
            ///
            /// </summary>
            public Telerik.TestingFramework.Controls.TelerikUI.Blazor.Drawer.TelerikBlazorDrawerItem ListItem
            {
                get
                {
                    return Get<Telerik.TestingFramework.Controls.TelerikUI.Blazor.Drawer.TelerikBlazorDrawerItem>("class=~k-drawer-item", "class=!k-drawer-items", "class=!k-drawer-separator", "GroupIndex=3");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' app][tagIndex 'Exact' img:6]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage Image
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlImage>("id=app", "|", "tagIndex=img:6");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [class 'Contains' k-button] AND [class 'Contains' telerik-blazor] AND [GroupIndex 'Exact' 5]
            ///
            /// </summary>
            public Telerik.TestingFramework.Controls.TelerikUI.Blazor.Button.TelerikBlazorButton SaveButtonTag
            {
                get
                {
                    return Get<Telerik.TestingFramework.Controls.TelerikUI.Blazor.Button.TelerikBlazorButton>("class=~k-button", "class=~telerik-blazor", "GroupIndex=5");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [class 'Contains' k-button] AND [class 'Contains' telerik-blazor] AND [GroupIndex 'Exact' 6]
            ///
            /// </summary>
            public Telerik.TestingFramework.Controls.TelerikUI.Blazor.Button.TelerikBlazorButton DeleteButtonTag
            {
                get
                {
                    return Get<Telerik.TestingFramework.Controls.TelerikUI.Blazor.Button.TelerikBlazorButton>("class=~k-button", "class=~telerik-blazor", "GroupIndex=6");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [class 'Contains' k-listview] AND [class 'Contains' k-widget] AND [class 'Contains' telerik-blazor] AND [class 'NotContain' pager]
            ///
            /// </summary>
            public Telerik.TestingFramework.Controls.TelerikUI.Blazor.ListView.TelerikBlazorListView Div0
            {
                get
                {
                    return Get<Telerik.TestingFramework.Controls.TelerikUI.Blazor.ListView.TelerikBlazorListView>("class=~k-listview", "class=~k-widget", "class=~telerik-blazor", "class=!pager");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' app][tagIndex 'Exact' div:19]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv Div
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv>("id=app", "|", "tagIndex=div:19");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [class 'Contains' k-pager-wrap] AND [class 'Contains' k-widget] AND [class 'Contains' telerik-blazor]
            ///
            /// </summary>
            public Telerik.TestingFramework.Controls.TelerikUI.Blazor.Pager.TelerikBlazorPager Div1
            {
                get
                {
                    return Get<Telerik.TestingFramework.Controls.TelerikUI.Blazor.Pager.TelerikBlazorPager>("class=~k-pager-wrap", "class=~k-widget", "class=~telerik-blazor");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression ListItem = new ArtOfTest.WebAii.Core.HtmlFindExpression("class=~k-drawer-item", "class=!k-drawer-items", "class=!k-drawer-separator", "GroupIndex=3");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Image = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=app", "|", "tagIndex=img:6");
                public ArtOfTest.WebAii.Core.HtmlFindExpression SaveButtonTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("class=~k-button", "class=~telerik-blazor", "GroupIndex=5");
                public ArtOfTest.WebAii.Core.HtmlFindExpression DeleteButtonTag = new ArtOfTest.WebAii.Core.HtmlFindExpression("class=~k-button", "class=~telerik-blazor", "GroupIndex=6");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Div0 = new ArtOfTest.WebAii.Core.HtmlFindExpression("class=~k-listview", "class=~k-widget", "class=~telerik-blazor", "class=!pager");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Div = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=app", "|", "tagIndex=div:19");
                public ArtOfTest.WebAii.Core.HtmlFindExpression Div1 = new ArtOfTest.WebAii.Core.HtmlFindExpression("class=~k-pager-wrap", "class=~k-widget", "class=~telerik-blazor");
            }
        }
        public class BookStores2Page : HtmlPage
        {
            public BookStores2Page(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' span] AND [TextContent 'Exact' Authors]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan AuthorsSpan
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan>("TextContent=Authors", "tagname=span");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' div] AND [TextContent 'Exact' 8:00 AM]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv x800AMDiv
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv>("TextContent=8:00 AM", "tagname=div");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' span] AND [TextContent 'StartsWith' Show business h]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan ShowBusinessSpan
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan>("TextContent=^Show business h", "tagname=span");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' div] AND [TextContent 'Exact' 9:00 AM]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv x900AMDiv
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv>("TextContent=9:00 AM", "tagname=div");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression AuthorsSpan = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=Authors", "tagname=span");
                public ArtOfTest.WebAii.Core.HtmlFindExpression x800AMDiv = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=8:00 AM", "tagname=div");
                public ArtOfTest.WebAii.Core.HtmlFindExpression ShowBusinessSpan = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=^Show business h", "tagname=span");
                public ArtOfTest.WebAii.Core.HtmlFindExpression x900AMDiv = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=9:00 AM", "tagname=div");
            }
        }
    }
    public class Applications
    {
        private Manager _manager;
        public Applications(Manager manager)
        {
            _manager = manager;
        }
    }
}
