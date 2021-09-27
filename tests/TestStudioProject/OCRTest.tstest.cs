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

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;

namespace TestStudioProject
{

    public class OCRTest : BaseWebAiiTest
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
    
        [CodedStep(@"New Coded Step")]
        public void OCRTest_VerifyingImage()
        {
            // Make sure we have latest DOM to pull up the image
            this.ActiveBrowser.RefreshDomTree();
            // Find the profilePictureDiv
            var profilePictureDiv = this.Find.ById("profilePictureDiv");
            // Capture Image
            var profilePictureImage = profilePictureDiv.CaptureImage();
            // Get text from Image
            var imgText = Telerik.TestStudio.OCR.OcrManager.GetTextFromImageBytes(profilePictureImage.Image, false);
            // Verify Image text
            Assert.IsTrue(imgText.Contains("Teleri"));
        }
    }
}
