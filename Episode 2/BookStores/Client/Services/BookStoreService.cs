﻿using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BookStores.Services
{
    public class BookStoresService<T> : IBookStoresService<T>
    {
        public HttpClient _httpClient { get; }
        
        public BookStoresService(HttpClient httpClient)
        {
          
            httpClient.BaseAddress = new Uri("https://localhost:5001/");
            httpClient.DefaultRequestHeaders.Add("User-Agent", "BookStoresWasm");

            _httpClient = httpClient;
        }

        public async Task<bool> DeleteAsync(string requestUri, int Id)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Delete, requestUri + Id);

            var response = await _httpClient.SendAsync(requestMessage);

            var responseStatusCode = response.StatusCode;

            return await Task.FromResult(true);
        }

        public async Task<List<T>> GetAllAsync(string requestUri)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri);

            var response = await _httpClient.SendAsync(requestMessage);

            var responseStatusCode = response.StatusCode;

            if (responseStatusCode.ToString() == "OK")
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                return await Task.FromResult(JsonConvert.DeserializeObject<List<T>>(responseBody));
            }
            else
                return null;
        }

        public async Task<T> GetByIdAsync(string requestUri, int Id)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, requestUri + Id);

            var response = await _httpClient.SendAsync(requestMessage);

            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            return await Task.FromResult(JsonConvert.DeserializeObject<T>(responseBody));
        }

        public async Task<T> SaveAsync(string requestUri, T obj)
        {
            string serializedUser = JsonConvert.SerializeObject(obj);

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, requestUri);

            requestMessage.Content = new StringContent(serializedUser);

            requestMessage.Content.Headers.ContentType
                = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.SendAsync(requestMessage);

            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            var returnedObj = JsonConvert.DeserializeObject<T>(responseBody);

            return await Task.FromResult(returnedObj);
        }

        public async Task<T> UpdateAsync(string requestUri, int Id, T obj)
        {
            string serializedUser = JsonConvert.SerializeObject(obj);

            var requestMessage = new HttpRequestMessage(HttpMethod.Put, requestUri + Id);

            requestMessage.Content = new StringContent(serializedUser);

            requestMessage.Content.Headers.ContentType
                = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.SendAsync(requestMessage);

            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            var returnedObj = JsonConvert.DeserializeObject<T>(responseBody);

            return await Task.FromResult(returnedObj);
        }
    }
}