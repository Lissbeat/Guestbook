
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using assignment_3.Data;
using Microsoft.AspNetCore.Mvc;
using assignment_3.Models;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace assignment_3.Controllers
{

    public class GuestBookController : Controller
    {
        public readonly StoreDbContext db;

        public GuestBookController(StoreDbContext context)
        {
            db = context;
        }




        [HttpGet]
        public IActionResult Index()
        {
            var vm = new PostViewModel();
            vm.Post = new Post();
            vm.Posts = db.Posts.ToList();
            return View(vm); //sender databasen som en liste

        }

        [HttpPost]
        public IActionResult Index(Post post)
        {

            //sikkerhet for å sjekke at modellen er fullstendig
            if (ModelState.IsValid)
            {
                Debug.Print("it is valid");
                db.Add(post);
                db.SaveChanges();

                post = new Post(); //resetter produktet, hvis den er fullstednig
                ModelState.Clear();
             
                    
            }
          
      
            var vm = new PostViewModel();
            vm.Post = post;
            vm.Posts = db.Posts.ToList();

            return View(vm); //sender databasen som en liste



        }




    }
}
