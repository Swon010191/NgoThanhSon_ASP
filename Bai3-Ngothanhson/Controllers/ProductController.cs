using Bai3_Ngothanhson.Data;
using Bai3_Ngothanhson.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bai3_Ngothanhson.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        public ActionResult Index(int categoryID)
        {
            //var products = SeedProduct.products;
            var products = SeedProduct.products
                .Where(p => p.CategoryId == categoryID)
                .ToList();

            return View(products);
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            var product = SeedProduct.products.FirstOrDefault(p => p.Id == id);
            return View(product);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Models.Product product)
        {
            if (ModelState.IsValid)
            {
                int maxID = SeedProduct.products.Max(i => i.Id);
                product.Id = maxID+1;
                SeedProduct.products.Add(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            var product = SeedProduct.products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([FromForm] Models.Product product)
        {
            var existingProduct = SeedProduct.products.FirstOrDefault(p => p.Id == product.Id);

            if (existingProduct == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                existingProduct.Description = product.Description;
                existingProduct.CategoryId = product.CategoryId;
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(product);
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            var product = SeedProduct.products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete([FromForm] Models.Product product)
        {
            var existingProduct = SeedProduct.products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct == null)
            {
                return NotFound();
            }
            SeedProduct.products.Remove(existingProduct);
            return RedirectToAction(nameof(Index));
        }
    }
}
