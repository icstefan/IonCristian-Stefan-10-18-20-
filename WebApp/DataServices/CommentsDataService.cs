using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApp.DTOs;

namespace WebApp.DataServices
{
    public class CommentsDataService : ICommentsDataService
    {
        public async Task<IEnumerable<CommentDTO>> GetCommentsForPost(int postId)
        {
            var items = new List<CommentDTO>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri($"https://jsonplaceholder.typicode.com");

                var response = await client.GetAsync($"posts/{postId }/comments");

                if (response.IsSuccessStatusCode)
                {
                    items = await response.Content.ReadAsAsync<List<CommentDTO>>();
                }
            }

            return items.OrderBy(i => i.Name);
        }
    }
}
