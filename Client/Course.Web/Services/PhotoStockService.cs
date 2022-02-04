using Course.Shared.Dtos;
using Course.Web.Models.PhotoStocks;
using Course.Web.Services.Interface;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Course.Web.Services
{
    public class PhotoStockService : IPhotoStockService
    {
        private readonly HttpClient _httpClient;

        public PhotoStockService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> Delete(string photoUrl)
        {
            var response = await _httpClient.DeleteAsync($"photos/PhotoDelete?photoUrl={photoUrl}");
            return response.IsSuccessStatusCode;
        }

        public async Task<PhotoStockViewModel> UploadPhoto(IFormFile photo)
        {
            if (photo==null || photo.Length<=0)
            {
                return null;
            }
            var randomFileName = $"{Guid.NewGuid().ToString()}{Path.GetExtension(photo.FileName)}";

            using var ms = new MemoryStream();
            await photo.CopyToAsync(ms);

            var multipartContent = new MultipartFormDataContent();

            multipartContent.Add(new ByteArrayContent(ms.ToArray()), "photo", randomFileName);

            var response = await _httpClient.PostAsync("photos/photosave", multipartContent);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            var responseSucces= await response.Content.ReadFromJsonAsync<Response<PhotoStockViewModel>>();
            return responseSucces.Data;

        }
    }
}
