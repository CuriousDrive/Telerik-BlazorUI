using Telerik.TestStudio.Translators.Common;
using Telerik.TestingFramework.Controls.TelerikUI.Blazor;
using Telerik.TestingFramework.Controls.KendoUI.Angular;
using Telerik.TestingFramework.Controls.KendoUI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace BookStores.Tests
{

    public class BlazorChartTest : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion
        
        // Add your test methods here...
    
        public List<ProductPoint> DataPoints = new List<ProductPoint>();
        
        [CodedStep(@"New Coded Step")]
        public void BlazorChartTest_CodedStep()
        {
            this.ActiveBrowser.RefreshDomTree();

            HtmlDiv chart = this.Find.ByExpression<HtmlDiv>("tagName=div", "class=~k-chart");
            
            HtmlControl pointsGroup = chart.Find.ByExpression<HtmlControl>("tagName=g", "clip-path=~salesandrevenue#kdef1");
            
            var points = pointsGroup.Find.AllByTagName("circle");
            
            foreach(Element point in points)
            {
                HtmlControl pCtrl = point.As<HtmlControl>();
                pCtrl.MouseHover(1, 1);
                
                System.Threading.Thread.Sleep(1000);
                
                this.ExtractPointData();
                
                this.ActiveBrowser.RefreshDomTree();
                
                System.Threading.Thread.Sleep(1000);
            }

            Assert.IsNotNull(this.DataPoints);
        }
        
        private void ExtractPointData()
        {
            this.ActiveBrowser.RefreshDomTree();
            
            HtmlDiv tooltipDiv = this.Find.ByExpression<HtmlDiv>("tagName=div","class=telerik-blazor k-animation-container k-chart-tooltip-wrapper");
            
            var img = tooltipDiv.BaseElement.CaptureImage();
            
            var imgText = Telerik.TestStudio.OCR.OcrManager.GetTextFromImageBytes(img.Image, false);
            
            this.DataPoints.Add(ProductPoint.Parse(imgText));
        }
    }
    
    public class ProductPoint
    {
        public string ScienceFiction { get; private set; }
        public string ActionAndAdventure { get; private set; }
        public string DetectiveAndMystery { get; private set; }
        public string TotalRevenue { get; private set; }
    
        private ProductPoint() { }
        
        public static ProductPoint Parse(string text)
        {
            var p = new ProductPoint();
            
            var strReader = new StringReader(text);
        
            while(true)
            {
                string line = strReader.ReadLine();
                if(line == null) break;
                if(String.IsNullOrEmpty(line)) continue;
                
                line = line.TrimStart('=').TrimStart();
                if(line.StartsWith("SF")) p.ScienceFiction = line;
                if(line.StartsWith("AA")) p.ActionAndAdventure = line;
                if(line.StartsWith("DM")) p.DetectiveAndMystery = line;
                if(line.StartsWith("Total")) p.TotalRevenue = line;
            }
            return p;
        }
    }
}
