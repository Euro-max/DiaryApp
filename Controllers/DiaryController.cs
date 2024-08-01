using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers
{
    public class DiaryController : Controller
    {
        //Dependency Injection
        private readonly ApplicationDbContext _db;
        public DiaryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<DiaryItems> items = _db.DiaryItems.ToList();
            return View(items);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DiaryItems obj)
        {
            if (obj != null && obj.Title.Length < 4)
            {
                ModelState.AddModelError("Title", "Title is Too short");
            }
            if (ModelState.IsValid)
            {
                _db.DiaryItems.Add(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(obj);

        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            DiaryItems? diaryItems = _db.DiaryItems.Find(id);
            if (diaryItems == null)
            {
                return NotFound();
            }
            return View(diaryItems);

        }
        [HttpPost]
        public IActionResult Edit(DiaryItems obj)
        {
            if (obj != null && obj.Title.Length < 4)
            {
                ModelState.AddModelError("Title", "Title is Too short");
            }
            if (ModelState.IsValid)
            {
                _db.DiaryItems.Update(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(obj);

        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            DiaryItems? diaryItems = _db.DiaryItems.Find(id);
            if (diaryItems == null)
            {
                return NotFound();
            }
            return View(diaryItems);

        }
        
        [HttpPost]
        public IActionResult Delete(DiaryItems obj)
        {
            if (obj != null && obj.Title.Length < 4)
            {
                ModelState.AddModelError("Title", "Title is Too short");
            }
            if (ModelState.IsValid)
            {
                _db.DiaryItems.Remove(obj);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(obj);

        }
     

    }
}

