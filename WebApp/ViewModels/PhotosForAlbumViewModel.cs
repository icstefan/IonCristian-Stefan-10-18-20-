using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.DTOs;

namespace WebApp.ViewModels
{
    public class PhotosForAlbumViewModel
    {
        public int AlbumName { get; set; }
        public List<PhotoDTO> PhotosList { get; set; }
    }
}
