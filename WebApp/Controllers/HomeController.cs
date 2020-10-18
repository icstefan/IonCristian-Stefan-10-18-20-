using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.DataServices;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private IAlbumsDataService _albumsDataService;

        public HomeController(IAlbumsDataService albumsDataService)
        {
            _albumsDataService = albumsDataService;
        }

        public async Task<IActionResult> Index()
        {
            var albums = await _albumsDataService.GetAlbums();

            if (albums.Count() <= 0)
            {
                ViewBag.Message = "No albums in the database";
            }

            return View(albums);
        }
    }
}
