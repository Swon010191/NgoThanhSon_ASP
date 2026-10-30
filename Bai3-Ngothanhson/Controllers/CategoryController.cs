using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bai3_Ngothanhson.Data;
using Bai3_Ngothanhson.Models;
namespace Bai3_Ngothanhson.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View(SeedData.categories);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            //lay ra category co id treyen vao tu seeddata
            var category = SeedData.categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();

            }
            return View(category);
        }

        // POST: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: Category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Models.Category category)
        {
            if (ModelState.IsValid)
            {
                //lay max id trong danh sacsh seeddata.categories
                int maxId = SeedData.categories.Max(c => c.Id);
                //set id cho category
                category.Id = maxId + 1;
                //them category vao danh sacsh seeddata.category
                SeedData.categories.Add(category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }
        

        // GET: Category/Edit/5
        public ActionResult Edit([FromRoute] int id)
        {
            var category = SeedData.categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: Category/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([FromForm] Models.Category category)
        {
            var exisitingcategory = SeedData.categories.FirstOrDefault(c => c.Id == category.Id);
            if(exisitingcategory == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                exisitingcategory.Name = category.Name;
                exisitingcategory.Description = category.Description;
                return RedirectToAction(nameof(Index));
            }

            return View(category);
            
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            var categori = SeedData.categories.FirstOrDefault(c => c.Id == id);
            if (categori == null)
            {
                return NotFound();
            }
            return View(categori);
        }

        // POST: Category/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete([FromForm] Models.Category category)
        {
            var existingcategory = SeedData.categories.FirstOrDefault(c => c.Id == category.Id);
            if(existingcategory == null)
            {
                return NotFound();
            }
            SeedData.categories.Remove(existingcategory);
            return RedirectToAction(nameof(Index));
        }
    }
}
