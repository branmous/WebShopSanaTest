using Domain.Contracts;
using Domain.Services.ProductMemoryStore;
using Domain.Services.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebShop.Controllers.Products
{
    public class ProductsController : Controller
    {
        private IProductService _productService;
        private IProductMemoryStoreService _productMemoryStoreService;

        public ProductsController(IProductService productService,
            IProductMemoryStoreService productMemoryStoreService)
        {
            _productService = productService;
            _productMemoryStoreService = productMemoryStoreService;
        }
        // GET: Products
        public ActionResult Index()
        {
            List<ProductContract> products = new List<ProductContract>();
            if (Session["MemoryStore"] == null)
            {
                products = _productService.GetAll();
            }
            else
            {
                products = _productMemoryStoreService.GetAll();
            }
            
            return View(products);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductContract model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (Session["MemoryStore"] == null)
                    {
                        bool response = _productService.CreateProduct(model);
                        if (response)
                        {
                            return RedirectToAction("ProductSuccess", "Products",
                                new { Message = string.Format("the product {0} was created successfully", model.Description) });
                        }

                        ModelState.AddModelError(string.Empty, "the product could not be created");
                        return View(model);
                    }
                    else
                    {
                        bool response = _productMemoryStoreService.AddProduct(model);
                        if (response)
                        {
                            return RedirectToAction("ProductSuccess", "Products",
                                new { Message = string.Format("the product {0} was created successfully in Memory storage", model.Description) });
                        }

                        ModelState.AddModelError(string.Empty, "the product could not be created");
                        return View(model);
                    }

                }

                return View(model);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex);
                return View(model);
            }
        }

        public ActionResult ProductSuccess(string message)
        {
            ViewBag.Message = message;
            return View();
        }

        public ActionResult ChangeToMemoryStore(bool? IsMemory)
        {
            if (IsMemory.Value)
            {
                Session.Add("MemoryStore", true);
            }
            else
            {
                if (Session["MemoryStore"] != null)
                {
                    Session.Remove("MemoryStore");
                }
            }

            return RedirectToAction("Index");
        }
    }
}