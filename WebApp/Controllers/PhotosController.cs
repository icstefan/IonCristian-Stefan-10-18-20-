using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.DataServices;

namespace WebApp.Controllers
{
    public class PhotosController : Controller
    {
        private IPhotosDataService _photosDataService;

        public PhotosController(IPhotosDataService photosDataService)
        {
            _photosDataService = photosDataService;
        }

        [HttpPost]
        public async Task<IActionResult> PhotosForAlbum(int albumId)
        {
            var photos = await _photosDataService.GetPhotosForAlbum(albumId);

            if (photos.Count() <= 0)
            {
                ViewBag.Message = "No photos in the database";
            }

            return View(photos);
        }
    }
}
