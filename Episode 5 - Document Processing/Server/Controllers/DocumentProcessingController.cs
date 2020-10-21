using BookStores.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.IO.Pipelines;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net.Mime;

namespace BookStores.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentProcessingController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public DocumentProcessingController(IWebHostEnvironment webHostEnvironment)
        {
            this._webHostEnvironment = webHostEnvironment;
        }

        [HttpGet("GetInteractiveForms")]
        public async Task<FileContentResult> GetInteractiveForms()
        {
            var filePath = Path.Combine(_webHostEnvironment.WebRootPath, @"shared\web\pdfprocessing\InteractiveForms.pdf");

            var memoryStream = new MemoryStream();
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                await fileStream.CopyToAsync(memoryStream);
                byte[] fileReadAllBytes = memoryStream.ToArray();
                return new FileContentResult(fileReadAllBytes, "application/pdf")
                {
                    FileDownloadName = "test.pdf"
                };
            }
        }

        [HttpGet("GetTemplate")]
        public async Task<FileContentResult> GetPdfTemplate()
        {
            var filePath = Path.Combine(_webHostEnvironment.WebRootPath, @"shared\web\pdfprocessing\Template.pdf");

            var memoryStream = new MemoryStream();
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                await fileStream.CopyToAsync(memoryStream);
                byte[] fileReadAllBytes = memoryStream.ToArray();
                return new FileContentResult(fileReadAllBytes, "application/pdf")
                {
                    FileDownloadName = "test.pdf"
                };
            }
        }

        [HttpGet("GetSampleDocument")]
        public async Task<FileContentResult> GetSampleDocument()
        {
            var filePath = Path.Combine(_webHostEnvironment.WebRootPath, @"shared\web\wordsprocessing\SampleDocument.docx");

            var memoryStream = new MemoryStream();
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                await fileStream.CopyToAsync(memoryStream);
                byte[] fileReadAllBytes = memoryStream.ToArray();
                return new FileContentResult(fileReadAllBytes, "application/doc")
                {
                    FileDownloadName = "test.docx"
                };
            }
        }

    }
}
