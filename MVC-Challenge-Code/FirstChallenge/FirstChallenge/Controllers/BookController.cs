using FirstChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstChallenge.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {

            var alotofBooks = ComicBookManager.GetComicBooks();
            return View(alotofBooks);


        }//End of Index


        public ActionResult Details(int id)
        {

            var alotOfComic = ComicBookManager.GetComicBooks();

            //We actually see this before. FirstOrdefault, later we will revisit Entity Framework to find it. 
            
            //Find the first book based on id given
            var onlyOneComic = alotOfComic.FirstOrDefault(p => p.ComicBookId == id);


            return View(onlyOneComic);
        }
    }
}