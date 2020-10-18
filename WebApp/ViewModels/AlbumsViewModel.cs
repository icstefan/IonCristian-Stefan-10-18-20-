using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.DTOs;

namespace WebApp.ViewModels
{
    public class AlbumsViewModel
    {
        public int AlbumId { get; set; }
        public List<AlbumDTO> AlbumsList { get; set; }
    }
}
