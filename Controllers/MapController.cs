using Microsoft.AspNetCore.Mvc;
using tracking.Models;

namespace tracking.Controllers
{
    public class MapController : Controller{
        private AirportRepository Repository;

        public MapController(AirportRepository airport)
        {
            this.Repository = airport;
        }

        public IActionResult Index(){
            return View();
        }

        public IActionResult Search(string name){
            var data = this.Repository.Search(name.Trim());
            return Ok(data);
        }
    }
}
