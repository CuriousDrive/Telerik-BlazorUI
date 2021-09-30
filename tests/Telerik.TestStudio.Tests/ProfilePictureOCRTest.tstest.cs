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

namespace BookStores.Tests
{

    public class ProfilePictureOCRTest : BaseWebAiiTest
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
        public void ProfilePictureOCRTest_CodedStep()
        {
            // Make sure we have latest DOM to pull up the image
            this.ActiveBrowser.RefreshDomTree();
            // Find the profilePictureImage
            var profilePictureImage = this.Find.ById<HtmlImage>("profilePictureImage");
            if(profilePictureImage != null)
            {
                string basePath = @"C:\Data\CuriousDrive\GitHub Repos\Telerik-BlazorUI\src\Client\wwwroot";
                // Get Image text
                var imgText = Telerik.TestStudio.OCR.OcrManager.GetTextFromImagePath(basePath + profilePictureImage.Src, false);
                // Verify Image text
                Assert.IsTrue(imgText.ToLower().Contains("progres"));            
                //Assert.IsTrue(true);    
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }
}
