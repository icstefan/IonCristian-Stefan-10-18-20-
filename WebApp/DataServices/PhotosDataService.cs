using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApp.DTOs;

namespace WebApp.DataServices
{
    public class PhotosDataService : IPhotosDataService
    {
        public async Task<IEnumerable<PhotoDTO>> GetPhotosForAlbum(int albumId)
        {
            var photos = new List<PhotoDTO>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"https://jsonplaceholder.typicode.com");

                var response = await client.GetAsync($"photos?albumId={albumId}");

                if (response.IsSuccessStatusCode)
                {
                    photos = await response.Content.ReadAsAsync<List<PhotoDTO>>();
                }
            }

            return photos.OrderBy(i => i.Title);
        }
    }
}
