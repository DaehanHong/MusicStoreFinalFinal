using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    [RequireHttps]
    public class AlbumsController : Controller
    {
        MusicStoreEntities storeDB = new MusicStoreEntities();
        object @object;

        public AlbumsController(object @object)
        {
            this.@object = @object;
        }

        // GET: Albums
        public ActionResult Index()
        {
            var albums = storeDB.Albums.Include(a => a.Artist).Include(a => a.Genre);
            return View(albums.ToList());
        }

        // GET: Albums/Details/5
        [Route("albums/details/{id}")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = storeDB.Albums.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }


    }
}