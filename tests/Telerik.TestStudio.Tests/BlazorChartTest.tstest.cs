using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using BookStores.Tests.Validation;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
        
        // Property to capture product points
        public List<ProductPoint> DataPoints = new List<ProductPoint>();
        
        [CodedStep(@"New Coded Step")]
        public void BlazorChartTest_CodedStep()
        {
            // Refreshing the DOM tree
            this.ActiveBrowser.RefreshDomTree();

            // Loading the chart
            HtmlDiv chart = this.Find.ByExpression<HtmlDiv>("tagName=div", "class=~k-chart");
            
            // Loading chart's point groups
            HtmlControl pointsGroup = chart.Find.ByExpression<HtmlControl>("tagName=g", "clip-path=~salesandrevenue#kdef1");
            
            // Finding the points by circle
            var points = pointsGroup.Find.AllByTagName("circle");
            
            foreach(Element point in points)
            {
                // Hovering over the circles 
                HtmlControl pCtrl = point.As<HtmlControl>();
                pCtrl.MouseHover(1, 1);
                
                System.Threading.Thread.Sleep(1000);
                
                // Capturing the image and using OCR to convert image into text data
                this.ExtractPointData();
                
                this.ActiveBrowser.RefreshDomTree();

                System.Threading.Thread.Sleep(1000);
            }

            // Logging captured data
            var dataPoint = this.DataPoints.Where(dp => dp.Category == "Jun").FirstOrDefault();

            Log.WriteLine("Category : " + dataPoint.Category);
            Log.WriteLine("HL : " + dataPoint.AA);
            Log.WriteLine("ML : " + dataPoint.DM);
            Log.WriteLine("SF : " + dataPoint.SF);
            Log.WriteLine("Total : " + dataPoint.TotalRevenue);

            // Validating if the captured data is matching with the data from the service
            Assert.IsTrue(new ValidationService().ValidateProductPoints(this.DataPoints));
        }
        
        private void ExtractPointData()
        {
            // Refreshing the DOM tree
            this.ActiveBrowser.RefreshDomTree();
            
            // Loading the tool tip div
            HtmlDiv tooltipDiv = this.Find.ByExpression<HtmlDiv>("tagName=div","class=telerik-blazor k-animation-container k-chart-tooltip-wrapper");
            
            // Capturing the image
            var img = tooltipDiv.BaseElement.CaptureImage();
            
            // Using OCR to get text from image
            var imgText = Telerik.TestStudio.OCR.OcrManager.GetTextFromImageBytes(img.Image, false);
            
            // Parsing and adding captured data into list of objects
            this.DataPoints.Add(ProductPoint.Parse(imgText));
        }
    }
    
    // Class for loading parsed text
    public class ProductPoint
    {
        public string AA { get; private set; } // Action and Adventure
        public string DM { get; private set; } // Detective and Mystery
        public string SF { get; private set; } // Science Fiction
        public string Category { get; private set; }
        public string TotalRevenue { get; private set; }
    
        private ProductPoint() { }
        
        // Method to parse text into ProductPoint
        public static ProductPoint Parse(string text)
        {
            var p = new ProductPoint();
            
            var strReader = new StringReader(text);
        
            while(true)
            {
                string line = strReader.ReadLine();
                
                if(line == null) break;
                if(string.IsNullOrEmpty(line)) continue;
                
                line = line.TrimStart('=').TrimStart();
                string[] splitLine = line.Split(' ');
                
                if(line.StartsWith("AA")) 
                    p.AA = splitLine[splitLine.Length -1];
                else if(line.StartsWith("DM"))
                   p.DM = splitLine[splitLine.Length -1]; 
                else if(line.StartsWith("SF")) 
                    p.SF = splitLine[splitLine.Length -1];
                else if(line.StartsWith("Revenue")) 
                    p.TotalRevenue = splitLine[splitLine.Length -1];
                else
                    p.Category = line;
            }
            return p;
        }
    }
}
