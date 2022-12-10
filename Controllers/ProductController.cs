using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Bson;
using System.Configuration;
using MongoDB.Driver.Core;
using umuly_case_sn.App_Start;     
using MongoDB.Driver;
using umuly_case_sn.Models;

namespace umuly_case_sn.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private MongoDBContext dbcontext;
        private IMongoCollection<mongo_model> teklifCollection;

        //for grid controller

        public ProductController()
        {
            dbcontext = new MongoDBContext();
            teklifCollection = dbcontext.database.GetCollection<mongo_model>("teklif"); 
        }

        public ActionResult Index()
        {

            List<mongo_model> products = teklifCollection.AsQueryable<mongo_model>().ToList();
            return View(products);
           
        }

        public ActionResult Teklifler(string id)
        {
            ViewBag.Message = "yapılan teklifler";

            var productId = new ObjectId(id);
            var product = teklifCollection.AsQueryable<mongo_model>().SingleOrDefault(x => x.Id == productId);
            return View(product);

           
        }


       
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(mongo_model product)
        {
            try
            {
                // TODO: Add insert logic here

                teklifCollection.InsertOne(product);     
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }








    }
}
