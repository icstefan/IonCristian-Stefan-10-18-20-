using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApp.DTOs;

namespace WebApp.DataServices
{
    public class AlbumsDataService : IAlbumsDataService
    {
        public async Task<IEnumerable<AlbumDTO>> GetAlbums()
        {
            IEnumerable<AlbumDTO> albums = new List<AlbumDTO>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");

                var response = await client.GetAsync("albums");

                if (response.IsSuccessStatusCode)
                {
                    albums = await response.Content.ReadAsAsync<IList<AlbumDTO>>();
                }
            }

            return albums.OrderBy(i => i.Title);
        }
    }
}
