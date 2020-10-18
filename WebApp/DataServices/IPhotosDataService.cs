using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.DTOs;

namespace WebApp.DataServices
{
    public interface IPhotosDataService
    {
        Task<IEnumerable<PhotoDTO>> GetPhotosForAlbum(int albumId);
    }
}
