using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookStores.Client.Models.DocumentProcessing
{
    public static class FileExporter
    {

        public static void Save(IJSRuntime jsRuntime, byte[] byteData, string mimeType, string fileName)
        {
            if (byteData == null)
            {
                jsRuntime.InvokeVoidAsync("alert", "The byte array provided for Exporting was Null.");
            }
            else
            {
                jsRuntime.InvokeVoidAsync("saveFile", Convert.ToBase64String(byteData), mimeType, fileName);
            }
        }

        public async static Task<FileDetails> Upload(IJSRuntime jsRuntime, string inputID)
        {
            FileDetails fileDetails = new FileDetails();

            JsonElement fileAsJson = await jsRuntime.InvokeAsync<JsonElement>("getUploadedFile", inputID);
            string fileAsString = fileAsJson.ToString();

            if (!string.IsNullOrEmpty(fileAsString))
            {
                Dictionary<string, string> uploadData = JsonSerializer.Deserialize<Dictionary<string, string>>(fileAsString);
                fileDetails.Name = uploadData["fileName"];
                fileDetails.Data = Convert.FromBase64String(uploadData["fileData"]);
            }

            return fileDetails;
        }
    }
}
