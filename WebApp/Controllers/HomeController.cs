using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _dbContext;
        public HomeController()
        {
            _dbContext = new AppDbContext("Server=tcp:teamgreenserver.database.windows.net,1433;Initial Catalog=teamgreendatabase;Persist Security Info=False;User ID=Teamgreensql;Password=DkKSDEGmdo29.21;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
        public ActionResult Index()
        {
            var viewModel = new ProductsViewModel();
            viewModel.Products = _dbContext.TblEmployees.ToList();
            return View(viewModel);
        }

        
    }
}