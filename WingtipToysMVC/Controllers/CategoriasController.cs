using System.Linq;
using System.Web.Mvc;
using WingtipToysMVC.Models;

namespace WingtipToysMVC.Controllers
{
    public class CategoriasController : Controller
    {
        private WingtipToysMVCContext banco = new WingtipToysMVCContext();

        // GET: Categorias  (www.meusistema.com/Categorias)
        public ActionResult Index()
        {
            return View(banco.Categorias.ToList());
        }

        //GET: Categorias/Create
        public ActionResult Create()
        {
            return View();
        }
    }
}