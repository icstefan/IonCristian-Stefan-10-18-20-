using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.DTOs;

namespace WebApp.DataServices
{
    public interface ICommentsDataService
    {
        Task<IEnumerable<CommentDTO>> GetCommentsForPost(int postId);
    }
}
